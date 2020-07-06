using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MyDictionary
{
    class DictionaryManager
    {
        IRepository repository;
        int askedToDay = 0;
        int answeredToDay = 0;
        IItem quest;
        bool rus_eng;
        bool IsReplay = false;

        public int ItemsCount => repository.Items.Count();
        public string FilePath => repository.FilePath;
        public int AskedToDay => askedToDay;
        public int AnsweredToDay => answeredToDay;
        public bool GameStop => quest == null;
        public string QuestEnglish
        { 
            get
            { 
                if (quest != null) 
                    return quest.English;                            
                return "";
            }
        }
        public string QuestRussian
        {
            get
            {
                if (quest != null)
                    return quest.Russian;
                return "";
            }
        }
        public int Studied
        {
            get
            {
                return repository.Items
         .Where(x => x.Asked >= 15 && x.Answered / (x.Asked + 1.0) >= 0.75)
         .Count();
            }
        }

        public DictionaryManager()
        {
            repository = new FileRepository();
        }


        public void OpenFile(string filepath)
        {
            repository.RecordFile();
            repository.Load(filepath);
        }


        public void DeleteFile()
        {
            if (File.Exists(repository.FilePath)) File.Delete(repository.FilePath);
            repository.Load(null);
        }


        public void CreateFile(string filename)
        {
            File.Create(filename + ".dat");
        }


        public void ClearFile()
        {
            repository.Clear();
        }


        public void ResetStat()
        {
            foreach (Item i in repository.Items)
            {
                i.Reset();
            }
        }


        public bool Check(string question, string answer)
        {
            if (quest != null)
            {
                bool right;
                if (rus_eng)
                {
                    right = quest.Answer(answer, question,!IsReplay);
                }
                else
                {
                    right = quest.Answer(question, answer, !IsReplay);
                }

                if (right)
                {
                    if (!IsReplay) answeredToDay++;
                    IsReplay = false;
                    CancelQuestion();
                    return true;
                }
                else
                {
                    IsReplay = true;
                    return false;
                }
            }
            else
            {
                throw new NullReferenceException("Объект задания пуст");
            }
        }


        public string GetQuestion(bool r_e)
        {
            quest = null;
            rus_eng = r_e;
            quest = repository.RandomItem(x => x.Asked < 15 || x.Answered / (x.Asked + 1.0) < 0.75);
            if (quest == null) { CancelQuestion(); return null; }
            askedToDay++;
            if (rus_eng)
                return quest.Russian;
            else
                return quest.English;
        }


        public void CancelQuestion()
        {
            quest = null;
        }


        public bool AddWord(string eng, string rus)
        {
            Item item;
            item = new Item(eng, rus);
            bool success = repository.AppendItem(item);
            if (success) return true;
            else return false;
        }


        public bool DeleteWord(string word)
        {
            IItem item = repository.FindItem(word);
            if (item != null)
            {
                return repository.DeleteItem(item);
            }
            return false;
        }


        public string[] GetWordsInfo()
        {
            string[] res = new string[repository.Items.Count()];
            int index = 0;
            foreach (Item i in repository.Items)
            {
                res[index]= $"{i.English}\t\t{i.Russian}\t\tЗапросов: {i.Asked}\tОтветов: {i.Answered}\r\n";
                index++;
            }
            return res.OrderBy(x=>x).ToArray();
        }


        public int AddWordsFromText(string text)
        {
            int progress = 0;
            int added = 0;
            ITranslater translater = new OpenTranTranslater();

            char[] nonLetter = text.ToCharArray();
            for (int i = 0; i < nonLetter.Length; i++)
            {
                if (char.IsLetter(nonLetter[i])) nonLetter[i] = ' ';
            }
            string[] words = text.Split(nonLetter, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)
            {
                try
                {
                    progress++;
                    OnProgress?.Invoke(100 * progress / words.Length);
                    if (repository.FindItem(word) != null) continue;
                    IItem tr = translater.Translate(word);
                    if (tr == null || tr.English == tr.Russian) continue;
                    repository.AppendItem(tr);
                    added++;
                }
                catch (ArgumentException) { }
            }
            return added;
        }

        public event Action<int> OnProgress;
    }
}

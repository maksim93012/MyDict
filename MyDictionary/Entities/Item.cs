using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class Item : IItem
    {
        string eng;
        string rus;
        int answered;
        int asked;
        public string English { get { return eng; } }
        public string Russian { get { return rus; } }
        public int Answered { get { return answered; } }
        public int Asked { get { return asked; } }

        public Item(string eng, string rus, int answered = 0, int asked = 0)
        {
            this.eng = eng.Trim().ToLower();
            this.rus = rus.Trim().ToLower();
            if (this.eng == "" || this.rus == "" ||this.eng==null||this.rus==null) throw new ArgumentException("Отсутствует слово");
            for (int i = 0; i < this.eng.Length; i++)
            {
                if (!(this.eng[i] >= 'a' && this.eng[i] <= 'z'))
                {
                    throw new ArgumentException("В строке <english> присутствуют неверные символы: "+this.eng);
                }
            }
            for (int i = 0; i < this.rus.Length; i++)
            {
                if (!(this.rus[i] >= 'а' && this.rus[i] <= 'я'))
                {
                    throw new ArgumentException("В строке <russian> присутствуют неверные символы: "+this.rus);
                }
            }
            this.answered = answered>=0?answered:0;
            this.asked = asked>=0?asked:0;
        }

        public bool Answer(string eng, string rus, bool rec_as_answered)
        {
            asked++;
            if(English == eng.Trim().ToLower() && Russian==rus.Trim().ToLower())
            {
                if(rec_as_answered)
                answered++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            asked = 0;
            answered = 0;
        }
    }
}

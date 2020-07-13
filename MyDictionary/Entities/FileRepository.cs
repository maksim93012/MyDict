using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDictionary
{
    class FileRepository : IRepository
    {
        const string defaultFileName = "dictrepo.dat";
        string filepath = "dictrepo.dat";
        List<IItem> items;
        Random rnd = new Random();
        public string FilePath { get { return filepath; } }

        public IEnumerable<IItem> Items => items;

        public FileRepository()
        {
            Load();
        }
        ~FileRepository()
        {
            RecordFile();
        }

        public bool AppendItem(IItem item)
        {
            if (items.Contains(item))
            {
                return false;
            }
            else
            {
                foreach(IItem i in items)
                {
                    if (i.English == item.English && i.Russian == item.Russian)
                        return false;
                }
                items.Add(item);
                RecordFile();
                return true;
            }
        }

        public void Clear()
        {
            try
            {
                File.Delete(filepath);
                items = new List<IItem>();
                Load();
            }
            catch { }
        }

        public bool DeleteItem(IItem item)
        {
            bool res = items.Remove(item);
            RecordFile();
            return res;
        }

        public void Load()
        {
            if (filepath == null || filepath == "") { filepath=defaultFileName; }
            using (BinaryReader reader = new BinaryReader(new FileStream(filepath, FileMode.OpenOrCreate)))
            {
                items = new List<IItem>();
                try
                {
                    while (true)
                    {
                        Item item = new Item(reader.ReadString(), reader.ReadString(), reader.ReadInt32());
                        items.Add(item);
                    }
                }
                catch (EndOfStreamException) { }
            }
        }

        public void Load(string path)
        {
            filepath = path;
            Load();
        }

        public IItem RandomItem(Func<IItem, bool> predicate)
        {
            IEnumerable<IItem> temp = items;
            int c = temp.Count();
            if (rnd.Next(0, 15) != 0)
            {
                temp = items.Where(predicate);
                c = temp.Count();
                if (c >= 30) c = 30;
            }
            if (c < 1) return null;
            return temp.ElementAt(rnd.Next(0, c));
        }

        public void RecordFile()
        {
            if (items.Count == 0 || filepath==null) { return; }
            using (BinaryWriter writer = new BinaryWriter(new FileStream(filepath, FileMode.Create)))
            {
                    foreach (Item item in items)
                    {
                    writer.Write(item.English);
                    writer.Write(item.Russian);
                    writer.Write(item.Points);
                    }
            }
        }

        public IItem FindItem(string word)
        {
            Item res = null;
            foreach(Item i in items)
            {
                if(i.English==word.Trim().ToLower() || i.Russian == word.Trim().ToLower())
                {
                    res = i;
                    break;
                }
            }
            return res;
        }

        public int AddItems(List<IItem> items)
        {
            int counter = 0;
            foreach (Item item in items)
            {
                if (AppendItem(item)) counter++;
            }
            return counter;
        }
    }
}

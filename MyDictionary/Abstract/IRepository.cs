using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    interface IRepository
    {
        string FilePath { get; }
        IEnumerable<IItem> Items { get; }
        void Load();
        void Load(string filename);
        void RecordFile();
        void Clear();
        IItem RandomItem(Func<IItem, bool> predicate);
        bool AppendItem(IItem item);
        int AddItems(List<IItem> items);
        bool DeleteItem(IItem item);
        IItem FindItem(string word);
    }
}

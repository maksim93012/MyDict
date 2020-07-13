using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDictionary
{
    interface IItem
    {
        string English { get; }
        string Russian { get; }
        int Points { get; set; }

        void Reset();

        bool Answer(string eng, string rus, bool rec_as_answered);
    }
}

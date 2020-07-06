using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    delegate void ProgressTickHandler(int proc);
    interface ITranslater
    {
        IItem Translate(string source);
    }
}

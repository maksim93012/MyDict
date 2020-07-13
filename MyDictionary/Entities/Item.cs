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
        int points = 0;
        public string English => eng;
        public string Russian => rus;
        public int Points { get { return points; } set { points = value < 0 ? 0 : value; } }

        public Item(string eng, string rus, int points = 0)
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
            Points = points>=0?points:0;
        }

        public bool Answer(string eng, string rus, bool rec_as_answered)
        {
            if(English == eng.Trim().ToLower() && Russian==rus.Trim().ToLower())
            {
                if (rec_as_answered)
                    Points+=2;
                return true;
            }
            else
            {
                if(Points>0)
                Points-=3;
                return false;
            }
        }

        public void Reset()
        {
            Points = 0;
        }
    }
}

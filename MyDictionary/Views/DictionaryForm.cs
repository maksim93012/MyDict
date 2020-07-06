using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDictionary
{
    partial class DictionaryForm : Form
    {
        public DictionaryForm(DictionaryManager manager)
        {
            InitializeComponent();
            foreach (string i in manager.GetWordsInfo())
            {
                textBox1.Text += i;
            }
        }
    }
}

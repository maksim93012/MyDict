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
            string[] words = manager.GetWordsInfo();
            foreach (string i in words)
            {
                textBox1.Text += i;
            }
        }
    }
}

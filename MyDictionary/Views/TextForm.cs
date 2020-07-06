using MyDictionary.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDictionary
{
    partial class TextForm : Form
    {
        DictionaryManager manager;
        public TextForm(DictionaryManager manager)
        {
            this.manager = manager;
            manager.OnProgress += Progress;
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter || textBox1.Text == "") return;
            textBox1.ReadOnly = true;
            int added=0;
            try
            {
                added = manager.AddWordsFromText(textBox1.Text);
            }
            catch(Exception ex)
            {
                Log.Write(ex);
            }
            MessageBox.Show($"В словарь добавлено {added} слов");
            manager.OnProgress -= Progress;
            this.Close();
        }

        private void Progress(int proc)
        {
            progressBar1.Value = proc*progressBar1.Maximum/100;
        }
    }
}

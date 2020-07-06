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
    partial class InsertForm : Form
    {
        private DictionaryManager manager;

        public InsertForm(DictionaryManager manager)
        {
            this.manager = manager;
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (manager.AddWord(textBox1.Text, textBox2.Text))
                {
                    MessageBox.Show($"Слово {textBox1.Text} - {textBox2.Text} добавлено в словарь");
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
                else
                {
                    MessageBox.Show("Слово уже есть в словаре");
                }
            }catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

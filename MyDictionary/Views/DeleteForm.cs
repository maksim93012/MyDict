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
    partial class DeleteForm : Form
    {
        DictionaryManager manager;
        public DeleteForm(DictionaryManager manager)
        {
            this.manager = manager;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (manager.DeleteWord(textBox1.Text))
            {
                MessageBox.Show($"Слово {textBox1.Text} удалено из словаря "+manager.FilePath);
            }
            else
            { MessageBox.Show("Слово не найдено"); }
            this.Close();
        }
    }
}

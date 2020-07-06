﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDictionary
{
    partial class NewFileForm : Form
    {
        DictionaryManager manager;
        public NewFileForm(DictionaryManager manager)
        {
            this.manager = manager;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            manager.CreateFile(textBox1.Text);
            this.Close();
        }
    }
}

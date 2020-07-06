using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using System.Linq.Expressions;
using MyDictionary.Views;

namespace MyDictionary
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                Application.Run(new MainForm());
            }catch(Exception ex)
            {
                Log.Write(ex);
            }
        }
    }
}

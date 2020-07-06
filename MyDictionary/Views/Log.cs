using System;
using System.IO;

namespace MyDictionary.Views
{
    class Log
    {
        public static void Write(Exception ex)
        {
            using (StreamWriter writer = new StreamWriter("log.txt", true))
            {
                writer.WriteLine(DateTime.Now.ToString()+": " + ex.Message);
            }
        }
    }
}

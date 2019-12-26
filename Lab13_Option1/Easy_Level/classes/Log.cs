using System;
using System.IO;
using System.Text;

namespace Easy_Level.classes
{
    public class Log
    {
        private string path = Environment.CurrentDirectory + @"\files\loginfo.txt";

        public void WriteToFile(string method)
        {
            using (StreamWriter sw = new StreamWriter(path, true, UTF8Encoding.UTF8))
            {
                sw.WriteLine(DateTime.Now + ": " + method);
            }
        }

        public void ReadFromFile()
        {
            using (StreamReader sr = new StreamReader(path))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
        }
    }
}

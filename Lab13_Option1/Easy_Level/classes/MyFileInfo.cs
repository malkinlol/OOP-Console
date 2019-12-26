using System;
using System.IO;

namespace Easy_Level.classes
{
    public class MyFileInfo
    {
        private string path = Environment.CurrentDirectory + @"\files\loginfo.txt";
        private readonly FileInfo _fileInfo;
        private readonly Log _log;

        public MyFileInfo()
        {
            _fileInfo = new FileInfo(path);
            _log = new Log();
        }

        private void Task_A()
        {
            if (_fileInfo.Exists)
            {
                Console.WriteLine(_fileInfo.FullName);
            }

            _log.WriteToFile("FileInfo, Task_A");
        }

        private void Task_B()
        {
            if (_fileInfo.Exists)
            {
                Console.WriteLine($"Размер: {_fileInfo.Length}");
                Console.WriteLine($"Расщирение: {_fileInfo.Extension}");
                Console.WriteLine($"Имя: {_fileInfo.Name}");
            }

            _log.WriteToFile("FileInfo, Task_B");
        }

        private void Task_C()
        {
            if (_fileInfo.Exists)
            {
                Console.WriteLine($"Время создания: {_fileInfo.CreationTime}");
            }

            _log.WriteToFile("FileInfo, Task_C");
        }

        public void Task_D()
        {
            Task_A();

            Console.WriteLine("-------------------------");

            Task_B();

            Console.WriteLine("-------------------------");

            Task_C();
        }
    }
}

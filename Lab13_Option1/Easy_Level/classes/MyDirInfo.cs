using System;
using System.IO;

namespace Easy_Level.classes
{
    public class MyDirInfo
    {
        private string path = Environment.CurrentDirectory;
        private readonly Log _log;

        public MyDirInfo()
        {
            _log = new Log();
        }

        private void Task_A()
        {
            if (Directory.Exists(path))
            {
                int countOfFiles = Directory.GetFiles(path).Length;

                Console.WriteLine($"Количество файлов: {countOfFiles}");
            }

            _log.WriteToFile("DirInfo, Task_A");
        }

        private void Task_B()
        {
            if (Directory.Exists(path))
            {
                DirectoryInfo directory = new DirectoryInfo(path);

                Console.WriteLine($"Время создания каталога: {directory.CreationTime}");
            }

            _log.WriteToFile("DirInfo, Task_B");
        }

        private void Task_C()
        {
            if (Directory.Exists(path))
            {
                int countOfDirectory = Directory.GetDirectories(path).Length;

                Console.WriteLine($"Количество поддиректориев: {countOfDirectory}");
            }

            _log.WriteToFile("DirInfo, Task_C");
        }

        private void Task_D()
        {
            if (Directory.Exists(path))
            {
                string parent = Directory.GetParent(path).Parent.FullName;

                string[] parentDirectories = Directory.GetDirectories(parent);

                Console.WriteLine($"Список родительский директориев:");

                foreach (string dir in parentDirectories)
                {
                    Console.WriteLine(dir);
                }
            }

            _log.WriteToFile("DirInfo, Task_D");
        }

        public void Task_E()
        {
            Task_A();

            Console.WriteLine("-----------------");

            Task_B();

            Console.WriteLine("-----------------");

            Task_C();

            Console.WriteLine("-----------------");

            Task_D();
        }
    }
}

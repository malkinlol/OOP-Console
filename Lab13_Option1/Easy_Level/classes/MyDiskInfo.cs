using System;
using System.IO;

namespace Easy_Level.classes
{
    public class MyDiskInfo
    {
        private readonly Log _log;
        private readonly DriveInfo[] _drives;

        public MyDiskInfo()
        {
            _log = new Log();
            _drives = DriveInfo.GetDrives();
        }

        private void Task_A()
        {
            foreach (DriveInfo drive in _drives)
            {
                Console.WriteLine($"Название: {drive.Name}");

                if (drive.IsReady)
                {
                    Console.WriteLine($"Свободное пространство: {drive.TotalFreeSpace}");
                }

                Console.WriteLine();
            }

            _log.WriteToFile("DiskInfo, Task_A");
        }

        private void Task_B()
        {
            foreach (DriveInfo drive in _drives)
            {
                Console.WriteLine($"Название: {drive.Name}");

                if (drive.IsReady)
                {
                    Console.WriteLine($"Файловая система: {drive.DriveFormat}");
                }

                Console.WriteLine();
            }

            _log.WriteToFile("DiskInfo, Task_B");
        }

        private void Task_C()
        {
            foreach (DriveInfo drive in _drives)
            {
                Console.WriteLine($"Название: {drive.Name}");
                Console.WriteLine($"Тип: {drive.DriveType}");

                if (drive.IsReady)
                {
                    Console.WriteLine($"Объем диска: {drive.TotalSize}");
                    Console.WriteLine($"Свободное пространство: {drive.TotalFreeSpace}");
                    Console.WriteLine($"Метка: {drive.VolumeLabel}");
                }

                Console.WriteLine();
            }

            _log.WriteToFile("DiskInfo, Task_C");
        }

        public void Task_D()
        {
            this.Task_A();

            Console.WriteLine("-----------------------");

            this.Task_B();

            Console.WriteLine("-----------------------");

            this.Task_C();
        }
    }
}

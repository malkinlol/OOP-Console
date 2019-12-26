using Easy_Level.classes;
using System;
using System.IO;

namespace Easy_Level
{
    class Program
    {
        static void Main(string[] args)
        {
            //DiskInfo_Task();

            //FileInfo_Task();

            DirInfo_Task();
        }
        
        private static void DiskInfo_Task()
        {
            MyDiskInfo disk = new MyDiskInfo();

            disk.Task_D();


        }

        private static void FileInfo_Task()
        {
            MyFileInfo file = new MyFileInfo();

            file.Task_D();
        }

        private static void DirInfo_Task()
        {
            MyDirInfo dir = new MyDirInfo();

            dir.Task_E();
        }
    }
}

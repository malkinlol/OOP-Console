using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Easy_Level.classes
{
    public class MyFileManager
    {
        private const string disk = "C";
        private const string diskPath = @"D:\";
        private const string customDirectory1 = @"\Custom Directory1";
        private const string customDirectory2 = @"\Custom Directory2";
        private const string customDirectory3 = @"\Files";
        private const string customFile1 = @"\customFile1.txt";
        private const string customFile2 = @"\customFile2.txt";
        private const string extension = ".config";
        private string projectPath = Environment.CurrentDirectory;

        private void Task_A()
        {
            GetDirectoriesAndFiles();

            CreateCustomDirectory();

            CreateCustomFile();

            CopyFile();

            DeleteCustomFile();
        }

        private void GetDirectoriesAndFiles()
        {
            string[] directories = Directory.GetDirectories(diskPath);
            string[] files = Directory.GetFiles(diskPath);

            Console.WriteLine("---- DIRECTORIES ----");

            foreach (string directory in directories)
            {
                Console.WriteLine(directory + " ");
            }

            Console.WriteLine("---- FILES ----");

            foreach (string file in files)
            {
                Console.WriteLine(file + " ");
            }
        }

        private void CreateCustomDirectory()
        {
            DirectoryInfo dirInfo1 = new DirectoryInfo(projectPath + customDirectory1);

            if (!dirInfo1.Exists)
            {
                dirInfo1.Create();
            }

            DirectoryInfo dirInfo2 = new DirectoryInfo(projectPath + customDirectory2);

            if (!dirInfo2.Exists)
            {
                dirInfo2.Create();
            }
        }

        private void CreateCustomFile()
        {
            FileInfo fileInfo = new FileInfo(projectPath + customDirectory1 + customFile1);

            if (!fileInfo.Exists)
            {
                fileInfo.Create();
            }

            try
            {
                WriteTextToFile("Hello world!", fileInfo.FullName);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}\n" +
                    "This error will be once. WRITE FILE!", ex.Message);
            }
        }

        private void WriteTextToFile(string text, string path)
        {
            using (StreamWriter sw = new StreamWriter(path, true, UTF8Encoding.UTF8))
            {
                sw.WriteLine(text);
            }
        }

        private void CopyFile()
        {
            string oldPath = projectPath + customDirectory1 + customFile1;
            string newPath = projectPath + customDirectory2 + customFile2;

            FileInfo fileInfo = new FileInfo(oldPath);

            if (fileInfo.Exists)
            {
                try
                {
                    fileInfo.CopyTo(newPath, true);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: {0}\n" +
                        "This error will be once. COPY FILE!", ex.Message);
                }
            }
        }

        private void DeleteCustomFile()
        {
            FileInfo fileInfo = new FileInfo(projectPath + customDirectory1 + customFile1);

            if (fileInfo.Exists)
            {
                try
                {
                    fileInfo.Delete();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: {0}\n" +
                        "This error will be once. DELETE FILE", ex.Message);
                }
            }
        }

        private void Task_B()
        {
            CreateCustomDirectoryFiles();

            CopyFilesByExtension();

            MoveFiles();
        }

        private void CreateCustomDirectoryFiles()
        {
            DirectoryInfo dirInfo = new DirectoryInfo(projectPath + customDirectory3);

            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
        }

        private void CopyFilesByExtension()
        {
            IEnumerable<string> files = Directory.GetFiles(projectPath)
                .Where(x => x.Contains(extension));

            Console.WriteLine("---- FILES BY EXTENSION config ----");

            string path = projectPath + customDirectory3;

            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);

                try
                {
                    fileInfo.CopyTo(path + $@"\{fileInfo.Name}", true);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: {0}\n" +
                        "This error will be once. COPY FILE!", ex.Message);
                }
            }
        }

        private void MoveFiles()
        {
            string oldPath = projectPath + customDirectory3;

            string[] files = Directory.GetFiles(oldPath);

            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);

                string newPath = projectPath + customDirectory2 + $@"\{fileInfo.Name}";

                try
                {
                    FileInfo newFileInfo = new FileInfo(newPath);

                    if (!newFileInfo.Exists)
                    {
                        fileInfo.MoveTo(newPath);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: {0}\n" +
                     "This error will be once. MOVE FILE!", ex.Message);
                }
            }
        }

        private void Task_C()
        {
            //Сделайте архив из файлов директория XXXFiles. Разархивируйте его в другой директорий.
        }

        private void CreateArchive()
        {
            //// поток для чтения исходного файла
            //using (FileStream sourceStream = new FileStream(projectPath + customDirectory3, FileMode.OpenOrCreate))
            //{
            //    // поток для записи сжатого файла
            //    using (FileStream targetStream = File.Create(compressedFile))
            //    {
            //        // поток архивации
            //        using (GZipStream compressionStream = new GZipStream(targetStream, CompressionMode.Compress))
            //        {
            //            sourceStream.CopyTo(compressionStream); // копируем байты из одного потока в другой
            //            Console.WriteLine("Сжатие файла {0} завершено. Исходный размер: {1}  сжатый размер: {2}.",
            //                sourceFile, sourceStream.Length.ToString(), targetStream.Length.ToString());
            //        }
            //    }
            //}
        }

        public void Task_D()
        {
            //Task_A();

            Console.WriteLine("----------------");

            //Task_B();

            Console.WriteLine("----------------");

            Task_C();
        }
    }
}

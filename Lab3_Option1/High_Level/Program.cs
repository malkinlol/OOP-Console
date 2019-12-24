using High_Level.classes;
using System;

namespace High_Level
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Computer computer = new Computer())
            {
                computer.Launch("Windows 8.1");
                Console.WriteLine(computer.OS.Name);

                computer.OS = OS.GetOS("Windows 10");
                Console.WriteLine(computer.OS.Name);
            }             
        }
    }
}

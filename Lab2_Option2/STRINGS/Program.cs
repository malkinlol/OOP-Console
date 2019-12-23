using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRINGS
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();

            Console.WriteLine("---------------");

            Task2();

            Console.WriteLine("---------------");

            Task3();

            Console.WriteLine("---------------");

            Task4();
        }

        private static void Task1()
        {
            string str1 = "Hello";
            string str2 = "Hello";
            string str3 = "HellO";

            Console.WriteLine(str1 == str2);
            Console.WriteLine(str1 == str3);
            Console.WriteLine(str2 == str3);

            Console.WriteLine(str1.Equals(str2));
            Console.WriteLine(str1.Equals(str3));
            Console.WriteLine(str2.Equals(str3));

            Console.WriteLine(str1.CompareTo(str2));
            Console.WriteLine(str1.CompareTo(str3));
            Console.WriteLine(str2.CompareTo(str3));
        }

        private static void Task2()
        {
            string str1 = "Hello";
            string str2 = new string('a', 6);
            string str3 = new string(new char[] { 'E', 'd', 'u', 'a', 'r', 'd' });

            Console.WriteLine("------ Concat ------");
            Console.WriteLine(str1 + " " + str2 + " " + str3 );
            Console.WriteLine(string.Concat(str1, str2,str3));

            Console.WriteLine("------ Copy ------");
            Console.WriteLine(string.Copy(str1));

            Console.WriteLine("------ Substing ------");
            Console.WriteLine(str1.Substring(0, 3));

            Console.WriteLine("------ Split ------");
            str1 = "Hello my name is world";
            string[] words = str1.Split(new char[] { ' ' });

            foreach(string word in words)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine("------ Insert ------");
            Console.WriteLine(str1.Insert(0, "I'll be back"));

            Console.WriteLine("------ Remove ------");
            Console.WriteLine(str1.Remove(0, 3));
        }

        private static void Task3()
        {
            string str1 = "";
            string str2 = null;

            Console.WriteLine(string.IsNullOrEmpty(str1));
            Console.WriteLine(string.IsNullOrEmpty(str2));
            Console.WriteLine(str1.Equals(str2));
            Console.WriteLine(str1.Length);

            //Console.WriteLine(str2.Length); -- The error will be here
        }

        private static void Task4()
        {
            StringBuilder str = new StringBuilder("Hello World", 50);
            str.Remove(0, 5);
            Console.WriteLine(str);
            str.Append("Hello");
            Console.WriteLine(str);
            str.Insert(0, "Hello");
            Console.WriteLine(str);
        }
    }
}

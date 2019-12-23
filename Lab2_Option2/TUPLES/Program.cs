using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUPLES
{
    class Program
    {
        static void Main(string[] args)
        {
            Task2();

            Console.WriteLine("----------------");

            Task4();
        }

        private static void Task1()
        {
            (int, string, char, string, ulong) tuple = (1, "string", 'a', "string", 100);
        }

        private static void Task2()
        {
            (int, string, char, string, ulong) tuple = (1, "string", 'a', "string", 100);

            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item3);
            Console.WriteLine(tuple.Item4);
        }

        private static void Task3()
        {
            (int, string, char, string, ulong) tuple = (1, "string", 'a', "string", 100);

            int x1 = tuple.Item1;
            string x2 = tuple.Item2;
            char x3 = tuple.Item3;
            string x4 = tuple.Item4;
            ulong x5 = tuple.Item5;
        }

        private static void Task4()
        {
            (int, string, char, string, ulong) tuple1 = (1, "string", 'a', "string", 100);
            (int, string, char, string, ulong) tuple2 = (1, "string", 'a', "string", 100);
            (int, string, char, string, ulong) tuple3 = (2, "string", 'a', "string", 100);

            Console.WriteLine(tuple1 == tuple2);
            Console.WriteLine(tuple1 == tuple3);
            Console.WriteLine(tuple2 == tuple3);
        }
    }
}

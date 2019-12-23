using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easy_Level
{
    class Program
    {
        static void Main(string[] args)
        {
            Task3();

            Console.WriteLine("--------------");

            Task4();

            Console.WriteLine("--------------");

            Task5();

            Console.WriteLine("--------------");

            Task6();

            Console.WriteLine("--------------");

            Task8();
        }

        private static void Task1()
        {
            int x1 = 5;
            double x2 = 10.10;
            string x3 = "Hello World";

            object o1 = x1;
            object o2 = x2;
            object o3 = x3;

            int xx1 = (int)o1;
            double xx2 = (double)o2;
            string xx3 = (string)o3;
        }

        private static void Task2()
        {
            double x = 13.10;

            byte x1 = (byte)x;
            short x2 = (short)x;
            int x3 = (int)x;

            byte y = 10;

            short y1 = y;
            int y2 = y;
            double y3 = y;
        }

        private static void Task3()
        {
            string name = "Eduard";

            Console.WriteLine("Hello, {0}", name);
            Console.WriteLine($"Hello, {name}");
        }

        private static void Task4()
        {
            int x = 5;
            int y = 5;

            Console.WriteLine(x.Equals(y));
            Console.WriteLine(x.ToString());
            Console.WriteLine(x.GetType());
            Console.WriteLine(x.GetHashCode());
            Console.WriteLine(x.CompareTo(y));
        }

        private static void Task5()
        {
            string str1 = "String_1";
            string str2 = "String_2";

            Console.WriteLine(str1.CompareTo(str2));
            Console.WriteLine(str1.Contains(str2));
            Console.WriteLine(str1.Substring(0, 3));
            Console.WriteLine(str1.Insert(0, str2));
            Console.WriteLine(str1.Replace('t', 's'));
        }

        private static void Task6()
        {
            string str1 = "";
            string str2 = null;

            Console.WriteLine(string.IsNullOrEmpty(str1));
            Console.WriteLine(string.IsNullOrEmpty(str2));
        }

        private static void Task7()
        {
            try
            {
                var x = 5;

                //x = "Hello World";

                Console.WriteLine(x);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void Task8()
        {
            int? x1 = null;
            bool? y1 = null;

            Nullable<int> x2 = 5;
            Nullable<bool> y2 = null;

            //Value | HasValue

            if (x1.HasValue)
            {
                Console.WriteLine($"x1 = {x1.Value}");
            }

            if (x2.HasValue)
            {
                Console.WriteLine($"x2 = {x2.Value}");
            }

            int? x3 = x1 ?? x2;
            bool? y3 = y1 ?? y2;

            if (x3.HasValue)
            {
                Console.WriteLine($"x3 = {x3.Value}");
            }

            if (y3.HasValue)
            {
                Console.WriteLine($"y3 = {y3.Value}");
            }
        }
    }
}

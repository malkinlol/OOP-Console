using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TYPES
{
    class Program
    {
        static void Main(string[] args)
        {
            Task4();

            Console.WriteLine("------------");

            Task5();
        }

        private static void Task1()
        {
            bool x1 = false;
            byte x2 = 100;
            sbyte x3 = -100;
            short x4 = -100;
            ushort x5 = 100;
            int x6 = -100;
            uint x7 = 100;
            long x8 = -100;
            ulong x9 = 100;
            float x10 = 10f;
            double x11 = 10;
            decimal x12 = 10m;
            string x13 = "str";
            char x14 = 'a';
            object x15 = "this is object variable";
        }

        private static void Task2()
        {
            //---- explicit ----
            double x = 10;

            byte x1 = (byte)x;
            short x2 = (short)x;
            int x3 = (int)x;
            long x4 = (long)x;
            float x5 = (float)x;

            //---- implicit ----
            byte y = 10;

            short y1 = y;
            int y2 = y;
            long y3 = y;
            float y4 = y;
            double y5 = y;
        }

        private static void Task3()
        {
            int x = 10;

            object o = x; // boxing

            int y = (int)o; // unboxing
        }

        private static void Task4()
        {
            var x = 10;
            x = 20;
            Console.WriteLine(x);
        }

        private static void Task5()
        {
            int? x = 5;
            int? y = null;

            if (x.HasValue)
            {
                Console.WriteLine("x: {0}", x.Value);
            }

            if (y.HasValue)
            {
                Console.WriteLine("y: {0}", y.Value);
            }

            int? z1 = x ?? y;
            int? z2 = y ?? x;

            if (z1.HasValue)
            {
                Console.WriteLine("z1: {0}", z1.Value);
            }

            if (z2.HasValue)
            {
                Console.WriteLine("z2: {0}", z2.Value);
            }
        }
    }
}

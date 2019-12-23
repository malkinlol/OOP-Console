using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARRAYS
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();

            Console.WriteLine("-----------------");

            Task2();

            Console.WriteLine("-----------------");

            Task3();
        }

        private static void Task1()
        {
            int[,] array = { { 1, 2, 3 }, { 4, 5, 6 } };

            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }
        }

        private static void Task2()
        {
            string[] array = { "hello", "world" };

            Console.WriteLine("----- New array -----");
            foreach (string str in array)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("Array length: {0}", array.Length);

            array[0] = "goodbye";

            Console.WriteLine("----- Update array -----");
            foreach (string str in array)
            {
                Console.WriteLine(str);
            }
        }

        private static void Task3()
        {
            float[][] array = new float[3][];
            array[0] = new float[2] { 1, 2 };
            array[1] = new float[3] { 1, 2, 3 };
            array[2] = new float[4] { 1, 2, 3, 4 };

            foreach (float[] row in array)
            {
                foreach (float number in row)
                {
                    Console.Write($"{number} \t");
                }
                Console.WriteLine();
            }
        }

        private static void Task4()
        {
            var array = new int[] { 1, 2, 3 };
            var str = "Hello";
        }
    }
}

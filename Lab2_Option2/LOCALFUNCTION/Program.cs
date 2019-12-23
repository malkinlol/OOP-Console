using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOCALFUNCTION
{
    class Program
    {
        static void Main(string[] args)
        {
            (int, int, int, char) LocalFunction(int[] array, string str)
            {
                int max = array.Max();
                int min = array.Min();
                int sum = array.Sum();
                char firstLetter = str[0];

                return (max, min, sum, firstLetter);
            }

            var result = LocalFunction(new int[] { 1, 2, 3 }, "Hello");

            Console.WriteLine(result);
        }
    }
}

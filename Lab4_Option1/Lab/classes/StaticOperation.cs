using System.Linq;

namespace Lab.classes
{
    public class StaticOperation
    {
        public static int Sum(int value1, int value2)
        {
            return value1 + value2;
        }

        public static int Sub(int[] array)
        {
            int max = array.Max();
            int min = array.Min();

            return max - min;
        }

        public static int Count(int[] array)
        {
            return array.Count();
        }
    }
}

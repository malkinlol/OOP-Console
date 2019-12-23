using System;

namespace Easy_Level.classes
{
    public class TestClass
    {
        public static void Method1()
        {
            try
            {
                Method2();
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("Catch in the Method1: {0}", ex.Message);
            }
            finally
            {
                Console.WriteLine("Block finally in the Method1");
            }

            Console.WriteLine("Method1 ended"); // not run
        }

        private static void Method2()
        {
            try
            {
                int x = 8;
                int y = x / 0;
            }
            finally
            {
                Console.WriteLine("Block finally in the Method2");
            }

            Console.WriteLine("Method2 ended!"); // not run
        }
    }
}

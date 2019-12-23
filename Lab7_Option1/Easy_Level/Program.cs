using Easy_Level.classes;
using System;
using System.Diagnostics;

namespace Easy_Level
{
    class Program
    {
        static void Main(string[] args)
        {
            Task2_a_b();

            Console.WriteLine("----------------");

            Task2_c();

            Console.WriteLine("----------------");

            Task2_d();

            Console.WriteLine("----------------");

            Task3();

            Console.WriteLine("----------------");

            Task4();
        }

        private static void Task1()
        {
            try
            {

            }
            catch (DivideByZeroException ex) { }
            catch (NullReferenceException ex) { }
            catch (IndexOutOfRangeException ex) { }
            catch (InvalidCastException ex) { }
            catch (ArgumentException ex) { }
            catch (Exception ex) { }
        }

        private static void Task2_a_b()
        {
            int x = 5;
            int y = 0;
            int z = 0;

            try
            {
                z = x / y;

                Console.WriteLine(z);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Block finally");
            }
        }

        private static void Task2_c()
        {
            try
            {
                TestClass.Method1();
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Catch in the Main: {0}", ex.Message);
            }
            finally
            {
                Console.WriteLine("Block finally in the Main");
            }

            Console.WriteLine("Method Task2 ended!");
        }

        private static void Task2_d()
        {
            int x = 5;
            int y = 0;
            int z = 0;

            try
            {
                z = x / 0;
            }
            catch (DivideByZeroException ex) when (x == 0 && y == 0)
            {
                Console.WriteLine("With filter: {0}", ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Without filter: {0}", ex.Message);
            }
        }

        private static void Task3()
        {
            //Trace - debug | release
            //Debug - debug

            Debug.Listeners.Add(new TextWriterTraceListener(Console.Out));
            Debug.AutoFlush = true;
            Debug.Indent(); // enable right shift
            Debug.WriteLine("Entering Main");
            Console.WriteLine("Hello World.");
            Debug.WriteLine("Exiting Main");
            Debug.Unindent(); // disable right shift
        }

        private static void Task4()
        {
            int x = 5;
            int y = 10;

            bool result1 = x > y;
            bool result2 = y > x;

            // Uncomment code below

            //Debug.Assert(result1, $"Message: {result1}");
            //Debug.Assert(result2, $"Message: {result2}");
        }
    }
}

using High_Level.Classes;
using System;

namespace High_Level
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1_Option1();
        }

        private static void Task1_Option1()
        {
            using(Person person = new Person("Eduard", 20))
            {
                Console.WriteLine("Get name: {0}", person.name);
            }

            Console.WriteLine("Method Task1 ended!");
        }

        private static void Task1_Option2()
        {
            ///
            /// You can try to run this code if you have C# 8 
            /// 
            
            //using Person person = new Person("Arina", 19);

            //Console.WriteLine("Get name: {0}", person.name);

            //Console.WriteLine("Method Task1 ended!");
        }
    }
}

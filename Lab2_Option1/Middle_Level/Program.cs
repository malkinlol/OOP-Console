using Middle_Level.Classes;
using System;

namespace Middle_Level
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();

            Console.WriteLine("------------");

            Task2();

            Console.WriteLine("------------");

            Task3();

            Console.WriteLine("------------");

            Task4();
        }

        private static void Task1()
        {
            int x = Sum((3, 3));

            Console.WriteLine($"Result Sum: {x}");

            int Sum((int x, int y) tuple)
            {
                return tuple.x + tuple.y;
            }
        }

        private static void Task2()
        {
            var personEduard = (name: "Eduard", age: 20, weigh: 84.20);

            Console.WriteLine(personEduard);
            Console.WriteLine(personEduard.name);
            Console.WriteLine(personEduard.age);
            Console.WriteLine(personEduard.weigh);
            Console.WriteLine("-----");

            (string, int, double) personArina = (name: "Aring", age: 19, weigh: 45.20);

            Console.WriteLine(personArina);
            Console.WriteLine(personArina.Item1);
            Console.WriteLine(personArina.Item2);
            Console.WriteLine(personArina.Item3);
            Console.WriteLine("-----");

            var (name, age, weight) = ("Maxim", 20, 76.90);

            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(weight);
        }

        private static void Task3()
        {
            Console.WriteLine("----- unsafe -----");

            unsafe
            {
                int* x;
                int y = 10;

                x = &y;
                Console.WriteLine(*x);

                y = y + 20;
                Console.WriteLine(*x);

                *x = 50;
                Console.WriteLine(y);

                ulong address = (ulong)x;
                Console.WriteLine("Address variable: {0}", address);
            }

            Console.WriteLine("----- fixed -----");

            unsafe
            {
                Person person = new Person();
                person.age = 20;

                fixed (int* p = &person.age)
                {
                    if (*p < 30)
                    {
                        *p = 30;
                    }
                }

                Console.WriteLine($"Age: {person.age}");
            }
        }

        private static void Task4()
        {
            Console.WriteLine("Checked result: {0}", CheckedFunction());
            Console.WriteLine("Unchecked result: {0}", UncheckedFunction());


            int CheckedFunction()
            {
                byte x = 0;

                try
                {
                    Console.Write("x = ");
                    x = unchecked((byte)int.Parse(Console.ReadLine()));

                    checked
                    {
                        x += 250;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                return x;
            }

            int UncheckedFunction()
            {
                Console.Write("x = ");
                byte x = unchecked((byte)int.Parse(Console.ReadLine()));

                return x;
            }
        }
    }


}

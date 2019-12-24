using Easy_Level.classes;
using System;

namespace Easy_Level
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = CreatePerson();

            Console.WriteLine("--------------");

            ExampleRefAndOutParameters(person);

            Console.WriteLine("--------------");

            ExamplePartialClass(person);

            Console.WriteLine("--------------");

            GetInfoByPerson(person);

            Console.WriteLine("--------------");

            CreateAnonymType();

            Console.WriteLine("--------------");
        }

        private static Person CreatePerson()
        {
            Person person = new Person(1, "Eduard", "Popkov", 1999, 'm');

            Console.WriteLine(person);

            return person;
        }

        private static void ExampleRefAndOutParameters(Person person)
        {
            int year = 0;

            person.UpdateYearWithoutRef(year);
            Console.WriteLine("Year without ref: {0}", year);

            person.UpdateYearWithRef(ref year);
            Console.WriteLine("Year with ref: {0}", year);

            int age = 0;
            person.GetCurrentAge(year, out age);
            Console.WriteLine("Age with out: {0}", age);
        }

        private static void ExamplePartialClass(Person person)
        {
            person.SetPhone("+375(xx)xxx-xx-xx");

            string phone = person.GetPhone();

            Console.WriteLine("Person phone: {0}", phone);
        }

        private static void GetInfoByPerson(Person person)
        {
            Info.GetInfoByPerson(person);
        }

        private static void CreateAnonymType()
        {
            var person = new { Name = "Eduard", Surname = "Popkov", Year = 1999, Gender = 'm' };

            Console.WriteLine(person);
        }
    }
}

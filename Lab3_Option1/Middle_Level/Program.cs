using Middle_Level.classes;
using System;
using System.Collections.Generic;

namespace Middle_Level
{
    static class Program
    {
        static void Main(string[] args)
        {
            Person person1 = CreatePerson(1, "Eduard", 1999);
            Person person1_1 = CreatePerson(2, "Arina", 2000);
            Person person1_2 = CreatePerson(3, "Tatyana", 1979);

            AddToFamily(person1, person1_1);
            AddToFamily(person1, person1_2);

            GetFamily(person1);

            Console.WriteLine("-------------------");

            RemoveFromFamily(person1, person1_1);

            GetFamily(person1);

            Console.WriteLine("-------------------");

            GetCountFamily(person1);

            Console.WriteLine("-------------------");

            ExampleByIndexator();

            Console.WriteLine("-------------------");
        }

        private static Person CreatePerson(int personId, string name, int year)
        {
            Person person = new Person(personId, name, year);

            return person;
        }

        private static void AddToFamily(Person person, Person memberFamily)
        {
            person.Add(memberFamily);
        }

        private static void RemoveFromFamily(Person person, Person memberFamily)
        {
            person.Delete(memberFamily);
        }

        private static void GetFamily(Person person)
        {
            IList<Person> family = person.GetFamily();

            foreach (Person p in family)
            {
                Console.WriteLine(p);
            }
        }

        private static void GetCountFamily(Person person)
        {
            int count = person.GetCountPeople();

            Console.WriteLine("Count people in family: {0}", count);
        }

        private static void ExampleByIndexator()
        {
            People people = new People();
            people[0] = CreatePerson(1, "Eduard", 1999);
            people[1] = CreatePerson(2, "Arina", 2000);

            Person person1 = people[0];

            Console.WriteLine(person1);
        }
    }
}

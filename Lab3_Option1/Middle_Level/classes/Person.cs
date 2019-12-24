using System;
using System.Collections.Generic;
using System.Linq;

namespace Middle_Level.classes
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public IList<Person> Family { get; set; } = new List<Person>();

        public Person(int personId, string name, int year)
        {
            PersonId = personId;
            Name = name;
            Year = year;
        }

        public void Add(Person person)
        {
            if (person == null)
            {
                Console.WriteLine("Method Add: Person is null");
            }

            Family.Add(person);
        }

        public void Delete(Person person)
        {
            if (person == null)
            {
                Console.WriteLine("Method Delete: Person is null");
            }

            Family.Remove(person);
        }

        public Person GetById(Person person)
        {
            if (person == null)
            {
                Console.WriteLine("Method GetById: Person is null");
            }

            return Family
                .FirstOrDefault(x => x.PersonId == person.PersonId);
        }

        public IList<Person> GetFamily()
        {
            return Family;
        }

        public int GetCountPeople()
        {
            return Family.Count;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            Person person = (Person)obj;

            return (
                this.PersonId == person.PersonId &&
                this.Name == person.Name &&
                this.Year == person.Year
            );
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"Name: {Name}" + Environment.NewLine +
                $"Year: {Year}";
        }
    }
}

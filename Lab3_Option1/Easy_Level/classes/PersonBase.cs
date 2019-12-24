using System;

namespace Easy_Level.classes
{
    public partial class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Year { get; set; }
        public char Gender { get; set; }

        public static int StaticField { get; set; } = 5;

        private int _propertyField1 = 5;
        public int PropertyField2 { get; }
        public int PropertyField3 { private get; set; }

        public readonly string ReadonlyField = "Hello World!";

        public Person()
        {
            Console.WriteLine("Constructor by default");
        }

        ~Person()
        {
            // Console.Beep();
            Console.WriteLine("Descructor");
        }

        public Person(int personId, string name, string surname, int year, char gender)
        {
            Console.WriteLine("Constructor by parameters");

            this.PersonId = personId;
            this.Name = name;
            this.Surname = surname;
            this.Year = year;
            this.Gender = gender;
        }

        static Person()
        {
            Console.WriteLine("Constructor is static");
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            Person person = (Person)obj;

            return (
                this.Name == person.Name &&
                this.Surname == person.Surname &&
                this.Year == person.Year &&
                this.Gender == person.Gender
            );
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"Name: {Name}" + Environment.NewLine +
                $"Surname: {Surname}" + Environment.NewLine +
                $"Year: {Year}" + Environment.NewLine +
                $"Gender: {Gender}";
        }

        public static void GetStaticField()
        {
            Console.WriteLine("Static Field: {0}", StaticField);
        }

        public int PropertyField1
        {
            get
            {
                return _propertyField1;
            }
            set
            {
                _propertyField1 = value;
            }
        }

        public void UpdateYearWithoutRef(int year)
        {
            year += this.Year;
        }

        public void UpdateYearWithRef(ref int year)
        {
            year += this.Year;
        }

        public void GetCurrentAge(int year, out int age)
        {
            int currentYear = DateTime.Now.Year;

            age = currentYear - year;
        }
    }
}

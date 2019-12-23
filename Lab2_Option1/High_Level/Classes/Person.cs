using System;

namespace High_Level.Classes
{
    public class Person : IDisposable
    {
        public string name;
        public int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Dispose()
        {
            Console.WriteLine("Disposed");
        }

        public override string ToString()
        {
            return $"Name: {this.name}" + Environment.NewLine +
                $"Age: {this.age}";
        }
    }
}

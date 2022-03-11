using System;
using System.Net.Http.Headers;

namespace Numerable
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person {Name ="rich", Age = 20};
            Console.WriteLine(person);
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return "Person:" + Name + " " + Age;
        }
    }
}
using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using IClonable interface is bad, because it offers only a shallow copy which is really dangerous (we need a deep object copy)
            // So this approach with using IClonable in Prototype Design Pattern is bad

            var john = new Person(new[] { "John", "Smith" }, new Address("London Road", 123));

            var jane = (Person)john.Clone();
            jane.Names[0] = "Jane";

            Console.WriteLine(john);
            Console.WriteLine(jane);

            Console.ReadLine();
        }
    }
}

using System;

namespace Prototype___Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person(new[] { "John", "Smith" }, new Address("London Road", 123));

            var jane = john.DeepCopy();
            jane.Names[0] = "Jane";
            jane.Address.HouseNumber = 321;

            Console.WriteLine(john);
            Console.WriteLine(jane);

            Console.ReadLine();
        }
    }
}

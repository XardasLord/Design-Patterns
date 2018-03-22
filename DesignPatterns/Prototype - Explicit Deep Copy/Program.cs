using System;

namespace Prototype___Explicit_Deep_Copy
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is quite good (much more better than using IClonable), 
            // because our own interface provides us a Deep copy, which returns specific object type, not the general object type.
            // But this approach still requires to implement this interface in each of the nested objects in the object we want to clone.

            var john = new Person(new[] { "John", "Smith" }, new Address("London Road", 123));

            var jane = john.DeepCopy();
            jane.Names[0] = "Jane";

            Console.WriteLine(john);
            Console.WriteLine(jane);

            Console.ReadLine();
        }
    }
}

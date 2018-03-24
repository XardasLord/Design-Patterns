using System;

namespace Singleton___Monostate
{
    class Program
    {
        static void Main(string[] args)
        {
            // All CEO objects points to the same fields (cause they are static)
            // To see more information see the CEO class

            var ceo = new CEO();
            ceo.Name = "Adam Smith";
            ceo.Age = 55;

            var ceo2 = new CEO();
            Console.WriteLine(ceo2); // Adam Smith with age 55

            Console.ReadLine();
        }
    }
}

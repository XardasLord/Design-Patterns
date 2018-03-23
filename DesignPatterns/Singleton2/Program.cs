using System;

namespace Singleton_With_Tests_And_DI
{
    class Program
    {
        static void Main(string[] args)
        {
            // We want only one instance of that database object, because it can cost a lot of performance to be created,
            // thats why we use Singleton Pattern

            var db = SingletonDatabase.Instance;
            var city = "Tokyo";

            Console.WriteLine($"{city} has population {db.GetPopulation(city)}");

            Console.ReadLine();
        }
    }
}

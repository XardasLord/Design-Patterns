using Decorator.Models;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pizza maker
            IPizza basicPizza = new TomatoSauce(new Mozzarella(new PlainPizza()));

            Console.WriteLine($"Ingredients: {basicPizza.GetDescription()}");
            Console.WriteLine($"Price: {basicPizza.GetCost()}");

            Console.ReadKey();
        }
    }
}

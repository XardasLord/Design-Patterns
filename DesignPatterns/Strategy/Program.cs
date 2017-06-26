using System;
using Strategy.Models;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal sparky = new Dog();
            Animal tweety = new Bird();

            Console.WriteLine($"Dog: {sparky.TryToFly()}");
            Console.WriteLine($"Bird: {tweety.TryToFly()}");

            sparky.SetFlyingAbility(new ItFlys());
            Console.WriteLine($"Dog after changing its flying ability: {sparky.TryToFly()}");

            Console.ReadKey();
        }
    }
}

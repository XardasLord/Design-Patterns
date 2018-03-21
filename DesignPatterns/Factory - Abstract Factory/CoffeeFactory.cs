using System;

namespace Factory
{
    internal class CoffeeFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare(int amount)
        {
            Console.WriteLine($"Grind some beans, boil water, pour {amount} ml, add cream, and sugar, enjoy!");
            return new Coffee();
        }
    }
}

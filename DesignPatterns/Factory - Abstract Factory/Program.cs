using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var machine = new HotDrinkMachine();
            var drink = machine.MakeDrink(HotDrinkMachine.AvailableDrink.Tea, 100);
            drink.Consume();

            Console.ReadLine();
        }
    }
}

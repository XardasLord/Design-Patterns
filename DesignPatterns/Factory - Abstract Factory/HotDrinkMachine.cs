using System;
using System.Collections.Generic;

namespace Factory
{
    public class HotDrinkMachine
    {
        // This commented code was breaking Open/Closed Principle

        //public enum AvailableDrink
        //{
        //    Coffee, Tea
        //}

        //private Dictionary<AvailableDrink, IHotDrinkFactory> factories = new Dictionary<AvailableDrink, IHotDrinkFactory>();

        //public HotDrinkMachine()
        //{
        //    foreach (AvailableDrink drink in Enum.GetValues(typeof(AvailableDrink)))
        //    {
        //        var factory = (IHotDrinkFactory)Activator.CreateInstance(
        //            Type.GetType("Factory." + Enum.GetName(typeof(AvailableDrink), drink) + "Factory"));

        //        factories.Add(drink, factory);
        //    }
        //}

        //public IHotDrink MakeDrink(AvailableDrink drink, int amount)
        //{
        //    return factories[drink].Prepare(amount);
        //}

        private List<Tuple<string, IHotDrinkFactory>> factories = new List<Tuple<string, IHotDrinkFactory>>();

        public HotDrinkMachine()
        {
            // Fill factories using reflection
            foreach (var t in typeof(HotDrinkMachine).Assembly.GetTypes())
            {
                if(typeof(IHotDrinkFactory).IsAssignableFrom(t) && !t.IsInterface)
                {
                    factories.Add(Tuple.Create(
                        t.Name.Replace("Factory", string.Empty),
                        (IHotDrinkFactory)Activator.CreateInstance(t)
                    ));
                }
            }
        }

        public IHotDrink MakeDrink()
        {
            Console.WriteLine("Available drinks:");
            for (var i = 0; i < factories.Count; i++)
            {
                var tuple = factories[i];
                Console.WriteLine($"{i}: {tuple.Item1}");
            }

            while (true)
            {
                string s;
                if((s = Console.ReadLine()) != null && int.TryParse(s, out int selectedDrink) && selectedDrink >= 0 && selectedDrink < factories.Count)
                {
                    Console.WriteLine("Specify amount:");
                    s = Console.ReadLine();
                    if(s != null && int.TryParse(s, out int amount) && amount > 0)
                    {
                        return factories[selectedDrink].Item2.Prepare(amount);
                    }
                }
            }
        }
    }
}

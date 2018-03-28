using System;

namespace Decorator_Pizza_Decorator.Models
{
    public class Mozzarella : ToppingDecorator
    {
        public Mozzarella(IPizza newPizza) 
            :base(newPizza)
        {
            Console.WriteLine("Adding Dough.");
            Console.WriteLine("Adding Mozzarella.");
        }

        public new string GetDescription()
        {
            return tempPizza.GetDescription() + ", Mozzarella";
        }

        public new double GetCost()
        {
            return tempPizza.GetCost() + .50;
        }
    }
}

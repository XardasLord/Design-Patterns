using System;

namespace Decorator.Models
{
    public class TomatoSauce : ToppingDecorator
    {
        public TomatoSauce(IPizza newPizza) 
            :base(newPizza)
        {
            Console.WriteLine("Adding Sauce.");
        }

        public new string GetDescription()
        {
            return tempPizza.GetDescription() + ", Tomato Sauce";
        }

        public new double GetCost()
        {
            return tempPizza.GetCost() + .35;
        }
    }
}

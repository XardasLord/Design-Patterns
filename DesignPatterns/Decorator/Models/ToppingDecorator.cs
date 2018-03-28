namespace Decorator_Pizza_Decorator.Models
{
    public abstract class ToppingDecorator : IPizza
    {
        protected IPizza tempPizza;

        public ToppingDecorator(IPizza newPizza)
        {
            tempPizza = newPizza;
        }

        public string GetDescription()
        {
            return tempPizza.GetDescription();
        }

        public double GetCost()
        {
            return tempPizza.GetCost();
        }
    }
}

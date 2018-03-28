namespace Decorator_Pizza_Decorator.Models
{
    public class PlainPizza : IPizza
    {
        public string GetDescription()
        {
            return "Thin Dought.";
        }

        public double GetCost()
        {
            return 4.00;
        }
    }
}

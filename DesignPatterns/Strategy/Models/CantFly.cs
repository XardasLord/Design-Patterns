using Strategy.Interfaces;

namespace Strategy.Models
{
    public class CantFly : IFlyable
    {
        public string Fly()
        {
            return "I can't fly.";
        }
    }
}

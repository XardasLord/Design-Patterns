using Strategy.Interfaces;

namespace Strategy.Models
{
    public class ItFlys : IFlyable
    {
        public string Fly()
        {
            return "Flying High.";
        }
    }
}

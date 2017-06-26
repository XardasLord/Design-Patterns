using Strategy.Interfaces;
using System;

namespace Strategy.Models
{
    public class Animal
    {
        private int _weight;

        public string Name { get; set; }
        public double Height { get; set; }
        public int Weight {
            get
            {
                return _weight;
            }
            set
            {
                if(value > 0)
                {
                    _weight = value;
                }
                else
                {
                    Console.WriteLine("Weight must be bigger that 0.");
                }
            }
        }
        public string FavouriteFood { get; set; }
        public double Speed { get; set; }
        public string Sound { get; set; }
        public IFlyable FlyingType { get; set; }

        public string TryToFly()
        {
            return FlyingType.Fly();
        }

        public void SetFlyingAbility(IFlyable newFlyType)
        {
            FlyingType = newFlyType;
        }
    }
}

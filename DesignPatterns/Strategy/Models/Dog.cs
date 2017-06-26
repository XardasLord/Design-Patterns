using System;

namespace Strategy.Models
{
    public class Dog : Animal
    {
        public void DigHole()
        {
            Console.WriteLine("Dug a hole.");
        }

        public Dog()
            :base()
        {
            Sound = "Bark";
            FlyingType = new CantFly();
        }
    }
}

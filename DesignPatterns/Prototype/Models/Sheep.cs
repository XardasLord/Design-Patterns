using System;

namespace Prototype.Models
{
    public class Sheep : IAnimal
    {
        public Sheep()
        {
            Console.WriteLine("Sheep is made.");
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public IAnimal MakeCopy()
        {
            Console.WriteLine("Sheep is being made.");

            Sheep sheepObject = null;

            try
            {
                sheepObject = (Sheep)MemberwiseClone();
            }
            catch(Exception e)
            {
                Console.WriteLine($"Error while cloning a sheep. Error message: {e.Message}");
            }

            return sheepObject;
        }

        public override string ToString()
        {
            return "Dolly is my hero!";
        }
    }
}

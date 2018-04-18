using System;
using System.Collections.Generic;

namespace Factory___Factory_Method___Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<Animal>();
            IAnimalFactory factory = new DogFactory();

            animals.Add(factory.GetAnimal());

            factory = new CatFactory();
            animals.Add(factory.GetAnimal());

            factory = new FishFactory();
            animals.Add(factory.GetAnimal());

            foreach (var animal in animals)
                animal.Display();


            Console.ReadLine();
        }
    }
}

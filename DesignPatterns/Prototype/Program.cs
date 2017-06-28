using Prototype.Models;
using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            CloneFactory animalMaker = new CloneFactory();
            Sheep sally = new Sheep();

            Sheep clonedSheep = (Sheep)animalMaker.GetClone(sally);

            Console.WriteLine(sally);
            Console.WriteLine(clonedSheep);
            Console.WriteLine($"Sally Hascode: {sally.GetHashCode()}");
            Console.WriteLine($"Cloned sheep Hascode: {clonedSheep.GetHashCode()}");

            Console.ReadKey();
        }
    }
}

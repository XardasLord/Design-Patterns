using System;

namespace Builder2
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarBuilder ferrariBuilder = new FerrariBuilder();
            ICarBuilder fordBuilder = new FordBuilder();

            var carDirector = new CarDirector(ferrariBuilder);

            carDirector.MakeCar();
            var ferrari = carDirector.GetCar();

            
            carDirector = new CarDirector(fordBuilder);

            carDirector.MakeCar();
            var ford = carDirector.GetCar();

            Console.WriteLine(ferrari.ToString());
            Console.WriteLine(ford.ToString());


            Console.ReadKey();
        }
    }
}

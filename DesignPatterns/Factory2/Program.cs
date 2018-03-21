using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var point = Point.Factory.NewPolarPoint(1.0, Math.PI / 2);
            Console.WriteLine(point.ToString());

            Console.ReadLine();
        }
    }
}

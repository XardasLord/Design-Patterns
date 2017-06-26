using System;

namespace Singleton
{
    public class Program
    {
        static void Main(string[] args)
        {
            Singleton firstInstance = Singleton.GetInstance();
            Console.WriteLine($"First instance ID: {firstInstance.GetHashCode()}");

            Singleton secondInstance = Singleton.GetInstance();
            Console.WriteLine($"Second instance ID: {secondInstance.GetHashCode()}");

            Console.ReadKey();
        }
    }
}

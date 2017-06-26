using Strategy2.Models;
using System;

namespace Strategy2
{
    class CalculateSalary
    {
        static void Main(string[] args)
        {
            Employees salesman = new Salesman(15000.00);
            Employees secretary = new Secretary(25000.00);

            Console.WriteLine($"Salesman {salesman.GetPay()}");
            Console.WriteLine($"Secretary {secretary.GetPay()}");

            secretary.SetBonusOption(new Bonus20Per());

            Console.WriteLine($"Salesman {salesman.GetPay()}");
            Console.WriteLine($"Secretary {secretary.GetPay()}");

            Console.ReadKey();
        }
    }
}

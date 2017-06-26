using Strategy2.Interfaces;

namespace Strategy2.Models
{
    public class NoBonus : IPay
    {
        public double GetPay(double salary)
        {
            return salary;
        }
    }
}

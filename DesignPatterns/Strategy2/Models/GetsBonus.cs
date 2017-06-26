using Strategy2.Interfaces;

namespace Strategy2.Models
{
    public class GetsBonus : IPay
    {
        public double GetPay(double salary)
        {
            return salary + (salary * .15);
        }
    }
}

using Strategy2.Interfaces;

namespace Strategy2.Models
{
    public class Bonus20Per : IPay
    {
        public double GetPay(double salary)
        {
            return salary + (salary * .20);
        }
    }
}

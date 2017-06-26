using Strategy2.Interfaces;

namespace Strategy2.Models
{
    public class Salesman : Employees
    {
        public Salesman(double salary)
            :base(salary)
        {

        }

        public Salesman(double salary, IPay payType)
            : base(salary, payType)
        {
            SetBonusOption(payType);
        }
    }
}

using Strategy2.Interfaces;

namespace Strategy2.Models
{
    public class Secretary : Employees
    {
        public Secretary(double salary)
            : base(salary)
        {

        }

        public Secretary(double salary, IPay payType)
            : base(salary, payType)
        {
            SetBonusOption(payType);
        }

        public double GetPay()
        {
            return _payType.GetPay(_salary);
        }
    }
}

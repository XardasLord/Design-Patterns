using Strategy2.Interfaces;

namespace Strategy2.Models
{
    public abstract class Employees
    {
        protected bool _bonus;
        protected double _salary = 0.0;
        protected IPay _payType = new NoBonus();

        public Employees(double salary)
        {
            _salary = salary;
        }

        public Employees(double salary, IPay payType)
        {
            _salary = salary;
            _payType = payType;
        }

        public void SetBonusOption(IPay payType)
        {
            _payType = payType;
        }

        public double GetPay()
        {
            return _payType.GetPay(_salary);
        }
    }
}

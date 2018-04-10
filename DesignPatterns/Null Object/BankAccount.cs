using System;

namespace Null_Object
{
    public class BankAccount
    {
        private ILog log;
        private int balance;

        public BankAccount(ILog log)
        {
            this.log = log ?? throw new ArgumentNullException(paramName: nameof(log));
        }

        public void Deposit(int amount)
        {
            balance += amount;
            log.Info($"Deposited ${amount}, balance is now ${balance}");
        }
    }
}

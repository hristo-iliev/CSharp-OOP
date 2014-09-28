namespace _02Bank
{
    using System;

    public class DepositAccount : Account, IDepositable
    {
        public DepositAccount(Customer customer)
            : base(customer, 0m, 0m)
        {
        }

        public DepositAccount(Customer customer, decimal balance)
            : base(customer, balance, 0m)
        {
        }

        public DepositAccount(Customer customer, decimal balance, decimal interest)
            : base(customer, balance, interest)
        {
        }

        public void Draw(decimal money)
        {
            if (money > this.Balance)
            {
                throw new ArgumentException("Invalid draw operation. The balance is lower than the wished draw");
            }
            else if (money <= 0)
            {
                throw new ArgumentException("Draw must be a non-negative number");
            }

            this.Balance -= money;
        }

        public override decimal CalculeteInterestAmountForPeriod(int months)
        {
            if (this.Balance < 1000)
            {
                throw new ArgumentException("The account doesn't have enough money to calculate the interest amount");
            }

            decimal amount = this.Interest * months;
            return amount;
        }
    }
}

namespace _02Bank
{
    using System;

    public abstract class Account : IDepositable
    {
        ////customer, balance and interest rate (monthly based)
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        protected Account(Customer someCustomer, decimal currentBalance, decimal currentInterest)
        {
            this.customer = someCustomer;
            this.balance = currentBalance;
            if (currentInterest < 0)
            {
                throw new ArgumentException("The interest rate can't be negative number");
            }

            this.interestRate = currentInterest;
        }

        public Customer Customer
        {
            get
            {
                return this.customer;
            }

            set
            {
                this.customer = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }

            set
            {
                this.balance = value;
            }
        }

        public decimal Interest
        {
            get
            {
                return this.balance;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The interest rate can't be negative number");
                }

                this.interestRate = value;
            }
        }

        public abstract decimal CalculeteInterestAmountForPeriod(int months);

        public void Deposit(decimal money)
        {
            if (money <= 0)
            {
                throw new ArgumentException("Deposit must be a non-negative number");
            }

            this.Balance += money;
        }
    }
}

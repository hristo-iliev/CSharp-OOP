namespace _02Bank
{
    using System;

    public class LoanAccount : Account, IDepositable
    {
        public LoanAccount(Customer customer) : base(customer, 0m, 0m)
        {
        }

        public LoanAccount(Customer customer, decimal balance) : base(customer, balance, 0m)
        {
        }

        public LoanAccount(Customer customer, decimal balance, decimal interest) : base(customer, balance, interest)
        {
        }

        public override decimal CalculeteInterestAmountForPeriod(int months)
        {
            if (this.Customer is IndividualCustomer && months <= 3)
            {
                throw new ArgumentException("Individuals cant calculate their interest for less than 4 mouths");
            }
            else if (this.Customer is CompanyCustomer && months <= 2)
            {
                throw new ArgumentException("Companies cant calculate their interest for less than 3 mouths");
            }
            else
            {
                decimal amount = this.Interest * months;
                return amount;
            }
        }
    }
}

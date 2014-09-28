namespace _02Bank
{
    using System;

    public class MortgageAccount : Account
    {
        public MortgageAccount(Customer customer) : base(customer, 0m, 0m)
        {
        }

        public MortgageAccount(Customer customer, decimal balance) : base(customer, balance, 0m)
        {
        }

        public MortgageAccount(Customer customer, decimal balance, decimal interest) : base(customer, balance, interest)
        {
        }

        public override decimal CalculeteInterestAmountForPeriod(int months)
        {
            if (this.Customer is IndividualCustomer && months <= 6)
            {
                throw new ArgumentException("Individuals cant calculate their interest for less than 7 mouths");
            }
            else if (this.Customer is CompanyCustomer && months <= 12)
            {
                decimal amount = (this.Interest / 2) * months;
                return amount;
            }
            else
            {
                decimal amount = this.Interest * months;
                return amount;
            }
        }
    }
}

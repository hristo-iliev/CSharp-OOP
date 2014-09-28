namespace _02Bank
{
    using System;
    using System.Collections.Generic;

    public class Bank
    {
        private string name;
        private List<Account> accounts;

        public Bank(string bankName)
        {
            if (bankName == null)
            {
                throw new ArgumentException("The bank name can't have null value");
            }

            this.name = bankName;
            this.accounts = new List<Account>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentException("The bank name can't have null value");
                }

                this.name = value;
            }
        }
        
        public List<Account> Accounts
        {
            get
            {
                return this.accounts;
            }

            set
            {
                this.accounts = value;
            }
        }       
    }
}

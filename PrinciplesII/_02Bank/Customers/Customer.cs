namespace _02Bank
{
    using System;

    public abstract class Customer
    {
        private string name;
        
        protected Customer(string currentName)
        {
            if (currentName == null)
            {
                throw new ArgumentException("Invalid customer name");
            }

            this.name = currentName;
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
                    throw new ArgumentException("Invalid customer name");
                }

                this.name = value;
            }
        }
    }
}

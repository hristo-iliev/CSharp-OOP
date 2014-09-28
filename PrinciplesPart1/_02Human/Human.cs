namespace _02Human
{
    using System;

    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Invalid name. The name should be at least 2 charachters long");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Invalid name. The name should be at least 2 charachters long");
                }

                this.lastName = value;
            }
        }

        public abstract override string ToString();
    }
}

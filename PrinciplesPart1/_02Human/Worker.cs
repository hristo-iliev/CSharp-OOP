namespace _02Human
{
    using System;

    public class Worker : Human
    {
        private decimal weekSalary;
        private decimal workHoursPerDay;

        public Worker(string firName, string secName)
        {                   
            if (firName.Length < 2)
            {
                 throw new ArgumentException("Invalid name. The name should be at least 2 charachters long");
            }

            if (secName.Length < 2)
            {
                throw new ArgumentException("Invalid name. The name should be at least 2 charachters long");
            }

            this.FirstName = firName;
            this.LastName = secName;

            this.weekSalary = 0m;
            this.workHoursPerDay = 0m;        
        }

        public Worker(string firName, string secName, decimal weekSal, decimal workHours) : this(firName, secName)
        {
            if (weekSal < 0m)
            {
                throw new ArgumentException("The week salary can't have negative value");
            }

            this.weekSalary = weekSal;

            if (workHours < 0m)
            {
                throw new ArgumentException("The work hours can't have negative value");
            }

            this.workHoursPerDay = workHours;
        }
        
        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }

            set
            {
                if (value < 0m)
                {
                    throw new ArgumentException("The week salary can't have negative value");
                }

                this.weekSalary = value;
            }
        }

        public decimal WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }

            set
            {
                if (value < 0m)
                {
                    throw new ArgumentException("The work hours can't have negative value");
                }

                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            decimal money = (this.weekSalary / 7m) / this.workHoursPerDay;            
            return money;
        }

        public override string ToString()
        {
            return "NAME: " + this.FirstName + " " + this.LastName + " MONEY: " + this.MoneyPerHour().ToString("{0.00}");
        }
    }
}

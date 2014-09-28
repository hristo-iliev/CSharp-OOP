namespace _02Human
{
    using System;
    using System.Text;

    public class Student : Human
    {
        private int grade;

        public Student(string firName, string secName)
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
        }

        public Student(string firName, string secName, int gradeNum) : this(firName, secName)
        {
            if (gradeNum < 1)
            {
                throw new ArgumentException("The grade must be non-negative number, bigger than 0");
            }

            this.grade = gradeNum;
        }

        public int Grade
        {
            get
            {
                return this.grade;
            }

            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("The grade must be non-negative number, bigger than 0");
                }

                this.grade = value;
            }
        }

        public override string ToString()
        {
            var toString = new StringBuilder();
            toString.Append("NAME: " + this.FirstName + " " + this.LastName + "  \n");
            toString.Append("Grade: " + this.grade);
            return toString.ToString();
        }
    }
}

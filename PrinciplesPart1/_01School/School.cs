namespace _01School
{
    using System;
    using System.Collections.Generic;

    public class School
    {
        private string name;
        private int schoolNumber;
        private List<Class> classes;

        public School(string schoolName, int number)
        {
            this.name = schoolName;
            if (number < 1)
            {
                throw new ArgumentException("Invalid school number (must be non-negative and > 0)");
            }

            this.schoolNumber = number;
            this.classes = new List<Class>();
        }

        public List<Class> SetOfClasses
        { 
            get
            {
                return this.classes;
            }

            set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentException("List of classes is empty");
                }

                this.classes = value;
            }
        }
    }
}

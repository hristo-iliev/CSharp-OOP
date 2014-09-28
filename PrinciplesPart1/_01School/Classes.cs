namespace _01School
{
    using System;
    using System.Collections.Generic;

    public class Class : IComantable
    {
        private char identifier;
        private List<Student> students;
        private List<Teacher> teachers;

        public Class(char idnt)
        {
            this.identifier = idnt;
            this.students = new List<Student>();
            this.teachers = new List<Teacher>();
        }

        public char TextIdentifier
        {
            get
            {
                return this.identifier;
            }

            set
            {
                this.identifier = value;
            }
        }

        public List<Student> StudentsInClass 
        {
            get 
            {
                return this.students;
            }

            set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentException("The List of students is empty");
                }

                this.students = value;
            }
        }

        public List<Teacher> TeachersInClass 
        {
            get 
            {
                return this.teachers;
            }

            set
            {
                if (value.Count == 0)
                {
                    throw new ArgumentException("The List of teachers is empty");
                }

                this.teachers = value;
            }
        }

        public string Comment { get; set; }        
    }
}

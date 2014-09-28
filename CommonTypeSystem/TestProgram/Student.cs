//// TASK 1
//// Define a class Student, which contains data about a student – first, middle and last name, SSN,
//// permanent address, mobile phone e-mail, course, specialty, university, faculty. Use an enumeration
//// for the specialties, universities and faculties. Override the standard methods, inherited by
//// System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.

//// TASK 2
//// Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's
//// fields into a new object of type Student.

//// TASK 3
//// Implement the  IComparable<Student> interface to compare students by names (as first criteria,
//// in lexicographic order) and by social security number (as second criteria, in increasing order).

namespace TestProgram
{
    using System;

    public class Student : ICloneable, IComparable<Student>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private long ssn;
        private string permanentAddress;
        private string mobilePhone;
        private string email;
        private string course;
        private University university;
        private Specialty specialty;
        private Faculty faculty;

        public Student(string first, string middle, string family)
        {
            if (first == null || middle == null || family == null)
            {
                throw new ArgumentException("Invalid name. Name can't have value = null");
            }

            this.firstName = first;
            this.middleName = middle;
            this.lastName = family;
        }

        public string FirstName
        {
            get { return this.firstName; }
        }

        public string MiddleName
        {
            get { return this.middleName; }
        }

        public string LastName
        {
            get { return this.lastName; }
        }

        public long SSN
        {
            get { return this.ssn; }
            set { this.ssn = value; }
        }

        public string Address
        {
            get 
            { 
                return this.permanentAddress;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Invalid Address");
                }

                this.permanentAddress = value;
            }
        }

        public string Mobile
        {
            get 
            { 
                return this.mobilePhone; 
            }

            set
            {
                if (value.Length < 10)
                {
                    throw new ArgumentException("Invalid Mobile Phone");
                }

                this.mobilePhone = value;
            }
        }

        public string Email
        {
            get 
            { 
                return this.email; 
            }

            set
            {
                if (value.Length < 6 || value.IndexOf('@') < 0)
                {
                    throw new ArgumentException("Invalid Email.");
                }

                this.email = value;
            }
        }

        public string Course
        {
            get 
            {
                return this.course; 
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Invalid Course");
                }

                this.course = value;
            }
        }

        public University University
        {
            get { return this.university; }
            set { this.university = value; }
        }

        public Specialty Specialty
        {
            get { return this.specialty; }
            set { this.specialty = value; }
        }

        public Faculty Faculty
        {
            get { return this.faculty; }
            set { this.faculty = value; }
        }

        public static bool operator ==(Student first, Student second)
        {
            return Student.Equals(first, second);
        }

        public static bool operator !=(Student first, Student second)
        {
            return !Student.Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            var student = obj as Student;
            if (student == null)
            {
                return false;
            }

            if (!object.Equals(this.FirstName, student.FirstName))
            {
                return false;
            }

            if (!object.Equals(this.MiddleName, student.MiddleName))
            {
                return false;
            }

            if (!object.Equals(this.LastName, student.LastName))
            {
                return false;
            }

            if (!object.Equals(this.Mobile, student.Mobile))
            {
                return false;
            }

            return true;
        }        

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.MiddleName + " " + this.LastName;
        }

        public Student Clone()
        {
            Student cloning = new Student(this.firstName, this.middleName, this.lastName);
            cloning.Mobile = this.Mobile;
            cloning.Specialty = this.Specialty;
            cloning.SSN = this.SSN;
            cloning.University = this.University;
            cloning.Address = this.Address;
            cloning.Course = this.Course;
            cloning.Email = this.Email;
            cloning.Faculty = this.Faculty;
            
            return cloning;
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public int CompareTo(Student other)
        {
            if (this.FirstName != other.FirstName)
            {
                return this.FirstName.CompareTo(other.FirstName);
            }

            if (this.MiddleName != other.MiddleName)
            {
                return this.MiddleName.CompareTo(other.MiddleName);
            }

            if (this.LastName != other.LastName)
            {
                return this.LastName.CompareTo(other.LastName);
            }

            if (this.SSN != other.SSN)
            {
                return this.SSN.CompareTo(other.SSN);
            }

            return 0;
        }
    }
}

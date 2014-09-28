//// TASK 3
//// Write a method that from a given array of students finds all students whose first name
//// is before its last name alphabetically. Use LINQ query operators.

//// TASK 4
//// Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

//// TASK 9
//// Create a class student with properties FirstName, LastName, FN, Tel, Email, Marks (a List<int>),
//// GroupNumber. Create a List<Student> with sample students. Select only the students that are
//// from group number 2. Use LINQ query. Order the students by FirstName.

namespace Extension_Methods
{
    using System.Collections.Generic;

    public class Student : Group
    {        
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string FN { get; set; }

        public string Tel { get; set; }

        public string Email { get; set; }

        public List<int> Marks { get; set; }

        public string LiveIn { get; set; }
                
        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
}

//// TASK 4
//// Create a class Person with two fields – name and age. Age can be left unspecified
//// (may contain null value. Override ToString() to display the information of a person
//// and if age is not specified – to say so. Write a program to test this functionality.

namespace TestProgram
{
    using System;
    using System.Text;

    public class Person
    {
        private string name;
        private int? age;

        public Person(string name, int? currentAge = null)
        {
            if (name == null)
            {
                throw new ArgumentException("Invalid Name");
            }

            this.name = name;
            this.age = currentAge;
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine("Name: " + this.name);
            if (this.age == null)
            {
                result.AppendLine("Age: Age is not specified!");
            }
            else
            {
                result.AppendLine("Age: " + this.age);
            }

            return result.ToString();
        }
    }
}

namespace Extension_Methods
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class ProgramTest
    {
        //// TASK 3
        //// Write a method that from a given array of students finds all students whose first name
        //// is before its last name alphabetically. Use LINQ query operators.
        public static List<Student> FindStudent(List<Student> students)
        {
            var newStudents = students.Where(st => (st.FirstName.CompareTo(st.LastName) < 0)).ToList();

            return newStudents;
        }
        
        //// TASK 6
        //// Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
        //// Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
        public static void DivisibleBy7And3(List<int> numbers)
        {
            var divided = numbers.Where(num => num % 7 == 0 && num % 3 == 0);

            foreach (var number in divided)
            {
                Console.WriteLine(number);
            }
        }

        public static void DivisibleBy7And3LINQ(List<int> numbers)
        {
            var divided = from num in numbers where num % 7 == 0 && num % 3 == 0 select num;

            foreach (var number in divided)
            {
                Console.WriteLine(number);
            }
        }

        //// TASK 7
        //// Using delegates write a class Timer that has can execute certain method at each t seconds.
        public static void DisplayNumberFrom0toX(int x)
        {
            for (int i = 0; i <= x; i++)
            {
                Console.WriteLine(i);
            }
        }      
        
        public static void Main()
        {
            var someText = new StringBuilder("Tozi Gosho skochi losho.");
            var sub = someText.Substring(5, 5);

            ////Console.WriteLine(sub.ToString());

            IEnumerable<int> someNums = new List<int>() { 2, 5, 8, 12, 10, 4 };

            int min = someNums.Min();
            int max = someNums.Max();
            int average = someNums.Average();
            int sum = someNums.Sum();
            int product = someNums.Product();

            ////Console.WriteLine(min);
            ////Console.WriteLine(max);
            ////Console.WriteLine(average);
            ////Console.WriteLine(sum);
            ////Console.WriteLine(product);

            Student pesho = new Student();
            pesho.FirstName = "Petar";
            pesho.LastName = "Popov";
            pesho.Age = 17;
            pesho.GroupNumber = 1;
            pesho.Email = "pesho@abv.bg";
            pesho.LiveIn = "Sofia";
            pesho.Tel = "0888-900-300";
            pesho.Marks = new List<int>() { 2, 3, 4 };
            pesho.FN = "111106";
            pesho.DepartmentName = "Mathematics";

            Student gesho = new Student();
            gesho.FirstName = "Georgi";
            gesho.LastName = "Marinov";
            gesho.Age = 20;
            gesho.GroupNumber = 2;
            gesho.Email = "gesho@gmail.com";
            gesho.LiveIn = "Plovdiv";
            gesho.Tel = "8787-300-200";
            gesho.Marks = new List<int>() { 2, 6, 2 };
            gesho.FN = "060605";
            gesho.DepartmentName = "Mathematics";

            Student albert = new Student();
            albert.FirstName = "Albert";
            albert.LastName = "Borisov";
            albert.Age = 23;
            albert.GroupNumber = 3;
            albert.Email = "albert@btv.bg";
            albert.LiveIn = "Sofia";
            albert.Marks = new List<int>() { 6, 3, 4 };
            albert.FN = "212104";
            albert.DepartmentName = "Music";

            Student maria = new Student();
            maria.FirstName = "Maria";
            maria.LastName = "Avramova";
            maria.Age = 100;
            maria.GroupNumber = 2;
            maria.Email = "mimi@abv.bg";
            maria.LiveIn = "Sofia";
            maria.Tel = "02/866-20-30-30";
            maria.Marks = new List<int>() { 2, 3, 4 };
            maria.FN = "060606";
            maria.DepartmentName = "IT";

            Student iva = new Student();
            iva.FirstName = "Ivanela";
            iva.LastName = "Stoqnova";
            iva.Age = 21;
            iva.GroupNumber = 1;
            iva.Email = "sLadKy_SexY@abv.bg";
            iva.LiveIn = "ALbena";
            iva.Tel = "900-999-911";
            iva.Marks = new List<int>() { 6, 3, 4 };
            iva.FN = "000005";
            iva.DepartmentName = "Mathematics";

            Student ivanela = new Student();
            ivanela.FirstName = "Ivanela";
            ivanela.LastName = "Dimitrova";
            ivanela.Age = 16;
            ivanela.GroupNumber = 1;
            ivanela.Email = "ivanela@yahoo.com";
            ivanela.LiveIn = "Sofia";
            ivanela.Marks = new List<int>() { 2, 2, 4 };
            ivanela.FN = "033306";
            ivanela.DepartmentName = "Mathematics";

            List<Student> students = new List<Student>();
            students.Add(pesho);
            students.Add(gesho);
            students.Add(albert);
            students.Add(maria);
            students.Add(iva);
            students.Add(ivanela);

            var newStudents = FindStudent(students);

            //// TASK 4
            //// Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
            var studentsBetween18And24 =
                students
                .Where(st => st.Age >= 18 && st.Age <= 24)
                .Select(st => st.FirstName + " " + st.LastName);

            //// TASK 5
            //// Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students
            //// by first name and last name in descending order. Rewrite the same with LINQ.
            var sorted = students.OrderBy(st => st.FirstName).ThenBy(st => st.LastName);

            var linqSorted = from st in students orderby st.FirstName, st.LastName select st;

            //// TASK 6
            //// Write a program that prints from given array of integers all numbers that are divisible by 7 and 3.
            //// Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
            List<int> testNumbers = new List<int>() { 2, 3, 7, 21, 42, 50 };

            ////DivisibleBy7And3(testNumbers);
            ////Console.WriteLine();
            ////DivisibleBy7And3LINQ(testNumbers);

            //// TASK 7
            //// Using delegates write a class Timer that has can execute certain method at each t seconds.
            Timer timer = new Timer();
            ////Timer.DisplayNumbersWithTimer x = new Timer.DisplayNumbersWithTimer(DisplayNumberFrom0toX);
            ////timer.Sleep(5, x, 5);

            //// TASK 9
            //// Create a class student with properties FirstName, LastName, FN, Tel, Email, Marks (a List<int>),
            //// GroupNumber. Create a List<Student> with sample students. Select only the students that are
            //// from group number 2. Use LINQ query. Order the students by FirstName.
            var studentsInGroup2LINQ = from st in students where st.GroupNumber == 2 orderby st.FirstName select st;

            //// TASK 10
            //// Implement the previous using the same query expressed with extension methods.
            var studentsInGroup2 = students.Where(st => st.GroupNumber == 2).OrderBy(st => st.FirstName);

            //// TASK 11
            //// Extract all students that have email in abv.bg. Use string methods and LINQ.
            var studentsInABV = students.Where(st => st.Email.IndexOf("abv.bg") > 0);

            //// TASK 12
            //// Extract all students with phones in Sofia. Use LINQ.
            var studentsWithPhoneSofia = students.Where(st => st.Tel != null && st.LiveIn.ToLower() == "sofia");

            //// TASK 13
            //// Select all students that have at least one mark Excellent (6)
            //// into a new anonymous class that has properties – FullName and Marks. Use LINQ.
            var studentsWithMark6  = 
            from st in students
            where st.Marks.Contains(6)
            select new { st.FirstName, st.LastName, st.Marks };

            //// TASK 14
            //// Write down a similar program that extracts the students with exactly  two marks "2".
            //// Use extension methods.
            var listCorrespondingtoTASK14 = students.StudentsWithEqualMarks(2, 2);

            //// TASK 15
            //// Extract all Marks of the students that enrolled in 2006.
            //// (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).
            var studentfrom06 = students.Where(st => st.FN.Substring(4, 2) == "06");

            //// TASK 16
            //// * Create a class Group with properties GroupNumber and DepartmentName. Introduce a property Group 
            //// in the Student class. Extract all students from "Mathematics" department. Use the Join operator.
            var studentsInMathematics = students.Where(st => st.DepartmentName == "Mathematics");

            //// TASK 17
            //// Write a program to return the string with maximum length from an array of strings. Use LINQ.
            string[] strings = 
            {
                "asdffgggg",
                "asdddff000000",
                "dsfdsfdsfds",
                "111111111",
                "32423423423",
                "6t8ujujh",
                "66677776666"
            };

            var longestStr = (from st in strings orderby st.Length descending select st).ElementAt(0);

            //// TASK 18
            //// Create a program that extracts all students grouped by GroupName and then prints them to the console.
            //// Use LINQ.

            var studentsByGroup = from st in students orderby st.DepartmentName select st;            
            ////foreach (var st in studentsByGroup)
            ////{
            ////    Console.WriteLine(st);
            ////}

            //// TASK 19
            //// Rewrite the previous using extension methods.
            var studentsByGroupEXT = students.SortByGroupName();
        }
    }
}

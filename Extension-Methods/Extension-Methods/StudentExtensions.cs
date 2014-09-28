//// TASK 14
//// Write down a similar program that extracts the students with exactly
//// two marks "2". Use extension methods.

namespace Extension_Methods
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class ListOFStudentExtensions
    {
        public static List<Student> StudentsWithEqualMarks(this List<Student> students, int mark, int howMany)
        {
            List<Student> result = new List<Student>();            

            for (int i = 0; i < students.Count; i++)
            {
                int currentAppeаrence = 0;

                for (int j = 0; j < students[i].Marks.Count; j++)
                {
                    if (students[i].Marks[j] == mark)
                    {
                        currentAppeаrence++;
                    }
                }

                if (currentAppeаrence == howMany)
                {
                    result.Add(students[i]);
                }
            }

            return result;
        }

        //// TASK 19
        //// Rewrite the previous using extension methods.
        public static List<Student> SortByGroupName(this List<Student> students)
        {
            var result = students.OrderBy(st => st.DepartmentName).ToList();

            foreach (var st in students)
            {
                Console.WriteLine(st);
            }

            return result;
        }
    }
}

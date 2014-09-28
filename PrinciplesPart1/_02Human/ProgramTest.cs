//// Define abstract class Human with first name and last name. Define new class Student which is derived from Human
//// and has new field – grade. Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay
//// and method MoneyPerHour() that returns money earned by hour by the worker. Define the proper constructors
//// and properties for this hierarchy. Initialize a list of 10 students and sort them by grade in ascending order
//// (use LINQ or OrderBy() extension method). Initialize a list of 10 workers and sort them by money per hour
//// in descending order. Merge the lists and sort them by first name and last name.

namespace _02Human
{
    using System.Collections.Generic;
    using System.Linq;

    public class ProgramTest
    {     
        public static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student("Petar", "Popov", 2),
                new Student("Ivailo", "Danailov", 3),
                new Student("Marina", "Ivanova", 4),
                new Student("Petar", "Kostov", 2),
                new Student("Stefania", "Tinova", 1),
                new Student("Ivan", "Arnaudov", 3),
                new Student("Cvetan", "Georgiev", 3),
                new Student("Mila", "Popova", 2),
                new Student("Silvia", "Dimova", 4),
                new Student("Emil", "Ignatov", 5),
            };

            List<Worker> workers = new List<Worker>()
            {
                new Worker("Gesho", "Kopacha", 200m, 25m),
                new Worker("Vanio", "Razbivacha", 15m, 36m),
                new Worker("Tsveta", "Mashinata", 2000m, 7m),
                new Worker("Tisho", "Kistata", 250m, 8m),
                new Worker("Misha", "Katarzisa", 100m, 12m),
                new Worker("Penio", "Klekacha", 100000m, 10m),
                new Worker("Misho", "Negramotnia", 150m, 80m),
                new Worker("Marta", "Tanka", 95m, 60m),
                new Worker("Gesho", "Panchev", 205m, 50m),
                new Worker("Gesho", "Mirchov", 202m, 40m),
            };

            var studentsByGrade = students.OrderBy(st => st.Grade);
            var workersBySalary = workers.OrderBy(wr => wr.MoneyPerHour());

            List<Human> all = new List<Human>();

            foreach (var student in studentsByGrade)
            {
                all.Add(student);
            }

            foreach (var worker in workersBySalary)
            {
                all.Add(worker);
            }

            var sortHumans = all.OrderBy(hm => hm.FirstName).ThenBy(hm => hm.LastName);
        }
    }
}

//// Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range.
//// It should hold error message and a range definition [start … end].
//// Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime>
//// by entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].

namespace _03Exception
{
    using System;

    public class Program
    {
        public static void PrintNumber(int x)
        {
            int min = 0;
            int max = 100;

            if (x < min || x > max)
            {
                throw new InvalidRangeException<int>(0, 100);
            }
            else
            {
                Console.WriteLine(x);
            }
        }

        public static void PrintDate(DateTime someDate)
        {
            DateTime min = new DateTime(1980, 1, 1);
            DateTime max = new DateTime(2013, 12, 31);

            if (someDate < min || someDate > max)
            {
                throw new InvalidRangeException<DateTime>(min, max);
            }
            else
            {
                Console.WriteLine(someDate);
            }
        }

        public static void Main()
        {
            ////int x = 102;
            DateTime today = DateTime.Now;

            ////PrintNumber(x);
            ////PrintDate(today);        
        }
    }
}

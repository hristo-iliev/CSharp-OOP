//// TASK 2
//// Implement a set of extension methods for IEnumerable<T> that implement the following group functions:
//// sum, product, min, max, average.

namespace Extension_Methods
{
    using System.Collections.Generic;
    using System.Linq;

    public static class IEnumerableExtensions
    {
        public static T Sum<T>(this IEnumerable<T> ienum)
        {
            T result = default(T);
            foreach (var item in ienum)
            {
                result += (dynamic)item;
            }

            return result;
        }

        public static T Min<T>(this IEnumerable<T> ienum)
        {
            T result = ienum.First();
            foreach (var item in ienum)
            {
                if (result > (dynamic)item)
                {
                    result = item;
                }
            }

            return result;
        }

        public static T Max<T>(this IEnumerable<T> ienum)
        {
            T result = ienum.First();
            foreach (var item in ienum)
            {
                if (result < (dynamic)item)
                {
                    result = item;
                }
            }

            return result;
        }

        public static T Average<T>(this IEnumerable<T> ienum)
        {
            T result = default(T);
            foreach (var item in ienum)
            {
                result += (dynamic)item;
            }

            result /= (dynamic)ienum.Count();
            return result;
        }

        public static T Product<T>(this IEnumerable<T> ienum)
        {
            T result = (dynamic)1;
            foreach (var item in ienum)
            {
                result *= (dynamic)item;
            }

            return result;
        }
    }
}

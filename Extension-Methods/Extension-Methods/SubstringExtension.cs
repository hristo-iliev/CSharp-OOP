//// TASK 1
//// Implement an extension method Substring(int index, int length) for the class StringBuilder
//// that returns new StringBuilder and has the same functionality as Substring in the class String.

namespace Extension_Methods
{
    using System.Text;

    public static class SubstringExtension
    {
        public static StringBuilder Substring(this StringBuilder text, int index, int length)
        {
            var result = new StringBuilder();

            result.Append(text.ToString().Substring(index, length));

            return result;
        }
    }
}

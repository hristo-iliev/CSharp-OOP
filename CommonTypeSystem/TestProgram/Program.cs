namespace TestProgram
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var pesho = new Person("John");
            var ceco = new Person("Ceko", 24);
            Console.WriteLine(pesho);
            Console.WriteLine();
            Console.WriteLine(ceco);

            var someNum = new BitArray64(2);
            Console.WriteLine(someNum[1]);
        }
    }
}

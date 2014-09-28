//// Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods.
//// Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface).
//// Kittens and tomcats are cats. All animals are described by age, name and sex. Kittens can be only female
//// and tomcats can be only male. Each animal produces a specific sound. Create arrays of different kinds of
//// animals and calculate the average age of each kind of animal using a static method (you may use LINQ).

namespace _03Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            Dog x = new Dog("Sharo");
            Console.WriteLine(x.Sound);
            List<Animal> animals = new List<Animal>()
            {
                new Cat("Suzi", 3),
                new Cat("Mecho", 7),
                new Dog("Sharo", 5),
                new Dog("Rex", 10),
                new Frog("Kurmmit", 2),
                new Frog("Joro", 3),
                new Kitten("Magy", 7),
                new Kitten("Merry", 2),
                new TomCat("Silvester", 6),
                new TomCat("Tom", 10)                
            };

            var averageCats = animals.Where(an => an is Cat).Average(an => an.Age);
            var averageDogs = animals.Where(an => an is Dog).Average(an => an.Age);
            var averageFrogs = animals.Where(an => an is Frog).Average(an => an.Age);
            var averageKittens = animals.Where(an => an is Kitten).Average(an => an.Age);
            var averageTomCats = animals.Where(an => an is TomCat).Average(an => an.Age);
        }
    }
}

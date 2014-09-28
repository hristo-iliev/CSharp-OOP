namespace _03Animals
{
    public class Cat : Animal, ISound
    {
        private const string SOUND = "Meow-meow";

        public Cat(string name) : base(name, SOUND)
        {
        }

        public Cat(string name, int age)
            : base(name, SOUND, age)
        {
        }

        public Cat(string name, int age, Sex gender) : base(name, SOUND, age, gender)
        {
        }
    }
}

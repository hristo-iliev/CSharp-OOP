namespace _03Animals
{
    public class Dog : Animal, ISound
    {
        private const string SOUND = "Woof-woof";

        public Dog(string name) : base(name, SOUND)
        {
        }

        public Dog(string name, int age)
            : base(name, SOUND, age)
        {
        }

        public Dog(string name, int age, Sex gender) : base(name, SOUND, age, gender)
        {
        }
    }
}

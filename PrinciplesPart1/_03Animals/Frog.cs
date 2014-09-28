namespace _03Animals
{
    public class Frog : Animal, ISound
    {
        private const string SOUND = "Croak-croak";

        public Frog(string name) : base(name, SOUND)
        {
        }

        public Frog(string name, int age)
            : base(name, SOUND, age)
        {
        }

        public Frog(string name, int age, Sex gender) : base(name, SOUND, age, gender)
        {
        }
    }
}

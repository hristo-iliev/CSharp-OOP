namespace _03Animals
{
    public class Kitten : Cat, ISound
    {
        public Kitten(string name) : base(name, 0, Sex.Female)
        {
        }

        public Kitten(string name, int age) : base(name, age, Sex.Female)
        {
        }
    }
}

namespace _03Animals
{
    public class TomCat : Cat, ISound
    {
        public TomCat(string name) : base(name, 0, Sex.Male)
        {
        }

        public TomCat(string name, int age) : base(name, age, Sex.Male)
        {
        }
    }
}

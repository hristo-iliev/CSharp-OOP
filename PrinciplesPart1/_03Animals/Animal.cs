namespace _03Animals
{
    using System;

    public class Animal : ISound
    {
        ////age, name and sex
        private string name;
        private int age;
        private Sex sex;
        private string sound;

        protected Animal(string animalName, string animalSound, int animalAge, Sex animalGender)
        {
            this.name = animalName;

            if (animalAge < 0)
            {
                throw new ArgumentException("Age can't be negative number");
            }
            
            if (null == animalSound)
            {
                throw new ArgumentException("The sound can't be null");
            }

            this.age = animalAge;
            this.sex = animalGender;
            this.sound = animalSound;
        }

        protected Animal(string animalName, string animalSound)
            : this(animalName, animalSound, 0, Sex.Male)
        {            
        }

        protected Animal(string animalName, string animalSound, int animalAge)
            : this(animalName, animalSound, animalAge, Sex.Male)
        {           
        }
        
        public string Sound
        {
            get
            {
                return this.sound;
            }        
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age can't be negative number");
                }

                this.age = value;
            }
        }

        public void MakeSound()
        {
            Console.WriteLine("{0} says {1}", this.name, this.sound); 
        }
    }
}

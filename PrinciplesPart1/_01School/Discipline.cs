namespace _01School
{
    using System;

    public class Discipline : IComantable
    {
        ////name, number of lectures and number of exercises.
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;

        public Discipline(string disName, int lectures, int exercises)
        {
            if (disName.Length < 2)
            {
                throw new ArgumentException("The discipline name must be at least 2 charachters long");
            }

            if (lectures < 1)
            {
                throw new ArgumentException("The number of lectures must be at least 1");
            }

            if (exercises < 1)
            {
                throw new ArgumentException("The number of exercises must be at least 1");
            }

            this.name = disName;
            this.numberOfLectures = lectures;
            this.numberOfExercises = exercises;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("The discipline name must be at least 2 charachters long");
                }

                this.name = value;
            }
        }

        public int CountOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }

            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("The number of lectures must be at least 1");
                }

                this.numberOfLectures = value;
            }
        }

        public int CountOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }

            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("The number of exercises must be at least 1");
                }

                this.numberOfExercises = value;
            }
        }

        public string Comment { get; set; }
    }
}

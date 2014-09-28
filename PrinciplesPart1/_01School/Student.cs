namespace _01School
{
    using System;

    public class Student : People, IComantable
    {
        private int classNumber;

        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }

            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("The class number must be bigger than 0");
                }

                this.classNumber = value;
            }
        }
    }
}

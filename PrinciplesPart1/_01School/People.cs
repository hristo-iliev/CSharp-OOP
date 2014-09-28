namespace _01School
{
    using System;

    public class People : IComantable
    {
        private string name;

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value.IndexOf(' ') <= 0 || value.Length < 4)
                {
                    throw new ArgumentException("Invalid name");
                }

                this.name = value;
            }
        }

        public string Comment { get; set; }
    }
}

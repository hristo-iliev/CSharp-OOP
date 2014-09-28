namespace _01Shapes
{
    using System;
    
    public abstract class Shape
    {
        private double width;
        private double height;

        public Shape()
        {
        }

        protected Shape(double x, double y)
        {
            if (x < 0 || y < 0)
            {
                throw new ArgumentException("Invalid shape parameters");
            }

            this.width = x;
            this.height = y;
        }

        public virtual double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid shape parameter");
                }

                this.width = value;
            }
        }

        public virtual double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid shape parameter");
                }

                this.height = value;
            }
        }

        public abstract double CalculateSurface();

        public override string ToString()
        {
            return this.GetType().Name;
        }
    }
}

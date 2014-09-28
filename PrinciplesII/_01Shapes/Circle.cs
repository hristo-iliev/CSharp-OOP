namespace _01Shapes
{
    using System; 
  
    public class Circle : Shape
    {
        public Circle(double x)
        {
            if (x < 0)
            {
                throw new ArgumentException("Invalid circle paramaters. The width and the height must be equal");
            }

            this.Width = x;
            this.Height = x;
        }

        public override double CalculateSurface()
        {
            double sur = this.Width * Math.PI;
            return sur;
        }
    }
}

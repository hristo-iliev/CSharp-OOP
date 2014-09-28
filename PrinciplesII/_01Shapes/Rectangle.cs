namespace _01Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle(double x, double y) : base(x, y)
        {            
        }

        public override double CalculateSurface()
        {
            double sur = this.Width * this.Height;
            return sur;
        }
    }
}

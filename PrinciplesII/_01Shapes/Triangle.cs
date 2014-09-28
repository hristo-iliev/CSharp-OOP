namespace _01Shapes
{
    using System;
    
    public class Triangle : Shape
    {
        public Triangle(double x, double y) : base(x, y)
        {            
        }                       
        
        public override double CalculateSurface()
        {
            double sur = (this.Width * this.Height) / 2;

            return sur;
        }
    }
}

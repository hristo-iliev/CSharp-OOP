//// Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
//// Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of
//// the figure (height*width for rectangle and height*width/2 for triangle). Define class Circle and suitable
//// constructor so that at initialization height must be kept equal to width and implement the CalculateSurface()
//// method. Write a program that tests the behavior of  the CalculateSurface() method for different shapes
//// (Circle, Rectangle, Triangle) stored in an array.

namespace _01Shapes
{
    using System;
    using System.Collections.Generic;          

    public class TestProgram
    {
        public static void Main()
        {
            List<Shape> shapes = new List<Shape>()
            {
                new Circle(3.3),
                new Rectangle(3, 4),
                new Triangle(2, 5)
            };

            foreach (var shape in shapes)
            {
                Console.Write(shape.ToString() + ": ");
                Console.WriteLine(shape.CalculateSurface());
            }
        }
    }
}

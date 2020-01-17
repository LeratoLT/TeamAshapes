using System;

namespace GitShapesTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is your Git test shapes project!");
            Circle cirlce = new Circle();
		    decimal circleArea = circle.calculateCircleArea(radius);
		    System.Console.WriteLine("The area of the circle is: " + circleArea);
        }
    }
}

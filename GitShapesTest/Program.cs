using System;

namespace GitShapesTest
{
    class Program
    {
        static decimal t_base, t_height, t_length, t_width;
        static void Main(string[] args)
        {
            Console.WriteLine("Area of Triangle");

            Console.WriteLine("Please enter base value of Triangle");
            while (!decimal.TryParse(Console.ReadLine(), out t_base))
            {
                Console.WriteLine("The value you passed isn't a decimal value");
                Console.WriteLine("Please Enter a Decimal value");
            }

                Console.WriteLine("Please enter height of Triangle");
            while (!decimal.TryParse(Console.ReadLine(), out t_height))
            {
                Console.WriteLine("The value you passed isn't a decimal value");
                Console.WriteLine("Please Enter a Decimal value");
            }

                Console.WriteLine("The area of a triangle is " + new Triangle().calculate_TriangleArea(t_base, t_height));

        }
    }
}

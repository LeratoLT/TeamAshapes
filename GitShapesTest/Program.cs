using System;

namespace GitShapesTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is your Git test shapes project!");

            Class1 rec = new Class1();
            decimal recArea = rec.Cal_Area(55, 4);



            Console.WriteLine("the area of rectangle", recArea);
        }
    }
}

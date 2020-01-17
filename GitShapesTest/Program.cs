using System;

namespace GitShapesTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is your Git test shapes project!");
            Console.Write("Which shape do you want to calculate (Square/Rec/Tri/Cir): ");

            if(Console.ReadLine().ToUpper().StartsWith('S'))
                SQStuff();
            
            
            Console.Write("\n\nPress any key to exit..");
            Console.ReadKey(); 
        }
        public static void SQStuff()
        {
                Console.WriteLine("===============================");
                Console.Write("Enter length: ");
                string slength = Console.ReadLine();
                Console.Write("Enter width: ");
                string sWidth = Console.ReadLine();
                decimal length, width;
                if (decimal.TryParse(slength, out length) && decimal.TryParse(sWidth, out width))
                {
                    Squares sq = new Squares();
                    Console.WriteLine("Area: " + sq.SQArea(length, width).ToString());
                }
                else
                {
                    Console.Write("Expected format is any positive numeric.");
                    Console.Write("\n\nTry again (Y/N): ");

                    if (Console.ReadKey().KeyChar == 'Y')
                    {

                    }
                    else if (Console.ReadKey().KeyChar == 'N')
                    {
                        Console.Write("Thanks bye");
                    }
                    else
                        Console.Write("Thanks bye");

                }
            }
    }
}

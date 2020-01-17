using System;

namespace GitShapesTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is your Git test shapes project!");
            Console.Write("Which shape do you want to calculate (Square/Rec/Tri/Cir): ");

            if (Console.ReadLine().ToUpper().StartsWith('S'))
                SQStuff();


            Console.Write("\n\nPress any key to exit..");
            Console.ReadKey();
        }
        public static void SQStuff()
        {
            Console.Clear();
            Console.Write("Your area for Sqaure.");
            Console.Write("\n\nEnter length: ");
            string slength = Console.ReadLine();
            Console.Write("Enter width: ");
            string sWidth = Console.ReadLine();
            decimal length, width;
            if (decimal.TryParse(slength, out length) && decimal.TryParse(sWidth, out width))
            {
                Squares sq = new Squares();
                Console.WriteLine("\nArea: " + sq.SQArea(length, width).ToString());
            }
            else
            {
                Console.Write("The epected format is any positive numeric.");
                Console.Write("\n\nDo you want to try again (Y/N): ");
                if (Console.ReadKey().KeyChar.ToString().ToUpper() == "Y")
                {
                    Console.Clear();
                    SQStuff();
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

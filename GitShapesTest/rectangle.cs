using System;

public class Class1
{
    private double length;
    private double width;



    public void Cal_Area()
    {
        Console.Write("Please enter the length of your rectangle:");
        double length = double.Parse(Console.ReadLine());
        Console.Write("Please enter the width of your rectangle:");
        double width = double.Parse(Console.ReadLine());

        double area = length * width;
        Console.WriteLine("The area of your rectangle is", area);

    }

}

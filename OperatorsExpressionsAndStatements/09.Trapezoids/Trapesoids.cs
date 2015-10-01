//Problem 9.	Trapezoids
//Write an expression that calculates trapezoid's area by given sides a and b and height h. Examples:

using System;

class Trapesoids
{
    static void Main()
    {
        Console.WriteLine("Please enter lenght:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter wight:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter hight:");
        double h = double.Parse(Console.ReadLine());
        double area = (a + b) / 2 * h;
        Console.WriteLine("Area:"+ area);
        
    }
}


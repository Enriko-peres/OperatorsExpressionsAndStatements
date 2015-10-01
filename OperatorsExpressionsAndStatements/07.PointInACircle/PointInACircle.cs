//Problem 7.	Point in a Circle
//Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2). Examples:

using System;

class PointInACircle
{
    static void Main()
    {
        Console.WriteLine("Please enter (x) coordinate:");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter (y) coordinate:");
        double y = double.Parse(Console.ReadLine());
        bool resultOne = (-2<=x && x<=2)&&(-2<=y && y<=2);
        Console.WriteLine(resultOne);
        bool resultTwo = Math.Pow(x - 1, 2) + Math.Pow(y - 1, 2) <= 5; // Sedcond solution
        Console.WriteLine(resultTwo);
    }
}


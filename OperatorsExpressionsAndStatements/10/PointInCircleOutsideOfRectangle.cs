//Problem 10.	Point Inside a Circle & Outside of a Rectangle
//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2). Examples:

using System;

class PointInCircleOutsideOfRectangle
{
    static void Main()
    {
        Console.WriteLine("Please enter (x) coordinate:");
       double x = double.Parse(Console.ReadLine());
       Console.WriteLine("Please enter (y) coordinate:");
       double y = double.Parse(Console.ReadLine());
       bool circle = Math.Pow(x - 1, 2) + Math.Pow(y - 1, 2) <= 1.5;
       bool rectangle = (1 <= x && x <= 5) && (-1 <= y && y <= 1);
       if (circle && !rectangle)
       {
           Console.WriteLine("Yes");
       }
       else
       {
           Console.WriteLine("No");
       }
       
    }
}


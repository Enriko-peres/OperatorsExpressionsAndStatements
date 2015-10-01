//Problem 4.	Rectangles
//Write an expression that calculates rectangle’s perimeter and area by given width and height. Examples:

using System;

namespace _04.Rectangles
{
    class Rectangles
    {
        static void Main()
        {
            Console.WriteLine("Please enter width:");
             double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter height:");
            double height = double.Parse(Console.ReadLine());
            double area = width * height;
            double parameter = 2 * width + 2 * height;
            Console.WriteLine("Area:"+area);
            Console.WriteLine("Parameter:" + parameter);

        }
    }
}

//Problem 5.	Third Digit is 7?
//Write an expression that checks for given integer if its third digit from right-to-left is 7. Examples:

using System;

class ThirdDigit7
{
    static void Main()
    {
        int n = Math.Abs(int.Parse(Console.ReadLine()));
        bool thirdDigit = (n / 100) % 10 == 7;
        Console.WriteLine(thirdDigit);
    }
}


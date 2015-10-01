//Problem 3.	Divide by 7 and 5
//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time. Examples:

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Plaese enter a number to check if it can be divided by 7 and 5 (at the same time)");
        int n = int.Parse(Console.ReadLine());
        bool number =(n%7 == 0 && n%5 == 0);
        Console.WriteLine(number);
    }
}


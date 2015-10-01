//Problem 13.	Check a Bit at Given Position
//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n has value of 1. Examples:

using System;

class CheckBitAtGivenPosition
{
    static void Main()
    {
        Console.WriteLine("Enter the number:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the bit position:");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine((n & (1 << p)) > 0 ? true : false);
    }
}


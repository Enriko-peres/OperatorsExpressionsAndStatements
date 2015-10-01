//Problem 12.	Extract Bit from Integer
//Write an expression that extracts from given integer n the value of given bit at index p. Examples:

using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        uint mask = 1;
        string check = (mask << p & number) == 0 ? "0" : "1";
        Console.WriteLine(check);

    }
}


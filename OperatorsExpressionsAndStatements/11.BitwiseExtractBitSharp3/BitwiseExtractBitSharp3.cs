//Problem 11.	Bitwise: Extract Bit #3
//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer. The bits are counted from right to left, starting from bit #0. The result of the expression should be either 1 or 0. Examples:

using System;

class BitwiseExtractBitSharp3
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());
        uint mask = 1;   
        string check = (mask << 3 & number) == 0 ? "0" : "1";
        Console.WriteLine(check);

    }
}

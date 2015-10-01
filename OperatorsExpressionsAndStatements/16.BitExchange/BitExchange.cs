//Problem 16.	** Bit Exchange (Advanced)
//Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer. The first and the second sequence of bits may not overlap. Examples:

using System;

class BitExchange
{
    static void Main()
    {
        try
        {
          uint n = uint.Parse(Console.ReadLine());
          int p = int.Parse(Console.ReadLine());
          int q = int.Parse(Console.ReadLine());
          int k = int.Parse(Console.ReadLine());
          if (Math.Max(p,q) + k - 1 > 31)
          {
              Console.WriteLine("Ou of range!");
          }
          else if (Math.Max(p,q) + k - 1 >= Math.Max(p,q))
          {
              Console.WriteLine("Overlapping");
          }
          else
          {
              for (int i = p; i <= p + k - 1; i++)
              {
               uint mask = 1;
               uint bitQ = (n & (mask << q)) >> q;
               uint bitP = (n & (mask << i)) >> i;
               n = n & ~(mask << q);
               n = n & ~(mask << i);
               n = n | (bitP << q);
               n = n | (bitQ << i);
               q++;
              }
              Console.WriteLine(n);
          }
        }
        catch(Exception ex)
        {
            Console.WriteLine("Out of range");
        }
    }
}







                 

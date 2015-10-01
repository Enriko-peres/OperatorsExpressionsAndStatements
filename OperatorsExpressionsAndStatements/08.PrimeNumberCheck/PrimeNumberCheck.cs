//Problem 8.	Prime Number Check
//Write an expression that checks if given positive integer number n (n ≤ 100) is prime (i.e. it is divisible without remainder only to itself and 1). Examples:

using System;

class PrimeNumberCheck
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool isPrime = true;
        if (n >= 1)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                }

            }
            Console.WriteLine(isPrime);
        }
        else 
        {
            Console.WriteLine("False");
        }
    }
}


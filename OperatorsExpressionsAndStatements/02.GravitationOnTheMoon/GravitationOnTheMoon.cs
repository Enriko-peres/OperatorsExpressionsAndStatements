//Problem 2.	Gravitation on the Moon
//The gravitational field of the Moon is approximately 17% of that on the Earth. Write a program that calculates the weight of a man on the moon by a given weight on the Earth. Examples:

using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        int weightOnEarth = int.Parse(Console.ReadLine());
        float weightOnMoon = 0.17f;
        Console.WriteLine(weightOnEarth*weightOnMoon);

    }
}


using System;
using System.Numerics;

public class HornetWings
{
    static void Main()
    {
        decimal flaps = decimal.Parse(Console.ReadLine());
        decimal distancePerThousand = decimal.Parse(Console.ReadLine());
        decimal endurance = decimal.Parse(Console.ReadLine());

        decimal distance = (flaps / 1000m) * distancePerThousand;
        Console.WriteLine($"{distance:F2} m.");

        BigInteger timeWithoutResting = (BigInteger)flaps / 100;
        BigInteger timeRest = (BigInteger)(flaps / endurance) * 5;
        BigInteger totalTime = timeWithoutResting + timeRest;

        Console.WriteLine($"{totalTime} s.");
    }
}

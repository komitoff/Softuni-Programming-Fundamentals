using System;
using System.Globalization;
using System.Numerics;

public class SinoTheWalker
{
    static void Main()
    {
        TimeSpan time = TimeSpan.Parse(Console.ReadLine());
        int steps = int.Parse(Console.ReadLine()) % 86400;
        int secondsPerStep = int.Parse(Console.ReadLine()) % 86400;

        long sum = steps * secondsPerStep;
        TimeSpan timeInSeconds = TimeSpan.FromSeconds(sum);

        TimeSpan totalTime = timeInSeconds + time;

        Console.WriteLine("Time Arrival: {0:hh\\:mm\\:ss}", totalTime);



    }
}
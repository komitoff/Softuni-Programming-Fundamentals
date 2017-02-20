using System;

public class SinoTheWalker
{
    static void Main()
    {
        TimeSpan timeLeftSchool = TimeSpan.Parse(Console.ReadLine());
        long numberOfSteps = long.Parse(Console.ReadLine()) % 86400;
        long secondsPerStep = long.Parse(Console.ReadLine()) % 86400;

        TimeSpan stepsTime = TimeSpan.FromSeconds(numberOfSteps * secondsPerStep);

        TimeSpan timeArrival = timeLeftSchool + stepsTime;

        Console.WriteLine("Time Arrival: {0:hh\\:mm\\:ss}", timeArrival);
    }
}

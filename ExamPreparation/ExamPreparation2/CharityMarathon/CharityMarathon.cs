using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CharityMarathon
{
    static void Main()
    {
        decimal marathonLengthInDays = decimal.Parse(Console.ReadLine());
        decimal runnersCount = decimal.Parse(Console.ReadLine());
        decimal averageLapsPerRunner = decimal.Parse(Console.ReadLine());
        decimal trackLength = decimal.Parse(Console.ReadLine());
        decimal trackCapacity = decimal.Parse(Console.ReadLine());
        decimal donatedMoneyPerKm = decimal.Parse(Console.ReadLine());

        decimal totalRunners = marathonLengthInDays * trackCapacity;
        if (runnersCount > totalRunners)
        {
            runnersCount = totalRunners;
        }

        decimal totalMarathonMeters = (runnersCount * trackLength * averageLapsPerRunner);
        decimal totalMarathonKms = totalMarathonMeters / 1000;

        decimal moneyRaised = totalMarathonKms * donatedMoneyPerKm;
        Console.WriteLine($"Money raised: {moneyRaised:F2}");
    }
}
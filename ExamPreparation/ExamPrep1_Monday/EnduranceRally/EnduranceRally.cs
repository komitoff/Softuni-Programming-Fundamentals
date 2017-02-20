using System;
using System.Collections.Generic;
using System.Linq;

public class EnduranceRally
{
    static void Main(string[] args)
    {

        List<string> drivers = Console
            .ReadLine()
            .Split()
            .ToList();

        List<double> zones = Console
            .ReadLine()
            .Split()
            .Select(double.Parse)
            .ToList();

        List<int> checkPoints = Console
            .ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();


        for (int i = 0; i < drivers.Count; i++)
        {
            string currentDriver = drivers[i];
            double fuel = (double)currentDriver[0];
            int reached = 0;
            for (int j = 0; j < zones.Count; j++)
            {
                if (checkPoints.Contains(j))
                    fuel += zones[j];
                else
                    fuel -= zones[j];

                if (fuel <= 0)
                {
                    Console.WriteLine($"{currentDriver} - reached {reached}");
                    break;
                }

                reached++;
            }

            if (reached == zones.Count)
            {
                Console.WriteLine($"{currentDriver} - fuel left {fuel:F2}");
            }
        }
    }
}

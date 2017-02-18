using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class EnduranceRally
{
    static void Main()
    {
        string[] participants = Console
            .ReadLine()
            .Split();

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

        //inverse the sign of the checkpoints
        for (int i = 0; i < checkPoints.Count; i++)
        {
            if (checkPoints[i] >= 0 && checkPoints[i] < zones.Count)
            {
                zones[checkPoints[i]] *= -1;
            }
        }

        for (int i = 0; i < participants.Length; i++)
        {
            double currentDriverFuel = (double)participants[i][0];
            int reached = 0;
            for (int j = 0; j < zones.Count; j++)
            {
                currentDriverFuel -= zones[j];
                if (currentDriverFuel < 0)
                {
                    break;
                }
                else
                {
                    reached++;
                }
            }

            if (reached >= zones.Count)
            {
                Console.WriteLine($"{participants[i]} - fuel left {currentDriverFuel:F2}");
            }
            else
            {
                Console.WriteLine($"{participants[i]} - reached {reached}");
            }
        }
    }
}
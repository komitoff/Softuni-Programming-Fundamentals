using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class HornetAssault
{
    static void Main()
    {
        List<long> beehives = Console.ReadLine().Split().Select(long.Parse).ToList();
        List<long> hornets = Console.ReadLine().Split().Select(long.Parse).ToList();

        long power = hornets.Sum();

        for (int i = 0; i < beehives.Count; i++)
        {
            if (beehives[i] >= power)
            {
                if (!hornets.Any())
                {
                    break;
                }
                beehives[i] -= power;
                power -= hornets[0];
                hornets.RemoveAt(0);
                
            }
            else
            {
                beehives[i] = 0;
            }
        }

        List<long> leftBees = beehives.Where(b => b > 0).ToList();

        if (leftBees.Any())
        {
            Console.WriteLine(string.Join(" ", leftBees));
        }
        else
        {
            Console.WriteLine(string.Join(" ", hornets));
        }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaxSeqOfEqualElements
{
    static void Main(string[] args)
    {
        int[] seq = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int current = 0;
        int previous = 0;
        int bestElement = 0;
        int currentCount = 1;
        int bestCount = 0;

        previous = seq[0];
        for (int i = 1; i < seq.Length; i++)
        {
            current = seq[i];
            if (current == previous)
            {
                currentCount++;
            }
            else
            {
                currentCount = 1;
            }
            if (currentCount > bestCount)
            {
                bestCount = currentCount;
                bestElement = current;
            }
            previous = current;
        }

        for (int i = 0; i < bestCount; i++)
        {
            Console.Write(bestElement + " ");
        }
    }
}

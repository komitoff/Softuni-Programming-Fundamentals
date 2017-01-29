using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MaxSeqIncreasingElements
{
    static void Main(string[] args)
    {
        int[] seq = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int previousElement = seq[0];
        int currentElement = 0;
        int startPosition = 0;
        int bestStart = 0;
        int currentCount = 1;
        int bestCount = 0;

        for (int i = 1; i < seq.Length; i++)
        {
            currentElement = seq[i];
            if (currentElement > previousElement)
            {
                currentCount++;
            }
            else
            {
                currentCount = 1;
                startPosition = i;
            }

            if (currentCount > bestCount)
            {
                bestCount = currentCount;
                bestStart = startPosition;
            }
            previousElement = currentElement;
        }

        if (bestCount < seq.Length - 1)
        {
            for (int i = bestStart; i < bestCount + bestStart; i++)
            {
                Console.Write(seq[i] + " ");
            }
        }
        else
        {
            for (int i = 0; i < seq.Length; i++)
            {
                Console.Write(seq[i] + " ");
            }
        }
    }
}
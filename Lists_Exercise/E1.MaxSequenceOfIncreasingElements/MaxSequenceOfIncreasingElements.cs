using System;
using System.Collections.Generic;
using System.Linq;

class MaxSequenceOfIncreasingElements
{
    static void Main()
    {
        //Refacotred the code from the previous exercise - best sequence of increasing elements
        List<int> seq = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        int previousElement = seq[0];
        int currentElement = 0;
        int startPosition = 0;
        int bestStart = 0;
        int currentCount = 1;
        int bestCount = 0;
        int bestElement = 0;

        for (int i = 1; i < seq.Count; i++)
        {
            currentElement = seq[i];
            if (currentElement == previousElement)
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
                bestElement = seq[bestStart];
            }
            previousElement = currentElement;
        }

        if (bestCount > 1)
        {
            for (int i = bestStart; i < bestCount + bestStart; i++)
            {
                Console.Write(bestElement + " ");
            }
        }
        else
        {
            Console.WriteLine(seq[0]);
        }

    }
}
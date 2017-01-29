using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MostFrequentNumber
{
    static void Main(string[] args)
    {
        int[] seq = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int currentElement = 0;
        int nextElement = 0;
        int bestElement = 0;
        int currentCount = 1;
        int bestCount = 0;
        bool flag = false;
        if (seq.Length <= 2)
        {
            Console.WriteLine(seq[0]);
            flag = true;
        }
        else
        {
            for (int j = 0; j < seq.Length; j++)
            {
                currentElement = seq[j];
                for (int i = j + 1; i < seq.Length; i++)
                {
                    nextElement = seq[i];
                    if (currentElement == nextElement)
                    {
                        currentCount++;
                    }

                    if (currentCount > bestCount)
                    {
                        bestCount = currentCount;
                        bestElement = currentElement;
                    }
                }
                currentCount = 1;
            }
        }

        if (!flag)
        {
            Console.WriteLine(bestElement);
        }
    }
}
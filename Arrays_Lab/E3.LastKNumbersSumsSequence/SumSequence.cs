using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SumSequence
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        int[] sequence = new int[n];
        sequence[0] = 1;
        for (int i = 1; i <= k; i++)
        {
            for (int j = 0; j < i; j++)
            {
                sequence[i] += sequence[j];
            }
        }

        for (int i = k + 1; i < n; i++)
        {
            for (int j = i - k; j < i; j++)
            {
                sequence[i] += sequence[j];
            }
        }


        foreach (var item in sequence)
        {
            Console.WriteLine(item + " ");
        }
    }

}
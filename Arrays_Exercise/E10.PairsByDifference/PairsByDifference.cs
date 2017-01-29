using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PairsByDifference
{
    static void Main(string[] args)
    {
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int difference = int.Parse(Console.ReadLine());
        int length = arr.Length;
        int cnt = 0;

        for (int i = 0; i < length; i++)
        {
            for (int j = i + 1; j < length ; j++)
            {
                if (Math.Abs(arr[i] - arr[j]) == difference)
                {
                    cnt++;
                }
            }
        }

        if (length < 2 || cnt == 0)
        {
            Console.WriteLine(0);
        }
        else
        {
            Console.WriteLine(cnt);
        }
    }
}
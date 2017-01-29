using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RotateAndSum
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int length = input.Length;
        int count = int.Parse(Console.ReadLine());
        int[] rotated = new int[length];
        int[] sums = new int[length];

        for (int i = 0; i < count; i++)
        {
            rotated[0] = input[length - 1];
            for (int j = 0; j < length - 1; j++)
            {
                rotated[j + 1] = input[j];
            }

            for (int j = 0; j < length; j++)
            {
                sums[j] += rotated[j];
            }

            for (int k = 0; k < length; k++)
            {
                input[k] = rotated[k];
            }
        }

        foreach (var number in sums)
        {
            Console.Write(number + " ");
        }
    }
}

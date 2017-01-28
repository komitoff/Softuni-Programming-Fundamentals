using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CondensedNumbers
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        int length = input.Length;
        int[] nums = new int[length];
        int[] condensed = new int[length - 1];

        for (int i = 0; i < length; i++)
        {
            nums[i] = int.Parse(input[i]);
        }

        int condensedLen = condensed.Length;
        if (length > 1)
        {
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < condensedLen; j++)
                {
                    condensed[j] = nums[j] + nums[j + 1];
                }
                nums = condensed;
                condensedLen--;
            }
            Console.WriteLine(condensed[0]);
        }
        else
        {
            Console.WriteLine(nums[0]);
        }
    }
}
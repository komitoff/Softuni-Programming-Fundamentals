using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class EqualSums
{
    static void Main(string[] args)
    {
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int length = arr.Length;
        int index = 0;
        int leftSum = 0;
        int rightSum = 0;
        bool flag = false;

        if (length == 1)
        {
            Console.WriteLine(0);
            flag = true;
        }
        else
        {
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    leftSum += arr[j];
                }

                for (int j = i + 1; j < length; j++)
                {
                    rightSum += arr[j];
                }
                
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    flag = true;
                    break;
                }

                leftSum = 0;
                rightSum = 0;
            }
        }

        if (!flag)
        {
            Console.WriteLine("no");
        }
    }
}
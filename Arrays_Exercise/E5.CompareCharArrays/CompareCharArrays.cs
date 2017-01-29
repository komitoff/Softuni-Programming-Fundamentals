using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CompareCharArrays
{
    static void Main(string[] args)
    {
        char[] arr1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
        char[] arr2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
        bool flag = false;
        int length = Math.Min(arr1.Length, arr2.Length);

        for (int i = 0; i < length; i++)
        {
            if (arr1[i] > arr2[i])
            {
                PrintArr(arr2, arr1);
                flag = true;
                break;
            }
            else if(arr1[i] < arr2[i])
            {
                PrintArr(arr1, arr2);
                flag = true;
                break;
            }
        }

        if (!flag)
        {
            if (arr1.Length < arr2.Length)
            {
                PrintArr(arr1, arr2);
            }
            else
            {
                PrintArr(arr2, arr1);
            }
        }
    }

    private static void PrintArr(char[] arr1, char[] arr2)
    {
        for (int i = 0; i < arr1.Length; i++)
        {
            Console.Write(arr1[i]);
        }
        Console.WriteLine();
        for (int i = 0; i < arr2.Length; i++)
        {
            Console.Write(arr2[i]);
        }
    }
}
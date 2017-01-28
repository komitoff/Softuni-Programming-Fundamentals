using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SumArrays
{
    static void Main(string[] args)
    {
        string[] firstArr = Console.ReadLine().Split(' ');
        string[] secondArr = Console.ReadLine().Split(' ');
        
        int len1 = firstArr.Length;
        int len2 = secondArr.Length;

        int[] arr1 = new int[len1];
        int[] arr2 = new int[len2];
        

        int pos1 = 0;
        int pos2 = 0;

        for (int i = 0; i < len1; i++)
        {
            arr1[i] = int.Parse(firstArr[i]);
        }

        for (int i = 0; i < len2; i++)
        {
            arr2[i] = int.Parse(secondArr[i]);
        }

        int length = Math.Max(len1, len2);
        int[] finArray = new int[length];

        for (int i = 0; i < length; i++)
        {
            
            finArray[i] = arr1[pos1] + arr2[pos2];
            if (pos1 < len1 - 1)
                pos1++;
            else
                pos1 = 0;
            if (pos2 < len2 - 1)
                pos2++;
            else
                pos2 = 0;
        }

        foreach (int item in finArray)
        {
            Console.Write(item + " ");
        }
    }
}
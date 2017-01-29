using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FoldAndSum
{
    static void Main(string[] args)
    {
        int[] inputArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int k = inputArr.Length / 4;

        int[] firstArr = new int[2 * k];
        int[] middle = new int[2 * k];
        int[] begin = new int[k];
        int[] end = new int[k];

        for (int i = 0; i < k; i++)
        {
            begin[k - i - 1] = inputArr[i];
        }

        for (int i = k, j = 0; i < 3 * k; i++, j++)
        {
            middle[j] = inputArr[i];
        }

        for (int i =3*k, j = k - 1; i < 4 * k; i++, j--)
        {
            end[j] = inputArr[i];
        }

        for (int i = 0; i < k; i++)
        {
            firstArr[i] = begin[i];
        }
        for (int i = k, j = 0; i < 2 * k; i++, j++)
        {
            firstArr[i] = end[j];
        }

        for (int i = 0; i < 2 * k; i++)
        {
            Console.Write(firstArr[i] + middle[i] + " ");
        }
    }
}
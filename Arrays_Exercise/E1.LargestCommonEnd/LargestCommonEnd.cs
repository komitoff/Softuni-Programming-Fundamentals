using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LargestCommonEnd
{
    static void Main(string[] args)
    {
        string[] firstArr = Console.ReadLine().Split(' ');
        string[] secondArr = Console.ReadLine().Split(' ');
        int length = Math.Min(firstArr.Length, secondArr.Length);
        int cnt1 = 0;
        int cnt2 = 0;

        for (int i = 0; i < length; i++)
        {
            if (firstArr[i].Equals(secondArr[i]))
            {
                cnt1++;
            }
        }
        Array.Reverse(firstArr);
        Array.Reverse(secondArr);

        for (int i = 0; i < length; i++)
        {
            if (firstArr[i].Equals(secondArr[i]))
            {
                cnt2++;
            }
        }
        Console.WriteLine(Math.Max(cnt1, cnt2));
    }
}
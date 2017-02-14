using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class CharacterMultiplier
{
    static void Main()
    {
        string[] words = Console.ReadLine().Split();
        char[] str1 = words[0].ToCharArray();
        char[] str2 = words[1].ToCharArray();
        char[] longerWord = str1.Length > str2.Length ? str1 : str2;
        int sum = 0;
        int minLength = Math.Min(str1.Length, str2.Length);
        int maxLength = Math.Max(str1.Length, str2.Length);

        for (int i = 0; i < minLength; i++)
        {
            int currentSum = 1;
            currentSum = ((int)str1[i]) * ((int)str2[i]);
            sum += currentSum;
        }

        for (int i = minLength; i < maxLength; i++)
        {
            sum += (int)longerWord[i];
        }
        Console.WriteLine(sum);
    }

}
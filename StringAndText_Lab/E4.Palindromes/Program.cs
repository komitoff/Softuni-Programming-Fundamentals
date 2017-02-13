using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        string[] input  = Console.ReadLine()
            .Split(new char[] { ' ', ',', '!', '.', '?'},
            StringSplitOptions.RemoveEmptyEntries);

        List<string> palindromes = new List<string>();

        for (int i = 0; i < input.Length; i++)
        {
            if (IsPalindrome(input[i]))
            {
                palindromes.Add(input[i]);
            }
        }

        Console.WriteLine(string.Join(", ", palindromes
                                            .OrderBy(p => p)
                                            .Distinct()));
    }
    
    public static bool IsPalindrome(string value)
    {
        int min = 0;
        int max = value.Length - 1;
        while (true)
        {
            if (min > max)
            {
                return true;
            }
            char a = value[min];
            char b = value[max];
            if (a != b)
            {
                return false;
            }
            min++;
            max--;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CountSubstrings
{
    static void Main()
    {
        string input = Console.ReadLine().ToLower();
        string substring = Console.ReadLine().ToLower();
        int index = input.IndexOf(substring);
        int cnt = 0;
        while (index != -1)
        {
            cnt++;
            index = input.IndexOf(substring, index + 1);
        }
        Console.WriteLine(cnt);
    }
}
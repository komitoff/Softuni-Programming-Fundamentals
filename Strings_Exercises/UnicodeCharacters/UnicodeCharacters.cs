using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class UnicodeCharacters
{
    static void Main()
    {
        string input = Console.ReadLine();
        StringBuilder result = new StringBuilder();
        foreach (char letter in input)
            result.AppendFormat("\\u{0:X4}".ToLower(), (int)letter);
        Console.WriteLine(result);
    }
}
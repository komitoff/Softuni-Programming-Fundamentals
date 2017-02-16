using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class MatchFullName
{
    static void Main()
    {
        string text = Console.ReadLine();

        string pattern = @"[A-Z][a-z]+\s+[A-Z][a-z]+";
        Regex rgx = new Regex(pattern);
        MatchCollection matches = rgx.Matches(text);
        Console.WriteLine($"found {matches.Count} matches");
        foreach (Match match in matches)
        {
            Console.WriteLine(match);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class ExtractEmails
{
    static void Main()
    {
        string inputText = Console.ReadLine();
        string pattern = @"[A-Za-z0-9.%-_+-]+@[A-Za-z0-9%-_+-]+\.[a-z]+.*?";
        Regex rgx = new Regex(pattern);
        MatchCollection matches = rgx.Matches(inputText);
        foreach (Match match in matches)
        {
            Console.WriteLine(match);
        }
    }
}
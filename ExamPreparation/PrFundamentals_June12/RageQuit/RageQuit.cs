using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public class RageQuit
{
    static void Main()
    {
        string input = Console.ReadLine();
        string pattern = @"(\D+)(\d+)";
        Regex rgx = new Regex(pattern);
        MatchCollection matches = rgx.Matches(input);
        StringBuilder output = new StringBuilder();
        foreach (Match match in matches)
        {
            int count = int.Parse(match.Groups[2].ToString());
            for (int i = 0; i < count; i++)
            {
                output.Append(match.Groups[1].ToString().ToUpper());
            }
        }
        int unique = output.ToString().Distinct().Count();
        Console.WriteLine($"Unique symbols used: {unique}");
        Console.WriteLine(output);
    }
}
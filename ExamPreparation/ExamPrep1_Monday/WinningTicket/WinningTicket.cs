using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class WinningTicket
{
    static void Main()
    {
        List<string> tickets = Console
            .ReadLine()
            .Split(',')
            .Select(x => x.Trim())
            .ToList();

        string pattern = @"[@]{6,}|[#]{6,}|[$]{6,}|[\^]{6,}";
        Regex rgx = new Regex(pattern);

        for (int i = 0; i < tickets.Count; i++)
        {
            if (tickets[i].Length != 20)
            {
                Console.WriteLine("invalid ticket");
                continue;
            }

            string left = tickets[i].Substring(0, 10);
            string right = tickets[i].Substring(10, 10);

            Match leftMatch = rgx.Match(left);
            Match rightMatch = rgx.Match(right);

            string leftSymbols = leftMatch.ToString();
            string rightSymbols = rightMatch.ToString();

            if (leftSymbols.Length == 10 &&
                rightSymbols.Length == 10 &&
                leftSymbols[0] == rightSymbols[0])
            {
                Console.WriteLine($"ticket \"{tickets[i]}\" - 10{leftSymbols[0]} Jackpot!");
            }
            else if (leftSymbols.Length >= 6 &&
                rightSymbols.Length >= 6 &&
                leftSymbols[0] == rightSymbols[0])
            {
                int minLen = Math.Min(leftSymbols.Length, rightSymbols.Length);
                Console.WriteLine($"ticket \"{tickets[i]}\" - {minLen}{leftSymbols[0]}");
            }
            else
            {
                Console.WriteLine($"ticket \"{tickets[i]}\" - no match");
            }
        }
    }
}
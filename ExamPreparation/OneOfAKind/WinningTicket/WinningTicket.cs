using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public class WinningTicket
{
    static void Main()
    {
        string[] tickets = Console
            .ReadLine()
            .Split(',')
            .Select(p => p.Trim())
            .ToArray();

        string pattern = @"[$@#^]{6,}";
        Regex rgx = new Regex(pattern);

        for (int i = 0; i < tickets.Length; i++)
        {
            if (tickets[i].Length != 20)
            {
                Console.WriteLine($"invalid ticket");
                continue;
            }
            string leftHalf = tickets[i].Substring(0, 10);
            string rightHalf = tickets[i].Substring(10, 10);
            Match left = rgx.Match(leftHalf);
            Match right = rgx.Match(rightHalf);
            string leftMatch = left.ToString();
            string rightMatch = right.ToString();

            if (leftMatch.Length == 10 && rightMatch.Length == 10 && leftMatch.Equals(rightMatch))
            {
                Console.WriteLine($"ticket \"{tickets[i]}\" - {leftMatch.Length}{leftMatch[0]} Jackpot!");
            }
            else if (leftMatch.Length >= 6 && rightMatch.Length >= 6 && leftMatch[0].Equals(rightMatch[0]))
            {
                int minLen = Math.Min(leftMatch.Length, rightMatch.Length);
                Console.WriteLine($"ticket \"{tickets[i]}\" - {minLen}{leftMatch[0]}");
            }
            else
            {
                Console.WriteLine($"ticket \"{tickets[i]}\" - no match");
            }
        }
    }
}
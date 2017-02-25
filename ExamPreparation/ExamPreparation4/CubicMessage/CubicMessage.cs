using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class CubicMessage
{
    static void Main()
    {
        string message = Console.ReadLine();
        List<int> indexers = new List<int>();
        StringBuilder output = new StringBuilder();
        while (!message.Equals("Over!"))
        {
            int number = int.Parse(Console.ReadLine());
            string messagePattern = @"[a-zA-Z]{"+ number +"}";
            Regex messageRegex = new Regex(messagePattern);
            Match correctMsg = messageRegex.Match(message);

            if (correctMsg.Length == 0)
            {
                message = Console.ReadLine();
                continue;
            }

            string left = message.Substring(0, number);
            string word = message.Substring(number, number);
            List<char> symbols = word.ToList();
            string right = message.Substring(number + number, number);
            string indexesString = left + right;
            
            string pattern = @"[1-9]";
            Regex rgx = new Regex(pattern);
            MatchCollection matches = rgx.Matches(indexesString);
            foreach (Match match in matches)
            {
                indexers.Add(int.Parse(match.ToString()));
            }

            for (int i = 0; i < indexers.Count; i++)
            {
                if (indexers[i] >= symbols.Count)
                {
                    output.Append(" ");
                }
                else
                {
                    output.Append(symbols[indexers[i]]);
                }
                
            }
            Console.WriteLine($"{word} == {output}");
            output.Clear();

            message = Console.ReadLine();
        }

    }
}
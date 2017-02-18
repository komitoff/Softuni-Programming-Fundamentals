using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        char[] winningSymbols = new char[] { '@', '$', '#', '^' };
        for (int i = 0; i < tickets.Length; i++)
        {
            if (tickets[i].Length != 20)
            {
                Console.WriteLine($"Invalid ticket");
                break;
            }
            string leftHalf = tickets[i].Substring(0, 10);
            string rightHalf = tickets[i].Substring(10, 10);
            for (int j = 0; j < winningSymbols.Length; j++)
            {
                char currentWinningSymbol = winningSymbols[j];
                int leftCount = leftHalf.Count(l => l == currentWinningSymbol);
                int rightCount = rightHalf.Count(r => r == currentWinningSymbol);

                if (leftCount >=6 && rightCount >= 6)
                {
                    if (leftCount + rightCount == 20)
                    {
                        Console.WriteLine($"ticket \"{tickets[i]}\" - 10{currentWinningSymbol} Jackpot!");
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{tickets[i]}\" - 10{currentWinningSymbol}");
                    }
                    break;
                }
                else if (j == 3)
                {
                    Console.WriteLine($"ticket \"{tickets[i]}\" - no match");
                    
                }
            }
        }
    }
}
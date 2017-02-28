using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public class HornetCom
{
    static void Main()
    {
        Dictionary<string, List<string>> broadcasts = new Dictionary<string, List<string>>();
        Dictionary<string, List<string>> privateMessages = new Dictionary<string, List<string>>();

        string command = Console.ReadLine();
        string privateMsgPattern = @"^(\d+)\s+<->\s+([0-9A-Za-z]+$)";
        string broadcastPattern = @"^(\D+)\s+<->\s+([0-9A-Za-z]+$)";
        Regex privateMsgCheck = new Regex(privateMsgPattern);
        Regex broadcastCheck = new Regex(broadcastPattern);

        while (!command.Equals("Hornet is Green"))
        {
            Match privateMessage = privateMsgCheck.Match(command);
            Match broadcast = broadcastCheck.Match(command);

            if (broadcast.Success)
            {
                string query = broadcast.Groups[1].Value;
                string frequency = broadcast.Groups[2].Value;
                char[] letters = frequency.ToCharArray();
                for (int i = 0; i < frequency.Length; i++)
                {
                    if (Char.IsUpper(letters[i]))
                    {
                        letters[i] = Char.ToLower(letters[i]);
                        continue;
                    }
                    else if (Char.IsLower(letters[i]))
                    {
                        letters[i] = Char.ToUpper(letters[i]);
                    }
                }

                string finalFrequency = new string(letters);
                if (!broadcasts.ContainsKey(finalFrequency))
                {
                    broadcasts.Add(finalFrequency, new List<string>());
                }
                broadcasts[finalFrequency].Add(query);
                //broadcasts.Add(finalFrequency, query);
            }
            else if (privateMessage.Success)
            {
                string recipentCode = privateMessage.Groups[1].Value;
                string message = privateMessage.Groups[2].Value;
                char[] symbols = recipentCode.ToCharArray();
                Array.Reverse(symbols);
                string finalCode = new string(symbols);
                if (!privateMessages.ContainsKey(finalCode))
                {
                    privateMessages.Add(finalCode, new List<string>());
                }
                privateMessages[finalCode].Add(message);

            }

            command = Console.ReadLine();
        }

        Console.WriteLine("Broadcasts:");
        if (!broadcasts.Any())
        {
            Console.WriteLine("None");
        }
        else
        {
            foreach (var br in broadcasts)
            {
                foreach (var kvp in br.Value)
                {
                    Console.WriteLine($"{br.Key} -> {kvp}");
                }
            }
        }

        Console.WriteLine("Messages:");
        if (!privateMessages.Any())
        {
            Console.WriteLine("None");
        }
        else
        {
            foreach (var mes in privateMessages)
            {
                foreach (var kvp in mes.Value)
                {
                    Console.WriteLine($"{mes.Key} -> {kvp}");
                }
            }
        }
    }
}
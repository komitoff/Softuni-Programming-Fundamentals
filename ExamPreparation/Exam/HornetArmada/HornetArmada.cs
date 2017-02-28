using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class HornetArmada
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string pattern = @"^(\d+)\s+=\s+(.*)\s+->\s+(.*):(\d+)";
        Regex rgx = new Regex(pattern);

        //legion and activity
        Dictionary<string, long> legionActivity = 
            new Dictionary<string, long>();

        //legion - soldier and soldier count
        Dictionary<string, Dictionary<string, long>> legionSoldierCount =
            new Dictionary<string, Dictionary<string, long>>();
        bool validLegion = true;
        bool validSouldier = true;
        char[] exludedSymbols = new char[] { '=', '-', '>', ':', ' ' };
        for (int i = 0; i < n; i++)
        {
            string command = Console.ReadLine();
            Match match = rgx.Match(command);
            long lastActivity = 0;
            string legionName = null;
            string soldierType = null;
            long soldierCount = 0;

            if (match.Success)
            {
                lastActivity = long.Parse(match.Groups[1].Value);
                legionName = match.Groups[2].Value;
                soldierType = match.Groups[3].Value;
                soldierCount = long.Parse(match.Groups[4].Value);
            }

            for (int j = 0; j < exludedSymbols.Length; j++)
            {
                if (legionName.Contains(exludedSymbols[j]))
                {
                    validLegion = false;
                }
                if (soldierType.Contains(exludedSymbols[j]))
                {
                    validSouldier = false;
                }
            }

            if (validLegion)
            {
                if (!legionSoldierCount.ContainsKey(legionName))
                {
                    legionSoldierCount.Add(legionName, new Dictionary<string, long>());
                    legionActivity.Add(legionName, 0);
                    if (!legionSoldierCount[legionName].ContainsKey(soldierType) && validSouldier)
                    {
                        legionSoldierCount[legionName].Add(soldierType, soldierCount);
                        legionActivity[legionName] = lastActivity;
                    }
                }
                else
                {
                    if (legionSoldierCount[legionName].ContainsKey(soldierType) && validSouldier)
                    {
                        if (legionActivity[legionName] < lastActivity)
                        {
                            legionSoldierCount[legionName][soldierType] += soldierCount;
                        }
                    }
                    else
                    {
                        legionSoldierCount[legionName].Add(soldierType, soldierCount);
                        if (legionActivity[legionName] < lastActivity)
                        {
                            legionActivity[legionName] = lastActivity;
                        }
                    }
                }
            }
        }
        string outputCommand = Console.ReadLine();
        if (outputCommand.Contains('\\'))
        {
            Dictionary<string, long> output = new Dictionary<string, long>();

            string[] tokens = outputCommand.Split('\\');
            long activity = long.Parse(tokens[0]);
            string type = tokens[1];

            foreach (var leg in legionSoldierCount)
            {
                string legionName = leg.Key;
                if (leg.Value.ContainsKey(type) && activity > legionActivity[leg.Key])
                {
                    if (!output.ContainsKey(legionName))
                    {
                        output.Add(legionName, legionSoldierCount[legionName][type]);
                    }
                }
            }

            foreach (var item in output
                .OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
        else
        {
            Dictionary<string, long> output = new Dictionary<string, long>();
            //Dictionary<long, string> output = new Dictionary<long, string>();
            foreach (var leg in legionSoldierCount)
            {
                if (leg.Value.ContainsKey(outputCommand))
                {
                    string currentLegion = leg.Key;
                    if (legionActivity.ContainsKey(currentLegion))
                    {
                        if (!output.ContainsKey(currentLegion))
                        {
                            output.Add(currentLegion, legionActivity[currentLegion]);
                        }
                    }
                }
            }

            foreach (var item in output
                .OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{item.Value} : {item.Key}");
            }
        }
        
    }
}
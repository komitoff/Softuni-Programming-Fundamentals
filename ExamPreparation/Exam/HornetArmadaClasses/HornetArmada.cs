using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HornetArmadaClasses
{
    class HornetArmada
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"^(\d+)\s+=\s+(.*)\s+->\s+(.*):(\d+)";
            Regex rgx = new Regex(pattern);

            List<Legion> legions = new List<Legion>();

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
                Legion currentLegion = new Legion()
                {
                    LastActivity = lastActivity,
                    Name = legionName,
                    SoldierType = soldierType,
                    SoldierCount = soldierCount
                };
                if (!legions.Any())
                {
                    legions.Add(currentLegion);
                }
            }

            string outCommand = Console.ReadLine();

            if (outCommand.Contains('\\'))
            {
                string[] tokens = outCommand.Split('\\');
                
            }
            else
            {
                foreach (var leg in legions)
                {
                    if (leg.SoldierType.Equals(outCommand))
                    {
                        Console.WriteLine($"{leg.LastActivity} : {leg.Name}");
                    }
                }
            }

        }
    }
}

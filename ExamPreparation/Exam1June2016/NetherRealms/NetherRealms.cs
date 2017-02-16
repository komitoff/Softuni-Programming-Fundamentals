using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class NetherRealms
{
    static void Main()
    {
        SortedDictionary<string, Dictionary<int, double>> realm =
            new SortedDictionary<string, Dictionary<int, double>>();

        string[] monsters = Console
            .ReadLine()
            .Split(new char[] { ' ', '\t', '\n', ',' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < monsters.Length; i++)
        {
            string monsterName = monsters[i];
            string healthPattern = @"([^0-9+\-*\/\.])";
            MatchCollection symbols = Regex.Matches(monsters[i], healthPattern);
            StringBuilder totalHpSymbols = new StringBuilder();
            foreach (Match match in symbols)
            {
                 totalHpSymbols.Append(match.ToString());
            }
            int totalHealth = CalculateTotalHealth(totalHpSymbols);

            string dmgPattern = @"[+-]?([0-9]*[.])?[0-9]+";
            MatchCollection damageSymbols = Regex.Matches(monsters[i], dmgPattern);
            List<string> damageNumbersInStr = new List<string>();
            List<double> damageNumbers = new List<double>();
            foreach (Match item in damageSymbols)
            {
                damageNumbers.Add(double.Parse(item.ToString()));
            }

            int mulCount = monsterName.Count(x => x == '*');
            int divCount = monsterName.Count(x => x == '/');
            double totalDamage = CalculatTotalDamage(damageNumbers, mulCount, divCount);

            realm.Add(monsterName, new Dictionary<int, double>());
            realm[monsterName].Add(totalHealth, totalDamage);

        }

        foreach (var monster in realm)
        {
            
            foreach (var hpAndDmg in monster.Value)
            {
                Console.WriteLine($"{monster.Key} - {hpAndDmg.Key} health, {hpAndDmg.Value:f2} damage");
            }
        }
    }

    private static double CalculatTotalDamage(List<double> damageNumbers, int mulCount, int divCount)
    {
        double damage = 0;
        for (int i = 0; i < damageNumbers.Count; i++)
        {
            damage += damageNumbers[i];
        }
        for (int i = 0; i < mulCount; i++)
        {
            damage *= 2;
        }
        for (int i = 0; i < divCount; i++)
        {
            damage /= 2;
        }
        return damage;
    }

    private static int CalculateTotalHealth(StringBuilder totalHpSymbols)
    {
        int sum = 0;
        for (int i = 0; i < totalHpSymbols.Length; i++)
        {
            sum += (int)totalHpSymbols[i];
        }
        return sum;
    }
}
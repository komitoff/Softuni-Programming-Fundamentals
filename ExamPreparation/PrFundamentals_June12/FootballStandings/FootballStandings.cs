using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

public class FootballStandings
{
    static void Main()
    {
        string decryptCode = Console.ReadLine().ToUpper();
        //team / score
        Dictionary<string, int> teamScores = new Dictionary<string, int>();
        //team / total goals
        Dictionary<string, long> teamGoals = new Dictionary<string, long>();

        string match = Console.ReadLine().ToUpper();

        while (!match.Equals("FINAL"))
        {
            string[] tokens = match.Split(new string[] { decryptCode }, StringSplitOptions.RemoveEmptyEntries);
            string matchResult = tokens[tokens.Length - 1];
            Console.WriteLine(matchResult);
            string[] teams = new string[2];
            for (int i = 0, j = 0; i < tokens.Length; i++)
            {
                if (tokens[i].IndexOf(decryptCode) != -1 && tokens[i].LastIndexOf(decryptCode) != -1)
                {
                    teams[j] = tokens[i];
                    j++;
                }
            }
            foreach (var tea in teams)
            {
                Console.WriteLine(tea);
            }
            match = Console.ReadLine().ToUpper();
        }
    }
}
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
            string teamA = String.Format(String.Join("", tokens[0].ToUpper().Reverse().ToArray()));
            string teamB = String.Format(String.Join("", tokens[2].ToUpper().Reverse().ToArray()));
            string[] scoreFull = tokens[3].Split().ToArray();
            long[] score = (scoreFull.Length == 1 ? scoreFull[0] : scoreFull[1]).Split(':').Select(long.Parse).ToArray();

            Console.WriteLine(teamA); Console.WriteLine(teamB);
            Console.WriteLine(string.Join(", ", score));
            match = Console.ReadLine().ToUpper();
        }
    }
}
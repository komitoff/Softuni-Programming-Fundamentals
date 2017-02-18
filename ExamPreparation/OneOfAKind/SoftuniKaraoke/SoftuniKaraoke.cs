using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class SoftuniKaraoke
{
    static void Main()
    {
        List<string> appliedParticipants = Console.ReadLine()
            .Split(',')
            .Select(p => p.TrimStart())
            .ToList();

        List<string> aviableSongs = Console.ReadLine()
            .Split(',')
            .Select(s => s.TrimStart())
            .ToList();
        //participant, awards
        Dictionary<string, List<string>> awardedParticipants =
            new Dictionary<string, List<string>>();

        string currentPerformance = Console.ReadLine();
        while (!currentPerformance.Equals("dawn"))
        {
            string[] tokens = currentPerformance
                .Split(',')
                .Select(t => t.TrimStart())
                .ToArray();
            string currentParticipant = tokens[0];
            string currentSong = tokens[1];
            string currentAward = tokens[2];

            if (appliedParticipants.Contains(currentParticipant) &&
                aviableSongs.Contains(currentSong))
            {
                if (!awardedParticipants.ContainsKey(currentParticipant))
                {
                    awardedParticipants.Add(currentParticipant, new List<string>());
                }
                if (!awardedParticipants[currentParticipant].Contains(currentAward))
                {
                    awardedParticipants[currentParticipant].Add(currentAward);
                }
            }
            currentPerformance = Console.ReadLine();
        }

        if (awardedParticipants.Count > 0)
        {
            foreach (var participant in awardedParticipants
            .OrderByDescending(p => p.Value.Count)
            .ThenBy(p => p.Key))
            {
                Console.WriteLine($"{participant.Key}: {participant.Value.Count} awards");
                foreach (var award in participant.Value.OrderBy(a => a))
                {
                    Console.WriteLine($"--{award}");
                }
            }
        }
        else
        {
            Console.WriteLine("No awards");
        }
        

    }
}
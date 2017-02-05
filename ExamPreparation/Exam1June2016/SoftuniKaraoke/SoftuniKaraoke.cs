using System;
using System.Collections.Generic;
using System.Linq;

class SoftuniKaraoke
{
    static void Main()
    {
        List<string> appliedParticipants = Console.ReadLine().Split(',').ToList();
        List<string> aviableSongs = Console.ReadLine().TrimStart().Split(',').ToList();

        for (int i = 0; i < appliedParticipants.Count; i++)
        {
            appliedParticipants[i] = appliedParticipants[i].TrimStart();
        }

        for (int i = 0; i < aviableSongs.Count; i++)
        {
            aviableSongs[i] = aviableSongs[i].TrimStart();
        }
        Dictionary<string, Dictionary<string, int>> awardedParticipants =
            new Dictionary<string, Dictionary<string, int>>();

        string cmd = Console.ReadLine();


        while (!cmd.Equals("dawn"))
        {
            string[] execution = cmd.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            string participant = execution[0].TrimStart();
            string song = execution[1].TrimStart();
            string award = execution[2].TrimStart();
            if (aviableSongs.Contains(song) && appliedParticipants.Contains(participant))
            {
                AddAward(participant, song, award, awardedParticipants);
            }
            cmd = Console.ReadLine();
        }
        if (awardedParticipants.Count == 0)
        {
            Console.WriteLine("No awards");
        }
        foreach (var person in awardedParticipants)
        {
            Console.WriteLine($"{person.Key}: {person.Value.Values.Count} awards");
            foreach (var award in person.Value)
            {
                Console.WriteLine($"--{award.Key}");
            }
        }
    }

    private static void AddAward(string participant, string song, string award, Dictionary<string, Dictionary<string, int>> awardedParticipants)
    {
        if (!awardedParticipants.ContainsKey(participant))
        {
            awardedParticipants.Add(participant, new Dictionary<string, int>());
        }
        if (!awardedParticipants[participant].ContainsKey(award))
        {
            awardedParticipants[participant].Add(award, 0);
        }
        awardedParticipants[participant][award]++;
    }
}
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
        Dictionary<string, List<string>> awardedParticipants =
            new Dictionary<string, List<string>>();

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
        foreach (var person in awardedParticipants.OrderByDescending(p => p.Value.Count).ThenBy(p => p.Key))
        {
            Console.WriteLine($"{person.Key}: {person.Value.Count} awards");
            string[] awards = awardedParticipants[person.Key].OrderBy(x => x).ToArray();
            foreach (var award in awardedParticipants[person.Key].OrderBy(x => x))
            {
                Console.WriteLine($"--{award}");
            }
        }
    }

    private static void AddAward(string participant, string song, string award, Dictionary<string, List<string>> awardedParticipants)
    {
        if (!awardedParticipants.ContainsKey(participant))
        {
            awardedParticipants.Add(participant,new List<string>());
        }
        if (!awardedParticipants[participant].Contains(award))
        {
            awardedParticipants[participant].Add(award);
        }

    }
}
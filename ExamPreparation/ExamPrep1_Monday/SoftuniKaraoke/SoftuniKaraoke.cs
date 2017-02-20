using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class SoftuniKaraoke
{
    static void Main()
    {

        List<string> listedParticipants = Console
            .ReadLine()
            .Split(',')
            .Select(x => x.TrimStart())
            .ToList();

        List<string> aviableSongs = Console
            .ReadLine()
            .Split(',')
            .Select(x => x.TrimStart())
            .ToList();

        // participant and his awards
        Dictionary<string, List<string>> participantAwards =
            new Dictionary<string, List<string>>();

        string command = Console.ReadLine();

        bool isListedParticipant = false;
        bool isListedSong = false;

        while (!command.Equals("dawn"))
        {
            string[] tokens = command
                .Split(',')
                .Select(x => x.TrimStart())
                .ToArray();

            string currentParticipant = tokens[0];
            string currentSong = tokens[1];
            string currentAward = tokens[2];

            if (listedParticipants.Contains(currentParticipant))
                isListedParticipant = true;

            if (aviableSongs.Contains(currentSong))
                isListedSong = true;

            if (isListedSong && isListedParticipant)
            {
                if (!participantAwards.ContainsKey(currentParticipant))
                {
                    participantAwards.Add(currentParticipant, new List<string>());
                }

                if (!participantAwards[currentParticipant].Contains(currentAward))
                {
                    participantAwards[currentParticipant].Add(currentAward);
                }
            }

            isListedParticipant = false;
            isListedSong = false;
            command = Console.ReadLine();
        }

        if (participantAwards.Values.Count <= 0)
        {
            Console.WriteLine("No awards");
        }
        else
        {
            foreach (var participant in participantAwards
                .OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{participant.Key}: {participant.Value.Count} awards");
                foreach (var item in participant.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"--{item}");
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

public class RollyTheCoder
{
    static void Main()
    {
        string input = Console.ReadLine();
        //event participants
        Dictionary<string, HashSet<string>> participantsForEvent =
            new Dictionary<string, HashSet<string>>();
        //id , event, participants
        Dictionary<long, Dictionary<string, List<string>>> rollyEvenet = 
            new Dictionary<long, Dictionary<string, List<string>>>();

        bool flag = false;
        while (!input.Equals("Time for Code"))
        {
            flag = true;
            string trimmedEvent = null;
            string[] info = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //get id
            long currentId = int.Parse(info[0]);
            string currentEvent = info[1];
            List<string> currentParticipants = new List<string>();

            //if the event contains hash tag
            if (IsValidEvent(currentEvent))
            {
                trimmedEvent = TrimEvent(currentEvent);

                for (int i = 2; i < info.Length; i++)
                {
                    currentParticipants.Add(info[i]);
                }

                if (!rollyEvenet.ContainsKey(currentId))
                {
                    rollyEvenet.Add(currentId, new Dictionary<string, List<string>>());
                    if (!rollyEvenet[currentId].ContainsKey(trimmedEvent))
                    {
                        rollyEvenet[currentId][trimmedEvent] = new List<string>();
                        participantsForEvent[trimmedEvent] = new HashSet<string>();
                    }
                }

                if (rollyEvenet[currentId].ContainsKey(trimmedEvent))
                {
                    foreach (var currentParticipant in currentParticipants)
                    {
                        rollyEvenet[currentId][trimmedEvent].Add(currentParticipant);
                        participantsForEvent[trimmedEvent].Add(currentParticipant);
                    }
                }
            }

            input = Console.ReadLine();
        }

        if (flag)
        {
            foreach (var eve in participantsForEvent
            .OrderByDescending(p => p.Value.Count))
            {
                Console.WriteLine($"{eve.Key} - {eve.Value.Count}");
                foreach (var part in eve.Value
                    .OrderBy(p => p))
                {
                    Console.WriteLine(part);
                }
            }
        }
    }

    private static string TrimEvent(string currentEvent)
    {
        return currentEvent.Substring(1, currentEvent.Length - 1);

    }

    private static bool IsValidEvent(string currentEvent)
    {
        if (currentEvent[0].Equals('#'))
        {
            return true;
        }
        return false;
    }
}
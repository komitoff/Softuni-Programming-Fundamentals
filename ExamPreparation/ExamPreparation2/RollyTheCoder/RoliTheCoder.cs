using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class RoliTheCoder
{
    static void Main()
    {
        string command = Console.ReadLine();
        Dictionary<int, string> eventsById = new Dictionary<int, string>();
        Dictionary<string, HashSet<string>> participantsInEvent =
            new Dictionary<string, HashSet<string>>();

        while (!command.Equals("Time for Code"))
        {
            bool isValidEvent = false;
            string[] tokens = command.Split();
            int currentId = int.Parse(tokens[0]);
            string currentEvent = tokens[1];
            HashSet<string> currentParticipants = new HashSet<string>();

            for (int i = 2; i < tokens.Length; i++)
            {
                if (tokens[i].Contains("@"))
                {
                    currentParticipants.Add(tokens[i]);
                }
            }
                

            if (currentEvent.Contains("#"))
            {
                isValidEvent = true;
            }
            else
            {
                command = Console.ReadLine();
                continue;
            }
                

            if (!eventsById.ContainsKey(currentId))
            {
                eventsById.Add(currentId, null);
                if (isValidEvent)
                {
                    eventsById[currentId] = currentEvent;
                    participantsInEvent.Add(currentEvent, new HashSet<string>());
                }
            }

            if (eventsById[currentId].Contains(currentEvent))
            {
                participantsInEvent[currentEvent].UnionWith(currentParticipants);
            }

            command = Console.ReadLine();
        }

        foreach (var events in participantsInEvent
            .OrderByDescending(x => x.Value.Count)
            .ThenBy(e => e.Key))
        {
            string eventName = events.Key.Substring(1, events.Key.Length - 1);
            Console.WriteLine($"{eventName} - {events.Value.Count}");
            foreach (var participant in events.Value.OrderBy(p => p))
            {
                Console.WriteLine(participant);
            }
        }
    }
}
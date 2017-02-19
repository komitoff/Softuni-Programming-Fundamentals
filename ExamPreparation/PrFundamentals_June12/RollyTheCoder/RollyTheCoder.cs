using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class RollyTheCoder
{
    static void Main()
    {
        Dictionary<int, Dictionary<string, HashSet<string>>> rollyEvent =
            new Dictionary<int, Dictionary<string, HashSet<string>>>();

        Dictionary<string, HashSet<string>> singleEventParticipants =
            new Dictionary<string, HashSet<string>>();

        string currentPerformance = Console.ReadLine();
        
        while (!currentPerformance.Equals("Time for Code"))
        {
            bool isValidEvent = false;
            string[] tokens = currentPerformance.Split();
            int id = int.Parse(tokens[0]);
            string currentEvent = tokens[1];
            HashSet<string> currentParticipants = new HashSet<string>();
            for (int i = 2; i < tokens.Length; i++)
            {
                currentParticipants.Add(tokens[i]);
            }
            Console.WriteLine(currentParticipants.Count);
            //check if the event is valid 
            if (currentEvent.Contains("#"))
            {
                currentEvent = currentEvent.Substring(1, currentEvent.Length - 1);
                isValidEvent = true;
            }
            
            if (!rollyEvent.ContainsKey(id) && isValidEvent)
            {
                rollyEvent.Add(id, new Dictionary<string, HashSet<string>>());
                rollyEvent[id].Add(currentEvent, new HashSet<string>());
                singleEventParticipants.Add(currentEvent, new HashSet<string>());
            }
            if(rollyEvent[id].ContainsKey(currentEvent))
            {
                rollyEvent[id][currentEvent].UnionWith(currentParticipants);
                singleEventParticipants[currentEvent].UnionWith(currentParticipants);
            }

            currentPerformance = Console.ReadLine();
        }

        foreach (var item in singleEventParticipants
            .OrderByDescending(e => e.Value.Count))
        {
            Console.WriteLine($"{item.Key} - {item.Value.Count}");
            foreach (var participant in item.Value.OrderBy(p => p))
            {
                Console.WriteLine(participant);
            }
        }
    }
}
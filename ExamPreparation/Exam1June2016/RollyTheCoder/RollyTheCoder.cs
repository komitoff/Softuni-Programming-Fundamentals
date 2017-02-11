using System;
using System.Collections.Generic;
using System.Linq;

public class RollyTheCoder
{
    static void Main()
    {
        string input = Console.ReadLine();
        //event participants
        Dictionary<string, List<string>> participantsForEvent =
            new Dictionary<string, List<string>>();
        //id , event, participants
        Dictionary<int, Dictionary<string, List<string>>> rollyEvenet = 
            new Dictionary<int, Dictionary<string, List<string>>>();

        while (!input.Equals("Time For Code"))
        {
            string trimmedEvent = null;
            string[] info = input.Split();
            //get id
            int currentId = int.Parse(info[0]);
            string currentEvent = info[1];
            List<string> currentParticipants = new List<string>();

            //if the event contains hash tag
            if (IsValidEvent(currentEvent))
            {
                trimmedEvent = TrimEvent(currentEvent);
            }

            for (int i = 2; i < info.Length; i++)
            {
                currentParticipants.Add(info[i]);
            }

            if (!rollyEvenet.ContainsKey(currentId))
            {
                rollyEvenet.Add(currentId, new Dictionary<string, List<string>>());
            }
            else
            {
                if (rollyEvenet[currentId].ContainsKey(trimmedEvent))
                {

                }
            }
            

            input = Console.ReadLine();
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
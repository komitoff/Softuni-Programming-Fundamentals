using System;
using System.Collections.Generic;
using System.Linq;

class UserLogs
{
    static void Main()
    {
        string input = Console.ReadLine();
        SortedDictionary<string, Dictionary<string, int>> userLogs = 
            new SortedDictionary<string, Dictionary<string, int>>();

        while (!input.Equals("end"))
        {
            string[] info = input.Split(' ');
            string[] ipInfo = info[0].Split('=');
            string ip = ipInfo[1];
            string msg = info[1];
            string userInfo = info[2];
            string[] user = userInfo.Split('=');
            string username = user[1];

            if (!userLogs.ContainsKey(username))
            {
                userLogs.Add(username, new Dictionary<string, int>());
            }
            if (!userLogs[username].ContainsKey(ip))
            {
                userLogs[username].Add(ip, 0);
            }

            userLogs[username][ip]++;

            input = Console.ReadLine();
        }

        foreach (var user in userLogs)
        {
            var output = new List<string>();
            Console.WriteLine($"{user.Key}:");
            foreach (var logs in user.Value)
            {
                output.Add($"{logs.Key} => {logs.Value}");
            }
            Console.WriteLine(string.Join(", ", output) + ".");
        }
    }
}
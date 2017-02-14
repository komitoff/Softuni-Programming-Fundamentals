using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Files
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        //root - full file name - size
        Dictionary<string, Dictionary<string, long>> fileData =
            new Dictionary<string, Dictionary<string, long>>();

        //full file name - size
        Dictionary<string, long> fileAndSize = 
            new Dictionary<string, long>();

        for (int i = 0; i < count; i++)
        {
            string[] input = Console.ReadLine().Split('\\');
            string fileInfoAndSize = input[input.Length - 1];
            string[] fileInfo = fileInfoAndSize.Split(';');
            string rootDir = input[0];
            string fullFileName = fileInfo[0];
            long fileSize = long.Parse(fileInfo[1]);

            if (!fileData.ContainsKey(rootDir))
            {
                fileData[rootDir] = new Dictionary<string, long>();
            }
            if (fileData[rootDir].ContainsKey(fullFileName))
            {
                fileData[rootDir][fullFileName] = 0;
            }
            fileData[rootDir][fullFileName] = fileSize;

        }

        string[] cmd = Console.ReadLine().Split();
        string typeSubj = cmd[0];
        string rootSubj = cmd[cmd.Length - 1];
        string realTypeSubj = typeSubj.Insert(0, ".");

        bool areThereResults = false;
        if (fileData.ContainsKey(rootSubj))
        {
            fileAndSize = fileData[rootSubj];
            
            foreach (var file in fileAndSize
                .OrderByDescending(f => f.Value)
                .ThenBy(f => f.Key))
            {
                if (file.Key.Contains(realTypeSubj))
                {
                    Console.WriteLine($"{file.Key} - {file.Value} KB");
                    areThereResults = true;
                }
            }
        }

        if (!areThereResults)
        {
            Console.WriteLine("No");
        }
        
    }
}


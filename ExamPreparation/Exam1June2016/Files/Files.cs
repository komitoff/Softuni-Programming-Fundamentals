using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Files
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        //root dir and the file + extension + size
        SortedDictionary<string, List<RunnableFile>> rootFiles =
            new SortedDictionary<string, List<RunnableFile>>();


        for (int i = 0; i < count; i++)
        {
            string[] tokens = Console.ReadLine().Split('\\');
            string rootDir = tokens[0];
            if (!rootFiles.ContainsKey(rootDir))
            {
                rootFiles[rootDir] = new List<RunnableFile>();
            }
            string[] fileNameAndSize = tokens[tokens.Length - 1].Split(new char[] { ';' });
            string[] fileNameAndExtension = GetFileExtension(fileNameAndSize[0]);
            RunnableFile currentFile = new RunnableFile()
            {
                Name = fileNameAndExtension[0],
                Extension = fileNameAndExtension[1],
                Size = long.Parse(fileNameAndSize[1])
            };
            rootFiles[rootDir].Add(currentFile);

        }

        string[] command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        if (rootFiles.ContainsKey(command[2]))
        {
            bool flag = true;
            List<string> printed = new List<string>();
            string extension = command[0];
            List<RunnableFile> filesList = rootFiles[command[2]];
            Dictionary<string, long> uniqueList = new Dictionary<string, long>();
            for (int i = 0; i < filesList.Count; i++)
            {
                if (filesList[i].Extension.Equals(extension))
                {
                    if (!uniqueList.ContainsKey(filesList[i].Name))
                    {
                        uniqueList.Add(filesList[i].Name, 0);
                    }
                    uniqueList[filesList[i].Name] = filesList[i].Size;
                }
                
            }
           
            foreach (var file in uniqueList
                .OrderByDescending(f => f.Value)
                .ThenBy(f => f.Key)
                .Distinct())
            {
                Console.WriteLine($"{file.Key}.{extension} - {file.Value} KB");
                flag = false;
            }
            if (flag)
            {
                Console.WriteLine("No");
            }
        }
    }

    private static string[] GetFileExtension(string input)
    {
        string[] nameAndExtension = input.Split('.');
        string extension = nameAndExtension[nameAndExtension.Length - 1];
        StringBuilder fileName = new StringBuilder();
        for (int i = 0; i < nameAndExtension.Length - 1; i++)
        {
            fileName.Append(nameAndExtension[i]);
        }

        string[] result = new string[2];
        result[0] = fileName.ToString();
        result[1] = extension;
        return result;
    }
}

//public class RunnableFile
//{
//    public string Name { get; set; }
//    public string Extension { get; set; }
//    public long Size { get; set; }
//}
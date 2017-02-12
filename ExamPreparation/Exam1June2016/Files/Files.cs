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
            List<RunnableFile> filesList = rootFiles[command[2]];
            string extension = command[0];
            foreach (var file in filesList
                .OrderByDescending(f => f.Size)
                .ThenBy(f => f.Name)
                .Distinct())
            {
                if (file.Extension.Equals(extension) && !printed.Contains(file.Name))
                {
                    Console.WriteLine($"{file.Name}.{file.Extension} - {file.Size} KB");
                    printed.Add(file.Name);
                    flag = false;
                }
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
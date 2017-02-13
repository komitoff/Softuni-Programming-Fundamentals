using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Files
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        Dictionary<string, List<RunnableFile>> dir =
            new Dictionary<string, List<RunnableFile>>();

        
        for (int i = 0; i < count; i++)
        {
            string[] path = Console.ReadLine().Split('\\');

            string rootDir = path[0];
            string fullFileSpec = path[path.Length - 1];

            string[] fileNameAndSize = fullFileSpec.Split(';');

            long size = long.Parse(fileNameAndSize[1]);
            string[] fileNameAndExtension = GetFileName(fileNameAndSize[0]);

            string fileName = fileNameAndExtension[0];
            string extension = fileNameAndExtension[1];

            RunnableFile currentFile = new RunnableFile()
            {
                Name = fileName,
                Size = size,
                Extension = extension
            };

            if (!dir.ContainsKey(rootDir))
            {
                dir[rootDir] = new List<RunnableFile>();
            }
            dir[rootDir].Add(currentFile);
            for (int j = 0; j < dir[rootDir].Count; j++)
            {
                if (dir[rootDir][j].Name.Equals(currentFile.Name))
                {
                    dir[rootDir][j] = currentFile;
                }
            }

        }

        string[] command = Console.ReadLine().Split();
        string root = command[2];
        string type = command[0];
        bool flag = false;
        if (dir.ContainsKey(root))
        {
            for (int i = 0; i < dir[root].Count; i++)
            {
                if (dir[root][i].Extension.Equals(type))
                {
                    flag = true;
                }
            }
        }
        if(flag)
        {
            foreach (var file in dir[root]
                .OrderBy(f => f.Size)
                .ThenBy(f => f.Name)
                .Where(f => f.Extension.Equals(type)))
            {
                Console.WriteLine($"{file.Name}.{file.Extension} - {file.Size} KB");
            }
        }
        else
        {
            Console.WriteLine("No");
        }
    }

    private static string[] GetFileName(string name)
    {
        string[] fileNameAndExtension = new string[2];
        int index = name.LastIndexOf('.');
        string extension = name.Substring(index + 1, name.Length - index - 1);
        string fileName = name.Substring(0, index);
        fileNameAndExtension[0] = fileName;
        fileNameAndExtension[1] = extension;
        return fileNameAndExtension;
    }
}

//public class RunnableFile
//{
//    public string Name { get; set; }
//    public string Extension { get; set; }
//    public long Size { get; set; }

//    public static implicit operator List<object>(RunnableFile v)
//    {
//        throw new NotImplementedException();
//    }
//}

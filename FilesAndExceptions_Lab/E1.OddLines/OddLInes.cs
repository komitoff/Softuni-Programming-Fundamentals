using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

public class OddLInes
{
    static void Main()
    {
        string[] textLines = File.ReadAllLines("input.txt");
        List<string> oddLines = new List<string>();

        for (int i = 0; i < textLines.Length; i++)
        {
            if (i % 2 == 0)
            {
                oddLines.Add(textLines[i]);
            }
        }

        File.WriteAllLines("output.txt", oddLines);

    }
}

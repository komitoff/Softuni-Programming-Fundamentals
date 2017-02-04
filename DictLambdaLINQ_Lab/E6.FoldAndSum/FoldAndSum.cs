using System;
using System.Collections.Generic;
using System.Linq;

class FoldAndSum
{
    static void Main()
    {
        List<int> sequnce = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();
        int k = sequnce.Count / 4;
        int[] leftRow = sequnce.Take(k).Reverse().ToArray();
        int[] rightRow = sequnce.Skip(3 * k).Take(k).Reverse().ToArray();
        int[] row1 = leftRow.Concat(rightRow).ToArray();
        int[] row2 = sequnce.Skip(k).Take(2 * k).ToArray();

        var summ = row1.Select((x, index) => x + row2[index]);
        Console.WriteLine(string.Join(" ", summ));
    }
}

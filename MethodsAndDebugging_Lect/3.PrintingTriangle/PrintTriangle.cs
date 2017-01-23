using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrintTriangle
{
    static void Main(string[] args)
    {
        int length = int.Parse(Console.ReadLine());

        for (int i = 1; i < length; i++)
        {
            PrintLine(1, i);
        }

        PrintLine(1, length);

        for (int i = length - 1; i >= 0; i--)
        {
            PrintLine(1, i);
        }
    }

    private static void PrintLine(int v, int length)
    {
        for (int i = 1; i <= length; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}
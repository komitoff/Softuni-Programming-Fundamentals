using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DrawFilledSquare
{
    static void Main()
    {
        int length = int.Parse(Console.ReadLine());

        PrintHeader(length);
        for (int i = 0; i < length - 2; i++)
        {
            PrintBody(length);
        }
        PrintFooter(length);
        
    }

    /// <summary>
    /// Prints the Header of the square
    /// </summary>
    /// <param name="length"></param>
    private static void PrintHeader(int length)
    {
        Console.Write(new string('-', length * 2));
        Console.WriteLine();
    }

    /// <summary>
    /// Prints the body of the square
    /// </summary>
    /// <param name="length"></param>
    private static void PrintBody(int length)
    {
        Console.Write("-");
        for (int i = 0; i < length - 1; i++)
        {
            Console.Write("\\/");
        }
        Console.Write("-");
        Console.WriteLine();
    }

    /// <summary>
    /// Prints the footer of the square
    /// </summary>
    /// <param name="length">length of the row</param>
    private static void PrintFooter(int length)
    {
        Console.Write(new string('-', length * 2));
    }


}
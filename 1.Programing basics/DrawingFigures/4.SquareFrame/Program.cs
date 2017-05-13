using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.Write('+');
        Console.Write(' ');
        for (int j = 0; j < n - 2; j++)
        {
            Console.Write('-');
            Console.Write(' ');
        }
        Console.Write('+');
        Console.WriteLine();

        for (int i = 0; i < n - 2; i++)
        {
            Console.Write('|');
            Console.Write(' ');

            for (int j = 0; j < n - 2; j++)
            {
                Console.Write('-');
                Console.Write(' ');
            }
            Console.Write('|');
            Console.WriteLine();
        }

        Console.Write('+');
        Console.Write(' ');
        for (int j = 0; j < n - 2; j++)
        {
            Console.Write('-');
            Console.Write(' ');
        }
        Console.Write('+');
    }
}
using System;

class ChristmasTree
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int outerSpaces = n + 1;
        int stars = 1;

        Console.Write(new string(' ', outerSpaces));
        Console.Write('|');
        Console.Write(new string(' ', outerSpaces));
        Console.WriteLine();
        outerSpaces -= 2;

        for (int i = 0; i < n; i++)
        {
            Console.Write(new string(' ', outerSpaces));
            Console.Write(new string('*', stars));
            Console.Write(' ');
            Console.Write('|');
            Console.Write(' ');
            Console.Write(new string('*', stars)); 
            Console.Write(new string(' ', outerSpaces));
            Console.WriteLine();
            stars++;
            outerSpaces--;
        }
    }
}
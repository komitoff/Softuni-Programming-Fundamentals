using System;

class Diamond
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.Write(new string('.', n));
        Console.Write(new string('*', 3 * n));
        Console.Write(new string('.', n));
        Console.WriteLine();
        for (int i = 1; i < n; i++)
        {
            Console.Write(new string('.', n-i));
            Console.Write('*');
            Console.Write(new string('.', (3 * n)-(2 - (2*i))));
            Console.Write('*');
            Console.Write(new string('.', n - i));
            Console.WriteLine();
        }
        Console.Write(new string('*', 5*n));
        Console.WriteLine();

        for (int i = 0; i < 2*n ; i++)
        {
            Console.Write(new string('.', 1 + i));
            Console.Write('*');
            Console.Write(new string('.', (5*n - 4) - 2 * i));
            Console.Write('*');
            Console.Write(new string('.', i + 1));
            Console.WriteLine();
        }
        Console.Write(new string('.', (2 * n) + 1));
        Console.Write(new string('*', n - 2));
        Console.Write(new string('.', (2 * n) + 1));
    }

}

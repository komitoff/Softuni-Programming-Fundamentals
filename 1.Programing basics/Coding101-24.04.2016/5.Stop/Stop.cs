using System;

class Stop
{
    static void Main ()
    {

        int n = int.Parse(Console.ReadLine());

        Console.Write(new string('.', n + 1));
        Console.Write(new string('_', (2*n) + 1));
        Console.Write(new string('.', n + 1));
        Console.WriteLine();

        for (int i = 0; i < n; i++)
        {
            Console.Write(new string('.', n - i));
            Console.Write(new string('/', 2));
            Console.Write(new string('_', ((2 * n ) - 1) + 2 * i ));
            Console.Write(new string('\\', 2));
            Console.Write(new string('.', n - i));
            Console.WriteLine();
        }

        Console.Write(new string('/', 2));
        Console.Write(new string('_', (((4 * n) - 1) - 5) / 2));
        Console.Write("STOP!");
        Console.Write(new string('_', (((4 * n) - 1) - 5) / 2));
        Console.Write(new string('\\', 2));
        Console.WriteLine();

        for (int i = 0; i < n; i++)
        {
            Console.Write(new string('.', i));
            Console.Write(new string('\\', 2));
            Console.Write(new string('_', ((4*n) - 1) - 2*i));
            Console.Write(new string('/', 2));
            Console.Write(new string('.', i));
            Console.WriteLine();
        }
    }
}

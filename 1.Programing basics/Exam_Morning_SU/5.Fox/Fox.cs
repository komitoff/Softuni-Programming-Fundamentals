using System;

class Fox
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write(new string('*', 1 + i));
            Console.Write("\\");
            Console.Write(new string('-', ((2*n) - 1) - (i*2)));
            Console.Write("/");
            Console.Write(new string('*', 1 + i));
            Console.WriteLine();
        }

        for (int i = 0; i < n / 3; i++)
        {
            Console.Write("|");
            Console.Write(new string('*', ((n-1)/2) + i));
            Console.Write("\\");
            Console.Write(new string('*', n - (i*2)));
            Console.Write("/");
            Console.Write(new string('*', ((n - 1) / 2) + i));
            Console.Write("|");
            Console.WriteLine();
        }

        for (int i = 0; i < n; i++)
        {
            Console.Write(new string('-', 1 + i));
            Console.Write("\\");
            Console.Write(new string('*', ((2 * n) - 1) - (i * 2)));
            Console.Write("/");
            Console.Write(new string('-', 1 + i));
            Console.WriteLine();
        }
    }
}

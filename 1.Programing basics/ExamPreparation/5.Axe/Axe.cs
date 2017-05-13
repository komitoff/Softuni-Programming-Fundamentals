using System;

class Axe
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write(new string('-', 3 * n));
            Console.Write('*');
            Console.Write(new string('-', i));
            Console.Write('*');
            Console.Write(new string('-', ((2 * n) - 2) - i));
            Console.WriteLine();
        }

        for (int i = 0; i < n / 2; i++)
        {
            Console.Write(new string('*', 3 * n));
            Console.Write('*');
            Console.Write(new string('-', n - 1));
            Console.Write('*');
            Console.Write(new string('-', n - 1));
            Console.WriteLine();
        }

        for (int i = 0; i < n / 2; i++)
        {
            if (i == (n / 2) - 1)
            {
                Console.Write(new string('-', (3 * n) - i));
                Console.Write('*');
                Console.Write(new string('*', n - 1 + (2 * i)));
                Console.Write('*');
                Console.Write(new string('-', n - i - 1));
                Console.WriteLine();
            }
            else
            {
                Console.Write(new string('-', (3 * n) - i));
                Console.Write('*');
                Console.Write(new string('-', n - 1 + (2 * i)));
                Console.Write('*');
                Console.Write(new string('-', n - i - 1));
                Console.WriteLine();
            }


        }


    }
}

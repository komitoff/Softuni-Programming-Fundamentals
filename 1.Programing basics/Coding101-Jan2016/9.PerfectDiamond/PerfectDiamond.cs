using System;

class PerfectDiamond
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int spaces = n - 1;
        if (n == 1)
	    {
            Console.WriteLine("*");
	    }
        else
	    {
            Console.Write(new string(' ', spaces));
            Console.Write("*");
            Console.Write(new string(' ', spaces));
            Console.WriteLine();
            for (int i = 1; i < n; i++)
            {
                Console.Write(new string(' ', spaces - i));
                Console.Write("*");
                for (int j = 0; j < i; j++)
                {
                    Console.Write("-*");
                }

                Console.Write(new string(' ', spaces - i));
                Console.WriteLine();
            }
            spaces = 0;
            for (int i = 1; i < n - 1; i++)
            {
                Console.Write(new string(' ', spaces + i));
                Console.Write("*");
                for (int j = n - 2; j > i - 1; j--)
                {
                    Console.Write("-*");
                }

                Console.Write(new string(' ', spaces + i));
                Console.WriteLine();
            }

            Console.Write(new string(' ', n - 1));
            Console.Write("*");
            Console.Write(new string(' ', n - 1));
            Console.WriteLine();
        }
	    }
}

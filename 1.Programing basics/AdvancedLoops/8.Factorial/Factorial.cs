using System;

class Factorial
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(fact(n));
    }

    public static int fact(int n) 
    {
        if (n == 0)
        {
            return 1;
        }
        else if (n == 1)
        {
            return 1;
        }
        else
        {
            return fact(n - 1) * n;
        }
    }
}


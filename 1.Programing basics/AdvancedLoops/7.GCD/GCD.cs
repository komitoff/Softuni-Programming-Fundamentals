using System;

class GCD
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int gcd = greatestCommonDivisor(a, b);
        Console.WriteLine(gcd);

    }

    //using the recursive method
    public static int greatestCommonDivisor(int a, int b)
    {
        if (a == 0)
        {
            return b;
        }
        else if (b == 0)
        {
            return a;
        }
        else
        {
            if (a > b)
            {
                return greatestCommonDivisor(a % b, b);
            }
            else
            {
                return greatestCommonDivisor(a, b % a);
            }
        }
    }
}

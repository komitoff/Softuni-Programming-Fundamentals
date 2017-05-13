using System;

class SumOfDigits
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int tmp = 0;
        int sum = 0;

        while (n > 0)
        {
            tmp = n % 10;
            n /= 10;
            sum += tmp;
        }
        Console.WriteLine(sum);
    }
}
using System;

class PowerOfTwo
{
    static void Main(string[] args)
    {
        int power = int.Parse(Console.ReadLine());

        Console.WriteLine(1);
        for (int i = 1; i <= power; i++)
        {
            Console.WriteLine(Math.Pow(2, i));
        }
    }
}
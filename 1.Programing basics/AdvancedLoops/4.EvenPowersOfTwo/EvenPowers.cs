using System;

class EvenPowers
{
    static void Main(string[] args)
    {
        int power = int.Parse(Console.ReadLine());


        Console.WriteLine(1);
        for (int i = 2; i <= power; i+=2)
        {
            Console.WriteLine(Math.Pow(2, i));
        }

    }
}


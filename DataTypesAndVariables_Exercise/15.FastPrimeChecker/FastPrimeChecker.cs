using System;

class FastPrimeChecker
{
    static void Main()
    {
        //int ___Do___ = int.Parse(Console.ReadLine());
        //for (int DAVIDIM = 0; DAVIDIM <= ___Do___; DAVIDIM++)
        //{
        //    bool TowaLIE = true;
        //    for (int delio = 2; delio <= Math.Sqrt(DAVIDIM); delio++)
        //    {
        //        if (DAVIDIM % delio == 0)
        //        {
        //            TowaLIE = false;
        //            break;
        //        }
        //    }
        //    Console.WriteLine($"{DAVIDIM} is prime -> {TowaLIE}");
        //}
        Console.WriteLine();

        int length = int.Parse(Console.ReadLine());
        int counter = 0;
        for (int i = 2; i <= length; i++)
        {
            bool isPrime = false; 
            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                {
                    counter++;
                }
            }
            
            if (counter <= 2)
            {
                isPrime = true;
            }
            counter = 0;
            Console.WriteLine($"{i} -> {isPrime}");
        }

    }
}


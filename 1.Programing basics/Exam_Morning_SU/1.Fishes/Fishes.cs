using System;

class Fishes
{
    static void Main()
    {
        double skPrice = double.Parse(Console.ReadLine());
        double caPrice = double.Parse(Console.ReadLine());

        double p = double.Parse(Console.ReadLine());
        double s = double.Parse(Console.ReadLine());
        double m = double.Parse(Console.ReadLine());


        double mPrice = 7.5;
        double pPrice = 1.6 * skPrice;
        double sPrice = 1.8 * caPrice;

        double totalSum = pPrice * p + sPrice * s + mPrice * m;
        Console.WriteLine("{0:F2}", totalSum);
    }
}

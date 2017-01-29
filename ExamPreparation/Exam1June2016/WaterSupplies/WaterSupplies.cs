using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class WaterSupplies
{
    static void Main(string[] args)
    {
        decimal totalAmmount = decimal.Parse(Console.ReadLine());
        decimal[] bottles = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
        decimal bottleCapacity = decimal.Parse(Console.ReadLine());
        int length = bottles.Length;
        decimal totalWaterNeeded = 0;
        for (int i = 0; i < length; i++)
        {
            totalWaterNeeded += bottleCapacity - bottles[i];

        }

        if (totalAmmount > totalWaterNeeded)
        {
            Console.WriteLine("Enough water!");
            Console.WriteLine($"Water left: {totalAmmount - totalWaterNeeded}l.");
        }
    }
}
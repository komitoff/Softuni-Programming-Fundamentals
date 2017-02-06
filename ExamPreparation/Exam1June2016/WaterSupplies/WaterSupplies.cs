using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class WaterSupplies
{
    static void Main(string[] args)
    {
        double totalAmmount = double.Parse(Console.ReadLine());
        double[] bottles = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

        long[] filledBottles = new long[bottles.Length];
        List<long> indexes = new List<long>();

        long bottlesLeft = bottles.Length;
        double bottleCapacity = double.Parse(Console.ReadLine());
        long length = bottles.Length;
        double totalWaterNeeded = 0;
        double currentAmmount = totalAmmount;

        for (int i = 0; i < length; i++)
        {
            totalWaterNeeded += bottleCapacity - bottles[i];
            currentAmmount -= (bottleCapacity - bottles[i]);

            if (currentAmmount >= 0)
            {
                filledBottles[i] = 1;
                bottlesLeft--;
            }

        }

        if (totalAmmount % 2 == 0)
        {
            for (int i = 0; i < filledBottles.Length; i++)
            {
                if (filledBottles[i] == 0)
                {
                    indexes.Add(i);
                }
            }
        }
        else
        {
            for (int i = filledBottles.Length - 1;  i >= 0; i--)
            {
                if (filledBottles[i] == 0)
                {
                    indexes.Add(i);
                }
            }
        }
        
        
        if (totalAmmount >= totalWaterNeeded)
        {
            Console.WriteLine("Enough water!");
            Console.WriteLine($"Water left: {totalAmmount - totalWaterNeeded}l.");
        }
        else
        {
            Console.WriteLine("We need more water!");
            Console.WriteLine("Bottles left: {0}", bottlesLeft);
            Console.Write("With indexes: ");
            Console.Write(string.Join(", ", indexes));
            Console.WriteLine();
            Console.WriteLine("We need {0} more liters!", totalWaterNeeded - totalAmmount);
        }
    }
}
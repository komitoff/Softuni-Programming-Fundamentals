using System;

class IncreasingElements
{
    static void Main()
    {
        // 91 / 100 pts in judge

        int n = int.Parse(Console.ReadLine());

        int tmpCounter = 1;
        int finCounter = 1;
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }


        for (int i = 0; i < n - 1; i++)
        {
            if (numbers[i] < numbers[i + 1])
            {
                tmpCounter++;
                if (tmpCounter > finCounter)
                {
                    finCounter = tmpCounter;
                }
            }
            else
            {
                tmpCounter = 1;
            }
        }
        Console.WriteLine(finCounter);
    }
}

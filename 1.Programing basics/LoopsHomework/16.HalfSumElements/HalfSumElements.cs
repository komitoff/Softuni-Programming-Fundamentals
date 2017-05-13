using System;

class HalfSumElements
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] elements = new int[n];
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            elements[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(elements);
        Array.Reverse(elements);

        for (int i = 1; i < n; i++)
        {
            sum += elements[i];
        }

        if (sum == elements[0])
        {
            Console.WriteLine("Yes Sum = {0}", sum);
        }
        else
        {
            Console.WriteLine("No diff = {0}", Math.Abs(sum - elements[0]));
        }
    }
}
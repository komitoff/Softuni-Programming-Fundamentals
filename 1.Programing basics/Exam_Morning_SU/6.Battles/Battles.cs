using System;

class Battles
{
    static void Main()
    {
        int firstPlayer = int.Parse(Console.ReadLine());
        int secondPlayer = int.Parse(Console.ReadLine());
        int battles = int.Parse(Console.ReadLine());
        int cnt = 0;

        for (int i = 1; i <= firstPlayer; i++)
        {
            for (int j = 1; j <= secondPlayer; j++)
            {
                if (battles > cnt)
                {
                    cnt++;
                    Console.Write("({0} <-> {1}) ", i, j);
                }
            }
        }
    }
}

using System;

class PointInsideFigure
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        if (x >= 4 && x <= 10 && y >= -5 && y <= 3)
        {
            Console.WriteLine("in");
        }
        else
        {
            if (x >= 2 && x <= 4 && y >= -3 && y <= 1)
            {
                Console.WriteLine("in");
            }
            else if (x >= 10 && x <= 12 && y >= -3 && y <= 1 )
            {
                Console.WriteLine("in");
            }
            else
            {
                Console.WriteLine("out");
            }
        }
    }
}

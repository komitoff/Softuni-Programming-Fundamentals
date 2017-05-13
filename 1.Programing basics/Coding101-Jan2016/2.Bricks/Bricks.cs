using System;

class Bricks
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int w = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        int courses = x / (m * w);
        if (x % (m * w) != 0)
        {
            Console.WriteLine(courses + 1);
        }
        else
        {
            Console.WriteLine(courses);
        }
        
    }
}

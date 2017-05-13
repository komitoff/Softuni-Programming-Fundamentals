using System;

class PointOnSegment
{
    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int point = int.Parse(Console.ReadLine());

        if (first > second)
        {
            int tmp = first;
            first = second;
            second = tmp;
        }

        if (point >= first && point <= second)
        {
            Console.WriteLine("in");
            Console.WriteLine(Math.Min(point - first, second - point));
        }
        else if (point < first )
        {
            Console.WriteLine("out");
            Console.WriteLine(first - point);
        }
        else
        {
            Console.WriteLine("out");
            Console.WriteLine(point - second);
        }
    }
}

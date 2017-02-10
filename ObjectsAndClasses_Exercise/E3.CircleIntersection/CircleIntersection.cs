using System;
using System.Collections.Generic;
using System.Linq;

public class CircleIntersection
{
    static void Main()
    {
        double[] firstCircleInfo = Console.ReadLine().Split().Select(double.Parse).ToArray();
        double[] secondCircleInfo = Console.ReadLine().Split().Select(double.Parse).ToArray();

        Circle c1 = new Circle()
        {
            Radius = firstCircleInfo[2],
            Center = new Point()
            {
                X = firstCircleInfo[0],
                Y = firstCircleInfo[1]
            }
        };

        Circle c2 = new Circle()
        {
            Radius = secondCircleInfo[2],
            Center = new Point()
            {
                X = secondCircleInfo[0],
                Y = secondCircleInfo[1]
            }
        };

        if (c1.Intersect(c2))
            Console.WriteLine("Yes");
        else
            Console.WriteLine("No");

    }
}
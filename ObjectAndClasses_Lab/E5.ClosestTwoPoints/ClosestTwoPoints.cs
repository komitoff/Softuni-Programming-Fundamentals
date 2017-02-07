using System;
using System.Collections.Generic;
using System.Linq;

class ClosestTwoPoints
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Point[] points = new Point[n];

        for (int i = 0; i < n; i++)
        {
            string[] pointCoordinates = Console.ReadLine().Split();
            double x = double.Parse(pointCoordinates[0]);
            double y = double.Parse(pointCoordinates[1]);
            Point point = new Point
            {
                X = x,
                Y = y
            };
            points[i] = point;
        }
        Point[] bestTwoPoints = FindClosestTwoPoints(points);
        Console.WriteLine($"({bestTwoPoints[0].X}, {bestTwoPoints[0].Y})");
        Console.WriteLine($"({bestTwoPoints[1].X}, {bestTwoPoints[1].Y})");

    }

    public static Point[] FindClosestTwoPoints(Point[] pts)
    {
        double distance = 0;
        double shortestDistance = double.MaxValue;
        Point[] bestTwoPoits = new Point[2];
        for (int j = 0; j < pts.Length; j++)
        {
            for (int i = j + 1; i < pts.Length; i++)
            {
                var firstPoint = pts[j];
                var secondPoint = pts[i];
                var sideA = firstPoint.X - secondPoint.X;
                var sideB = firstPoint.Y - secondPoint.Y;
                distance = Math.Sqrt(Math.Abs((sideA * sideA) + (sideB * sideB)));
                if (distance < shortestDistance)
                {
                    shortestDistance = distance;
                    bestTwoPoits[0] = firstPoint;
                    bestTwoPoits[1] = secondPoint;
                }
            }
        }
        Console.WriteLine($"{shortestDistance:f3}");
        return bestTwoPoits;
    }
}
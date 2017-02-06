using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DistanceBetweenTwoPoints
{
    static void Main(string[] args)
    {
        int[] firstPointCoord = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] secondPointCoord = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Point firstPoint = new Point(firstPointCoord[0], firstPointCoord[1]);
        Point secondPoint = new Point(secondPointCoord[0], secondPointCoord[1]);

        Console.WriteLine($"{FindEucledianDistance(firstPoint, secondPoint):f3}");
    }

    public static double FindEucledianDistance(Point p1, Point p2)
    {
        double sideA = Math.Abs(p1.X - p2.X);
        double sideB = Math.Abs(p1.Y - p2.Y);
        double hypotenuse = Math.Sqrt((sideA*sideA) + (sideB*sideB));
        return hypotenuse;
    }
}

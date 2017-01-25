using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LongerLine
{

    static void Main(string[] args)
    {
        double point1X = double.Parse(Console.ReadLine());
        double point1Y = double.Parse(Console.ReadLine());
        double point2X = double.Parse(Console.ReadLine());
        double point2Y = double.Parse(Console.ReadLine());
        double point3x = double.Parse(Console.ReadLine());
        double point3Y = double.Parse(Console.ReadLine());
        double point4X = double.Parse(Console.ReadLine());
        double point4Y = double.Parse(Console.ReadLine());

        printLongerLine(point1X, point1Y, point2X, point2Y, point3x, point3Y, point4X, point4Y);
    }

    private static double lineLength (double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
    }


    private static double distanceToCenter(double x, double y)
    {
        return Math.Sqrt(Math.Pow((0 - x), 2) + Math.Pow((0 - y), 2));
    }


    static void printClosestPointFirst(double x1, double y1, double x2, double y2)
    {
        if (distanceToCenter(x1, y1) > distanceToCenter(x2, y2))
        {
            Console.Write("(" + x2 + ", " + y2 + ")");
            Console.WriteLine("(" + x1 + ", " + y1 + ")");
        }
        else
        {
            Console.Write("(" + x1 + ", " + y1 + ")");
            Console.WriteLine("(" + x2 + ", " + y2 + ")");
        }
    }


    private static void printLongerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
    {
        if (lineLength(x1, y1, x2, y2) >= lineLength(x3, y3, x4, y4))
        {
            printClosestPointFirst(x1, y1, x2, y2);
        }
        else if (lineLength(x1, y1, x2, y2) < lineLength(x3, y3, x4, y4))
        {
            printClosestPointFirst(x3, y3, x4, y4);
        }
    }



}


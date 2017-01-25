using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ClosestPointToCenter
{
    static void Main(string[] args)
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        ClosestPoint(x1, y1, x2, y2);
    }

    private static void ClosestPoint(double x1, double y1, double x2, double y2)
    {
        double line1 = Math.Abs((x1 * x1)) + Math.Abs((y1 * y1));
        double line2 = Math.Abs((x2 * x2)) + Math.Abs((y2 * y2));
        if (line1 <= line2)
        {
            Console.WriteLine($"({x1}, {y1})");
        }
        else
        {
            Console.WriteLine($"({x2}, {y2})");
        }
    }
}
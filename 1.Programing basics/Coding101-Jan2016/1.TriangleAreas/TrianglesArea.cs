using System;

class TrianglesArea
{
    static void Main()
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());
        double x3 = double.Parse(Console.ReadLine());
        double y3 = double.Parse(Console.ReadLine());

        double a = Math.Abs(x2 - x3);
        double ha = Math.Abs(y2 - y1);
        double s = (a * ha) / 2;
        Console.WriteLine(s);
    }
}

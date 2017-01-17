using System;

class CircleArea
{
    static void Main()
    {
        double radius = double.Parse(Console.ReadLine());

        double area = Math.PI * radius * radius;

        Console.WriteLine("{0:f12}", area);
    }
}

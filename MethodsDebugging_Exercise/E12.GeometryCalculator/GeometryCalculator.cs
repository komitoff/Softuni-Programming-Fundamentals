using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GeometryCalculator
{
    static void Main(string[] args)
    {
        string figure = Console.ReadLine();
        Console.WriteLine($"{CalculateArea(figure):F2}");
    }

    /// <summary>
    /// Returns the area of specific figure given by parameter
    /// </summary>
    /// <param name="figure">String parameter</param>
    /// <returns></returns>
    private static double CalculateArea(string figure)
    {
        switch (figure.ToLower())
        {
            case "triangle": return TriangleAreaCalc();
            case "square": return SquareAreaCalc();
            case "rectangle": return RectangleAreaCalc();
            case "circle": return CircleAreaCalc();
            default: return 0;
        }
    }

    /// <summary>
    /// Reads the radius parameter and returns the area of circle
    /// </summary>
    /// <returns></returns>
    private static double CircleAreaCalc()
    {
        double radius = double.Parse(Console.ReadLine());
        return Math.PI * radius * radius;
    }

    /// <summary>
    /// Reads the width and height and returns the area of rectangle
    /// </summary>
    /// <returns></returns>
    private static double RectangleAreaCalc()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        return width * height;
    }

    /// <summary>
    /// Reads the side length of square and returns its area
    /// </summary>
    /// <returns></returns>
    private static double SquareAreaCalc()
    {
        double side = double.Parse(Console.ReadLine());
        return side * side;
    }

    /// <summary>
    /// Reads the heght and side length and returns the area of triangle
    /// </summary>
    /// <returns></returns>
    private static double TriangleAreaCalc()
    {
        double side = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        return (side * height) / 2;
    }
}
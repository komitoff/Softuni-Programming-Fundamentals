using System;
using System.Linq;

class RectanglePosition
{
    static void Main()
    {
        int[] firstRectangleProps = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] secondRectangleProps = Console.ReadLine().Split().Select(int.Parse).ToArray();
        //read two rectangles {left, top, width, height} 
        Rectangle r1 = new Rectangle
        {
            Left = firstRectangleProps[0],
            Top = firstRectangleProps[1],
            Width = firstRectangleProps[2],
            Height = firstRectangleProps[3]
        };

        Rectangle r2 = new Rectangle
        {
            Left = secondRectangleProps[0],
            Top = secondRectangleProps[1],
            Width = secondRectangleProps[2],
            Height = secondRectangleProps[3]
        };

        Console.WriteLine(r1.IsInside(r2) ? "Inside" : "Not inside");
    }
}
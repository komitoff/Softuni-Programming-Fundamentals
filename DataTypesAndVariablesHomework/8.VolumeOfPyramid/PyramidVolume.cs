using System;

class PyramidVolume
{
    static void Main()
    {
        double length = 0;
        double height = 0;
        double width = 0;
        double volume = 0;
        Console.Write("Length: ");
        length = double.Parse(Console.ReadLine());
        Console.Write("Width: ");
        width = double.Parse(Console.ReadLine());
        Console.Write("Height: ");
        height = double.Parse(Console.ReadLine());
        volume = (length + height + width) / 3;
        Console.WriteLine("Pyramid Volume: {0:F2}", volume);

    }
}

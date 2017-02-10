using System;

public class Circle
{
    internal Point p;

    public Point Center { get; set; }
    public double Radius { get; set; }

    public bool Intersect( Circle c2)
    {
        double sideA = Math.Abs(this.Center.X - c2.Center.X);
        double sideB = Math.Abs(this.Center.Y - c2.Center.Y);
        double distance = Math.Sqrt((sideA * sideA) + (sideB * sideB));
        if (distance <= (this.Radius + c2.Radius))
        {
            return true;
        }
        return false;
    }
}
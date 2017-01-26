using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CubeProperties
{
    static void Main(string[] args)
    {
        double side = double.Parse(Console.ReadLine());
        string operation = Console.ReadLine();
        Console.WriteLine($"{CalculateCubeProp(side, operation):f2}");
        
    }

    /// <summary>
    /// Checks the need operation and calls the need method to calculate it
    /// </summary>
    /// <param name="side">Side of the Cube - Double parameter</param>
    /// <param name="prop">The specific property</param>
    /// <returns></returns>
    private static double CalculateCubeProp(double side, string prop)
    {
        switch (prop.ToLower())
        {
            case "face": return CalculateFace(side);
            case "space": return CalculateSpace(side);
            case "volume": return CalculateVolume(side); 
            case "area": return CalculateArea(side);
            default: return 0; 
        }
    }

    /// <summary>
    /// Returns the Surface Area of the cube
    /// </summary>
    /// <param name="side">Double parameter</param>
    /// <returns></returns>
    private static double CalculateArea(double side)
    {
        return 6 * (side * side);
    }

    /// <summary>
    /// Returns the volume of the cube
    /// </summary>
    /// <param name="side">Double parameter</param>
    /// <returns></returns>
    private static double CalculateVolume(double side)
    {
        return side * side * side;
    }

    /// <summary>
    /// Returns the length of the Space Diagonal of the cube
    /// </summary>
    /// <param name="side">Double parameter</param>
    /// <returns></returns>
    private static double CalculateSpace(double side)
    {
        return Math.Sqrt(3 * side * side);
    }

    /// <summary>
    /// Returns the length of the face diagonal 
    /// </summary>
    /// <param name="side">Double parameter</param>
    /// <returns></returns>
    private static double CalculateFace(double side)
    {
        return Math.Sqrt(2 * side * side);
    }
}
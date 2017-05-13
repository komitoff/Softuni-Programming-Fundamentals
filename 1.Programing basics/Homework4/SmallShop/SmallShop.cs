using System;

class SmallShop
{
    static void Main(string[] args)
    {
        string product = Console.ReadLine();
        string town = Console.ReadLine();
        
        double amount = double.Parse(Console.ReadLine());

        if (town == "Sofia")
        {
            if (product == "coffee") Console.WriteLine(0.50 * amount);
            else if (product == "water") Console.WriteLine(0.80 * amount);
            else if (product == "beer") Console.WriteLine(1.20 * amount);
            else if (product == "sweets") Console.WriteLine(1.45 * amount);
            else Console.WriteLine(1.6 * amount);
        }
        else if (town == "Plovdiv")
        {
            if (product == "coffee") Console.WriteLine(0.40 * amount);
            else if (product == "water") Console.WriteLine(0.70 * amount);
            else if (product == "beer") Console.WriteLine(1.15 * amount);
            else if (product == "sweets") Console.WriteLine(1.30 * amount);
            else Console.WriteLine(1.50 * amount);
        }
        else if (town == "Varna")
        {
            if (product == "coffee") Console.WriteLine(0.45 * amount);
            else if (product == "water") Console.WriteLine(0.70 * amount);
            else if (product == "beer") Console.WriteLine(1.10 * amount);
            else if (product == "sweets") Console.WriteLine(1.35 * amount);
            else Console.WriteLine(1.55 * amount);
        }
    }
}

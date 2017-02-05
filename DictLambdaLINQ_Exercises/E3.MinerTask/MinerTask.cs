using System;
using System.Collections.Generic;
using System.Linq;

class MinerTask
{
    static void Main()
    {
        string material = Console.ReadLine();
        long quantity = 0;
        Dictionary<string, long> priceCatalog = new Dictionary<string, long>();

        while (!material.Equals("stop"))
        {
            quantity = long.Parse(Console.ReadLine());
            if (!priceCatalog.ContainsKey(material))
            {
                priceCatalog.Add(material, 0);
            }
            priceCatalog[material] += quantity;

            material = Console.ReadLine();
        }

        foreach (var item in priceCatalog)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }
    }
}
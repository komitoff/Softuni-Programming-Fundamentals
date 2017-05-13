using System;

class FruitOrVegetable
{
    static void Main()
    {
        string input = Console.ReadLine();

        // banana, apple, kiwi, cherry, lemon, grapes
        if (input == "banana" || input == "kiwi" || input == "apple" || input == "cherry" || input == "lemon" || input == "grapes")
        {
            Console.WriteLine("fruit");
        }
        // tomato, cucumber, pepper, carrot
        else if (input == "tomato" || input == "cucumber" || input == "pepper" || input == "carrot")
        {
            Console.WriteLine("vegetable");
        }
        else
        {
            Console.WriteLine("unknown");
        }
    }
}

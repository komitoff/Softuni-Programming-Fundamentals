using System;

class Pets
{
    static void Main()
    {
        double days = double.Parse(Console.ReadLine());
        double leftFood = double.Parse(Console.ReadLine());
        double dogFoodPerDay = double.Parse(Console.ReadLine());
        double catFoodPerDay = double.Parse(Console.ReadLine());
        double turtleFoodPerDay = double.Parse(Console.ReadLine());

        double totalDogFood = days * dogFoodPerDay;
        double totlaCatFood = days * catFoodPerDay;
        double totalTurtleFood = days * (turtleFoodPerDay / 1000);

        double totalFood = totalDogFood + totlaCatFood + totalTurtleFood;

        if (leftFood >= totalFood)
        {
            int odd = (int)(leftFood - totalFood);
            Console.WriteLine("{0} kilos of food left.", odd);
        }
        else
        {
            double odd = Math.Ceiling(totalFood - leftFood);
            Console.WriteLine("{0} more kilos of food are needed.", odd);
        }

    }
}

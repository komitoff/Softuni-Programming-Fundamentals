using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tests
{
    class Program
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
                double tmp = totalFood - leftFood + 0.5;
                double odd = Math.Round(tmp);
                Console.WriteLine("{0} more kilos of food are needed.", odd);
            }

        }
       
    }
}

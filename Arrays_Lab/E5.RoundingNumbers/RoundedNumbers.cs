using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RoundedNumbers
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        double [] numbers = new double[input.Length];
        int [] roundNumbers = new int[numbers.Length];
        for (int i = 0; i < input.Length; i++)
        {
            numbers[i] = double.Parse(input[i]);
            roundNumbers[i] = (int)Math.Round(numbers[i], MidpointRounding.AwayFromZero);
            Console.WriteLine($"{numbers[i]} => {roundNumbers[i]}");
        }


    }
}
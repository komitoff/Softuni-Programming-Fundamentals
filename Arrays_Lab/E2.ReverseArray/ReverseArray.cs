using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReverseArray
{
    static void Main(string[] args)
    {
        int length = int.Parse(Console.ReadLine());
        int [] array = new int [length];
        for (int i = 0; i < length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = length - 1; i >= 0; i--)
        {
            Console.WriteLine(array[i] + " ");
        }
    }
}
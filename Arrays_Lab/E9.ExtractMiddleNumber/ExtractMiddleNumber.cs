using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ExtractMiddleNumber
{
    static void Main(string[] args)
    {
        string[] seq = Console.ReadLine().Split(' ');
        var length = seq.Length;
        int[] numbers = new int[length];
        for (int i = 0; i < length; i++)
        {
            numbers[i] = int.Parse(seq[i]);
        }

        if (length == 1)
        {
            Console.WriteLine("{ " + numbers[0] + " }");
        }
        else if (length % 2 == 0)
        {
            Console.WriteLine("{ " + numbers[length/2 - 1] + " }");
            Console.WriteLine("{ " + numbers[length / 2] + " }");
        }
        else
        {
            Console.WriteLine("{ " + numbers[length / 2 - 1] + " }");
            Console.WriteLine("{ " + numbers[length / 2] + " }");
            Console.WriteLine("{ " + numbers[length / 2 + 1] + " }");
        }
    }
}
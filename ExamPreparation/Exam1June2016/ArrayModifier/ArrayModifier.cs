using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ArrayModifier
{
    static void Main(string[] args)
    {
        long[] array = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

        int length = array.Length;
        string cmd = Console.ReadLine().ToLower();
        while (!cmd.Equals("end"))
        {
            if (cmd.Equals("decrease"))
            {
                Decrease(array);
            }
            else
            {
                string[] instructions = cmd.Split(' ');
                string command = instructions[0];
                int index1 = int.Parse(instructions[1]);
                int index2 = int.Parse(instructions[2]);

                if (command.Equals("swap"))
                {
                    Swap(index1, index2, array);
                }
                else if (command.Equals("multiply"))
                {
                    Multiply(index1, index2, array);
                }
            }

            cmd = Console.ReadLine().ToLower();
        }

        Print(array);

    }

    private static void Print(long[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            Console.Write(array[i] + ", ");
        }
        Console.Write(array[array.Length - 1]);
    }

    private static void Decrease(long[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i]--;
        }
    }

    private static void Multiply(int index1, int index2, long[] array)
    {
        long tmp = array[index1] * array[index2];
        array[index1] = tmp;
    }

    private static void Swap(int index1, int index2, long[] array)
    {
        long tmp = array[index1];
        array[index1] = array[index2];
        array[index2] = tmp;
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int leftSpaces = n - 1;
        int rightSpaces = n - 1;
        int innerSpaces = 0;


        //drawing first row
        Console.Write(new string(' ', leftSpaces));
        Console.Write('*');
        Console.Write(new string(' ', rightSpaces));
        Console.WriteLine();

        //drawing inner rows upper part
        for (int i = 0; i < n - 1; i++)
        {
            Console.Write(new string(' ',n-2-i));
            Console.Write('*');
            for (int k = 0; k <= i; k++)
            { 
                                               
                Console.Write(' ');
                Console.Write('*');   
            }
            Console.Write(new string(' ', n - 2));
            Console.WriteLine();
        }

        //drawing inner rows bottom part
        for (int i = n - 2; i > 0; i--)
        {
            Console.Write(new string(' ',n-1-i));
            Console.Write('*');
            for (int k = 0; k < i; k++)
            {                                 
                Console.Write(' ');
                Console.Write('*');   
            }
            Console.Write(new string(' ', n - 2));
            Console.WriteLine();
        }

        if (n > 1)
        {
            //drawing last row    (same like first one)
            Console.Write(new string(' ', leftSpaces));
            Console.Write('*');
            Console.Write(new string(' ', rightSpaces));
        }

    }
}
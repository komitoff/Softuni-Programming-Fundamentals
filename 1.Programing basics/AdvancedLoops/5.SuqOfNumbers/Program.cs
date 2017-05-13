using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int actual = 0;
        int prev = 1;
        while (prev <= n)
        {
	        actual = (prev * 2) + 1;
            Console.WriteLine(prev);
            prev = actual;  
        }
    }
}

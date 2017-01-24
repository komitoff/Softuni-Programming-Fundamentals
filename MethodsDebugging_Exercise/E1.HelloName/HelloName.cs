using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HelloName
{
    static void Main(string[] args)
    {
        string name = Console.ReadLine();
        Hello(name);
    }

    /// <summary>
    /// Prints out the input string to the console
    /// </summary>
    /// <param name="name"></param>
    private static void Hello(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }
}
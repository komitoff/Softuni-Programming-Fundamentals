using System;

class BooleanVariables
{
    static void Main()
    {
        String input = Console.ReadLine();
        bool result = Convert.ToBoolean(input);
        if (result) { Console.WriteLine("Yes"); }
        else { Console.WriteLine("No");  }
    }
}

using System;

class Greetings
{
    static void Main()
    {
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        string age = Console.ReadLine();

        //For some reasong using $ infront of the string does not work
        //possible reason - using visual studio 2013
        Console.WriteLine("Hello, {0} {1}.\r\n You are {2} years old.",firstName, lastName, age);
    }
}

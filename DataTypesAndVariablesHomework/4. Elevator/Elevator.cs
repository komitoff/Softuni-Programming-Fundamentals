using System;

class Elevator
{
    static void Main()
    {
        int numberOfPeople = int.Parse(Console.ReadLine());
        int capacity = int.Parse(Console.ReadLine());
        int courses = 0;

        if (capacity >= numberOfPeople)
        {
            Console.WriteLine(1);
        }
        else if (numberOfPeople % capacity == 0)
        {
            courses = numberOfPeople / capacity;

            Console.WriteLine(courses);
        }
        else
        {
            courses = numberOfPeople / capacity + 1;
            Console.WriteLine(courses);
        }
    }
}

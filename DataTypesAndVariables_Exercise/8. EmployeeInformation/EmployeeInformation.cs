using System;

class EmployeeInformation
{
    static void Main()
    {
        //First name: Amanda
        //Last name: Jonson
        //Age: 27
        //Gender: f
        //Personal ID: 8306112507
        //Unique Employee number: 27563571

        string firstName = "Amanda";
        string lastName = "Jonson";
        short age = 27;
        char gender = 'f';
        long personalID = 8306112507;
        long uniqueEmployeeNumber = 27563571;

        Console.WriteLine("First name: " + firstName);
        Console.WriteLine("Last name: " + lastName);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Gender: " + gender);
        Console.WriteLine("Personal ID: " + personalID);
        Console.WriteLine("Unique Employee number: " + uniqueEmployeeNumber);

    }
}
using System;
using System.Collections.Generic;
using System.Linq;

class PhoneBook
{
    static void Main()
    {
        string cmdLine = Console.ReadLine();
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();
        while (!cmdLine.Equals("END"))
        {
            string[] data = cmdLine.Split(' ');
            if (data[0].Equals("A"))
            {
                AddContact(data[1], data[2], phoneBook);
            }
            if (data[0].Equals("S"))
            {
                SearchContact(data[1], phoneBook);
            }
            cmdLine = Console.ReadLine();
        }
    }

    private static void AddContact(string name, string phoneNumber, Dictionary<string, string> phoneBook)
    {
        if (!phoneBook.ContainsKey(name))
        {
            phoneBook.Add(name, null);
        }
        phoneBook[name] = phoneNumber;
    }

    private static void SearchContact(string name, Dictionary<string, string> phoneBook)
    {
        if (phoneBook.ContainsKey(name))
        {
            Console.WriteLine($"{name} -> {phoneBook[name]}");
        }
        else
        {
            Console.WriteLine($"Contact {name} does not exist.");
        }
    }
}
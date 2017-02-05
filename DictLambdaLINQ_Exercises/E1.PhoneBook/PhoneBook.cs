using System;
using System.Collections.Generic;
using System.Linq;

class PhoneBook
{
    static void Main()
    {
        string cmdLine = Console.ReadLine();
        SortedDictionary<string, string> phoneBook = new SortedDictionary<string, string>();
        while (!cmdLine.Equals("END"))
        {
            string[] data = cmdLine.Split(' ');
            if (data[0].Equals("ListAll"))
            {
                ListAll(phoneBook);
            }
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

    private static void ListAll(SortedDictionary<string, string> phoneBook)
    {
        foreach (var contact in phoneBook)
        {
            Console.WriteLine($"{contact.Key} -> {contact.Value}");
        }
    }

    private static void AddContact(string name, string phoneNumber, SortedDictionary<string, string> phoneBook)
    {
        if (!phoneBook.ContainsKey(name))
        {
            phoneBook.Add(name, null);
        }
        phoneBook[name] = phoneNumber;
    }

    private static void SearchContact(string name, SortedDictionary<string, string> phoneBook)
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
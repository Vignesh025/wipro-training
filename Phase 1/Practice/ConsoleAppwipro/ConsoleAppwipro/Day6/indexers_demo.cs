//using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        var phoneBook = new PhoneBook();

//        // Adding entries to the phone book
//        phoneBook["Alice"] = "123-456-7890";
//        phoneBook["Bob"] = "987-654-3210";
//        phoneBook["Charlie"] = "555-123-4567";

//        // Accessing phone numbers using the indexer
//        Console.WriteLine($"Alice's phone number: {phoneBook["Alice"]}");
//        Console.WriteLine($"Bob's phone number: {phoneBook["Bob"]}");
//        Console.WriteLine($"Charlie's phone number: {phoneBook["Charlie"]}");

//        // Trying to access a non-existent entry
//        Console.WriteLine($"Dave's phone number: {phoneBook["Dave"] ?? "Not found"}");
//    }
//}

//class PhoneBook
//{
//    private Dictionary<string, string> phoneNumbers = new Dictionary<string, string>();

//    // Indexer definition
//    public string this[string name]
//    {
//        get
//        {
//            if (phoneNumbers.TryGetValue(name, out string phoneNumber))
//            {
//                return phoneNumber;
//            }
//            else
//            {
//                return null; // Return null if the name is not found
//            }
//        }
//        set
//        {
//            phoneNumbers[name] = value;
//        }
//    }
//}

using Spectre.Console;
using System;

namespace Contacts_aplication
{
    class Program
    {      
        static void Main(string[] args)
        {
        AddContact addContact = new AddContact();
            Display display = new Display();
            Console.WriteLine("Add Contact");
            Console.WriteLine("Remove Contact");
            Console.WriteLine("Display all Contacts");
            Console.WriteLine("Search Contact");

            var userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    addContact.AddContacts();
                    break;
                case "2":
                    display.DisplayContact(name);
                    break;
                case "3":
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("Incorrect choice");
                    break;
            }
        }
    }
}

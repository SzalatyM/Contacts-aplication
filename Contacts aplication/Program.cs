
using Spectre.Console;
using System;

namespace Contacts_aplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            do
            {


                string command = AnsiConsole.Prompt(
                        new SelectionPrompt<string>()
                            .Title("\nContacts: ")
                            .AddChoices("Add Contact", "Remove Contact", "Display all Contacts", "Search Contact"));
                Commands.Command(command);
                Console.WriteLine();
                userInput = Console.ReadLine();
            }
            while (userInput != "exit");
        }
    }
}
        
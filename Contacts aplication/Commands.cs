using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts_aplication
{
    class Commands
    {
        private static AddContact addContact;     // ? ?
        public static void Command(string userInput)
        {
            switch (userInput)
            {
                case "1":
                    AddContact.AddContacts();
                    break;
                case "2":
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

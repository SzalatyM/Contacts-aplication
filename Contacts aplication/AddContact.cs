using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts_aplication
{
    class AddContact 
    {
        public static void AddContacts() // static?  ? ? 
        {
            List<Contact> contacts = new List<Contact>();
            Console.WriteLine("Insert name");
            var userName = Console.ReadLine();
            Console.WriteLine("Instert number");
            var userNumber = Console.ReadLine();
            int number;                                             
            if(!(int.TryParse(userNumber, out number)) && userNumber.Length == 9)
            {
                Console.WriteLine("Wrong number. Type a correct number.");
                return;
            }
            Console.WriteLine("Insert a note (max 50 signs)");
            var note = Console.ReadLine();
            if(note.Length > 50)
            {
                Console.WriteLine("The number of characters has been exceeded.");
            }
            var newContact = new Contact(userName,number,note);
            contacts.Add(newContact);
            Console.WriteLine("____________________________");
            Console.WriteLine($"\nYou added a new constact. \n Name: {userName} \n Number: {userNumber} \n Note: {note}");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts_aplication
{
    class AddContact 
    {
        List<Contact> contacts = new List<Contact>();
        public void AddContacts()
        {
            Console.WriteLine("Insert name");
            var name = Console.ReadLine();
            Console.WriteLine("Instert number");
            var number = int.Parse(Console.ReadLine());
            if (number < 9)
            {
                Console.WriteLine("Insert correct number");
                return;
            }
        
            Console.WriteLine("Insert a note (max 50 signs)");
            var note = Console.ReadLine();
            if(note.Length > 50)
            {
                Console.WriteLine("The number of characters has been exceeded.");
            }
            var newContact = new Contact(name,number,note);
            contacts.Add(newContact);
        }

    }
}

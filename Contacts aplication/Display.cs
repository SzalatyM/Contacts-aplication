using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contacts_aplication
{
    class Display
    {
        List<Contact> contacts;
        public void DisplayContact(string name)
        {
            Console.WriteLine("Insert name to find");           
            var contact = contacts.FirstOrDefault(c => c.name == name);
            if (contact == null)
            {
                Console.WriteLine("Contact not found");
            }
            else
            {
                Console.WriteLine(contact.name);
            }
        }
    }
}

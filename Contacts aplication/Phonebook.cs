using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contacts_aplication
{
    class Phonebook
    {
        List<Contact> constacts { get; set; }

        public void AddContact(Contact contact)
        {
            constacts.Add(contact);
        }
        public void DeleteContact(Contact contact)
        {
            constacts.Remove(contact);
        }
        public void AddNoteToContact(string text)
        {
            
        }
        public void RemoveNote()
        {

        }
        public void DisplayContact(string name)
        {
            var contact = constacts.FirstOrDefault(c => c.name == name);

            if(contact == null)
            {
                Console.WriteLine("Contact not found");
            }
            else
            {
                Console.WriteLine($"Name: \n{contact.name}, Number \n{contact.number}, Note \n{contact.note} ");
            }          
        }
        public void DisplayAllContacts()
        {
            foreach (Contact display in constacts )
            {
                Console.WriteLine(display);
            }
        }
    }
}

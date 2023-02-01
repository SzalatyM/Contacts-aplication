using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contacts_aplication
{
    class Phonebook
    {
<<<<<<< HEAD
        List<Contact> constacts { get; set; } 
=======
       public List<Contact> constacts { get; set; } = new List<Contact>();
>>>>>>> 65c9ed6bdd7e506e0a2308cc7c36eb9edfd62ce2


        public void DisplayDetails(Contact contact)
        {
            Console.WriteLine($"Name: \n{contact.name}, Number \n{contact.number}, Note \n{contact.note} ");
        }
        public void DeleteContact(Contact contact)
        {
            constacts.Remove(contact);
        }

        public void DisplayAllContacts()
        {
            foreach (var display in constacts )
            {
                DisplayDetails(display);
            }
        }
        public void DisplayUserInputContact(string input)
        {
            var userInput = constacts.Where(c => c.name.Contains(input)).ToList();
            foreach (var contact in userInput)
            {
                DisplayDetails(contact);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contacts_aplication
{
    class Phonebook
    {
       public List<Contact> constacts { get; set; } = new List<Contact>();


        public void DisplayDetails(Contact contact)
        {
            Console.WriteLine($"Name: \n{contact.name}, Number \n{contact.number}, Note \n{contact.note} ");
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

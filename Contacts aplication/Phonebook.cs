using System;
using System.Collections.Generic;
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
        public void 
    }
}

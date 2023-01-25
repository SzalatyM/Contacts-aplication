using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts_aplication
{
    class Contact
    {
        public Contact(string Name, int Number, string Note)
        {
            name = Name;
            number = Number;
            note = Note;
        }
        public string name { get; set; }
       public int number { get; set; }
       public string note { get; set; }
    }
}

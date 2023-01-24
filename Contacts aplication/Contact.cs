using System;
using System.Collections.Generic;
using System.Text;

namespace Contacts_aplication
{
    class Contact
    {
        public Contact(string Name, string Number, string Note)
        {
            name = Name;
            number = Number;
            note = Note;
        }
        public string name { get; set; }
       public string number { get; set; }
       public string note { get; set; }
    }
}

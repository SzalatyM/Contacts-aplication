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
        string name { get; set; }
        string number { get; set; }
        string note { get; set; }
    }
}

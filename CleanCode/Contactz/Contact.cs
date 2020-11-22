using System;

namespace Contactz
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Contact(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
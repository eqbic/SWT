using System;
using System.Collections.Generic;
using System.Linq;

namespace Contactz
{
    public abstract class MenuBase
    {
        protected List<Contact> contacts;

        public MenuBase(List<Contact> contacts)
        {
            this.contacts = contacts.OrderBy(contact => contact.FirstName).ToList<Contact>();
        }

        public abstract void Show();
        public abstract MenuBase SwitchMenu(ConsoleKey input);
    }
}
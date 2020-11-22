using System;
using System.Collections.Generic;

namespace Contactz
{
    public class AddContactMenu : MenuBase
    {
        public AddContactMenu(List<Contact> contacts) : base(contacts)
        {
        }

        private string firstName;
        private string lastName;
        public override void Show()
        {
            Console.Clear();
            Console.WriteLine("Firstname:");
            firstName = Console.ReadLine();
            Console.WriteLine("Lastname:");
            lastName = Console.ReadLine();
            Console.WriteLine("Save contact? (y/n)");
        }

        public override MenuBase SwitchMenu(ConsoleKey input)
        {
            switch (input)
            {
                case ConsoleKey.Y:
                    var newContact = new Contact(firstName, lastName);
                    contacts.Add(newContact);
                    return new ContactsMenu(contacts);
                case ConsoleKey.N:
                    return new ContactsMenu(contacts);
                default:
                    return this;
            }
        }
    }
}
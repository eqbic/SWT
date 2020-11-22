using System;
using System.Collections.Generic;

namespace Contactz
{
    public class ContactsMenu : MenuBase
    {
        public ContactsMenu(List<Contact> contacts) : base(contacts)
        {
        }

        public override void Show()
        {
            Console.Clear();
            foreach (var contact in contacts)
            {
                Console.WriteLine($"Firstname: {contact.FirstName}");
                Console.WriteLine($"Lastname: {contact.LastName}");
                Console.WriteLine("-------------------------------------");
            }
            Console.WriteLine("Press ESC to get back to main menu!");
        }

        public override MenuBase SwitchMenu(ConsoleKey input)
        {
            if (input == ConsoleKey.Escape)
            {
                return new MainMenu(contacts);
            }
            else
            {
                return this;
            }
        }
    }
}
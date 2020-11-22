using System;
using System.Collections.Generic;
using System.Linq;
namespace Contactz
{
    public class ContactsMenu : MenuBase
    {
        public ContactsMenu(Dictionary<Guid,Contact> contacts) : base(contacts)
        {
        }

        public override void Show()
        {
            var orderedContacts = contacts.Values.OrderBy(contact => contact.FirstName);   
            Console.Clear();
            foreach (var contact in orderedContacts)
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
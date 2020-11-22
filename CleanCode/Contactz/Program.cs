using System;
using System.Collections.Generic;

namespace Contactz
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contact> contacts = CreateRandomContacts(5);
            MenuBase menu = new MainMenu(contacts);

            while (true)
            {
                menu.Show();
                var input = GetInput();
                menu = menu.SwitchMenu(input);
            }
        }

        static ConsoleKey GetInput()
        {
            return Console.ReadKey().Key;
        }

        static List<Contact> CreateRandomContacts(int numberOfContacts)
        {
            var contacts = new List<Contact>();

            Random random = new Random();

            string[] firstNames = { "Max", "Anna", "Maria", "Tim", "Susi", "Alex", "Tino", "Lisa" };
            string[] lastNames = { "Jensen", "Muller", "Obermaier", "Brant", "Stevens", "Doe", "Timmons" };
            
            for (int i = 0; i < numberOfContacts; i++)
            {
                var firstNameIndex = random.Next(firstNames.Length);
                var lastNameIndex = random.Next(lastNames.Length);
                var contact = new Contact(firstNames[firstNameIndex], lastNames[lastNameIndex]);
                contacts.Add(contact);
            }

            return contacts;
        }
    }
}

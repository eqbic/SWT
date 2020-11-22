﻿using System;
using System.Collections.Generic;

namespace Contactz
{
    class Program
    {
        static void Main(string[] args)
        {
            const int numberOfRandomContacts = 5;
            Dictionary<Guid,Contact> contacts = CreateRandomContacts(numberOfRandomContacts);
            MenuBase currentMenu = new MainMenu(contacts);

            while (true)
            {
                currentMenu.Show();
                var input = GetInput();
                currentMenu = currentMenu.SwitchMenu(input);
            }
        }

        static ConsoleKey GetInput()
        {
            return Console.ReadKey().Key;
        }

        static Dictionary<Guid,Contact> CreateRandomContacts(int numberOfContacts)
        {
            var contacts = new Dictionary<Guid,Contact>();

            Random random = new Random();

            string[] firstNames = { "Max", "Anna", "Maria", "Tim", "Susi", "Alex", "Tino", "Lisa" };
            string[] lastNames = { "Jensen", "Muller", "Obermaier", "Brant", "Stevens", "Doe", "Timmons" };
            
            for (int i = 0; i < numberOfContacts; i++)
            {
                var firstNameIndex = random.Next(firstNames.Length);
                var lastNameIndex = random.Next(lastNames.Length);
                var contact = new Contact(firstNames[firstNameIndex], lastNames[lastNameIndex]);
                contacts.Add(contact.Id, contact);
            }

            return contacts;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneBook
{
    class ContactManager
    {
        List<Contact> contacts = new List<Contact>();
        private List<Contact> Contacts { get => contacts; set => contacts = value; }
        public ContactManager(List<Contact> contacts)
        {
            Contacts = contacts;
        }
        ConsoleUI consoleUI = new ConsoleUI();

        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
            Console.WriteLine("Kayıt ekleme işlemi gerçekleştirildi.");
        }
        public void DeleteContact(int indice)
        {
            contacts.RemoveAt(indice);
            consoleUI.ShowActionResult("Silme İşlemi Başarıyla Gerçekleşti.");
        }
        public void ListTheContacts(SortingType type)
        {
            Console.WriteLine("************* Kişiler ****************");
            contacts.Sort((c1, c2) => c1.Name.CompareTo(c2.Name));

            if (type == SortingType.descending)
            {
                contacts.Reverse();
            }

            Console.WriteLine();
            foreach (Contact contact in contacts)
            {
                ShowContact(contact);
            }
        }
        public void UpdatePhoneNumber(string newPhoneNumber, short indice)
        {
            contacts[indice].PhoneNumber = newPhoneNumber;
            consoleUI.ShowActionResult("Güncelleme İşlemi Başarıyla Gerçekleşti.");
        }
        public void ShowContact(Contact contact)
        {
            Console.WriteLine("   İsim: " + contact.Name);
            Console.WriteLine("   Soyisim: " + contact.Surname);
            Console.WriteLine("   Telefon numarası: " + contact.PhoneNumber);
            Console.WriteLine();
        }
        public void FindByNameOrSurname(string input)
        {
            bool hasContact = false;
            foreach (Contact contact in contacts)
            {
                if (input == contact.Name || input == contact.Surname)
                {
                    ShowContact(contact);
                    hasContact = true;
                }
            }

            if (!hasContact)
            {
                consoleUI.ShowActionResult("Aradığınız ifadeyle eşleşen sonuç bulunamamıştır.");
            }
        }
        public void FindByPhoneNumber(string phoneNumber)
        {
            bool hasContact = false;
            foreach (Contact contact in contacts)
            {
                if (phoneNumber == contact.PhoneNumber)
                {
                    ShowContact(contact);
                    hasContact = true;
                }
            }

            if (!hasContact)
            {
                consoleUI.ShowActionResult("Aradığınız ifadeyle eşleşen sonuç bulunamamıştır.");
            }

        }
        public bool HasThePhoneNumber(string input, out short indice)
        {
            bool control = false;
            foreach (Contact contact in contacts)
            {
                if (contact.Name.Equals(input) || contact.Surname.Equals(input))
                {
                    indice = (short)contacts.IndexOf(contact);
                    control= true;
                }
            }
            indice = 1;
            return control;
        }
       public enum SortingType
        {
            ascending,
            descending
        }
    }
}

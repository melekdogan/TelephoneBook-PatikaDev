using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneBook
{
    class Contact
    {
        private string phoneNumber;
        private string name;
        private string surname;



        public Contact(string name, string surname, string phoneNumber)
        {
            PhoneNumber = phoneNumber;
            this.name = name;
            this.surname = surname;
        }
        public Contact() { }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }

    }
}

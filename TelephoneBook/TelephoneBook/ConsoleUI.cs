using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneBook
{
    class ConsoleUI
    {
        public void ShowMainMenu()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak﻿");
            Console.WriteLine("(6).Sonlandır");
            Console.WriteLine("*******************************************");
        }
        public void showSearchOptions()
        {
            Console.WriteLine("       Arama yapmak istediğiniz tipi seçiniz      ");
            Console.WriteLine(" - Kişinin adı ya da soyadı ile arama yapmak için: (1)");
            Console.WriteLine(" - Kişinin telefon numarası ile arama yapmak için: (2)");
        }
        public Contact GetNewContactFromUser()
        {
            Contact contact = new Contact();
            Console.WriteLine("Lütfen isim giriniz             :");
            contact.Name = Console.ReadLine();
            Console.WriteLine("Lütfen soyisim giriniz          :");
            contact.Surname = Console.ReadLine();
            Console.WriteLine("Lütfen telefon numarası giriniz :");
            contact.PhoneNumber = Console.ReadLine();
            return contact;
        }
        public string GetContactInfoToDeleteFromUser()
        {
            Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
            return Console.ReadLine();
        }
        public void ShowActionResult(string result)
        {
            Console.WriteLine(result);
        }
        public void CouldNotFindContact()
        {
            Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen işlem seçiniz.");
            Console.WriteLine(" *Yeniden denemek için: (1)");
            Console.WriteLine(" *İşlemi sonlandırmak için herhangi bir tuşa basabilirsiniz.");
        }
        public void ChooseTheSortingTypeForContacts()
        {
            Console.WriteLine("Liste sıralamasını nasıl gerçekleştirmek istersiniz?");
            Console.WriteLine(" A-Z Sıralaması için: A/a");
            Console.WriteLine(" Z-A Sıralaması için: Z/z");
        }
    }
}

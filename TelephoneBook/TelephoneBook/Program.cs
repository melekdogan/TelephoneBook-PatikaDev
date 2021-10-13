using System;
using System.Collections.Generic;

namespace TelephoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleUI UIManager = new ConsoleUI();
            List<Contact> myContactList = new List<Contact>();
            myContactList.Add(new Contact("Melek", "Doğan", "05463748389"));
            myContactList.Add(new Contact("Zehra", "Kara", "05374834834"));
            myContactList.Add(new Contact("Melis", "Demir", "05647384838"));
            myContactList.Add(new Contact("Melis", "Demir", "05647330990"));
            ContactManager manager = new ContactManager(myContactList);

            while (true)
            {
                UIManager.ShowMainMenu();
                string choice = Console.ReadLine();
                Console.Clear();
                #region
                switch (choice)
                {
                    case "1":
                        {
                            manager.AddContact(UIManager.GetNewContactFromUser());
                            break;
                        }
                    case "2":
                        {
                            while (true)
                            {
                                Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                                string input = Console.ReadLine();
                                short indice = 0;

                                if (manager.HasThePhoneNumber(input, out indice))
                                {
                                    Console.WriteLine("-->" + input + " değerinizle eşleşen kayıt silinmek üzere onaylıyor musunuz?(y/n)");
                                    Console.Write("Seçiminiz:");
                                    string islem = Console.ReadLine();

                                    if (islem == "y")
                                    {
                                        manager.DeleteContact(indice);
                                        break;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                else
                                {
                                    UIManager.CouldNotFindContact();
                                    Console.Write("Seçiminiz:");
                                    string actionChoice = Console.ReadLine();
                                    if (actionChoice == "1")
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        break;
                                    }


                                }
                            }
                            break;
                        }
                    case "3":
                        {
                            while (true)
                            {
                                Console.Write("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
                                string input = Console.ReadLine();
                                short indice = -1;

                                if (manager.HasThePhoneNumber(input, out indice))
                                {
                                    Console.Write($" *{input}* ile eşleşen kaydı güncellemek için yeni numara giriniz:");
                                    string newNumber = Console.ReadLine();
                                    manager.UpdatePhoneNumber(newNumber, indice);
                                    break;
                                }
                                else
                                {
                                    UIManager.CouldNotFindContact();
                                    string actionChoice = Console.ReadLine();
                                    if (actionChoice == "1")
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                            }
                            break;
                        }
                    case "4":
                        {
                            UIManager.ChooseTheSortingTypeForContacts();
                            string choiceforsorting =Console.ReadLine();

                            if (choiceforsorting == "A"|| choiceforsorting == "a")
                            {
                                manager.ListTheContacts(ContactManager.SortingType.ascending);
                            }
                            else if(choiceforsorting =="Z"||choiceforsorting=="z")
                            {
                                manager.ListTheContacts(ContactManager.SortingType.descending);
                            }

                            break;
                        }
                    case "5":
                        {
                            UIManager.showSearchOptions();
                            string newInput = Console.ReadLine();
                            if (newInput == "1")
                            {
                                Console.Write("İsim veya soyisim giriniz:");
                                string input = Console.ReadLine();
                                manager.FindByNameOrSurname(input);
                            }
                            else
                            {
                                Console.Write("Telefon giriniz:");
                                string input = Console.ReadLine();
                                manager.FindByPhoneNumber(input);
                            }

                            break;
                        }
                    case "6":
                        {
                            Console.WriteLine("İşlem Sonlandırıldı.");
                            break;
                           
                        }
                    default:
                        {
                            Console.WriteLine("\n Hatalı Tuşlama Yaptınız! \n");
                            continue;
                        }
                }
                #endregion
                Console.WriteLine("Ana menüye dönmek için herhangi bir tuşa basınız");
                Console.ReadKey();
                Console.Clear();

            }
        
    }
    }
}

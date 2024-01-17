using System;
using System.Collections.Generic;


namespace Dictionaries
{
    internal class Program
    {
        /// <summary>
        /// Creates phone book dictionary
        /// </summary>
        /// <returns>Created phone book dictionary</returns>
        private static Dictionary<string, string> CreatePhoneBook()
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();
            
            while (true)
            {
                Console.Write("Введите номер тедефона:\t");
                string phoneNumber = Console.ReadLine();
                if (phoneNumber == "")
                {
                    break;
                }
                if (!int.TryParse(phoneNumber, out int _))
                {
                    Console.WriteLine("Введен некоректный номер !");
                    continue;
                }
                while (true)
                {
                    Console.Write("Введите имя:\t\t");
                    string name = Console.ReadLine();
                    if (name != "")
                    {
                        if (!phoneBook.ContainsKey(phoneNumber))
                        {
                            phoneBook.Add(phoneNumber, name);
                        }
                        else
                        {
                            phoneBook[phoneNumber] = name;                            
                        }
                        break;
                    }                    
                }                
            }
            
            return phoneBook;
        }

        /// <summary>
        /// Searches name by phone number in phonebook
        /// </summary>
        /// <param name="phoneBook">Phone book</param>
        private static void PhoneBookSearch(Dictionary<string, string> phoneBook)
        {
            Console.WriteLine("Поиск по телефонной книге\n");

            while (true)
            {
                Console.Write("Введите номер тедефона:\t");
                string phoneNumber = Console.ReadLine();
                if (phoneNumber == "")
                {
                    break;
                }
                if (!int.TryParse(phoneNumber, out int _))
                {
                    Console.WriteLine("Введен некоректный номер !");
                    continue;
                }
                if (phoneBook.ContainsKey(phoneNumber))
                {
                    Console.WriteLine($"Имя: {phoneBook[phoneNumber]}\t\tНомер: {phoneNumber}");
                }
                else
                {
                    Console.WriteLine("Введенного номера нет в телефонной книге");
                }
            }
        }
        
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = CreatePhoneBook();
            PhoneBookSearch(phoneBook);
            Console.ReadKey();
        }
    }
}

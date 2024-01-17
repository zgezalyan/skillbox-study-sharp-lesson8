using System;
using System.IO;
using System.Xml.Linq;

namespace XElements
{
    internal class Program
    {
        
        private static string EnterParameter(string caption)
        {
            while (true)
            {
                Console.Write(caption);
                string res = Console.ReadLine();
                if (res == "" || res == null)
                {
                    continue;
                }
                return res;
            }
        }

        private static AddressBookEntry CreateEntry()
        {
            
            string name = EnterParameter("Введите ФИО: ");
            string street = EnterParameter("Введите название улицы: ");
            string houseNumber = EnterParameter("Введите номер дома: ");
            string flatNumber = EnterParameter("Введите номер квартиры: ");
            string mobilePhone = EnterParameter("Введите мобильный телефон: ");
            string flatPhone = EnterParameter("Введите домашний телефон: ");            

            return new AddressBookEntry(name, street, houseNumber, flatNumber, mobilePhone, flatPhone);
        }

        private static XElement CreateElement(AddressBookEntry adEntry)
        {
            XElement person = new XElement("Person",
                new XAttribute("name", adEntry.Name),
                new XElement("Address",
                    new XElement("Street", adEntry.Street),
                    new XElement("HouseNumber", adEntry.HouseNumber),
                    new XElement("FlatNumber", adEntry.FlatNumber)
                ),
                new XElement("Phones",
                    new XElement("MobilePhone", adEntry.MobilePhone),
                    new XElement("FlatPhone", adEntry.FlatPhone)
                )
            );
            return person;
        }

        static void Main(string[] args)
        {
            AddressBookEntry adEntry = CreateEntry();
            XElement xElement = CreateElement(adEntry);
            xElement.Save("../../../AddressBook.xml");
        }
    }
}

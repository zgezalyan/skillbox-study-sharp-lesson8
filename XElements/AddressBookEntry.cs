using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XElements
{
    internal class AddressBookEntry
    {
        /// <summary>
        /// Person name
        /// </summary>
        private string name;
        
        /// <summary>
        /// Street name
        /// </summary>
        private string street;
        
        /// <summary>
        /// House number
        /// </summary>
        private string houseNumber;
        
        /// <summary>
        /// Flat number
        /// </summary>
        private string flatNumber;
        
        /// <summary>
        /// Mobile phone number
        /// </summary>
        private string mobilePhone;
        
        /// <summary>
        /// Flat phone number
        /// </summary>
        private string flatPhone;

        /// <summary>
        /// Main constructor for address book entry
        /// </summary>
        /// <param name="name">Person name</param>
        /// <param name="street">Street name</param>
        /// <param name="houseNumber">House number</param>
        /// <param name="flatNumber">Flat number</param>
        /// <param name="mobilePhone">Mobile phone number</param>
        /// <param name="flatPhone">Flat phone number</param>
        public AddressBookEntry(string name, string street, string houseNumber, string flatNumber, string mobilePhone, string flatPhone) 
        { 
            this.name = name;
            this.street = street;
            this.houseNumber = houseNumber;
            this.flatNumber = flatNumber;
            this.mobilePhone = mobilePhone;
            this.flatPhone = flatPhone;
        }

        /// <summary>
        /// Accessor for person name
        /// </summary>
        public string Name { get { return name; } set { this.name = value; } }
        
        /// <summary>
        /// Accessor for street name
        /// </summary>
        public string Street { get { return street; } set { this.street = value; } }
        
        /// <summary>
        /// Accessor for house number
        /// </summary>
        public string HouseNumber { get { return houseNumber; } set { this.houseNumber = value; } }
        
        /// <summary>
        /// Accessor for flat number
        /// </summary>
        public string FlatNumber { get { return flatNumber; } set { this.flatNumber = value; } }
        
        /// <summary>
        /// Accessor for mobile phone number
        /// </summary>
        public string MobilePhone { get { return mobilePhone; } set { this.mobilePhone = value; } }
        
        /// <summary>
        /// Accessor for flat phone number
        /// </summary>
        public string FlatPhone { get { return flatPhone; } set {  this.flatPhone = value; } }
    }
}

using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Has the data about the address.
    /// </summary>
    public class Address : ICloneable, IEquatable<Address>
    {
        /// <summary>
        /// Postal code.
        /// </summary>
        private int _index;

        /// <summary>
        /// Country/region.
        /// </summary>
        private string _country = string.Empty;

        /// <summary>
        /// City.
        /// </summary>
        private string _city = string.Empty;

        /// <summary>
        /// Street.
        /// </summary>
        private string _street = string.Empty;

        /// <summary>
        /// House number.
        /// </summary>
        private string _building = string.Empty;

        /// <summary>
        /// Apartment number.
        /// </summary>
        private string _apartment = string.Empty;

        /// <summary>
        /// Event of address being changed
        /// </summary>
        public event EventHandler<EventArgs> AddressChanged;

        /// <summary>
        /// Gets and sets a postal index. Supposed to have 6 numbers in it.
        /// </summary>
        public int Index
        {
            get { return _index; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 100000, 999999, "Index");
                _index = value;
                AddressChanged?.Invoke(this, EventArgs.Empty);
            }
        }


        /// <summary>
        /// Gets and sets country/region. Not lonegr than 50 symbols.
        /// </summary>
        public string Country
        {
            get { return _country; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, "Country");
                _country = value;
                AddressChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Gets and sets a city. Not longer than 50 symbols.
        /// </summary>
        public string City
        {
            get { return _city; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, "City");
                _city = value;
                AddressChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Gets and sets a street. Not longer than 100 symbols.
        /// </summary>
        public string Street
        {
            get { return _street; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 100, "Street");
                _street = value;
                AddressChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Gets and ssets a house number. Not longer than 10 symbols.
        /// </summary>
        public string Building
        {
            get { return _building; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, "Building");
                _building = value;
                AddressChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Gets and ssets an apartment. Not longer than 10 symbols.
        /// </summary>
        public string Apartment
        {
            get { return _apartment; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, "Apartment");
                _apartment = value;
                AddressChanged?.Invoke(this, EventArgs.Empty);
            }
        }


        /// <summary>
        /// Creates a sample of the class <see cref="Address"/>.
        /// </summary>
        /// <param name="index">Почтовый индекс.</param>
        /// <param name="country">Страна или регион.</param>
        /// <param name="city">Город(населенный пункт).</param>
        /// <param name="street">Улица.</param>
        /// <param name="building">Номер дома.</param>
        /// <param name="apartment">Номер кватиры или помещения.</param>
        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;    
        }

        /// <summary>
        /// Creates a sample of the class <see cref="Address"/>.
        /// </summary>
        public Address()
        {
            Index = 100000;
            Country = string.Empty;
            City = string.Empty;
            Street = string.Empty;
            Building = string.Empty;
            Apartment = string.Empty;
        }

        /// <summary>
        /// Creates a copy of the class.
        /// </summary>
        /// <returns> Copy of an object. </returns>
        public object Clone()
        {
            return new Address(Index, Country, City, Street, Building, Apartment);
        }

        /// <summary>
        /// Checks if the subjects are the same.
        /// </summary>
        /// <param name="subject"></param>
        /// <returns> Whether they are equal or not. </returns>
        public bool Equals(Address subject)
        {
            if (subject == null)
            {
                return false;
            }
            if (ReferenceEquals(this, subject))
            {
                return true;
            }
            return
                Index == subject.Index && 
                Country == subject.Country && 
                City == subject.City && 
                Street == subject.Street && 
                Building == subject.Building && 
                Apartment == subject.Apartment;
        }

        /// <summary>
        /// Checks if the subjects are the same.
        /// </summary>
        /// <param name="subject"></param>
        /// <returns> Whether they are equal or not. </returns>
        public override bool Equals(object subject)
        {
            if (subject == null)
            {
                return false;
            }
            if (ReferenceEquals(this, subject))
            {
                return true;
            }
            return Equals((Address)subject);
        }

    }
}

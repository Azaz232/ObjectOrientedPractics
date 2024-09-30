using System;
using System.Collections.Generic;
using System.Linq;
using ObjectOrientedPractics.Services;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{

    /// <summary>
    /// Holds data of a customer.
    /// </summary>
    class Customer
    {
        /// <summary>
        /// Unique customer number.
        /// </summary>
        private readonly int _id;
        /// <summary>
        /// ПFull name of a customer.
        /// </summary>
        private string _fullname;
        /// <summary>
        /// Delivery address.
        /// </summary>
        private string _address;

        /// <summary>
        /// Gets and sets the full name of a customer.
        /// </summary>
        public string Fullname
        {
            get { return _fullname; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(_fullname));
                _fullname = value;
            }
        }
        /// <summary>
        /// Gets and sets an address for delivery.
        /// </summary>
        public string Address {
            get { return _address; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 500, nameof(_address));
                _address = value;
            }
        }
        /// <summary>
        /// Returns unique id of a customer.
        /// </summary>
        public int Id
        {
            get { return _id; }
        }
        /// <summary>
        /// Creates a sample of a class  <see cref="Item"/>.
        /// </summary>
        /// <param name="fullname">Полное имя покупателя.</param>
        /// <param name="address">Адрес доставки для покупателя.</param>
        public Customer(string fullname, string address)
        {
            Fullname = fullname;
            Address = address;
            _id = IdGenerator.GetNextId();
        }
        /// <summary>
        /// Creates an empty sample of a class <see cref="Item"/>.
        /// </summary>
        public Customer()
        {
            Fullname = string.Empty;
            Address = string.Empty;
            _id = IdGenerator.GetNextId();
        }
    }
}


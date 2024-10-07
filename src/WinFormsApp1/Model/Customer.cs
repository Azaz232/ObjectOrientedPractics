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
    public class Customer
    {
        /// <summary>
        /// Unique customer number.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Full name of a customer.
        /// </summary>
        private string _fullname = string.Empty;

        /// <summary>
        /// Delivery address.
        /// </summary>
        private Address _address = new Address();


        /// <summary>
        /// New variable of a Cart type.                                  ))
        /// </summary>
        private Cart _cart = new Cart();

        /// <summary> 
        /// Gets and sets cart data.                                      ))
        /// </summary>
        public Cart Cart
        {
            get { return _cart; }
            set { _cart = value; }
        }

        /// <summary>
        /// Returns unique id of a customer.
        /// </summary>
        public int Id{ get { return _id; } }

        /// <summary>
        /// Gets and sets an address for delivery.
        /// </summary>
        public Address CustomerAddress
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }

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
        /// Creates a sample of a class  <see cref="Item"/>.
        /// </summary>
        /// <param name="fullname">Full name of a customer.</param>
        /// <param name="address">Delivery address.</param>
         
        public Customer(string fullname, Address address)
        {
            Fullname = fullname;
            CustomerAddress = address;
            _id = IdGenerator.GetNextId();
            Cart = new Cart();
        }

        /// <summary>
        /// Creates an empty sample of a class <see cref="Item"/>.
        /// </summary>
         
        public Customer()
        {
            Fullname = string.Empty;
            CustomerAddress = new Address();
            _id = IdGenerator.GetNextId();
            Cart = new Cart();  
        }
    }
}


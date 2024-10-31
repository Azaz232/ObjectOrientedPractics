using System;
using System.Collections.Generic;
using System.Linq;
using ObjectOrientedPractics.Services;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Model.Orders;

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
        /// New variable of a Cart type.                                 
        /// </summary>
        private Cart _cart = new Cart();

        /// <summary>
        /// A list of orders.                                            
        /// </summary>
        private List<Order> _orders = new List<Order>();


        /// <summary> 
        /// Gets and sets cart data.                                      
        /// </summary>
        public Cart CustomerCart
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
        /// Gets and sets the list of orders.
        /// </summary>
        public List<Order> Orders
        {
            get
            {
                return _orders; 
            }
            set
            {
                _orders = value;
            }
        }

        /// <summary>
        /// Gets and sets the priority of the order.
        /// </summary>
        public bool IsPriority { get; set; } = false;

        /// <summary>
        /// Gets and sets a list of discounts for a customer.
        /// </summary>
        public List<IDiscount> Discounts { get; set; }

        /// <summary>
        /// Creates a sample of a class  <see cref="Item"/>.
        /// </summary>
        /// <param name="fullname">Full name of a customer.</param>
         
        public Customer(string fullname)
        {
            Fullname = fullname;
            CustomerAddress = new Address();
            _id = IdGenerator.GetNextId();
            CustomerCart = new Cart();
            Discounts = new List<IDiscount>();
            Discounts.Add(new PointsDiscount());
        }

        /// <summary>
        /// Creates an empty sample of a class <see cref="Item"/>.
        /// </summary>
        public Customer()
        {
            Fullname = string.Empty;
            CustomerAddress = new Address();
            _id = IdGenerator.GetNextId();
            CustomerCart = new Cart();
            Orders = new List<Order>();
            Discounts = new List<IDiscount>();
            Discounts.Add(new PointsDiscount());
        }

    }
}


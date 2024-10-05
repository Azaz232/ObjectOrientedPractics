using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Holds data about items and customers.
    /// </summary>
    internal class Store
    {
        /// <summary>
        /// List of items.
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// List of customers.
        /// </summary>
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Gets and setd a list of items and items.
        /// </summary>
        public List<Item> Items { get { return _items; } set { _items = value; } }

        /// <summary>
        /// Returns and sets a list if customers. 
        /// </summary>
        public List<Customer> Customers { get { return _customers; } set { _customers = value; } }

        /// <summary>
        /// Creates a sample of the class <see cref="Store"/>.
        /// </summary>
        public Store()
        {
            Items = new List<Item>();
            Customers = new List<Customer>();
        }
    }
}

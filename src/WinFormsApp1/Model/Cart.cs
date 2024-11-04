using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Holds data of a customers cart.
    /// </summary>
    public class Cart : ICloneable
    {
        /// <summary>
        /// Create a variable of a Item type.
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Gets and sets items.
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        /// <summary>
        /// Gets the cost of all item in the cart.
        /// </summary>
        public double Amount
        {
            get
            {   
                if (_items.Count != 0 && _items != null) 
                {
                    double amount = 0.0;
                    foreach (var item in _items)
                    {
                        amount += item.Cost;
                    }
                    return amount;

                } 
                else
                {
                    return 0.0;
                }
            }
        }

        /// <summary>
        /// creates a sample of the class.
        /// </summary>
        public Cart()
        {
            Items = new List<Item>();   
        }

        /// <summary>
        /// Copies an object of the class.
        /// </summary>
        /// <returns> A copy of the object. </returns>
        public object Clone()
        {
            var cartClone = new Cart();
            foreach (Item item in Items)
            {
                cartClone.Items.Add((Item)item.Clone());
            }
            return cartClone;
        }
    }
}

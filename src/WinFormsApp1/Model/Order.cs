using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  i still need help

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Holds data of a customers order.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Order's id.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Date of order's creation.
        /// </summary>
        private readonly DateTime _date = DateTime.Now;

        /// <summary>
        /// Returns unique id.
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
        }

        /// <summary>
        /// Date of order's creation.
        /// </summary>
        public DateTime CreationDate
        {
            get
            {
                return _date;
            }
        }

        /// <summary>
        /// Gets and sets order's status.
        /// </summary>
        public OrderStatus Status { get; set; } = OrderStatus.New;

        /// <summary>
        /// Gets ans sets delivery Address.
        /// </summary>
        public Address Address { get; set; } = new Address();    //   в автосвойстве уже создано поле и его автосвойство, и я сразк к автосвойству присваиваю значению (хз куда) 

        /// <summary>
        /// Gets and sets a list of new items.                   ????
        /// </summary>
        private List<Item> _items { get; set; } = new List<Item>();


        /// <summary>
        /// Gets a total cost of a cart.
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
        /// Creates a sample of a class <see cref="Order"/>.
        /// </summary>
        /// <param name="status">Статус заказа.</param>
        /// <param name="address">Адрес доставки.</param>
        /// <param name="items">Список товаров заказа.</param>
        public Order(OrderStatus status, Address address, List<Item> items)               //  ??????
        {
            _id = IdGenerator.GetNextId();
            Status = status;
            Address = address;
            _items = items;
        }

        /// <summary>
        /// Creates a sample of a class <see cref="Order"/>.
        /// </summary>
        public Order()
        {
            _id = IdGenerator.GetNextId();
        }

    }
}

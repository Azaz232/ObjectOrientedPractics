﻿using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  i still need help

namespace ObjectOrientedPractics.Model.Orders
{
    /// <summary>
    /// Holds data of a customers order.
    /// </summary>
    public class Order : IEquatable<Order>
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
        public DateTime Date
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
        public Address Address { get; set; } = new Address();

        /// <summary>
        /// Gets and sets a list of new items.                                 
        /// </summary>
        public List<Item> Items { get; set; } = new List<Item>();


        /// <summary>
        /// Gets a total cost of a cart.
        /// </summary>
        public double Amount
        {
            get
            {
                if (Items.Count != 0 && Items != null)
                {
                    double amount = 0.0;
                    foreach (var item in Items)
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
        /// Gets and sets a discount for items.
        /// </summary>
        public double DiscountAmount { get; set; }

        /// <summary>
        /// Returns the cost of the order with the discount.
        /// </summary>
        public double Total
        {
            get
            {
                return Amount - DiscountAmount;
            }
        }


        /// <summary>
        /// Creates a sample of a class <see cref="Order"/>.
        /// </summary>
        /// <param name="status">Order's status.</param>
        /// <param name="address">Delivery address.</param>
        /// <param name="items">List of items.</param>
        public Order(Address address, List<Item> items, double discountAmount)
        {
            _id = IdGenerator.GetNextId();
            Status = new OrderStatus();
            Address = address;
            _date = DateTime.Now;
            foreach (Item item in items)
            {
                Items.Add(item);
            }
            DiscountAmount = discountAmount;
        }

        /// <summary>
        /// Creates a sample of a class <see cref="Order"/>.
        /// </summary>
        public Order()
        {
            _id = IdGenerator.GetNextId();
            _date = DateTime.Now;
            Status = new OrderStatus();
            Items = new List<Item>();
            DiscountAmount = 0.0;
        }

        /// <summary>
        /// Compares whether they are equal or not.
        /// </summary>
        /// <param name="subject"></param>
        /// <returns> Whether they are equal or not. </returns>
        public bool Equals(Order subject)
        {
            if (subject == null)
            {
                return false;
            }
            if (ReferenceEquals(this, subject))
            {
                return true;
            }
            if (!Items.SequenceEqual(subject.Items))
            {
                return false;
            }
            return
                Address == subject.Address &&
                Status == subject.Status &&
                Amount == subject.Amount;
        }

        /// <summary>
        /// Compares whether they are equal or not.
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
            return Equals((Order)subject);
        }
    }
}

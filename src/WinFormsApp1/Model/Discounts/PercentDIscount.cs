﻿using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// nothing has changed, i still need help
// help
// im trying to stay sane


namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Holds percentage discount.
    /// </summary>
    public class PercentDiscount : IDiscount, IComparable<PercentDiscount>
    {
        /// <summary>
        /// Discount in percentage.
        /// </summary>
        private int _percent = 1;

        /// <summary>
        /// Gets and sets the discount categoty.
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Gets and sets the discount in percents.
        /// </summary>
        public int Percent
        {
            get
            {
                return _percent;
            }
            private set
            {
                if (value < 1 || value > 10)
                {
                    throw new ArgumentException("out of range");
                }
                _percent = value;
            }
        }

        /// <summary>
        /// Gets and sets the sum that the customer spent in specific category.
        /// </summary>
        public double SpendingPerCategory { get; private set; } = 0;

        /// <summary>
        /// Returns info about the discount.
        /// </summary>
        public string Info
        {
            get
            {
                return $"Percent \"{Category}\" - {Percent}%";
            }
        }

        /// <summary>
        /// Calculates discounts for items.
        /// </summary>
        /// <param name="items">List of items.</param>
        /// <returns> Returns size of the discount</returns>
        public double Calculate(List<Item> items)
        {
            double totalCost = 0;

            foreach (var item in items)
            {
                if (item.Category == Category)
                {
                    totalCost += item.Cost;
                }
            }
            return totalCost * Percent / 100;

        }

        /// <summary>
        /// Uses points.
        /// </summary>
        /// <param name="items">List of items.</param>
        /// <returns> Returns size of the discount. </returns>
        public double Apply(List<Item> items)
        {
            return Calculate(items);
        }

        /// <summary>
        /// Updates point.
        /// </summary>
        /// <param name="items">List of items.</param>
        public void Update(List<Item> items)
        {
            double totalCost = 0;

            foreach (var item in items)
            {
                if (item.Category == Category)
                {
                    totalCost += item.Cost;
                }
            }

            SpendingPerCategory += totalCost;
            var percentage = (int)(SpendingPerCategory / 100);  
            Percent = Math.Min(percentage, 10);
        }

        /// <summary>
        /// Creates a sample of the class <see cref="PercentDiscount"/>.
        /// </summary>
        /// <param name="category">Category of the item.</param>
        public PercentDiscount(Category category)
        {
            Category = category;
        }

        /// <summary>
        /// Creates an empty sample of the class <see cref="PercentDiscount"/>.
        /// </summary>
        public PercentDiscount()
        {
            Category = Category.Monitors;
        }

        /// <summary>
        /// Compares disocount percent.
        /// </summary>
        /// <param name="subject"></param>
        /// <returns> 0 - equal, 1 - percent is smaller, -1 - percent is bigger. </returns>
        public int CompareTo(PercentDiscount subject)
        {
            if (subject == null)
            {
                return 1;
            }
            if (ReferenceEquals(this, subject))
            {
                return 0;
            }
            else
            {
                return _percent.CompareTo(subject.Percent);
            }
        }
    }
}

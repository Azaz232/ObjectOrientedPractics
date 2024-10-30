using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Discounts.
    /// </summary>
    public class PointsDiscount
    {
        /// <summary>
        /// Points.
        /// </summary>
        private int _points;

        /// <summary>
        /// Maximum discount.
        /// </summary>
        private const double MaxDiscountPercentage = 0.3;

        /// <summary>
        /// Gets and sets points.
        /// </summary>
        public int Points
        {
            get
            {
                return _points;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Positive value is expected.");
                }
                _points = value;
            }
        }

        /// <summary>
        /// Calculates discounts for items.
        /// </summary>
        /// <param name="items">List of items.</param>
        /// <returns>Size of the discount</returns>
        public double Calculate(List<Item> items)
        {
            double totalPrice = 0;

            foreach (var item in items)
            {
                totalPrice += item.Cost;
            }

            double maxDiscount = totalPrice * MaxDiscountPercentage;

            return Math.Min(Points, maxDiscount);

        }

        /// <summary>
        /// Uses points.
        /// </summary>
        /// <param name="items">List of items.</param>
        /// <returns>Size of the discount</returns>
        public double Apply(List<Item> items)
        {
            double discount = Calculate(items);

            Points -= (int)Math.Floor(discount);

            return discount;
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
                totalCost += item.Cost;
            }

            int earnedPoints = (int)Math.Ceiling(totalCost * 0.10);
            Points += earnedPoints;
        }

        /// <summary>
        /// Creates a sample of the class <see cref="PointsDiscount"/>.
        /// </summary>
        /// <param name="initialPoints">Saved Points.</param>
        public PointsDiscount(int initialPoints)
        {
            Points = initialPoints;
        }

        /// <summary>
        /// Creates an empty sample of the class <see cref="PointsDiscount"/>.
        /// </summary>
        public PointsDiscount()
        {
            Points = 0;
        }


        /// <summary>
        /// Returns info about the discount.
        /// </summary>
        public string Info => $"Saved – {Points} points";
    }
}

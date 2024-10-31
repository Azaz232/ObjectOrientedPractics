using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Discounts interface.
    /// </summary>
    public interface IDiscount
    {
        /// <summary>
        /// Returns info about the discount.
        /// </summary>
        string Info { get; }

        /// <summary>
        /// Calculates discounts for items.
        /// </summary>
        /// <param name="items"> List of items. </param>
        /// <returns> Returns size of the discounts.</returns>
        double Calculate(List<Item> items);

        /// <summary>
        /// Uses points.
        /// </summary>
        /// <param name="items"> List of items. </param>
        /// <returns> Returns size of the discount </returns>
        double Apply(List<Item> items);

        /// <summary>
        /// Updates point.
        /// </summary>
        /// <param name="items">List of items.</param>
        void Update(List <Item> items);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Sorts and filters items.
    /// </summary>
    public class DataTools
    {
        /// <summary>
        /// Comparative delegete.
        /// </summary>
        /// <param name="first">Item 1.</param>
        /// <param name="second">Item 2.</param>
        /// <returns> Whether to swap them or not. </returns>
        public delegate bool CompareCriteria(Item first, Item second);

        /// <summary>
        /// Filters items by criteria.
        /// </summary>
        /// <param name="items"> List of items.</param>
        /// <param name="criteria"> Criteria.</param>
        /// <returns> Filtred list of items.</returns>
        public static List<Item> FilterItems(List<Item> items, Predicate<Item> criteria)   // predicate - возвращает булевое значение
        {
            var filteredItems = new List<Item>();

            foreach (var item in items)
            {
                if (criteria(item))                                                       // 
                {
                    filteredItems.Add(item);
                }
            }

            return filteredItems;
        }

        /// <summary>
        /// Sorts items by criteria.
        /// </summary>
        /// <param name="items"> List of items <see cref="List{Item}"/>.</param>
        /// <param name="compare"> Criteria method <see cref="CompareCriteria"/>.</param>
        /// <returns> Sorted list of items.</returns>
        public static List<Item> SortItems(List<Item> items, CompareCriteria compare)     // compare - переменная делегата
        {
            var sortedItems = new List<Item>(items);

            for (var i = 0; i < sortedItems.Count; i++)
            {
                for (var j = 0; j < sortedItems.Count; j++)
                {
                    if (compare(sortedItems[i], sortedItems[j]))   // с помощью делегата сравниваем айтемы
                    {
                        var item = sortedItems[i];
                        sortedItems[i] = sortedItems[j];
                        sortedItems[j] = item;
                    }
                }
            }

            return sortedItems;
        }
    }
}

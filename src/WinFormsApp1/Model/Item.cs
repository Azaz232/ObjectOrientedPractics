using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//i need help


//using System.ComponentModel.DataAnnotations;
//using System.Reflection.Emit;

using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model {
    /// <summary>
    /// Holds data of items.
    /// </summary>
    class Item
    {
        /// <summary>
        /// Unique number of the item.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Name of the item.
        /// </summary>
        private string _name;

        /// <summary>
        /// Description of the item.
        /// </summary>
        private string _info;

        /// <summary>
        /// Cost of the item.
        /// </summary>
        private double _cost;

        /// <summary>
        /// Returns unique number of the item.
        /// </summary>
        public int Id { get { return _id; } }

        /// <summary>
        /// Gets and sets the name of the item.
        /// </summary>
        public string Name {
            get { return _name; }
            set {
                ValueValidator.AssertStringOnLength(value, 200, nameof(_name));
                _name = value;
                }
            }

        /// <summary>
        /// Gets and sets the description of the item.
        /// </summary>
        public string Info {
            get { return _info; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 1000, nameof(_info));
                _info = value;
            }
        }

        /// <summary>
        /// Gets and sets the price of the item.
        /// </summary>
        public double Cost
        {
            get { return _cost; }
            set {
                ValueValidator.AssertStringOnLength(value, 0, 100000, nameof(_cost));
                _cost = value;
            }
        }

        /// <summary>
        /// Gets and sets item's category. <see cref="Item"/>.
        /// </summary>
        public Category Category { get; set; }


        /// <summary>
        /// Creates a sample of the class <see cref="Item"/>.
        /// </summary>
        /// <param name="name">Name of the item.</param>
        /// <param name="info">Description of the item.</param>
        /// <param name="cost">Cost of the item.</param>
        /// <param name="category">Category of the item.</param>
        public Item(string name, string info, double cost, Category category)
        {
            Name = name;
            Info = info;
            Cost = cost;
            _id = IdGenerator.GetNextId();
            Category = category;
        }

        /// <summary>
        /// Creates an emprty sample of the class <see cref="Item"/>.
        /// </summary>
        public Item()
        {
            Name = string.Empty;
            Info = string.Empty;
            Cost = 0;
            _id = IdGenerator.GetNextId();
            Category = 0;
        }

    }
}
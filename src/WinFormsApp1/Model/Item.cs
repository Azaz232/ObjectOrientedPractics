﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model.Enums;

//i need help


//using System.ComponentModel.DataAnnotations;
//using System.Reflection.Emit;

using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Holds data of items.
    /// </summary>
    public class Item : ICloneable, IEquatable<Item>, IComparable<Item>
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
        /// Event of name being chnaged
        /// </summary>
        public event EventHandler<EventArgs> NameChanged;

        /// <summary>
        /// Event of info being changed
        /// </summary>
        public event EventHandler<EventArgs> InfoChanged;

        /// <summary>
        /// event of cost being changed
        /// </summary>
        public event EventHandler<EventArgs> CostChanged;

        /// <summary>
        /// Returns unique number of the item.
        /// </summary>
        public int Id { get { return _id; } }

        /// <summary>
        /// Gets and sets the name of the item.
        /// </summary>
        public string Name 
        {
            get 
            { 
                return _name; 
            }
            set 
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(_name));
                _name = value;
                NameChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Gets and sets the description of the item.
        /// </summary>
        public string Info 
        {
            get 
            { 
                return _info; 
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 1000, nameof(_info));
                _info = value;
                InfoChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Gets and sets the price of the item.
        /// </summary>
        public double Cost
        {
            get 
            {
                return _cost; 
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 0, 100000, nameof(_cost));
                _cost = value;
                CostChanged?.Invoke(this, EventArgs.Empty); 
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
        public Item(string name, string info, double cost)
        {
            Name = name;
            Info = info;
            Cost = cost;
            _id = IdGenerator.GetNextId();
            Category = new Category();
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
            Category = new Category();
        }

        /// <summary>
        /// Creates a copy of the class.
        /// </summary>
        /// <returns> Copy of an object. </returns>
        public object Clone()
        {
            return new Item
            {
                Name = Name,
                Info = Info,
                Cost = Cost,
                Category = Category
            };
        }

        /// <summary>
        /// Checks if the subjects are the same.
        /// </summary>
        /// <param name="subject"></param>
        /// <returns> Whether they are equal or not. </returns>
        public bool Equals(Item subject)
        {
            if (subject == null)
            {
                return false;
            }
            if (ReferenceEquals(this, subject))
            {
                return true;
            }
            return
                Name == subject.Name &&
                Info == subject.Info &&
                Cost == subject.Cost &&
                Category == subject.Category;
        }

        /// <summary>
        /// Checks if the subjects are the same.
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
            return Equals((Item)subject);
        }

        /// <summary>
        /// Compares the cost.
        /// </summary>
        /// <param name="subject"></param>
        /// <returns> 0 - equal, 1 - cost is lower, -1 - cost id higher.  </returns>
        public int CompareTo(Item subject)
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
                return _cost.CompareTo(subject.Cost);
            }
        }
    }
}
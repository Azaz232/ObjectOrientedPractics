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
    class Item
    {
        private readonly int _id;

        private string _name = string.Empty;

        private string _info = string.Empty; 

        private double _cost;

        public int Id { get { return _id; } }

        public string Name {
            get { return _name; }
            set {
                ValueValidator.AssertStringOnLength(value, 200, nameof(_name));
                _name = value;
                }
            }


        public string Info {
            get { return _info; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 1000, nameof(_info));
                _info = value;
            }
        }
        public double Cost
        {
            get { return _cost; }
            set {
                ValueValidator.AssertStringOnLength(value, 0, 100000, nameof(_cost));
                _cost = value;
            }
        }


        public Item(string name, string info, double cost)
        {
            Name = name;
            Info = info;
            Cost = cost;
            _id = IdGenerator.GetNextId();
        }

        public Item()
        {
            Name = string.Empty;
            Info = string.Empty;
            Cost = 0;
            _id = IdGenerator.GetNextId();  
        }

    }
}
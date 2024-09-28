using System;
using System.Collections.Generic;
using System.Linq;
using ObjectOrientedPractics.Services;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    class Customer
    {
        private readonly int _id;
        private string _fullname;
        private string _address;

        public string Fullname
        {
            get { return _fullname; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(_fullname));
                _fullname = value;
            }
        }

        public string Address {
            get { return _address; }
            set
            {
                ValueValidator.AssertStringOnLength(value, 500, nameof(_address));
                _address = value;
            }
        }

        public int Id
        {
            get { return _id; }
        }

        public Customer(string fullname, string address)
        {
            Fullname = fullname;
            Address = address;
        }

        public Customer()
        {
            Fullname = string.Empty;
            Address = string.Empty;
            //_id = IdGenerator.GetNextId();
        }
    }
}


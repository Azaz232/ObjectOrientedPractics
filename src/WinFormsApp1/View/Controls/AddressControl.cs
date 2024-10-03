using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {
        /// <summary>
        /// Variable type - Address.
        /// </summary>
        private Address _address = new Address();

        /// <summary>
        /// Gets and sets an address.
        /// </summary>
        public Address OurAddress { get { return _address; } set { _address = value; } }


        public AddressControl()
        {
            InitializeComponent();
        }
    }
}

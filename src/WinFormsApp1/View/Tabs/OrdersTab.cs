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

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Orders tab.
    /// </summary>
    public partial class OrdersTab : UserControl
    {
        /// <summary>
        /// Gets and sets a list of customers.
        /// </summary>
        public List<Customer> Customers { get; set; } = new List<Customer>();




        public OrdersTab()
        {
            InitializeComponent();
        }
    }
}

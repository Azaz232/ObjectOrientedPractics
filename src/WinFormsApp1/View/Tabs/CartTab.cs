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
    /// Cart tab.
    /// </summary>
    public partial class CartTab : UserControl
    {
        /// <summary>
        /// A list of items.
        /// </summary>
        public List<Item> _items;

        /// <summary>
        /// A list of customers.
        /// </summary>
        public List<Customer> _customers;



        /// <summary>
        /// Gets and set a list of items.
        /// </summary>
        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        /// <summary>
        /// Gets and set a list of customers.
        /// </summary>
        public List<Customer> Customers
        {
            get { return _customers; }
            set { _customers = value; }
        }

        /// <summary>
        /// Gets and sets current customer.
        /// </summary>
        private Customer CurrentCustomer { get; set; } = new Customer();

        public CartTab()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Adds elements of the item list to ItemsListBox.
        /// </summary>
        private void FillItemListBox()
        {
            ItemsListBox.Items.Clear();

            foreach (Item item in Items)
            {
                ItemsListBox.Items.Add($"{item.Name}");
            }
        }

        /// <summary>
        /// Adds elements of the customer list to CustomerComboBox.
        /// </summary>
        private void LoadCustomersComboBox()
        {
            CustomerComboBox.Items.Clear();

            foreach (var customer in Customers)
            {
                CustomerComboBox.Items.Add($"{customer.Fullname}");
            }
        }

        /// <summary>
        /// Updates customers cart.
        /// </summary>
        private void UpdateCartListBox()
        {
            CartListBox.Items.Clear();

            if (CurrentCustomer.CustomerCart.Items.Count != 0)
            {
                foreach (Item item in CurrentCustomer.CustomerCart.Items)
                {
                    CartListBox.Items.Add($"{item.Name}");
                }
            }
            else
            {
                CartListBox.Items.Clear();
            }
            TotalCostLabel.Text = CurrentCustomer.CustomerCart.Amount.ToString();
        }

        /// <summary>
        /// Updates values of items and customers.
        /// </summary>
        public void RefreshData()
        {
            LoadCustomersComboBox();
            FillItemListBox();
            CartListBox.Items.Clear();
            TotalCostLabel.Text = "0";
            CustomerComboBox.Text = null;
        }

        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomerComboBox.SelectedItem != null)
            {
                CurrentCustomer = Customers[CustomerComboBox.SelectedIndex];
                UpdateCartListBox();
            }
            else
            {
                CartListBox.Items.Clear();
            }
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem == null || CustomerComboBox.SelectedItem == null)
            {
                MessageBox.Show(
                    "In order to add something to cart choose an item or a customer",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                return;
            }
            CurrentCustomer.CustomerCart.Items.Add(Items[ItemsListBox.SelectedIndex]);
            UpdateCartListBox();
        }

        private void RemoveItemButtton_Click(object sender, EventArgs e)
        {
            if (CartListBox.SelectedIndex == -1)
            { 
                MessageBox.Show(
                    "You didn't choose an item to delete.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                return;
            }
            CurrentCustomer.CustomerCart.Items.RemoveAt(CartListBox.SelectedIndex);
            UpdateCartListBox();
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (CustomerComboBox.SelectedIndex != -1 && CurrentCustomer.CustomerCart.Items.Count != 0)
            {
                CurrentCustomer.Orders.Add(new Order(CurrentCustomer.CustomerAddress,
                    CurrentCustomer.CustomerCart.Items/* CurrentCustomer.Fullname*/));
                CurrentCustomer.CustomerCart.Items.Clear();
                UpdateCartListBox();
            }
            else
            {
                MessageBox.Show(
                    "Fill the cart or choose the customer to create an order.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                return;
            }
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            if (CustomerComboBox.SelectedIndex != -1)
            {
                CurrentCustomer.CustomerCart.Items.Clear();
                UpdateCartListBox();
            }
        }
    }
}

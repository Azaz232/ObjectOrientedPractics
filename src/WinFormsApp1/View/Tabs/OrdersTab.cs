using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        /// <summary>
        /// Selected index of the row in the orders list.
        /// </summary>
        private int _selectedOrderIndex;


        /// <summary>
        /// Gets and sets a list of orders.
        /// </summary>
        private List<Order> _orders = new List<Order>();

        /// <summary>
        /// Selected order.
        /// </summary>
        private Order _selectedOrder = new Order();


        public OrdersTab()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Refreshes data in OrdersDataGRidView.
        /// </summary>
        public void RefreshData()
        {
            OrdersDataGridView.Rows.Clear();
            _orders = new List<Order>();
            UpdateOrders();
            //RefreshDataGrid();
            LoadStatusComboBox();
        }


        //public void RefreshDataGrid()
        //{
        //    OrdersDataGridView.Rows.Clear();

        //    foreach (Order order in _orders)
        //    {
        //        OrdersDataGridView.Rows.Add(order.Id, order.Date, order.Status, /*$"{order.Address.Country}, " +
        //            $"{order.Address.City}, {order.Address.Street}, {order.Address.Building}," +
        //            $"{order.Address.Apartment}"*/ );
        //    }
        //}


        /// <summary>
        /// Updates orders in DataGridView.
        /// </summary>
        private void UpdateOrders()
        {
            _orders.Clear();
            OrdersDataGridView.Rows.Clear();

            foreach (var customer in Customers)
            {
                var address = $"{customer.CustomerAddress.Country}, {customer.CustomerAddress.City}";
                address += $"{customer.CustomerAddress.Street}, {customer.CustomerAddress.Building}";
                address += $"{customer.CustomerAddress.Apartment}";

                foreach (var order in customer.Orders)
                {
                    _orders.Add(order);
                    OrdersDataGridView.Rows.Add(
                        order.Id, order.Date, order.Status,
                        customer.Fullname, order.Amount
                        );
                }
            }
        }

        /// <summary>
        /// Adds elements of enum Orderstatus into StatusComboBox.
        /// </summary>
        private void LoadStatusComboBox()
        {
            StatusComboBox.Items.Clear();

            foreach (var status in Enum.GetValues(typeof(OrderStatus)))
            {
                StatusComboBox.Items.Add(status);
            }
        }

        /// <summary>
        /// Fills the list with orders.
        /// </summary>
        private void FillOrderItemsListBox()
        {
            OrderItemsListBox.Items.Clear();

            foreach (Item item in _orders[_selectedOrderIndex].Items)
            {
                OrderItemsListBox.Items.Add(item.Name);
            }
        }

        private void OrdersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (OrdersDataGridView.SelectedRows.Count != 0)
            {
                _selectedOrderIndex = OrdersDataGridView.SelectedRows[0].Index;
                _selectedOrder = _orders[_selectedOrderIndex];

                AddressControl.OurAddress = _orders[_selectedOrderIndex].Address;
                AddressControl.SelelctedTextBoxs();

                IdTextBox.Text = _selectedOrder.Id.ToString();
                CreatedTextBox.Text = _selectedOrder.Date.ToString();
                StatusComboBox.SelectedItem = _selectedOrder.Status;
                TotalCostLabel.Text = _selectedOrder.Amount.ToString();

                FillOrderItemsListBox();
            }
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string ourStatus = StatusComboBox.Text;
                OrderStatus orderStatus = (OrderStatus)Enum.Parse(typeof(OrderStatus), ourStatus);
                _selectedOrder.Status = orderStatus;
                //RefreshDataGrid();
            }
            catch (Exception)
            {
                MessageBox.Show(
                    "Incorrect status of the order.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                return;
            }
        }
    }
}

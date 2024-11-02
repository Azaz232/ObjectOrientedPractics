using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Model.Orders;
using ObjectOrientedPractics.View.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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

        /// <summary>
        /// Priority order.
        /// </summary>
        private PriorityOrder _priorityOrder;

        public OrdersTab()
        {
            InitializeComponent();
            StatusComboBox.DataSource = Enum.GetValues(typeof(OrderStatus));
            DeliveryTimeComboBox.DataSource = Enum.GetValues(typeof(OrderTime));
        }

        /// <summary>
        /// Refreshes data in OrdersDataGRidView.
        /// </summary>
        public void RefreshData()
        {
            OrdersDataGridView.Rows.Clear();
            _orders = new List<Order>();
            UpdateOrders();
            TotalCostLabel.Text = "0";
            TotalAmountLabel.Text = "0";
            //LoadStatusComboBox();
        }

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
                        customer.Fullname, order.Amount, order.Total
                        );
                }
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

        private List<string> ParseItemNames(List<Item> items)
        {
            var itemNames = items.Select(item => item.Name).ToList();
            return itemNames;
        }


        private void OrdersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (OrdersDataGridView.SelectedRows.Count != 0)
            {
                _selectedOrderIndex = OrdersDataGridView.CurrentCell.RowIndex;
                _selectedOrder = _orders[_selectedOrderIndex];

                AddressControl.OurAddress = _orders[_selectedOrderIndex].Address;
                AddressControl.SelelctedTextBoxs();

                IdTextBox.Text = _selectedOrder.Id.ToString();
                CreatedTextBox.Text = _selectedOrder.Date.ToString();
                StatusComboBox.SelectedItem = _selectedOrder.Status;
                TotalCostLabel.Text = _selectedOrder.Amount.ToString();
                TotalAmountLabel.Text = _selectedOrder.Total.ToString();


                if (_selectedOrder is PriorityOrder priorityOrder)
                {
                    _priorityOrder = (PriorityOrder)_orders[_selectedOrderIndex];
                    DeliveryTimeComboBox.SelectedIndex = ((int)_priorityOrder.DeliveryTime - 1);
                    PriorityOptionsGroupBox.Visible = true; 
                }
                else if(_selectedOrder is Order)
                {
                    _priorityOrder = null;
                    PriorityOptionsGroupBox.Visible = false;
                }
                FillOrderItemsListBox();
            }
        }


        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StatusComboBox.Text != null)
            {
                string ourStatus = StatusComboBox.Text;
                OrderStatus orderStatus = (OrderStatus)Enum.Parse(typeof(OrderStatus), ourStatus);
                _selectedOrder.Status = orderStatus;
            }
        }

        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_priorityOrder == null)
            {
                return;
            }

            if (DeliveryTimeComboBox.SelectedItem == null)
            {
                return; 
            }
            _priorityOrder.DeliveryTime = (OrderTime)DeliveryTimeComboBox.SelectedItem;


        }
    }
}

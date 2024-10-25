using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class PriorityOrderTab : UserControl
    {


        /// <summary>
        /// Selected order.
        /// </summary>
        private PriorityOrder _selectedOrder;


        /// <summary>
        /// List of orders.
        /// </summary>
        private List<Order> _orders = new List<Order>();

        /// <summary>
        /// List of priority orders.
        /// </summary>
        private List<PriorityOrder> _priorityOrders = new List<PriorityOrder>();

        /// <summary>
        /// Gets and sets a list of customers
        /// .
        /// </summary>
        public List<Customer> Customers { get; set; } = new List<Customer>();

        /// <summary>
        /// Gets and sets a list of items.
        /// </summary>
        public List<Item> Items { get; set; } = new List<Item>();

        /// <summary>
        /// Selected index in orders.
        /// </summary>
        private int _selectedOrderIndex;




        public PriorityOrderTab()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Updates list of orders.
        /// </summary>
        private void UpdateOrders()
        {
            _orders.Clear();
            _priorityOrders.Clear();
            foreach (Customer customer in Customers)
            {
                if (customer.Orders.Count != 0)
                {
                    foreach (Order order in customer.Orders)
                    {
                        _priorityOrders.Add(new PriorityOrder(order.Status, order.Address, order.Items,
                           DateTime.Now, OrderTime.f9t11));
                    }
                }
            }
        }


        /// <summary>
        /// Refreshes data with orders.
        /// </summary>
        private void RefreshDataGrid()
        {
            OrdersDataGridView.Rows.Clear();
            foreach (PriorityOrder order in _priorityOrders)
            {
                OrdersDataGridView.Rows.Add(order.Id, order.Date, order.Status);
            }
        }


        /// <summary>
        /// Fills the list with orders.
        /// </summary>
        private void FillOrderItemsListBox()
        {
            OrderItemsListBox.Items.Clear();
            foreach (Item item in _priorityOrders[_selectedOrderIndex].Items)
            {
                OrderItemsListBox.Items.Add(item.Name);
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
        /// Adds elements of enum Orderstatus into StatusComboBox.
        /// </summary>
        private void LoadDeliveryTimeComboBox()
        {
            DeliveryTimeComboBox.Items.Clear();
            foreach (var delivery in Enum.GetValues(typeof(OrderTime)))
            {
                DeliveryTimeComboBox.Items.Add(delivery);
            }
        }


        /// <summary>
        /// Refreshes data when swith to the tab.
        /// </summary>
        private void Refreshdata()
        {
            UpdateOrders();
            RefreshDataGrid();
            LoadStatusComboBox();
            LoadDeliveryTimeComboBox();
            TotalCostLabel.Text = "0";
        }

        /// <summary>
        /// Обновляет текстбоксы.
        /// </summary>
        public void ClearTextBoxs()
        {
            IdTextBox.Text = string.Empty;
            CreatedTextBox.Text = string.Empty;
            StatusComboBox.SelectedItem = null;
            DeliveryTimeComboBox.SelectedItem = null;
            TotalCostLabel.Text = "0";
            AddressControl.ClearTextBoxes();
            OrderItemsListBox.Items.Clear();
        }

        private void OrdersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (OrdersDataGridView.SelectedRows.Count != 0)
            {
                _selectedOrderIndex = OrdersDataGridView.SelectedRows[0].Index;
                _selectedOrder = _priorityOrders[_selectedOrderIndex];


                AddressControl.OurAddress = _orders[_selectedOrderIndex].Address;
                AddressControl.SelelctedTextBoxs();

                IdTextBox.Text = _selectedOrder.Id.ToString();
                CreatedTextBox.Text = _selectedOrder.Date.ToString();
                StatusComboBox.SelectedItem = _selectedOrder.Status;
                DeliveryTimeComboBox.SelectedItem = _selectedOrder.DeliveryTime;
                TotalCostLabel.Text = _selectedOrder.Amount.ToString();

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
                RefreshDataGrid();
            }
        }

        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DeliveryTimeComboBox.Text != null)
            {
                var selectedDeliveryTime = DeliveryTimeComboBox.Text;
                OrderTime orderTime = (OrderTime)Enum.Parse(typeof(OrderTime), selectedDeliveryTime);
                _selectedOrder.DeliveryTime = orderTime;
                RefreshDataGrid();
            }
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            Random ran = new Random();
            _selectedOrder.Items.Add(Items[ran.Next(Items.Count)]);
            FillOrderItemsListBox();
            TotalCostLabel.Text = _selectedOrder.Amount.ToString();
        }

        private void RemoveItemButtton_Click(object sender, EventArgs e)
        {
            _selectedOrder.Items.RemoveAt(OrderItemsListBox.SelectedIndex);
            FillOrderItemsListBox();
            TotalCostLabel.Text = _selectedOrder.Amount.ToString();
        }

        private void ClearOrderButton_Click(object sender, EventArgs e)
        {
            _selectedOrderIndex = OrdersDataGridView.CurrentCell.RowIndex;

            _priorityOrders.RemoveAt(_selectedOrderIndex);
            OrdersDataGridView.Rows.RemoveAt(_selectedOrderIndex);

            var newOrder = new PriorityOrder();
            _priorityOrders.Add(newOrder);
            OrdersDataGridView.Rows.Insert(_selectedOrderIndex, newOrder.Id,
                newOrder.Date, newOrder.Status);

            ClearTextBoxs();
        }
    }
}

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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomerTab : UserControl
    {
        /// <summary>
        /// List of customers.
        /// </summary>
        private List<Customer> _customersList = new List<Customer>();

        /// <summary>
        /// Variable - Customer type.
        /// </summary>
        private Customer _currentCustomer = new Customer();

        /// <summary>
        /// Variable - Customer type.
        /// </summary>
        private Customer _selectedCustomer = new Customer();
        public CustomerTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Generates object of Customer with the help of TextBox.
        /// </summary>
        private Customer AddItemsInfo()
        {
            string fullname = FullNameTextBox.Text;
            string address = AddressTextBox.Text;
            return new Customer(fullname, address);
        }

        /// <summary>
        /// Updates elements in ItemsListBox.
        /// </summary>
        private void UpdateListBox()
        {
            CustomersListBox.Items.Clear();

            foreach (Customer customer in _customersList)
            {
                CustomersListBox.Items.Add($"{customer.Id} / {customer.Fullname}");
            }
        }

        /// <summary>
        /// Clears info about a customer in the TextBox.
        /// </summary>
        private void ClearItemInfo()
        {
            FullNameTextBox.Clear();
            FullNameTextBox.BackColor = Color.White;

            AddressTextBox.Clear();
            AddressTextBox.BackColor = Color.White;

            IDTextBox.Clear();
        }

        /// <summary>
        /// Updates info about a customer in the TextBox.
        /// </summary>
        private void UpdateItemInfo(Customer customer)
        {
            IDTextBox.Text = customer.Id.ToString();
            FullNameTextBox.Text = customer.Fullname.ToString();
            AddressTextBox.Text = customer.Address.ToString();
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentCustomer.Fullname = FullNameTextBox.Text;
                FullNameTextBox.BackColor = Color.White;
            }
            catch (ArgumentException)
            {
                FullNameTextBox.BackColor = Color.LightPink;
            }
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentCustomer.Address = AddressTextBox.Text;
                AddressTextBox.BackColor = Color.White;
            }
            catch (ArgumentException)
            {
                AddressTextBox.BackColor = Color.LightPink;
            }
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a list of TextBoxes to check
                var textBoxes = new List<System.Windows.Forms.TextBox>
                { FullNameTextBox, AddressTextBox };
                bool ifRed = true;

                foreach (var textBox in textBoxes)
                {
                    if (textBox.BackColor == Color.LightPink)
                    {
                        ifRed = false;
                    }
                }

                // Check TextBoxes if they are empty or red
                if (textBoxes.All(tb => !string.IsNullOrWhiteSpace(tb.Text)) && ifRed)
                {
                    Customer selectedCustomer = AddItemsInfo();
                    _customersList.Add(selectedCustomer);
                    UpdateListBox();
                }
                else
                {
                    throw new Exception("Некоректные значения. Введите корректные значения для корректной работы программы.");
                }
            }
            catch (Exception ex)
            {
                // Error message
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1)
            {
                // No chosen elements error message
                MessageBox.Show(
                    "Не выбран элемент для удаления.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                return;
            }
            _customersList.RemoveAt(CustomersListBox.SelectedIndex);
            CustomersListBox.Items.RemoveAt(CustomersListBox.SelectedIndex);
            ClearItemInfo();
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem != null)
            {
                _currentCustomer = _customersList[CustomersListBox.SelectedIndex];
                UpdateItemInfo(_currentCustomer);
            }
        }

        private void CustomerListBox_DoubleClick(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem != null)
            {
                UpdateListBox();
                _currentCustomer = _selectedCustomer;
            }
        }
    }
}

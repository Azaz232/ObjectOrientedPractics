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
using ObjectOrientedPractics.View.AdditionalForms;
using ObjectOrientedPractics.Model.Discounts;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomerTab : UserControl
    {
        /// <summary>
        /// List of customers.
        /// </summary>
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Variable - Customer type.
        /// </summary>
        private Customer _currentCustomer = new Customer();

        /// <summary>
        /// Reterns and sets a list of cistomers.
        /// </summary>
        public List<Customer> Customers { get { return _customers; } set { _customers = value; } }



        private bool _isPriority = false;


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
            return new Customer(fullname);
        }

        /// <summary>
        /// Updates elements in ItemsListBox.
        /// </summary>
        private void UpdateListBox()
        {
            CustomersListBox.Items.Clear();

            foreach (Customer customer in _customers)
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
            AddressControl.ClearTextBoxes();
            IDTextBox.Clear();
        }

        /// <summary>
        /// Updates info in discounts list box. 
        /// </summary>
        /// <param name="customer"></param>
        private void UpdateDiscountsListBox(Customer customer)
        {
            DiscountsListBox.Items.Clear();

            foreach (var discount in customer.Discounts)
            {
                DiscountsListBox.Items.Add(discount.Info);
            }
        }

        /// <summary>
        /// Updates info in discounts list box. 
        /// </summary>
        private void UpdateDiscountsListBox()
        {
            if (CustomersListBox.SelectedIndex > 0)
            {
                UpdateDiscountsListBox(Customers[CustomersListBox.SelectedIndex]);
            }
        }

        /// <summary>
        /// Updates info about a customer in the TextBox.
        /// </summary>
        private void UpdateItemInfo()
        {
            _currentCustomer = _customers[CustomersListBox.SelectedIndex];
            IDTextBox.Text = _currentCustomer.Id.ToString();
            FullNameTextBox.Text = _currentCustomer.Fullname.ToString();
            Address selectedAddress = _currentCustomer.CustomerAddress;
            AddressControl.SelelctedTextBoxs();

            if (PriorityCheckBox.Checked)
            {
                _currentCustomer.IsPriority = true;
            }
            else
            {
                _currentCustomer.IsPriority = false;
            }

            UpdateDiscountsListBox(_currentCustomer);
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


        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a list of TextBoxes to check
                var textBoxes = new List<System.Windows.Forms.TextBox>
                { FullNameTextBox };
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
                    selectedCustomer.CustomerAddress = AddressControl.AddInfoFromTextBox();
                    selectedCustomer.IsPriority = _isPriority;
                    _customers.Add(selectedCustomer);
                    UpdateListBox();
                    //MessageBox.Show($"{selectedCustomer.IsPriority}");
                }
                else
                {
                    throw new Exception("Incorrect values.");
                }
            }
            catch (Exception ex)
            {
                // Error message
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1)
            {
                // No chosen elements error message
                MessageBox.Show(
                    "You didnt choose an object to delete it.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                return;
            }
            _customers.RemoveAt(CustomersListBox.SelectedIndex);
            CustomersListBox.Items.RemoveAt(CustomersListBox.SelectedIndex);
            ClearItemInfo();
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem != null)
            {
                UpdateItemInfo();
            }
        }

        private void CustomersListBox_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem != null)
            {
                AddressControl.EditTextBoxes(_currentCustomer);
            }
        }


        private void CustomerListBox_DoubleClick(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem != null)
            {
                UpdateListBox();
            }
        }

        private void PriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PriorityCheckBox.Checked == true)
            {
                _isPriority = true;
            }
            else
            {
                _isPriority = false;
            }
        }

        private void AddDiscountsButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                _currentCustomer = Customers[CustomersListBox.SelectedIndex];
                var discountWindowPopUp = new DiscountModalWindow(_currentCustomer);


                if (discountWindowPopUp.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                var discount = new PercentDiscount(discountWindowPopUp.Category);
                _currentCustomer.Discounts.Add(discount);
                UpdateDiscountsListBox(_currentCustomer);
            }
            else
            {
                MessageBox.Show(
                    "You didnt choose a customer to add a discount.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                return;
            }
        }

        private void RemoveDiscountsButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1 && DiscountsListBox.SelectedIndex != -1)
            {
                _currentCustomer = Customers[CustomersListBox.SelectedIndex];
                if (DiscountsListBox.SelectedIndex != 0)
                {
                    _currentCustomer.Discounts.RemoveAt(
                        DiscountsListBox.SelectedIndex);
                    UpdateDiscountsListBox(_currentCustomer);
                }
                else
                {
                    return;
                }
            }
            else
            {
                // Выводим сообщение, если не выбран элемент
                MessageBox.Show(
                    "You didnt choose a discount or a customer to delete.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                return;
            }
        }
    }
}

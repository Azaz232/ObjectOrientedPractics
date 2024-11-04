using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Model;
using System.Net;

namespace ObjectOrientedPractics.View.AdditionalForms
{
    /// <summary>
    /// Modal window for addition of percent discount to a customer.
    /// </summary>
    public partial class DiscountModalWindow : Form
    {
        /// <summary>
        /// Gets and sets the category of the item.
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Returns the customers.
        /// </summary>
        public Customer Customer { get; } = new Customer();  
        
        /// <summary>
        /// Creates a sample of the class
        /// </summary>
        /// <param name="customer"> Current customer. </param>
        public DiscountModalWindow(Customer customer)
        {
            InitializeComponent();
            Customer = customer;
            LoadCategoryComboBox();
        }

        /// <summary>
        /// Adds elements of category into categorycombobox.
        /// </summary>
        private void LoadCategoryComboBox()
        {
            var customerCategories = Customer.Discounts
                .OfType<PercentDiscount>()
                .Select(discount => discount.Category)
                .Distinct()
                .ToList();

            var dataCategories = Enum.GetValues(typeof(Category))
                .Cast<Category>()
                .ToList()
                .Except(customerCategories)
                .ToList();

            CategoryComboBox.DataSource = dataCategories;
        }


        private void OkDiscountsButton_Click(object sender, EventArgs e)
        {
            if (CategoryComboBox.SelectedItem != null)
            {
                Category = (Category)CategoryComboBox.SelectedItem;
                DialogResult = DialogResult.OK;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OkButton.Enabled = CategoryComboBox.SelectedIndex >= 0;
        }
    }
}

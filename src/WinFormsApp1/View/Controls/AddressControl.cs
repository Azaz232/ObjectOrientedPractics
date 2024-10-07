using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
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

        /// <summary>
        /// Updates information in TextBoxes.
        /// </summary>
        public void SelelctedTextBoxs(Address address)
        {
            PostIndexTextBox.Text = address.Index.ToString();
            CountryTextBox.Text = address.Country.ToString();
            CityTextBox.Text = address.City.ToString();
            StreetTextBox.Text = address.Street.ToString();
            BuildingTextBox.Text = address.Building.ToString();
            ApartmentTextBox.Text = address.Apartment.ToString();
        }

        /// <summary>
        /// Clears information in TextBoxes.
        /// </summary>
        public void ClearTextBoxes()
        {
            PostIndexTextBox.Clear();
            CountryTextBox.Clear();
            CityTextBox.Clear();
            StreetTextBox.Clear();
            BuildingTextBox.Clear();
            ApartmentTextBox.Clear();
        }

        /// <summary>
        /// Adds information from TextBoxes.                        
        /// </summary>
        public Address AddInfoFromTextBox()
        {
            int index = int.Parse(PostIndexTextBox.Text);
            string country = CountryTextBox.Text;
            string city = CityTextBox.Text;
            string street = StreetTextBox.Text;
            string building = BuildingTextBox.Text;
            string apartment = ApartmentTextBox.Text;

            return new Address(index, country, city, street, building, apartment);
        }

        /// <summary>
        /// Edits information from TextBoxes.                     
        /// </summary>
        private void EditTextBoxes(Customer customer)
        {
            customer.CustomerAddress.Index = int.Parse(PostIndexTextBox.Text);
            customer.CustomerAddress.Country = CountryTextBox.Text;
            customer.CustomerAddress.City = CityTextBox.Text;
            customer.CustomerAddress.Street = StreetTextBox.Text;
            customer.CustomerAddress.Building = BuildingTextBox.Text;
            customer.CustomerAddress.Apartment = ApartmentTextBox.Text;
        }

        private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Index = int.Parse(PostIndexTextBox.Text);
                PostIndexTextBox.BackColor = Color.White;
            }
            catch (Exception)
            {
                if (PostIndexTextBox.Text != "")
                {
                    PostIndexTextBox.BackColor = Color.LightPink;
                }
            }
        }

        private void CountyTextBox_TextxChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Country = CountryTextBox.Text;
                CountryTextBox.BackColor = Color.White;
            }
            catch (ArgumentException)
            {
                CountryTextBox.BackColor = Color.LightPink;
            }
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.City = CityTextBox.Text;
                CityTextBox.BackColor = Color.White;
            }
            catch (ArgumentException)
            {
                CityTextBox.BackColor = Color.LightPink;
            }
        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Street = StreetTextBox.Text;
                StreetTextBox.BackColor = Color.White;
            }
            catch (ArgumentException)
            {
                StreetTextBox.BackColor = Color.LightPink;
            }
        }

        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Building = BuildingTextBox.Text;
                BuildingTextBox.BackColor = Color.White;
            }
            catch (ArgumentException)
            {
                BuildingTextBox.BackColor = Color.LightPink;
            }
        }

        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Apartment = ApartmentTextBox.Text;
                ApartmentTextBox.BackColor = Color.White;
            }
            catch (ArgumentException)
            {
                ApartmentTextBox.BackColor = Color.LightPink;
            }
        }
    }
}

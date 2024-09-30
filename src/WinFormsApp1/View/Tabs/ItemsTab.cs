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
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// List of items.
        /// </summary>
        private List<Item> _itemsList = new();

        /// <summary>
        /// Variable - type Item.
        /// </summary>
        private Item _currentItem = new Item();

        /// <summary>
        /// Variable - type Item.
        /// </summary>
        private Item _selectedItem = new Item();

        public ItemsTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Generates objects of an item with TextBoxes.
        /// </summary>
        private Model.Item AddItemsInfo()
        {
            string name = NameTextBox.Text;
            string description = DescriptionTextBox.Text;
            double cost = double.Parse(CostTextBox.Text);
            return new Model.Item(name, description, cost);
        }

        /// <summary>
        /// Adds list elements to ItemListBox.
        /// </summary>
        private void UpdateListBox()
        {
            ItemsListBox.Items.Clear();

            foreach (Item item in _itemsList)
            {
                ItemsListBox.Items.Add($"{item.Id} / {item.Name}");
            }
        }

        /// <summary>
        /// Clears info about an item from TextBoxes.
        /// </summary>
        private void ClearItemInfo()
        {
            IDTextBox.Clear();

            CostTextBox.Clear();
            CostTextBox.BackColor = Color.White;

            DescriptionTextBox.Clear();
            DescriptionTextBox.BackColor = Color.White;

            NameTextBox.Clear();
            NameTextBox.BackColor = Color.White;
        }

        /// <summary>
        /// Updates info about an item in TextBox.
        /// </summary>
        /// <param name="item">Обновляемая книга.</param>
        private void UpdateItemInfo(Item item)
        {
            IDTextBox.Text = item.Id.ToString();
            DescriptionTextBox.Text = item.Info.ToString();
            CostTextBox.Text = item.Cost.ToString();
            NameTextBox.Text = item.Name.ToString();
        }

        private void NameTextBox_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                _currentItem.Name = NameTextBox.Text;
                NameTextBox.BackColor = Color.White;
            }
            catch (ArgumentException)
            {
                NameTextBox.BackColor = Color.LightPink;
            }
        }

        private void CostTextBox_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                _currentItem.Cost = double.Parse(CostTextBox.Text);
                CostTextBox.BackColor = Color.White;
            }
            catch (Exception)
            {
                if (CostTextBox.Text != "")
                {
                    CostTextBox.BackColor = Color.LightPink;
                }
            }

        }

        private void DescriptionTextBox_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                _currentItem.Info = DescriptionTextBox.Text;
                DescriptionTextBox.BackColor = Color.White;
            }
            catch (ArgumentException)
            {
                DescriptionTextBox.BackColor = Color.LightPink;
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "No selected items.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                return;
            }
            _itemsList.RemoveAt(ItemsListBox.SelectedIndex);
            ItemsListBox.Items.RemoveAt(ItemsListBox.SelectedIndex);
            ClearItemInfo();
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem != null)
            {
                _currentItem = _itemsList[ItemsListBox.SelectedIndex];
                UpdateItemInfo(_currentItem);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                // list of TextBoxes
                var TextBoxes = new List<TextBox> { CostTextBox, NameTextBox, DescriptionTextBox };
                bool RedBox = true;

                foreach (var TextBox in TextBoxes)
                {
                    if (TextBox.BackColor == Color.LightPink)
                    {
                        RedBox = false;
                    }
                }
                // check for empty or red boxes.
                if (TextBoxes.All(box => !string.IsNullOrWhiteSpace(box.Text)) && RedBox)
                {
                    Model.Item selectedItem = AddItemsInfo();
                    _itemsList.Add(selectedItem);
                    UpdateListBox();
                }
                else
                {
                    throw new Exception("Incorrect Values. ");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void ItemsListBox_DoubleClick(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem != null)
            {
                UpdateListBox();
                _currentItem = _selectedItem;
            }
        }

        

    }

}

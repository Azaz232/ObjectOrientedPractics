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

        public ItemsTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Generates objects of an item with TextBoxes.
        /// </summary>
        private void AddItemsInfo()
        {
            string name = NameTextBox.Text;
            string descryption = DescriptionTextBox.Text;
            double cost = double.Parse(CostTextBox.Text);
            _currentItem = new Model.Item(name, descryption, cost);
        }

        /// <summary>
        /// Adds list elements to ItemListBox.
        /// </summary>
        private void UpdateItemsInfo()
        {
            ItemsListBox.Items.Clear();
            foreach (Item item in _itemsList)
            {
                ItemsListBox.Items.Add($"{item.Id} / {item.Name} / {item.Cost}");
            }
        }

        /// <summary>
        /// Clears info about an item from TextBoxes.
        /// </summary>
        private void ClearItemInfo()
        {
            CostTextBox.Clear();
            CostTextBox.BackColor = Color.White;

            DescriptionTextBox.Clear();
            DescriptionTextBox.BackColor = Color.White;

            NameTextBox.Clear();
            NameTextBox.BackColor = Color.White;

            IDTextBox.Clear();
        }

        /// <summary>
        /// Updates info about an item in TextBoxes.
        /// </summary>
        /// <param name="item">Обновляемая книга.</param>
        private void UpdateItemInfo()
        {
            IDTextBox.Text = _currentItem.Id.ToString();
            DescriptionTextBox.Text = _currentItem.Info.ToString();
            CostTextBox.Text = _currentItem.Cost.ToString();
            NameTextBox.Text = _currentItem.Name.ToString();
        }

        /// <summary>
        /// Редактирует объект книги с помощью TextBox's.
        /// </summary>
        private void EditBooksInfo()
        {
            if (ItemsListBox.SelectedItem != null)
            {
                _currentItem.Cost = double.Parse(CostTextBox.Text);
                _currentItem.Name = NameTextBox.Text;
                _currentItem.Info = DescriptionTextBox.Text;
            }
        }
        // 7


        private void NameTextBox_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                string valueName = NameTextBox.Text;
                if (valueName.Length > 200)
                {
                    NameTextBox.BackColor = Color.LightPink;
                }
                else
                {
                    NameTextBox.BackColor = Color.White;
                }
            }
            catch (SystemException)
            {
                NameTextBox.BackColor = Color.LightPink;
            }
        }

        private void CostTextBox_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                double valueCost = double.Parse(CostTextBox.Text);
                if (valueCost < 0 || valueCost > 100000)
                {
                    CostTextBox.BackColor = Color.LightPink;
                }
                else
                {
                    CostTextBox.BackColor = Color.White;
                }
            }
            catch (SystemException)
            {
                CostTextBox.BackColor = Color.LightPink;
            }
        }

        private void DescriptionTextBox_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                string valueInfo = DescriptionTextBox.Text;
                if (valueInfo.Length > 1000)
                {
                    DescriptionTextBox.BackColor = Color.LightPink;
                }
                else
                {
                    DescriptionTextBox.BackColor = Color.White;
                }
            }
            catch (SystemException)
            {
                DescriptionTextBox.BackColor = Color.LightPink;
            }
        }
        private void AddButton_Click()
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
                    AddItemsInfo();
                    _itemsList.Add(_currentItem);
                    UpdateItemInfo();
                    ClearItemInfo();

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
                UpdateItemsInfo();
            }
            if (ItemsListBox.SelectedIndex == -1)
            {
                ClearItemInfo();
            }
        }
    }

}

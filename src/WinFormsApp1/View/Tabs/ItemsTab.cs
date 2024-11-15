using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
        public List<Item> _items = new();

        /// <summary>
        /// Variable - type Item.
        /// </summary>
        private Item _currentItem = new Item();

        /// <summary>
        /// Variable - type Item.
        /// </summary>
        private Item _selectedItem = new Item();

        /// <summary>
        /// Gets and sets a list of item.
        /// </summary>
        public List<Item> Items { get { return _items; } set { _items = value; } }

        /// <summary>
        /// Gets and sets a delegate of filtration criteria.
        /// </summary>
        private Predicate<Item> FilterCriteria { get; set; }

        /// <summary>
        /// Gets and sets a delegate of sort criteria.
        /// </summary>
        private DataTools.CompareCriteria SortCriteria { get; set; }

        /// <summary>
        /// Event of item being changed
        /// </summary>
        public event EventHandler<EventArgs> ItemsChanged;

        private List<Item> _displayedItems = new();


        public ItemsTab()
        {
            InitializeComponent();
            LoadCategoryComboBox();
            SortByComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Generates objects of an item with TextBoxes.
        /// </summary>
        private Model.Item AddItemsInfo()
        {
            string name = NameTextBox.Text;
            string description = DescriptionTextBox.Text;
            double cost = double.Parse(CostTextBox.Text);
            Category category = (Category)CategoryComboBox.SelectedItem;
            return new Model.Item(name, description, cost);
        }

        /// <summary>
        /// Adds list elements to ItemListBox.
        /// </summary>
        private void UpdateListBox(List<Item> items)
        {
            ItemsListBox.Items.Clear();

            foreach (Item item in items)
            {
                ItemsListBox.Items.Add($"{item.Id} / {item.Name} / {item.Category}");
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

            CategoryComboBox.SelectedIndex = -1;
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
            CategoryComboBox.Text = item.Category.ToString();
        }

        private void NameTextBox_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                _currentItem.Name = NameTextBox.Text;
                NameTextBox.BackColor = Color.White;
                ItemsChanged?.Invoke(this, EventArgs.Empty);
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
                ItemsChanged?.Invoke(this, EventArgs.Empty);
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
                ItemsChanged?.Invoke(this, EventArgs.Empty);
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
            _items.RemoveAt(ItemsListBox.SelectedIndex);
            ItemsListBox.Items.RemoveAt(ItemsListBox.SelectedIndex);
            ClearItemInfo();
            ItemsChanged?.Invoke(this, EventArgs.Empty);
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem != null)
            {
                _currentItem = _items[ItemsListBox.SelectedIndex];
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
                if (TextBoxes.All(tb => !string.IsNullOrWhiteSpace(tb.Text))
                    && CategoryComboBox.SelectedItem != null && RedBox)
                {
                    Item selectedItem = AddItemsInfo();
                    selectedItem.Category = (Category)CategoryComboBox.SelectedItem;
                    _items.Add(selectedItem);
                    //UpdateListBox();
                    _displayedItems = Items;
                    UpdateDisplayedItems();
                    ItemsChanged?.Invoke(this, EventArgs.Empty);
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
                UpdateDisplayedItems();
                //_currentItem = _selectedItem;
            }
        }

        /// <summary>
        /// Adds elements of Category into CategoryComboBox.
        /// </summary>
        private void LoadCategoryComboBox()
        {
            foreach (var item in Enum.GetValues(typeof(Category)))
            {
                CategoryComboBox.Items.Add(item);
            }
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CategoryComboBox.SelectedItem != null && ItemsListBox.SelectedItem != null)
            {
                _currentItem.Category = (Category)CategoryComboBox.SelectedItem;
                UpdateItemInfo(_currentItem);
                ItemsChanged?.Invoke(this, EventArgs.Empty);
            }
        }


        private void UpdateDisplayedItems()
        {
            var displayedItems = Items;

            if (FilterCriteria != null)
            {
                displayedItems = DataTools.FilterItems(displayedItems, FilterCriteria);
            }
            if (SortCriteria != null)
            {
                displayedItems = DataTools.SortItems(displayedItems, SortCriteria);
            }

            _displayedItems = displayedItems;
            UpdateListBox(_displayedItems);
        }


        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FindTextBox.Text.Length == 0)
            {
                FilterCriteria = null;
            }
            else
            {
                FilterCriteria = (item) => { return item.Name.Contains(FindTextBox.Text); };
            }
            UpdateDisplayedItems();
        }

        private void SortByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SortByComboBox.SelectedIndex)
            {
                case 0:
                    {
                        SortCriteria = (first, second) =>
                        {
                            return first.Name.CompareTo(second.Name) < 0;
                        };
                        break;
                    }
                case 1:
                    {
                        SortCriteria = (first, second) =>
                        {
                            return first.Cost.CompareTo(second.Cost) > 0;
                        };
                        break;
                    }
                case 2:
                    {
                        SortCriteria = (first, second) =>
                        {
                            return first.Cost.CompareTo(second.Cost) < 0;
                        };
                        break;
                    }
            }
            _displayedItems = Items;
            UpdateDisplayedItems();
        }
    }
}

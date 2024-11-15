using ObjectOrientedPractics.View.Tabs;
using ObjectOrientedPractics.Model;


namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// .
        /// </summary>
        private Store _store = new Store();
        public MainForm()
        {
            InitializeComponent();
            itemsTab1.Items = _store.Items;
            customer1.Customers = _store.Customers;

            cartTab1.Items = _store.Items;
            cartTab1.Customers = _store.Customers;

            ordersTab1.Customers = _store.Customers;

            priorityOrderTab1.Customers = _store.Customers;
            priorityOrderTab1.Items = _store.Items;


            itemsTab1.ItemsChanged += ItemsChanged;
            cartTab1.OrdersCreated += OrdersCreated;
            customer1.CustomersChanged += CustomersChanged;

        }

        //private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    switch (tabControl1.SelectedIndex)
        //    {
        //        case 2:
        //            cartTab1.RefreshData();
        //            break;
        //        case 3:
        //            ordersTab1.RefreshData();
        //            break;
        //        case 4:
        //            priorityOrderTab1.RefreshData();
        //            break;
        //    }
        //}

        private void ItemsChanged(object? sender, EventArgs e)
        {
            cartTab1.Items = itemsTab1.Items;
            cartTab1.RefreshData();
        }
        
        private void OrdersCreated(object? sender, EventArgs e)
        {
            cartTab1.Items = itemsTab1.Items;
            cartTab1.RefreshData();
            ordersTab1.RefreshData();
        }

        private void CustomersChanged(object? sender, EventArgs e)
        {
            cartTab1.Customers = customer1.Customers;
            ordersTab1.Customers = _store.Customers;
            cartTab1.RefreshData();
            ordersTab1.RefreshData();
        }
    }
}

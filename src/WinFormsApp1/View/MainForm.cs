using ObjectOrientedPractics.View.Tabs;
using ObjectOrientedPractics.Model;


namespace WinFormsApp1
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Переменная типа Store.
        /// </summary>
        private Store _store = new Store();
        public MainForm()
        {
            InitializeComponent();
            itemsTab1.Items = _store.Items;
            customer1.Customers = _store.Customers;
        }
    }
}

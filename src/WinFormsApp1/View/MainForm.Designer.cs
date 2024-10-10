﻿namespace WinFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tabControl1 = new TabControl();
            ItemTab = new TabPage();
            itemsTab1 = new ObjectOrientedPractics.View.Tabs.ItemsTab();
            CustomerTab = new TabPage();
            customer1 = new ObjectOrientedPractics.View.Tabs.CustomerTab();
            CartsTab = new TabPage();
            cartTab1 = new ObjectOrientedPractics.View.Tabs.CartTab();
            OrdersTab = new TabPage();
            ordersTab1 = new ObjectOrientedPractics.View.Tabs.OrdersTab();
            tabControl1.SuspendLayout();
            ItemTab.SuspendLayout();
            CustomerTab.SuspendLayout();
            CartsTab.SuspendLayout();
            OrdersTab.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(ItemTab);
            tabControl1.Controls.Add(CustomerTab);
            tabControl1.Controls.Add(CartsTab);
            tabControl1.Controls.Add(OrdersTab);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(736, 620);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // ItemTab
            // 
            ItemTab.Controls.Add(itemsTab1);
            ItemTab.Location = new Point(4, 24);
            ItemTab.Margin = new Padding(3, 2, 3, 2);
            ItemTab.Name = "ItemTab";
            ItemTab.Padding = new Padding(3, 2, 3, 2);
            ItemTab.Size = new Size(601, 548);
            ItemTab.TabIndex = 0;
            ItemTab.Text = "Items";
            ItemTab.UseVisualStyleBackColor = true;
            // 
            // itemsTab1
            // 
            itemsTab1.Dock = DockStyle.Fill;
            itemsTab1.Location = new Point(3, 2);
            itemsTab1.Margin = new Padding(3, 2, 3, 2);
            itemsTab1.Name = "itemsTab1";
            itemsTab1.Size = new Size(595, 544);
            itemsTab1.TabIndex = 0;
            // 
            // CustomerTab
            // 
            CustomerTab.Controls.Add(customer1);
            CustomerTab.Location = new Point(4, 24);
            CustomerTab.Margin = new Padding(3, 2, 3, 2);
            CustomerTab.Name = "CustomerTab";
            CustomerTab.Padding = new Padding(3, 2, 3, 2);
            CustomerTab.Size = new Size(601, 548);
            CustomerTab.TabIndex = 1;
            CustomerTab.Text = "Customers";
            CustomerTab.UseVisualStyleBackColor = true;
            // 
            // customer1
            // 
            customer1.Dock = DockStyle.Fill;
            customer1.Location = new Point(3, 2);
            customer1.Margin = new Padding(3, 2, 3, 2);
            customer1.Name = "customer1";
            customer1.Size = new Size(595, 544);
            customer1.TabIndex = 0;
            // 
            // CartsTab
            // 
            CartsTab.Controls.Add(cartTab1);
            CartsTab.Location = new Point(4, 24);
            CartsTab.Name = "CartsTab";
            CartsTab.Size = new Size(601, 548);
            CartsTab.TabIndex = 2;
            CartsTab.Text = "Carts";
            CartsTab.UseVisualStyleBackColor = true;
            // 
            // cartTab1
            // 
            cartTab1.Customers = null;
            cartTab1.Dock = DockStyle.Fill;
            cartTab1.Items = null;
            cartTab1.Location = new Point(0, 0);
            cartTab1.Name = "cartTab1";
            cartTab1.Size = new Size(601, 548);
            cartTab1.TabIndex = 0;
            // 
            // OrdersTab
            // 
            OrdersTab.Controls.Add(ordersTab1);
            OrdersTab.Location = new Point(4, 24);
            OrdersTab.Name = "OrdersTab";
            OrdersTab.Size = new Size(728, 592);
            OrdersTab.TabIndex = 3;
            OrdersTab.Text = "Orders";
            OrdersTab.UseVisualStyleBackColor = true;
            // 
            // ordersTab1
            // 
            ordersTab1.Dock = DockStyle.Fill;
            ordersTab1.Location = new Point(0, 0);
            ordersTab1.Name = "ordersTab1";
            ordersTab1.Size = new Size(728, 592);
            ordersTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 620);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            ItemTab.ResumeLayout(false);
            CustomerTab.ResumeLayout(false);
            CartsTab.ResumeLayout(false);
            OrdersTab.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage ItemTab;
        private TabPage CustomerTab;
        private ObjectOrientedPractics.View.Tabs.ItemsTab itemsTab1;
        private ObjectOrientedPractics.View.Tabs.CustomerTab customer1;
        private TabPage CartsTab;
        private ObjectOrientedPractics.View.Tabs.CartTab cartTab1;
        private TabPage OrdersTab;
        private ObjectOrientedPractics.View.Tabs.OrdersTab ordersTab1;
    }
}

﻿namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomerTab
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            Model.Address address1 = new Model.Address();
            CustomersGroupBox = new GroupBox();
            CustomersListBox = new ListBox();
            SelectedCustomerGroupBox = new GroupBox();
            FullNameTextBox = new TextBox();
            IDTextBox = new TextBox();
            FullNameLabel = new Label();
            IDLabel = new Label();
            ButtonsGroupBox = new GroupBox();
            RemoveButton = new Button();
            AddButton = new Button();
            CustomerPanel = new Panel();
            AddressControl = new Controls.AddressControl();
            CustomersGroupBox.SuspendLayout();
            SelectedCustomerGroupBox.SuspendLayout();
            ButtonsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // CustomersGroupBox
            // 
            CustomersGroupBox.Controls.Add(CustomersListBox);
            CustomersGroupBox.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CustomersGroupBox.Location = new Point(0, 0);
            CustomersGroupBox.Name = "CustomersGroupBox";
            CustomersGroupBox.Size = new Size(236, 503);
            CustomersGroupBox.TabIndex = 0;
            CustomersGroupBox.TabStop = false;
            CustomersGroupBox.Text = "Customers";
            // 
            // CustomersListBox
            // 
            CustomersListBox.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.ItemHeight = 17;
            CustomersListBox.Location = new Point(6, 27);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(230, 480);
            CustomersListBox.TabIndex = 6;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            CustomersListBox.DoubleClick += CustomerListBox_DoubleClick;
            // 
            // SelectedCustomerGroupBox
            // 
            SelectedCustomerGroupBox.Controls.Add(AddressControl);
            SelectedCustomerGroupBox.Controls.Add(FullNameTextBox);
            SelectedCustomerGroupBox.Controls.Add(IDTextBox);
            SelectedCustomerGroupBox.Controls.Add(FullNameLabel);
            SelectedCustomerGroupBox.Controls.Add(IDLabel);
            SelectedCustomerGroupBox.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SelectedCustomerGroupBox.Location = new Point(242, 0);
            SelectedCustomerGroupBox.Name = "SelectedCustomerGroupBox";
            SelectedCustomerGroupBox.Size = new Size(554, 413);
            SelectedCustomerGroupBox.TabIndex = 1;
            SelectedCustomerGroupBox.TabStop = false;
            SelectedCustomerGroupBox.Text = "Selected Customer";
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Location = new Point(101, 83);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(313, 28);
            FullNameTextBox.TabIndex = 4;
            FullNameTextBox.TextChanged += FullNameTextBox_TextChanged;
            // 
            // IDTextBox
            // 
            IDTextBox.Enabled = false;
            IDTextBox.Location = new Point(101, 39);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.ReadOnly = true;
            IDTextBox.Size = new Size(125, 28);
            IDTextBox.TabIndex = 3;
            // 
            // FullNameLabel
            // 
            FullNameLabel.AutoSize = true;
            FullNameLabel.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FullNameLabel.Location = new Point(6, 88);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(78, 17);
            FullNameLabel.TabIndex = 1;
            FullNameLabel.Text = "Full Name:";
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            IDLabel.Location = new Point(6, 44);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(30, 17);
            IDLabel.TabIndex = 0;
            IDLabel.Text = "ID: ";
            // 
            // ButtonsGroupBox
            // 
            ButtonsGroupBox.Controls.Add(RemoveButton);
            ButtonsGroupBox.Controls.Add(AddButton);
            ButtonsGroupBox.Location = new Point(3, 509);
            ButtonsGroupBox.Name = "ButtonsGroupBox";
            ButtonsGroupBox.Size = new Size(233, 59);
            ButtonsGroupBox.TabIndex = 0;
            ButtonsGroupBox.TabStop = false;
            // 
            // RemoveButton
            // 
            RemoveButton.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RemoveButton.Location = new Point(115, 11);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(118, 48);
            RemoveButton.TabIndex = 1;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // AddButton
            // 
            AddButton.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddButton.Location = new Point(0, 11);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(118, 48);
            AddButton.TabIndex = 0;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // CustomerPanel
            // 
            CustomerPanel.BackgroundImageLayout = ImageLayout.None;
            CustomerPanel.Location = new Point(242, 419);
            CustomerPanel.Name = "CustomerPanel";
            CustomerPanel.Size = new Size(548, 149);
            CustomerPanel.TabIndex = 2;
            // 
            // AddressControl
            // 
            AddressControl.Location = new Point(0, 117);
            AddressControl.Name = "AddressControl";
            address1.Apartment = "";
            address1.Building = "";
            address1.City = "";
            address1.Country = "";
            address1.Index = 100000;
            address1.Street = "";
            AddressControl.OurAddress = address1;
            AddressControl.Size = new Size(548, 238);
            AddressControl.TabIndex = 5;
            // 
            // CustomerTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CustomerPanel);
            Controls.Add(ButtonsGroupBox);
            Controls.Add(SelectedCustomerGroupBox);
            Controls.Add(CustomersGroupBox);
            Name = "CustomerTab";
            Size = new Size(799, 571);
            CustomersGroupBox.ResumeLayout(false);
            SelectedCustomerGroupBox.ResumeLayout(false);
            SelectedCustomerGroupBox.PerformLayout();
            ButtonsGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox CustomersGroupBox;
        private GroupBox SelectedCustomerGroupBox;
        private GroupBox ButtonsGroupBox;
        private Label FullNameLabel;
        private Label IDLabel;
        private TextBox FullNameTextBox;
        private TextBox IDTextBox;
        private Panel CustomerPanel;
        private Button AddButton;
        private Button RemoveButton;
        private ListBox CustomersListBox;
        private Controls.AddressControl AddressControl;
    }
}

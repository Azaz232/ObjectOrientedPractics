namespace ObjectOrientedPractics.View.Tabs
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
            AddressControl = new Controls.AddressControl();
            FullNameTextBox = new TextBox();
            IDTextBox = new TextBox();
            FullNameLabel = new Label();
            IDLabel = new Label();
            ButtonsGroupBox = new GroupBox();
            RemoveButton = new Button();
            AddButton = new Button();
            CustomersGroupBox.SuspendLayout();
            SelectedCustomerGroupBox.SuspendLayout();
            ButtonsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // CustomersGroupBox
            // 
            CustomersGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CustomersGroupBox.Controls.Add(CustomersListBox);
            CustomersGroupBox.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CustomersGroupBox.Location = new Point(0, 0);
            CustomersGroupBox.Margin = new Padding(3, 2, 3, 2);
            CustomersGroupBox.Name = "CustomersGroupBox";
            CustomersGroupBox.Padding = new Padding(3, 2, 3, 2);
            CustomersGroupBox.Size = new Size(235, 370);
            CustomersGroupBox.TabIndex = 0;
            CustomersGroupBox.TabStop = false;
            CustomersGroupBox.Text = "Customers";
            // 
            // CustomersListBox
            // 
            CustomersListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomersListBox.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.ItemHeight = 15;
            CustomersListBox.Location = new Point(5, 20);
            CustomersListBox.Margin = new Padding(3, 2, 3, 2);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(230, 304);
            CustomersListBox.TabIndex = 6;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            CustomersListBox.DoubleClick += CustomerListBox_DoubleClick;
            // 
            // SelectedCustomerGroupBox
            // 
            SelectedCustomerGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SelectedCustomerGroupBox.Controls.Add(AddressControl);
            SelectedCustomerGroupBox.Controls.Add(FullNameTextBox);
            SelectedCustomerGroupBox.Controls.Add(IDTextBox);
            SelectedCustomerGroupBox.Controls.Add(FullNameLabel);
            SelectedCustomerGroupBox.Controls.Add(IDLabel);
            SelectedCustomerGroupBox.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SelectedCustomerGroupBox.Location = new Point(247, 22);
            SelectedCustomerGroupBox.Margin = new Padding(3, 2, 3, 2);
            SelectedCustomerGroupBox.Name = "SelectedCustomerGroupBox";
            SelectedCustomerGroupBox.Padding = new Padding(3, 2, 3, 2);
            SelectedCustomerGroupBox.Size = new Size(466, 348);
            SelectedCustomerGroupBox.TabIndex = 1;
            SelectedCustomerGroupBox.TabStop = false;
            SelectedCustomerGroupBox.Text = "Selected Customer";
            // 
            // AddressControl
            // 
            AddressControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddressControl.Location = new Point(5, 88);
            AddressControl.Margin = new Padding(3, 2, 3, 2);
            AddressControl.Name = "AddressControl";
            address1.Apartment = "";
            address1.Building = "";
            address1.City = "";
            address1.Country = "";
            address1.Index = 100000;
            address1.Street = "";
            AddressControl.OurAddress = address1;
            AddressControl.Size = new Size(457, 153);
            AddressControl.TabIndex = 5;
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Location = new Point(88, 62);
            FullNameTextBox.Margin = new Padding(3, 2, 3, 2);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(278, 24);
            FullNameTextBox.TabIndex = 4;
            FullNameTextBox.TextChanged += FullNameTextBox_TextChanged;
            // 
            // IDTextBox
            // 
            IDTextBox.Enabled = false;
            IDTextBox.Location = new Point(88, 29);
            IDTextBox.Margin = new Padding(3, 2, 3, 2);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.ReadOnly = true;
            IDTextBox.Size = new Size(110, 24);
            IDTextBox.TabIndex = 3;
            // 
            // FullNameLabel
            // 
            FullNameLabel.AutoSize = true;
            FullNameLabel.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FullNameLabel.Location = new Point(5, 66);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(67, 15);
            FullNameLabel.TabIndex = 1;
            FullNameLabel.Text = "Full Name:";
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            IDLabel.Location = new Point(5, 33);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(25, 15);
            IDLabel.TabIndex = 0;
            IDLabel.Text = "ID: ";
            // 
            // ButtonsGroupBox
            // 
            ButtonsGroupBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonsGroupBox.Controls.Add(RemoveButton);
            ButtonsGroupBox.Controls.Add(AddButton);
            ButtonsGroupBox.Location = new Point(12, 374);
            ButtonsGroupBox.Margin = new Padding(3, 2, 3, 2);
            ButtonsGroupBox.Name = "ButtonsGroupBox";
            ButtonsGroupBox.Padding = new Padding(3, 2, 3, 2);
            ButtonsGroupBox.Size = new Size(223, 61);
            ButtonsGroupBox.TabIndex = 0;
            ButtonsGroupBox.TabStop = false;
            // 
            // RemoveButton
            // 
            RemoveButton.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RemoveButton.Location = new Point(101, 8);
            RemoveButton.Margin = new Padding(3, 2, 3, 2);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(103, 36);
            RemoveButton.TabIndex = 1;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // AddButton
            // 
            AddButton.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddButton.Location = new Point(0, 8);
            AddButton.Margin = new Padding(3, 2, 3, 2);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(103, 36);
            AddButton.TabIndex = 0;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // CustomerTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ButtonsGroupBox);
            Controls.Add(SelectedCustomerGroupBox);
            Controls.Add(CustomersGroupBox);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(716, 437);
            Name = "CustomerTab";
            Size = new Size(716, 437);
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
        private Button AddButton;
        private Button RemoveButton;
        private ListBox CustomersListBox;
        private Controls.AddressControl AddressControl;
    }
}

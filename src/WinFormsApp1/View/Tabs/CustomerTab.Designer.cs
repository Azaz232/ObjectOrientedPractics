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
            DiscountsPanel = new Panel();
            DiscountsdLabel = new Label();
            RemoveDiscountsButton = new Button();
            AddDiscountsButton = new Button();
            DiscountsListBox = new ListBox();
            PriorityCheckBox = new CheckBox();
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
            DiscountsPanel.SuspendLayout();
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
            CustomersGroupBox.Size = new Size(235, 572);
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
            CustomersListBox.Size = new Size(230, 499);
            CustomersListBox.TabIndex = 6;
            CustomersListBox.Click += CustomersListBox_Click;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            CustomersListBox.DoubleClick += CustomerListBox_DoubleClick;
            // 
            // SelectedCustomerGroupBox
            // 
            SelectedCustomerGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SelectedCustomerGroupBox.Controls.Add(DiscountsPanel);
            SelectedCustomerGroupBox.Controls.Add(PriorityCheckBox);
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
            SelectedCustomerGroupBox.Size = new Size(466, 550);
            SelectedCustomerGroupBox.TabIndex = 1;
            SelectedCustomerGroupBox.TabStop = false;
            SelectedCustomerGroupBox.Text = "Selected Customer";
            // 
            // DiscountsPanel
            // 
            DiscountsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DiscountsPanel.Controls.Add(DiscountsdLabel);
            DiscountsPanel.Controls.Add(RemoveDiscountsButton);
            DiscountsPanel.Controls.Add(AddDiscountsButton);
            DiscountsPanel.Controls.Add(DiscountsListBox);
            DiscountsPanel.Location = new Point(16, 340);
            DiscountsPanel.MinimumSize = new Size(440, 150);
            DiscountsPanel.Name = "DiscountsPanel";
            DiscountsPanel.Size = new Size(444, 177);
            DiscountsPanel.TabIndex = 7;
            // 
            // DiscountsdLabel
            // 
            DiscountsdLabel.AutoSize = true;
            DiscountsdLabel.Location = new Point(20, 6);
            DiscountsdLabel.Name = "DiscountsdLabel";
            DiscountsdLabel.Size = new Size(67, 15);
            DiscountsdLabel.TabIndex = 3;
            DiscountsdLabel.Text = "Discounts";
            // 
            // RemoveDiscountsButton
            // 
            RemoveDiscountsButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RemoveDiscountsButton.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RemoveDiscountsButton.Location = new Point(321, 82);
            RemoveDiscountsButton.Margin = new Padding(3, 2, 3, 2);
            RemoveDiscountsButton.Name = "RemoveDiscountsButton";
            RemoveDiscountsButton.Size = new Size(103, 36);
            RemoveDiscountsButton.TabIndex = 2;
            RemoveDiscountsButton.Text = "Remove";
            RemoveDiscountsButton.UseVisualStyleBackColor = true;
            RemoveDiscountsButton.Click += RemoveDiscountsButton_Click;
            // 
            // AddDiscountsButton
            // 
            AddDiscountsButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddDiscountsButton.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddDiscountsButton.Location = new Point(321, 38);
            AddDiscountsButton.Margin = new Padding(3, 2, 3, 2);
            AddDiscountsButton.Name = "AddDiscountsButton";
            AddDiscountsButton.Size = new Size(103, 36);
            AddDiscountsButton.TabIndex = 1;
            AddDiscountsButton.Text = "Add";
            AddDiscountsButton.UseVisualStyleBackColor = true;
            AddDiscountsButton.Click += AddDiscountsButton_Click;
            // 
            // DiscountsListBox
            // 
            DiscountsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DiscountsListBox.FormattingEnabled = true;
            DiscountsListBox.ItemHeight = 15;
            DiscountsListBox.Location = new Point(20, 38);
            DiscountsListBox.MaximumSize = new Size(301, 124);
            DiscountsListBox.MinimumSize = new Size(260, 120);
            DiscountsListBox.Name = "DiscountsListBox";
            DiscountsListBox.Size = new Size(268, 124);
            DiscountsListBox.TabIndex = 0;
            // 
            // PriorityCheckBox
            // 
            PriorityCheckBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PriorityCheckBox.AutoSize = true;
            PriorityCheckBox.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PriorityCheckBox.Location = new Point(89, 105);
            PriorityCheckBox.Name = "PriorityCheckBox";
            PriorityCheckBox.Size = new Size(97, 19);
            PriorityCheckBox.TabIndex = 6;
            PriorityCheckBox.Text = "Priority Order";
            PriorityCheckBox.UseVisualStyleBackColor = true;
            PriorityCheckBox.CheckedChanged += PriorityCheckBox_CheckedChanged;
            // 
            // AddressControl
            // 
            AddressControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddressControl.Location = new Point(3, 164);
            AddressControl.Margin = new Padding(3, 2, 3, 2);
            AddressControl.MinimumSize = new Size(390, 180);
            AddressControl.Name = "AddressControl";
            address1.Apartment = "";
            address1.Building = "";
            address1.City = "";
            address1.Country = "";
            address1.Index = 100000;
            address1.Street = "";
            AddressControl.OurAddress = address1;
            AddressControl.Size = new Size(457, 207);
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
            ButtonsGroupBox.Location = new Point(12, 576);
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
            Size = new Size(716, 639);
            CustomersGroupBox.ResumeLayout(false);
            SelectedCustomerGroupBox.ResumeLayout(false);
            SelectedCustomerGroupBox.PerformLayout();
            DiscountsPanel.ResumeLayout(false);
            DiscountsPanel.PerformLayout();
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
        private CheckBox PriorityCheckBox;
        private Panel DiscountsPanel;
        private ListBox DiscountsListBox;
        private Button RemoveDiscountsButton;
        private Button AddDiscountsButton;
        private Label DiscountsdLabel;
    }
}

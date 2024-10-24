namespace ObjectOrientedPractics.View.Tabs
{
    partial class PriorityOrderTab
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
            Model.Address address2 = new Model.Address();
            AddressControl = new Controls.AddressControl();
            SelectedOrderGroupBox = new GroupBox();
            StatusComboBox = new ComboBox();
            CreatedTextBox = new TextBox();
            IdTextBox = new TextBox();
            StatusLabel = new Label();
            CreatedLabel = new Label();
            IdLabel = new Label();
            OrderItemsListBox = new ListBox();
            OrderItemsGroupBox = new GroupBox();
            CustomerGroupBox2 = new GroupBox();
            AddItemButton = new Button();
            AmountLabel = new Label();
            TotalCostLabel = new Label();
            ClearOrderButton = new Button();
            RemoveItemButtton = new Button();
            label1 = new Label();
            label2 = new Label();
            PriorityOptionsGroupBox = new GroupBox();
            DeliveryTimeLabel = new Label();
            DeliveruTimeComboBox = new ComboBox();
            SelectedOrderGroupBox.SuspendLayout();
            OrderItemsGroupBox.SuspendLayout();
            CustomerGroupBox2.SuspendLayout();
            PriorityOptionsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // AddressControl
            // 
            AddressControl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddressControl.Location = new Point(39, 172);
            AddressControl.Margin = new Padding(3, 2, 3, 2);
            AddressControl.MinimumSize = new Size(390, 180);
            AddressControl.Name = "AddressControl";
            address2.Apartment = "";
            address2.Building = "";
            address2.City = "";
            address2.Country = "";
            address2.Index = 100000;
            address2.Street = "";
            AddressControl.OurAddress = address2;
            AddressControl.Size = new Size(464, 180);
            AddressControl.TabIndex = 9;
            // 
            // SelectedOrderGroupBox
            // 
            SelectedOrderGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SelectedOrderGroupBox.Controls.Add(PriorityOptionsGroupBox);
            SelectedOrderGroupBox.Controls.Add(StatusComboBox);
            SelectedOrderGroupBox.Controls.Add(CreatedTextBox);
            SelectedOrderGroupBox.Controls.Add(IdTextBox);
            SelectedOrderGroupBox.Controls.Add(StatusLabel);
            SelectedOrderGroupBox.Controls.Add(CreatedLabel);
            SelectedOrderGroupBox.Controls.Add(IdLabel);
            SelectedOrderGroupBox.Location = new Point(39, 25);
            SelectedOrderGroupBox.Name = "SelectedOrderGroupBox";
            SelectedOrderGroupBox.Size = new Size(464, 128);
            SelectedOrderGroupBox.TabIndex = 8;
            SelectedOrderGroupBox.TabStop = false;
            SelectedOrderGroupBox.Text = "Selected Order";
            // 
            // StatusComboBox
            // 
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Location = new Point(65, 91);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(121, 23);
            StatusComboBox.TabIndex = 5;
            // 
            // CreatedTextBox
            // 
            CreatedTextBox.Location = new Point(65, 56);
            CreatedTextBox.Name = "CreatedTextBox";
            CreatedTextBox.Size = new Size(121, 23);
            CreatedTextBox.TabIndex = 4;
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(65, 22);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(121, 23);
            IdTextBox.TabIndex = 3;
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new Point(6, 94);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(42, 15);
            StatusLabel.TabIndex = 2;
            StatusLabel.Text = "Status:";
            // 
            // CreatedLabel
            // 
            CreatedLabel.AutoSize = true;
            CreatedLabel.Location = new Point(6, 59);
            CreatedLabel.Name = "CreatedLabel";
            CreatedLabel.Size = new Size(51, 15);
            CreatedLabel.TabIndex = 1;
            CreatedLabel.Text = "Created:";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(6, 25);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(21, 15);
            IdLabel.TabIndex = 0;
            IdLabel.Text = "ID:";
            // 
            // OrderItemsListBox
            // 
            OrderItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OrderItemsListBox.FormattingEnabled = true;
            OrderItemsListBox.ItemHeight = 15;
            OrderItemsListBox.Location = new Point(16, 22);
            OrderItemsListBox.Name = "OrderItemsListBox";
            OrderItemsListBox.Size = new Size(462, 94);
            OrderItemsListBox.TabIndex = 10;
            // 
            // OrderItemsGroupBox
            // 
            OrderItemsGroupBox.Controls.Add(CustomerGroupBox2);
            OrderItemsGroupBox.Controls.Add(OrderItemsListBox);
            OrderItemsGroupBox.Location = new Point(45, 345);
            OrderItemsGroupBox.Name = "OrderItemsGroupBox";
            OrderItemsGroupBox.Size = new Size(522, 249);
            OrderItemsGroupBox.TabIndex = 11;
            OrderItemsGroupBox.TabStop = false;
            OrderItemsGroupBox.Text = "OrderItems";
            // 
            // CustomerGroupBox2
            // 
            CustomerGroupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomerGroupBox2.Controls.Add(label1);
            CustomerGroupBox2.Controls.Add(label2);
            CustomerGroupBox2.Controls.Add(AddItemButton);
            CustomerGroupBox2.Controls.Add(AmountLabel);
            CustomerGroupBox2.Controls.Add(TotalCostLabel);
            CustomerGroupBox2.Controls.Add(ClearOrderButton);
            CustomerGroupBox2.Controls.Add(RemoveItemButtton);
            CustomerGroupBox2.Location = new Point(16, 138);
            CustomerGroupBox2.MinimumSize = new Size(300, 105);
            CustomerGroupBox2.Name = "CustomerGroupBox2";
            CustomerGroupBox2.Size = new Size(462, 105);
            CustomerGroupBox2.TabIndex = 14;
            CustomerGroupBox2.TabStop = false;
            // 
            // AddItemButton
            // 
            AddItemButton.Location = new Point(6, 71);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(111, 23);
            AddItemButton.TabIndex = 8;
            AddItemButton.Text = "Add iItem";
            AddItemButton.UseVisualStyleBackColor = true;
            // 
            // AmountLabel
            // 
            AmountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AmountLabel.ForeColor = SystemColors.ControlText;
            AmountLabel.Location = new Point(534, 10);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(60, 15);
            AmountLabel.TabIndex = 6;
            AmountLabel.Text = "Amount:";
            // 
            // TotalCostLabel
            // 
            TotalCostLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            TotalCostLabel.AutoSize = true;
            TotalCostLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TotalCostLabel.Location = new Point(534, 37);
            TotalCostLabel.Name = "TotalCostLabel";
            TotalCostLabel.Size = new Size(60, 21);
            TotalCostLabel.TabIndex = 7;
            TotalCostLabel.Text = "44777";
            // 
            // ClearOrderButton
            // 
            ClearOrderButton.Location = new Point(363, 70);
            ClearOrderButton.Name = "ClearOrderButton";
            ClearOrderButton.Size = new Size(99, 23);
            ClearOrderButton.TabIndex = 10;
            ClearOrderButton.Text = "Clear Order";
            ClearOrderButton.UseVisualStyleBackColor = true;
            // 
            // RemoveItemButtton
            // 
            RemoveItemButtton.Location = new Point(139, 71);
            RemoveItemButtton.Name = "RemoveItemButtton";
            RemoveItemButtton.Size = new Size(94, 23);
            RemoveItemButtton.TabIndex = 9;
            RemoveItemButtton.Text = "Remove Item";
            RemoveItemButtton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(396, 19);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 11;
            label1.Text = "Amount:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(396, 46);
            label2.Name = "label2";
            label2.Size = new Size(60, 21);
            label2.TabIndex = 12;
            label2.Text = "44777";
            // 
            // PriorityOptionsGroupBox
            // 
            PriorityOptionsGroupBox.Controls.Add(DeliveruTimeComboBox);
            PriorityOptionsGroupBox.Controls.Add(DeliveryTimeLabel);
            PriorityOptionsGroupBox.Location = new Point(210, 0);
            PriorityOptionsGroupBox.Name = "PriorityOptionsGroupBox";
            PriorityOptionsGroupBox.Size = new Size(237, 93);
            PriorityOptionsGroupBox.TabIndex = 6;
            PriorityOptionsGroupBox.TabStop = false;
            PriorityOptionsGroupBox.Text = "Priority Options";
            // 
            // DeliveryTimeLabel
            // 
            DeliveryTimeLabel.AutoSize = true;
            DeliveryTimeLabel.Location = new Point(6, 26);
            DeliveryTimeLabel.Name = "DeliveryTimeLabel";
            DeliveryTimeLabel.Size = new Size(81, 15);
            DeliveryTimeLabel.TabIndex = 0;
            DeliveryTimeLabel.Text = "Delivery Time:";
            // 
            // DeliveruTimeComboBox
            // 
            DeliveruTimeComboBox.FormattingEnabled = true;
            DeliveruTimeComboBox.Location = new Point(110, 26);
            DeliveruTimeComboBox.Name = "DeliveruTimeComboBox";
            DeliveruTimeComboBox.Size = new Size(121, 23);
            DeliveruTimeComboBox.TabIndex = 1;
            DeliveruTimeComboBox.Text = "9:00 - 11:00";
            // 
            // PriorityOrderTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(OrderItemsGroupBox);
            Controls.Add(AddressControl);
            Controls.Add(SelectedOrderGroupBox);
            Name = "PriorityOrderTab";
            Size = new Size(626, 810);
            SelectedOrderGroupBox.ResumeLayout(false);
            SelectedOrderGroupBox.PerformLayout();
            OrderItemsGroupBox.ResumeLayout(false);
            CustomerGroupBox2.ResumeLayout(false);
            CustomerGroupBox2.PerformLayout();
            PriorityOptionsGroupBox.ResumeLayout(false);
            PriorityOptionsGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Controls.AddressControl AddressControl;
        private GroupBox SelectedOrderGroupBox;
        private ComboBox StatusComboBox;
        private TextBox CreatedTextBox;
        private TextBox IdTextBox;
        private Label StatusLabel;
        private Label CreatedLabel;
        private Label IdLabel;
        private ListBox OrderItemsListBox;
        private GroupBox OrderItemsGroupBox;
        private GroupBox CustomerGroupBox2;
        private Button AddItemButton;
        private Label AmountLabel;
        private Label TotalCostLabel;
        private Button ClearOrderButton;
        private Button RemoveItemButtton;
        private Label label1;
        private Label label2;
        private GroupBox PriorityOptionsGroupBox;
        private ComboBox DeliveruTimeComboBox;
        private Label DeliveryTimeLabel;
    }
}

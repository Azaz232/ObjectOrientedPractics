namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartTab
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
            CustomerGroupBox = new GroupBox();
            CustomerGroupBox2 = new GroupBox();
            CreateOrderButton = new Button();
            AmountLabel = new Label();
            TotalCostLabel = new Label();
            ClearCartButton = new Button();
            RemoveItemButtton = new Button();
            CartListBox = new ListBox();
            CartLabel = new Label();
            CustomerLabel = new Label();
            CustomerComboBox = new ComboBox();
            ItemsGroupBox = new GroupBox();
            AddToCartButton = new Button();
            ItemsListBox = new ListBox();
            CustomerGroupBox.SuspendLayout();
            CustomerGroupBox2.SuspendLayout();
            ItemsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // CustomerGroupBox
            // 
            CustomerGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomerGroupBox.BackgroundImageLayout = ImageLayout.None;
            CustomerGroupBox.Controls.Add(CustomerGroupBox2);
            CustomerGroupBox.Controls.Add(CartListBox);
            CustomerGroupBox.Controls.Add(CartLabel);
            CustomerGroupBox.Controls.Add(CustomerLabel);
            CustomerGroupBox.Controls.Add(CustomerComboBox);
            CustomerGroupBox.Location = new Point(200, 3);
            CustomerGroupBox.MinimumSize = new Size(305, 250);
            CustomerGroupBox.Name = "CustomerGroupBox";
            CustomerGroupBox.Size = new Size(446, 378);
            CustomerGroupBox.TabIndex = 12;
            CustomerGroupBox.TabStop = false;
            // 
            // CustomerGroupBox2
            // 
            CustomerGroupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomerGroupBox2.Controls.Add(CreateOrderButton);
            CustomerGroupBox2.Controls.Add(AmountLabel);
            CustomerGroupBox2.Controls.Add(TotalCostLabel);
            CustomerGroupBox2.Controls.Add(ClearCartButton);
            CustomerGroupBox2.Controls.Add(RemoveItemButtton);
            CustomerGroupBox2.Location = new Point(6, 251);
            CustomerGroupBox2.MinimumSize = new Size(300, 105);
            CustomerGroupBox2.Name = "CustomerGroupBox2";
            CustomerGroupBox2.Size = new Size(436, 105);
            CustomerGroupBox2.TabIndex = 13;
            CustomerGroupBox2.TabStop = false;
            // 
            // CreateOrderButton
            // 
            CreateOrderButton.Location = new Point(6, 71);
            CreateOrderButton.Name = "CreateOrderButton";
            CreateOrderButton.Size = new Size(111, 23);
            CreateOrderButton.TabIndex = 8;
            CreateOrderButton.Text = "Create Order";
            CreateOrderButton.UseVisualStyleBackColor = true;
            CreateOrderButton.Click += CreateOrderButton_Click;
            // 
            // AmountLabel
            // 
            AmountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AmountLabel.ForeColor = SystemColors.ControlText;
            AmountLabel.Location = new Point(362, 10);
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
            TotalCostLabel.Location = new Point(362, 37);
            TotalCostLabel.Name = "TotalCostLabel";
            TotalCostLabel.Size = new Size(60, 21);
            TotalCostLabel.TabIndex = 7;
            TotalCostLabel.Text = "44777";
            // 
            // ClearCartButton
            // 
            ClearCartButton.Location = new Point(239, 71);
            ClearCartButton.Name = "ClearCartButton";
            ClearCartButton.Size = new Size(99, 23);
            ClearCartButton.TabIndex = 10;
            ClearCartButton.Text = "Clear Cart";
            ClearCartButton.UseVisualStyleBackColor = true;
            ClearCartButton.Click += ClearCartButton_Click;
            // 
            // RemoveItemButtton
            // 
            RemoveItemButtton.Location = new Point(139, 71);
            RemoveItemButtton.Name = "RemoveItemButtton";
            RemoveItemButtton.Size = new Size(94, 23);
            RemoveItemButtton.TabIndex = 9;
            RemoveItemButtton.Text = "Remove Item";
            RemoveItemButtton.UseVisualStyleBackColor = true;
            RemoveItemButtton.Click += RemoveItemButtton_Click;
            // 
            // CartListBox
            // 
            CartListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CartListBox.FormattingEnabled = true;
            CartListBox.ItemHeight = 15;
            CartListBox.Location = new Point(14, 73);
            CartListBox.MinimumSize = new Size(269, 169);
            CartListBox.Name = "CartListBox";
            CartListBox.Size = new Size(393, 169);
            CartListBox.TabIndex = 11;
            // 
            // CartLabel
            // 
            CartLabel.AutoSize = true;
            CartLabel.Location = new Point(14, 45);
            CartLabel.Name = "CartLabel";
            CartLabel.Size = new Size(32, 15);
            CartLabel.TabIndex = 4;
            CartLabel.Text = "Cart:";
            // 
            // CustomerLabel
            // 
            CustomerLabel.AutoSize = true;
            CustomerLabel.Location = new Point(14, 19);
            CustomerLabel.Name = "CustomerLabel";
            CustomerLabel.Size = new Size(65, 15);
            CustomerLabel.TabIndex = 2;
            CustomerLabel.Text = "Customer: ";
            // 
            // CustomerComboBox
            // 
            CustomerComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CustomerComboBox.FormattingEnabled = true;
            CustomerComboBox.Location = new Point(92, 16);
            CustomerComboBox.Name = "CustomerComboBox";
            CustomerComboBox.Size = new Size(315, 23);
            CustomerComboBox.TabIndex = 3;
            CustomerComboBox.SelectedIndexChanged += CustomerComboBox_SelectedIndexChanged;
            // 
            // ItemsGroupBox
            // 
            ItemsGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ItemsGroupBox.Controls.Add(AddToCartButton);
            ItemsGroupBox.Controls.Add(ItemsListBox);
            ItemsGroupBox.Location = new Point(0, 0);
            ItemsGroupBox.MinimumSize = new Size(200, 400);
            ItemsGroupBox.Name = "ItemsGroupBox";
            ItemsGroupBox.Size = new Size(200, 560);
            ItemsGroupBox.TabIndex = 0;
            ItemsGroupBox.TabStop = false;
            ItemsGroupBox.Text = "Items";
            // 
            // AddToCartButton
            // 
            AddToCartButton.Dock = DockStyle.Bottom;
            AddToCartButton.Location = new Point(3, 527);
            AddToCartButton.MinimumSize = new Size(80, 30);
            AddToCartButton.Name = "AddToCartButton";
            AddToCartButton.Size = new Size(194, 30);
            AddToCartButton.TabIndex = 1;
            AddToCartButton.Text = "Add To Cart";
            AddToCartButton.UseVisualStyleBackColor = true;
            AddToCartButton.Click += AddToCartButton_Click;
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 15;
            ItemsListBox.Location = new Point(3, 19);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(191, 469);
            ItemsListBox.TabIndex = 11;
            // 
            // CartTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ItemsGroupBox);
            Controls.Add(CustomerGroupBox);
            MinimumSize = new Size(556, 403);
            Name = "CartTab";
            Size = new Size(646, 563);
            CustomerGroupBox.ResumeLayout(false);
            CustomerGroupBox.PerformLayout();
            CustomerGroupBox2.ResumeLayout(false);
            CustomerGroupBox2.PerformLayout();
            ItemsGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox CustomerGroupBox;
        private ListBox CartListBox;
        private Label CartLabel;
        private Label CustomerLabel;
        private ComboBox CustomerComboBox;
        private GroupBox ItemsGroupBox;
        private ListBox ItemsListBox;
        private Button AddToCartButton;
        private GroupBox CustomerGroupBox2;
        private Button CreateOrderButton;
        private Label AmountLabel;
        private Label TotalCostLabel;
        private Button ClearCartButton;
        private Button RemoveItemButtton;
    }
}

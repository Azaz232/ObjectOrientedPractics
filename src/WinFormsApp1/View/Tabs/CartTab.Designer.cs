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
            panel1 = new Panel();
            CartListBox = new ListBox();
            ClearCartButton = new Button();
            RemoveItemButtton = new Button();
            CreateOrderButton = new Button();
            TotalCostLabel = new Label();
            AmountLabel = new Label();
            CartLabel = new Label();
            CustomerComboBox = new ComboBox();
            CustomerLabel = new Label();
            AddToCartButton = new Button();
            ItemsGroupBox = new GroupBox();
            ItemsListBox = new ListBox();
            panel1.SuspendLayout();
            ItemsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(CartListBox);
            panel1.Controls.Add(ClearCartButton);
            panel1.Controls.Add(RemoveItemButtton);
            panel1.Controls.Add(CreateOrderButton);
            panel1.Controls.Add(TotalCostLabel);
            panel1.Controls.Add(AmountLabel);
            panel1.Controls.Add(CartLabel);
            panel1.Controls.Add(CustomerComboBox);
            panel1.Controls.Add(CustomerLabel);
            panel1.Controls.Add(AddToCartButton);
            panel1.Controls.Add(ItemsGroupBox);
            panel1.Location = new Point(15, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(580, 496);
            panel1.TabIndex = 0;
            // 
            // CartListBox
            // 
            CartListBox.FormattingEnabled = true;
            CartListBox.ItemHeight = 15;
            CartListBox.Location = new Point(244, 66);
            CartListBox.Name = "CartListBox";
            CartListBox.Size = new Size(325, 109);
            CartListBox.TabIndex = 11;
            // 
            // ClearCartButton
            // 
            ClearCartButton.Location = new Point(481, 254);
            ClearCartButton.Name = "ClearCartButton";
            ClearCartButton.Size = new Size(75, 23);
            ClearCartButton.TabIndex = 10;
            ClearCartButton.Text = "Clear Cart";
            ClearCartButton.UseVisualStyleBackColor = true;
            ClearCartButton.Click += ClearCartButton_Click;
            // 
            // RemoveItemButtton
            // 
            RemoveItemButtton.Location = new Point(378, 254);
            RemoveItemButtton.Name = "RemoveItemButtton";
            RemoveItemButtton.Size = new Size(97, 23);
            RemoveItemButtton.TabIndex = 9;
            RemoveItemButtton.Text = "Remove Item";
            RemoveItemButtton.UseVisualStyleBackColor = true;
            RemoveItemButtton.Click += RemoveItemButtton_Click;
            // 
            // CreateOrderButton
            // 
            CreateOrderButton.Location = new Point(244, 254);
            CreateOrderButton.Name = "CreateOrderButton";
            CreateOrderButton.Size = new Size(86, 23);
            CreateOrderButton.TabIndex = 8;
            CreateOrderButton.Text = "Create Order";
            CreateOrderButton.UseVisualStyleBackColor = true;
            CreateOrderButton.Click += CreateOrderButton_Click;
            // 
            // TotalCostLabel
            // 
            TotalCostLabel.AutoSize = true;
            TotalCostLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TotalCostLabel.Location = new Point(497, 217);
            TotalCostLabel.Name = "TotalCostLabel";
            TotalCostLabel.Size = new Size(60, 21);
            TotalCostLabel.TabIndex = 7;
            TotalCostLabel.Text = "44777";
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AmountLabel.ForeColor = SystemColors.ControlText;
            AmountLabel.Location = new Point(497, 188);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(60, 15);
            AmountLabel.TabIndex = 6;
            AmountLabel.Text = "Amount:";
            // 
            // CartLabel
            // 
            CartLabel.AutoSize = true;
            CartLabel.Location = new Point(244, 48);
            CartLabel.Name = "CartLabel";
            CartLabel.Size = new Size(32, 15);
            CartLabel.TabIndex = 4;
            CartLabel.Text = "Cart:";
            // 
            // CustomerComboBox
            // 
            CustomerComboBox.FormattingEnabled = true;
            CustomerComboBox.Location = new Point(322, 10);
            CustomerComboBox.Name = "CustomerComboBox";
            CustomerComboBox.Size = new Size(247, 23);
            CustomerComboBox.TabIndex = 3;
            CustomerComboBox.SelectedIndexChanged += CustomerComboBox_SelectedIndexChanged;
            // 
            // CustomerLabel
            // 
            CustomerLabel.AutoSize = true;
            CustomerLabel.Location = new Point(244, 13);
            CustomerLabel.Name = "CustomerLabel";
            CustomerLabel.Size = new Size(65, 15);
            CustomerLabel.TabIndex = 2;
            CustomerLabel.Text = "Customer: ";
            // 
            // AddToCartButton
            // 
            AddToCartButton.Location = new Point(9, 455);
            AddToCartButton.MinimumSize = new Size(80, 30);
            AddToCartButton.Name = "AddToCartButton";
            AddToCartButton.Size = new Size(93, 32);
            AddToCartButton.TabIndex = 1;
            AddToCartButton.Text = "Add To Cart";
            AddToCartButton.UseVisualStyleBackColor = true;
            AddToCartButton.Click += AddToCartButton_Click;
            // 
            // ItemsGroupBox
            // 
            ItemsGroupBox.Controls.Add(ItemsListBox);
            ItemsGroupBox.Location = new Point(3, 3);
            ItemsGroupBox.MinimumSize = new Size(200, 400);
            ItemsGroupBox.Name = "ItemsGroupBox";
            ItemsGroupBox.Size = new Size(219, 456);
            ItemsGroupBox.TabIndex = 0;
            ItemsGroupBox.TabStop = false;
            ItemsGroupBox.Text = "Items";
            // 
            // ItemsListBox
            // 
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 15;
            ItemsListBox.Location = new Point(6, 22);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(207, 424);
            ItemsListBox.TabIndex = 11;
            // 
            // CartTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "CartTab";
            Size = new Size(611, 528);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ItemsGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button AddToCartButton;
        private GroupBox ItemsGroupBox;
        private Label CustomerLabel;
        private Label TotalCostLabel;
        private Label AmountLabel;
        private Label CartLabel;
        private ComboBox CustomerComboBox;
        private Button ClearCartButton;
        private Button RemoveItemButtton;
        private Button CreateOrderButton;
        private ListBox ItemsListBox;
        private ListBox CartListBox;
    }
}

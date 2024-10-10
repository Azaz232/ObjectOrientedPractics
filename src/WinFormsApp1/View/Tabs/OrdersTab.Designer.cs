namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdersTab
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
            SelectedOrderGroupBox = new GroupBox();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            StatusLabel = new Label();
            CreatedLabel = new Label();
            IdLabel = new Label();
            DeliveryAddressGroupBox = new GroupBox();
            CityTextBox = new TextBox();
            ApartmentTextBox = new TextBox();
            BuildingTextBox = new TextBox();
            StreetTextBox = new TextBox();
            CountryTextBox = new TextBox();
            PostIndexTextBox = new TextBox();
            ApartmentLabel = new Label();
            CityLabel = new Label();
            BuildingLabel = new Label();
            StreetLabel = new Label();
            CountryLabel = new Label();
            PostIndexLabel = new Label();
            OrderItemsLabel = new Label();
            OrderItemsListBox = new ListBox();
            AmountLabel = new Label();
            TotalCostLabel = new Label();
            dataGridView1 = new DataGridView();
            IdColumn = new DataGridViewTextBoxColumn();
            CreatedColumn = new DataGridViewTextBoxColumn();
            OrderStatusColumn = new DataGridViewTextBoxColumn();
            CustomerFullNameColumn = new DataGridViewTextBoxColumn();
            SelectedOrderGroupBox.SuspendLayout();
            DeliveryAddressGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // SelectedOrderGroupBox
            // 
            SelectedOrderGroupBox.Controls.Add(comboBox1);
            SelectedOrderGroupBox.Controls.Add(textBox2);
            SelectedOrderGroupBox.Controls.Add(textBox1);
            SelectedOrderGroupBox.Controls.Add(StatusLabel);
            SelectedOrderGroupBox.Controls.Add(CreatedLabel);
            SelectedOrderGroupBox.Controls.Add(IdLabel);
            SelectedOrderGroupBox.Location = new Point(326, 3);
            SelectedOrderGroupBox.Name = "SelectedOrderGroupBox";
            SelectedOrderGroupBox.Size = new Size(285, 128);
            SelectedOrderGroupBox.TabIndex = 0;
            SelectedOrderGroupBox.TabStop = false;
            SelectedOrderGroupBox.Text = "Selected Order";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(65, 91);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(65, 56);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(65, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 3;
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
            // DeliveryAddressGroupBox
            // 
            DeliveryAddressGroupBox.Controls.Add(CityTextBox);
            DeliveryAddressGroupBox.Controls.Add(ApartmentTextBox);
            DeliveryAddressGroupBox.Controls.Add(BuildingTextBox);
            DeliveryAddressGroupBox.Controls.Add(StreetTextBox);
            DeliveryAddressGroupBox.Controls.Add(CountryTextBox);
            DeliveryAddressGroupBox.Controls.Add(PostIndexTextBox);
            DeliveryAddressGroupBox.Controls.Add(ApartmentLabel);
            DeliveryAddressGroupBox.Controls.Add(CityLabel);
            DeliveryAddressGroupBox.Controls.Add(BuildingLabel);
            DeliveryAddressGroupBox.Controls.Add(StreetLabel);
            DeliveryAddressGroupBox.Controls.Add(CountryLabel);
            DeliveryAddressGroupBox.Controls.Add(PostIndexLabel);
            DeliveryAddressGroupBox.Location = new Point(326, 147);
            DeliveryAddressGroupBox.Name = "DeliveryAddressGroupBox";
            DeliveryAddressGroupBox.Size = new Size(394, 180);
            DeliveryAddressGroupBox.TabIndex = 1;
            DeliveryAddressGroupBox.TabStop = false;
            DeliveryAddressGroupBox.Text = "Delivery Address";
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(272, 62);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(105, 23);
            CityTextBox.TabIndex = 11;
            // 
            // ApartmentTextBox
            // 
            ApartmentTextBox.Location = new Point(262, 137);
            ApartmentTextBox.Name = "ApartmentTextBox";
            ApartmentTextBox.Size = new Size(115, 23);
            ApartmentTextBox.TabIndex = 10;
            // 
            // BuildingTextBox
            // 
            BuildingTextBox.Location = new Point(77, 137);
            BuildingTextBox.Name = "BuildingTextBox";
            BuildingTextBox.Size = new Size(52, 23);
            BuildingTextBox.TabIndex = 9;
            // 
            // StreetTextBox
            // 
            StreetTextBox.Location = new Point(77, 98);
            StreetTextBox.Name = "StreetTextBox";
            StreetTextBox.Size = new Size(300, 23);
            StreetTextBox.TabIndex = 8;
            // 
            // CountryTextBox
            // 
            CountryTextBox.Location = new Point(77, 62);
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.Size = new Size(152, 23);
            CountryTextBox.TabIndex = 7;
            // 
            // PostIndexTextBox
            // 
            PostIndexTextBox.Location = new Point(77, 28);
            PostIndexTextBox.Name = "PostIndexTextBox";
            PostIndexTextBox.Size = new Size(100, 23);
            PostIndexTextBox.TabIndex = 6;
            // 
            // ApartmentLabel
            // 
            ApartmentLabel.AutoSize = true;
            ApartmentLabel.Location = new Point(189, 140);
            ApartmentLabel.Name = "ApartmentLabel";
            ApartmentLabel.Size = new Size(67, 15);
            ApartmentLabel.TabIndex = 5;
            ApartmentLabel.Text = "Apartment:";
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(235, 65);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(31, 15);
            CityLabel.TabIndex = 4;
            CityLabel.Text = "City:";
            // 
            // BuildingLabel
            // 
            BuildingLabel.AutoSize = true;
            BuildingLabel.Location = new Point(6, 140);
            BuildingLabel.Name = "BuildingLabel";
            BuildingLabel.Size = new Size(54, 15);
            BuildingLabel.TabIndex = 3;
            BuildingLabel.Text = "Building:";
            // 
            // StreetLabel
            // 
            StreetLabel.AutoSize = true;
            StreetLabel.Location = new Point(6, 101);
            StreetLabel.Name = "StreetLabel";
            StreetLabel.Size = new Size(40, 15);
            StreetLabel.TabIndex = 2;
            StreetLabel.Text = "Street:";
            // 
            // CountryLabel
            // 
            CountryLabel.AutoSize = true;
            CountryLabel.Location = new Point(6, 65);
            CountryLabel.Name = "CountryLabel";
            CountryLabel.Size = new Size(53, 15);
            CountryLabel.TabIndex = 1;
            CountryLabel.Text = "Country:";
            // 
            // PostIndexLabel
            // 
            PostIndexLabel.AutoSize = true;
            PostIndexLabel.Location = new Point(6, 31);
            PostIndexLabel.Name = "PostIndexLabel";
            PostIndexLabel.Size = new Size(65, 15);
            PostIndexLabel.TabIndex = 0;
            PostIndexLabel.Text = "Post Index:";
            // 
            // OrderItemsLabel
            // 
            OrderItemsLabel.AutoSize = true;
            OrderItemsLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            OrderItemsLabel.Location = new Point(326, 339);
            OrderItemsLabel.Name = "OrderItemsLabel";
            OrderItemsLabel.Size = new Size(77, 15);
            OrderItemsLabel.TabIndex = 2;
            OrderItemsLabel.Text = "Order Items";
            // 
            // OrderItemsListBox
            // 
            OrderItemsListBox.FormattingEnabled = true;
            OrderItemsListBox.ItemHeight = 15;
            OrderItemsListBox.Location = new Point(326, 357);
            OrderItemsListBox.Name = "OrderItemsListBox";
            OrderItemsListBox.Size = new Size(394, 109);
            OrderItemsListBox.TabIndex = 3;
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AmountLabel.Location = new Point(643, 481);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(60, 15);
            AmountLabel.TabIndex = 4;
            AmountLabel.Text = "Amount:";
            // 
            // TotalCostLabel
            // 
            TotalCostLabel.AutoSize = true;
            TotalCostLabel.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            TotalCostLabel.Location = new Point(658, 507);
            TotalCostLabel.Name = "TotalCostLabel";
            TotalCostLabel.Size = new Size(45, 25);
            TotalCostLabel.TabIndex = 5;
            TotalCostLabel.Text = "555";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { IdColumn, CreatedColumn, OrderStatusColumn, CustomerFullNameColumn });
            dataGridView1.Location = new Point(14, 12);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 30;
            dataGridView1.Size = new Size(306, 454);
            dataGridView1.TabIndex = 6;
            // 
            // IdColumn
            // 
            IdColumn.HeaderText = "Id";
            IdColumn.Name = "IdColumn";
            // 
            // CreatedColumn
            // 
            CreatedColumn.HeaderText = "Created";
            CreatedColumn.Name = "CreatedColumn";
            // 
            // OrderStatusColumn
            // 
            OrderStatusColumn.HeaderText = "Order Status";
            OrderStatusColumn.Name = "OrderStatusColumn";
            // 
            // CustomerFullNameColumn
            // 
            CustomerFullNameColumn.HeaderText = "Customer FullName";
            CustomerFullNameColumn.Name = "CustomerFullNameColumn";
            // 
            // OrdersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(TotalCostLabel);
            Controls.Add(AmountLabel);
            Controls.Add(OrderItemsListBox);
            Controls.Add(OrderItemsLabel);
            Controls.Add(DeliveryAddressGroupBox);
            Controls.Add(SelectedOrderGroupBox);
            Name = "OrdersTab";
            Size = new Size(731, 554);
            SelectedOrderGroupBox.ResumeLayout(false);
            SelectedOrderGroupBox.PerformLayout();
            DeliveryAddressGroupBox.ResumeLayout(false);
            DeliveryAddressGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox SelectedOrderGroupBox;
        private Label IdLabel;
        private Label StatusLabel;
        private Label CreatedLabel;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private GroupBox DeliveryAddressGroupBox;
        private Label BuildingLabel;
        private Label StreetLabel;
        private Label CountryLabel;
        private Label PostIndexLabel;
        private TextBox CityTextBox;
        private TextBox ApartmentTextBox;
        private TextBox BuildingTextBox;
        private TextBox StreetTextBox;
        private TextBox CountryTextBox;
        private TextBox PostIndexTextBox;
        private Label ApartmentLabel;
        private Label CityLabel;
        private Label OrderItemsLabel;
        private ListBox OrderItemsListBox;
        private Label AmountLabel;
        private Label TotalCostLabel;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn IdColumn;
        private DataGridViewTextBoxColumn CreatedColumn;
        private DataGridViewTextBoxColumn OrderStatusColumn;
        private DataGridViewTextBoxColumn CustomerFullNameColumn;
        private Label label1;
        private GroupBox groupBox1;
    }
}

namespace ObjectOrientedPractics.View.Controls
{
    partial class AddressControl
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
            DeliveryAddressLabel = new Label();
            PostIndexLabel = new Label();
            CountryLabel = new Label();
            StreetLabel = new Label();
            BuildingLabel = new Label();
            PostIndexTextBox = new TextBox();
            CountryTextBox = new TextBox();
            StreetTextBox = new TextBox();
            CityLabel = new Label();
            CityTextBox = new TextBox();
            BuildingTextBox = new TextBox();
            ApartmentLabel = new Label();
            ApartmentTextBox = new TextBox();
            SuspendLayout();
            // 
            // DeliveryAddressLabel
            // 
            DeliveryAddressLabel.AutoSize = true;
            DeliveryAddressLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DeliveryAddressLabel.Location = new Point(10, 9);
            DeliveryAddressLabel.Name = "DeliveryAddressLabel";
            DeliveryAddressLabel.Size = new Size(109, 15);
            DeliveryAddressLabel.TabIndex = 0;
            DeliveryAddressLabel.Text = "Delivery Address";
            // 
            // PostIndexLabel
            // 
            PostIndexLabel.AutoSize = true;
            PostIndexLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PostIndexLabel.Location = new Point(11, 37);
            PostIndexLabel.Name = "PostIndexLabel";
            PostIndexLabel.Size = new Size(65, 15);
            PostIndexLabel.TabIndex = 1;
            PostIndexLabel.Text = "Post index:";
            // 
            // CountryLabel
            // 
            CountryLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CountryLabel.AutoSize = true;
            CountryLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CountryLabel.Location = new Point(10, 67);
            CountryLabel.Name = "CountryLabel";
            CountryLabel.Size = new Size(53, 15);
            CountryLabel.TabIndex = 2;
            CountryLabel.Text = "Country:";
            // 
            // StreetLabel
            // 
            StreetLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            StreetLabel.AutoSize = true;
            StreetLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            StreetLabel.Location = new Point(10, 92);
            StreetLabel.Name = "StreetLabel";
            StreetLabel.Size = new Size(43, 15);
            StreetLabel.TabIndex = 3;
            StreetLabel.Text = "Street: ";
            // 
            // BuildingLabel
            // 
            BuildingLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BuildingLabel.AutoSize = true;
            BuildingLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BuildingLabel.Location = new Point(10, 124);
            BuildingLabel.Name = "BuildingLabel";
            BuildingLabel.Size = new Size(57, 15);
            BuildingLabel.TabIndex = 4;
            BuildingLabel.Text = "Building: ";
            // 
            // PostIndexTextBox
            // 
            PostIndexTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PostIndexTextBox.Location = new Point(85, 34);
            PostIndexTextBox.Margin = new Padding(3, 2, 3, 2);
            PostIndexTextBox.MaximumSize = new Size(169, 23);
            PostIndexTextBox.MinimumSize = new Size(48, 23);
            PostIndexTextBox.Name = "PostIndexTextBox";
            PostIndexTextBox.Size = new Size(48, 23);
            PostIndexTextBox.TabIndex = 5;
            PostIndexTextBox.TextChanged += PostIndexTextBox_TextChanged;
            // 
            // CountryTextBox
            // 
            CountryTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CountryTextBox.Location = new Point(85, 62);
            CountryTextBox.Margin = new Padding(3, 2, 3, 2);
            CountryTextBox.MaximumSize = new Size(169, 23);
            CountryTextBox.MinimumSize = new Size(48, 23);
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.Size = new Size(48, 23);
            CountryTextBox.TabIndex = 6;
            CountryTextBox.TextChanged += CountyTextBox_TextxChanged;
            // 
            // StreetTextBox
            // 
            StreetTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            StreetTextBox.Location = new Point(85, 90);
            StreetTextBox.Margin = new Padding(3, 2, 3, 2);
            StreetTextBox.Name = "StreetTextBox";
            StreetTextBox.Size = new Size(287, 23);
            StreetTextBox.TabIndex = 7;
            StreetTextBox.TextChanged += StreetTextBox_TextChanged;
            // 
            // CityLabel
            // 
            CityLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            CityLabel.AutoSize = true;
            CityLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CityLabel.Location = new Point(139, 62);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(34, 15);
            CityLabel.TabIndex = 8;
            CityLabel.Text = "City: ";
            // 
            // CityTextBox
            // 
            CityTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            CityTextBox.Location = new Point(207, 62);
            CityTextBox.Margin = new Padding(3, 2, 3, 2);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(165, 23);
            CityTextBox.TabIndex = 9;
            CityTextBox.TextChanged += CityTextBox_TextChanged;
            // 
            // BuildingTextBox
            // 
            BuildingTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BuildingTextBox.Location = new Point(85, 124);
            BuildingTextBox.Margin = new Padding(3, 2, 3, 2);
            BuildingTextBox.MaximumSize = new Size(169, 23);
            BuildingTextBox.MinimumSize = new Size(48, 23);
            BuildingTextBox.Name = "BuildingTextBox";
            BuildingTextBox.Size = new Size(48, 23);
            BuildingTextBox.TabIndex = 10;
            BuildingTextBox.TextChanged += BuildingTextBox_TextChanged;
            // 
            // ApartmentLabel
            // 
            ApartmentLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ApartmentLabel.AutoSize = true;
            ApartmentLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ApartmentLabel.Location = new Point(137, 125);
            ApartmentLabel.Name = "ApartmentLabel";
            ApartmentLabel.Size = new Size(70, 15);
            ApartmentLabel.TabIndex = 11;
            ApartmentLabel.Text = "Apartment: ";
            // 
            // ApartmentTextBox
            // 
            ApartmentTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            ApartmentTextBox.Location = new Point(209, 124);
            ApartmentTextBox.Margin = new Padding(3, 2, 3, 2);
            ApartmentTextBox.Name = "ApartmentTextBox";
            ApartmentTextBox.Size = new Size(164, 23);
            ApartmentTextBox.TabIndex = 12;
            ApartmentTextBox.TextChanged += ApartmentTextBox_TextChanged;
            // 
            // AddressControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ApartmentTextBox);
            Controls.Add(ApartmentLabel);
            Controls.Add(BuildingTextBox);
            Controls.Add(CityTextBox);
            Controls.Add(CityLabel);
            Controls.Add(StreetTextBox);
            Controls.Add(CountryTextBox);
            Controls.Add(PostIndexTextBox);
            Controls.Add(BuildingLabel);
            Controls.Add(StreetLabel);
            Controls.Add(CountryLabel);
            Controls.Add(PostIndexLabel);
            Controls.Add(DeliveryAddressLabel);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(390, 180);
            Name = "AddressControl";
            Size = new Size(390, 180);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DeliveryAddressLabel;
        private Label PostIndexLabel;
        private Label CountryLabel;
        private Label StreetLabel;
        private Label BuildingLabel;
        private TextBox PostIndexTextBox;
        private TextBox CountryTextBox;
        private TextBox StreetTextBox;
        private Label CityLabel;
        private TextBox CityTextBox;
        private TextBox BuildingTextBox;
        private Label ApartmentLabel;
        private TextBox ApartmentTextBox;
    }
}

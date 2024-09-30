namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
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
            ItemsGroupBox = new GroupBox();
            groupBox1 = new GroupBox();
            RemoveButton = new Button();
            AddButton = new Button();
            ItemsListBox = new ListBox();
            groupBox2 = new GroupBox();
            DescriptionTextBox = new TextBox();
            label4 = new Label();
            NameTextBox = new TextBox();
            CostTextBox = new TextBox();
            IDTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ItemsGroupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // ItemsGroupBox
            // 
            ItemsGroupBox.Controls.Add(groupBox1);
            ItemsGroupBox.Controls.Add(ItemsListBox);
            ItemsGroupBox.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ItemsGroupBox.Location = new Point(0, 0);
            ItemsGroupBox.Name = "ItemsGroupBox";
            ItemsGroupBox.Size = new Size(326, 593);
            ItemsGroupBox.TabIndex = 0;
            ItemsGroupBox.TabStop = false;
            ItemsGroupBox.Text = "Items";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RemoveButton);
            groupBox1.Controls.Add(AddButton);
            groupBox1.Location = new Point(6, 530);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(314, 63);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // RemoveButton
            // 
            RemoveButton.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            RemoveButton.Location = new Point(125, 19);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(119, 44);
            RemoveButton.TabIndex = 8;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // AddButton
            // 
            AddButton.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            AddButton.Location = new Point(6, 18);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(113, 45);
            AddButton.TabIndex = 8;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // ItemsListBox
            // 
            ItemsListBox.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 17;
            ItemsListBox.Location = new Point(6, 27);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(314, 497);
            ItemsListBox.TabIndex = 0;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
            ItemsListBox.DoubleClick += ItemsListBox_DoubleClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(DescriptionTextBox);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(NameTextBox);
            groupBox2.Controls.Add(CostTextBox);
            groupBox2.Controls.Add(IDTextBox);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBox2.Location = new Point(326, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(431, 590);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Selected Item";
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(17, 322);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(380, 199);
            DescriptionTextBox.TabIndex = 7;
            DescriptionTextBox.TextChanged += DescriptionTextBox_TextChanged_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(6, 291);
            label4.Name = "label4";
            label4.Size = new Size(86, 17);
            label4.TabIndex = 6;
            label4.Text = "Description:";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(17, 158);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(380, 111);
            NameTextBox.TabIndex = 5;
            NameTextBox.TextChanged += NameTextBox_TextChanged_1;
            // 
            // CostTextBox
            // 
            CostTextBox.Location = new Point(53, 74);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(146, 28);
            CostTextBox.TabIndex = 4;
            CostTextBox.TextChanged += CostTextBox_TextChanged_1;
            // 
            // IDTextBox
            // 
            IDTextBox.Enabled = false;
            IDTextBox.Location = new Point(53, 38);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.ReadOnly = true;
            IDTextBox.Size = new Size(146, 28);
            IDTextBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(6, 123);
            label3.Name = "label3";
            label3.Size = new Size(55, 17);
            label3.TabIndex = 2;
            label3.Text = "Name: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(6, 79);
            label2.Name = "label2";
            label2.Size = new Size(47, 17);
            label2.TabIndex = 1;
            label2.Text = "Cost: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(6, 43);
            label1.Name = "label1";
            label1.Size = new Size(26, 17);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(ItemsGroupBox);
            Name = "ItemsTab";
            Size = new Size(757, 602);
            ItemsGroupBox.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox ItemsGroupBox;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private ListBox ItemsListBox;
        private TextBox CostTextBox;
        private TextBox IDTextBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox NameTextBox;
        private Button RemoveButton;
        private Button AddButton;
        private TextBox DescriptionTextBox;
    }
}

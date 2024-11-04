namespace ObjectOrientedPractics.View.AdditionalForms
{
    partial class DiscountModalWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DiscountFornPanel = new Panel();
            CancelButton = new Button();
            OkButton = new Button();
            CategoryComboBox = new ComboBox();
            CategoryLabel = new Label();
            PercentDiscountLabel = new Label();
            DiscountFornPanel.SuspendLayout();
            SuspendLayout();
            // 
            // DiscountFornPanel
            // 
            DiscountFornPanel.Controls.Add(CancelButton);
            DiscountFornPanel.Controls.Add(OkButton);
            DiscountFornPanel.Controls.Add(CategoryComboBox);
            DiscountFornPanel.Controls.Add(CategoryLabel);
            DiscountFornPanel.Controls.Add(PercentDiscountLabel);
            DiscountFornPanel.Dock = DockStyle.Fill;
            DiscountFornPanel.Location = new Point(0, 0);
            DiscountFornPanel.Name = "DiscountFornPanel";
            DiscountFornPanel.Size = new Size(388, 157);
            DiscountFornPanel.TabIndex = 1;
            // 
            // CancelButton
            // 
            CancelButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CancelButton.BackColor = SystemColors.AppWorkspace;
            CancelButton.Location = new Point(258, 101);
            CancelButton.MaximumSize = new Size(93, 23);
            CancelButton.MinimumSize = new Size(54, 23);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(93, 23);
            CancelButton.TabIndex = 4;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // OkButton
            // 
            OkButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            OkButton.BackColor = SystemColors.AppWorkspace;
            OkButton.Location = new Point(166, 101);
            OkButton.MaximumSize = new Size(93, 23);
            OkButton.MinimumSize = new Size(54, 23);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(93, 23);
            OkButton.TabIndex = 3;
            OkButton.Text = "Ok";
            OkButton.UseVisualStyleBackColor = false;
            OkButton.Click += OkDiscountsButton_Click;
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(99, 46);
            CategoryComboBox.MaximumSize = new Size(254, 0);
            CategoryComboBox.MaxLength = 242;
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(254, 23);
            CategoryComboBox.TabIndex = 2;
            CategoryComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;
            // 
            // CategoryLabel
            // 
            CategoryLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(12, 49);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(58, 15);
            CategoryLabel.TabIndex = 1;
            CategoryLabel.Text = "Category:";
            // 
            // PercentDiscountLabel
            // 
            PercentDiscountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PercentDiscountLabel.AutoSize = true;
            PercentDiscountLabel.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PercentDiscountLabel.Location = new Point(12, 9);
            PercentDiscountLabel.Name = "PercentDiscountLabel";
            PercentDiscountLabel.Size = new Size(124, 17);
            PercentDiscountLabel.TabIndex = 0;
            PercentDiscountLabel.Text = "Percent Discount:";
            // 
            // DiscountModalWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 157);
            Controls.Add(DiscountFornPanel);
            MaximumSize = new Size(404, 196);
            MinimumSize = new Size(332, 168);
            Name = "DiscountModalWindow";
            Text = "AddDiscountForm";
            DiscountFornPanel.ResumeLayout(false);
            DiscountFornPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel DiscountFornPanel;
        private Button CancelButton;
        private Button OkButton;
        private ComboBox CategoryComboBox;
        private Label CategoryLabel;
        private Label PercentDiscountLabel;
    }
}
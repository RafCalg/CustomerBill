namespace CustomeBill1
{
    partial class CalculateBill
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
            this.customerTypeLabel = new System.Windows.Forms.Label();
            this.usageLabel = new System.Windows.Forms.Label();
            this.usageTextBox = new System.Windows.Forms.TextBox();
            this.customerTypeComboBox = new System.Windows.Forms.ComboBox();
            this.offPeakUsageLabel = new System.Windows.Forms.Label();
            this.offPeakTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.billTotalLabel = new System.Windows.Forms.Label();
            this.billTotalTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customerTypeLabel
            // 
            this.customerTypeLabel.AutoSize = true;
            this.customerTypeLabel.Location = new System.Drawing.Point(52, 33);
            this.customerTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customerTypeLabel.Name = "customerTypeLabel";
            this.customerTypeLabel.Size = new System.Drawing.Size(104, 17);
            this.customerTypeLabel.TabIndex = 0;
            this.customerTypeLabel.Text = "Customer Type";
            // 
            // usageLabel
            // 
            this.usageLabel.AutoSize = true;
            this.usageLabel.Location = new System.Drawing.Point(52, 90);
            this.usageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usageLabel.Name = "usageLabel";
            this.usageLabel.Size = new System.Drawing.Size(81, 17);
            this.usageLabel.TabIndex = 0;
            this.usageLabel.Text = "Usage kWh";
            // 
            // usageTextBox
            // 
            this.usageTextBox.Location = new System.Drawing.Point(183, 86);
            this.usageTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usageTextBox.Name = "usageTextBox";
            this.usageTextBox.Size = new System.Drawing.Size(160, 22);
            this.usageTextBox.TabIndex = 2;
            this.usageTextBox.TextChanged += new System.EventHandler(this.usageTextBox_TextChanged);
            // 
            // customerTypeComboBox
            // 
            this.customerTypeComboBox.FormattingEnabled = true;
            this.customerTypeComboBox.Items.AddRange(new object[] {
            "Residential",
            "Commercial",
            "Industrial"});
            this.customerTypeComboBox.Location = new System.Drawing.Point(183, 33);
            this.customerTypeComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customerTypeComboBox.Name = "customerTypeComboBox";
            this.customerTypeComboBox.Size = new System.Drawing.Size(160, 24);
            this.customerTypeComboBox.TabIndex = 3;
            this.customerTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.customerTypeComboBox_SelectedIndexChanged);
            // 
            // offPeakUsageLabel
            // 
            this.offPeakUsageLabel.AutoSize = true;
            this.offPeakUsageLabel.Location = new System.Drawing.Point(56, 140);
            this.offPeakUsageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.offPeakUsageLabel.Name = "offPeakUsageLabel";
            this.offPeakUsageLabel.Size = new System.Drawing.Size(108, 17);
            this.offPeakUsageLabel.TabIndex = 4;
            this.offPeakUsageLabel.Text = "Off Peak Usage";
            this.offPeakUsageLabel.Visible = false;
            // 
            // offPeakTextBox
            // 
            this.offPeakTextBox.Location = new System.Drawing.Point(183, 140);
            this.offPeakTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.offPeakTextBox.Name = "offPeakTextBox";
            this.offPeakTextBox.Size = new System.Drawing.Size(160, 22);
            this.offPeakTextBox.TabIndex = 5;
            this.offPeakTextBox.Visible = false;
            this.offPeakTextBox.TextChanged += new System.EventHandler(this.offPeakTextBox_TextChanged);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(60, 187);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(284, 28);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate Bill";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // billTotalLabel
            // 
            this.billTotalLabel.AutoSize = true;
            this.billTotalLabel.Location = new System.Drawing.Point(60, 262);
            this.billTotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.billTotalLabel.Name = "billTotalLabel";
            this.billTotalLabel.Size = new System.Drawing.Size(62, 17);
            this.billTotalLabel.TabIndex = 7;
            this.billTotalLabel.Text = "Bill Total";
            // 
            // billTotalTextBox
            // 
            this.billTotalTextBox.Location = new System.Drawing.Point(183, 252);
            this.billTotalTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.billTotalTextBox.Name = "billTotalTextBox";
            this.billTotalTextBox.Size = new System.Drawing.Size(160, 22);
            this.billTotalTextBox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 342);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "Clear All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(244, 342);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 9;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CalculateBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 482);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.billTotalTextBox);
            this.Controls.Add(this.billTotalLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.offPeakTextBox);
            this.Controls.Add(this.offPeakUsageLabel);
            this.Controls.Add(this.customerTypeComboBox);
            this.Controls.Add(this.usageTextBox);
            this.Controls.Add(this.usageLabel);
            this.Controls.Add(this.customerTypeLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CalculateBill";
            this.Text = "Calculate Bill Form";
            this.Load += new System.EventHandler(this.CalculateBill_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerTypeLabel;
        private System.Windows.Forms.Label usageLabel;
        private System.Windows.Forms.TextBox usageTextBox;
        private System.Windows.Forms.ComboBox customerTypeComboBox;
        private System.Windows.Forms.Label offPeakUsageLabel;
        private System.Windows.Forms.TextBox offPeakTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label billTotalLabel;
        private System.Windows.Forms.TextBox billTotalTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}


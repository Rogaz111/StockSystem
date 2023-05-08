namespace Store_Inventory
{
    partial class bookOutsScreen
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            productDropDownButton = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            quantityTextBox = new System.Windows.Forms.TextBox();
            panel1 = new System.Windows.Forms.Panel();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            label9 = new System.Windows.Forms.Label();
            bookOutButton = new roundedButton();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            customerNameTextBox = new System.Windows.Forms.TextBox();
            customerEmailTextBox = new System.Windows.Forms.TextBox();
            customerAddressTextBox = new System.Windows.Forms.TextBox();
            customerNumberTextBox = new System.Windows.Forms.TextBox();
            newInvBackButton = new System.Windows.Forms.LinkLabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // productDropDownButton
            // 
            productDropDownButton.FormattingEnabled = true;
            productDropDownButton.Location = new System.Drawing.Point(52, 175);
            productDropDownButton.Name = "productDropDownButton";
            productDropDownButton.Size = new System.Drawing.Size(244, 28);
            productDropDownButton.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(88, 135);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(186, 20);
            label1.TabIndex = 1;
            label1.Text = "Select Product to book out";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(101, 271);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(148, 20);
            label2.TabIndex = 2;
            label2.Text = "Quantity Booked Out";
            // 
            // quantityTextBox
            // 
            quantityTextBox.Location = new System.Drawing.Point(52, 320);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new System.Drawing.Size(244, 27);
            quantityTextBox.TabIndex = 3;
            quantityTextBox.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(bookOutButton);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(quantityTextBox);
            panel1.Controls.Add(productDropDownButton);
            panel1.Controls.Add(label2);
            panel1.Location = new System.Drawing.Point(12, 2);
            panel1.Name = "panel1";
            panel1.Padding = new System.Windows.Forms.Padding(5);
            panel1.Size = new System.Drawing.Size(384, 682);
            panel1.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new System.Drawing.Point(52, 466);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            dateTimePicker1.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(101, 406);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(124, 20);
            label9.TabIndex = 15;
            label9.Text = "Date Booked Out";
            // 
            // bookOutButton
            // 
            bookOutButton.BackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            bookOutButton.CornerRadius = 25;
            bookOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            bookOutButton.Location = new System.Drawing.Point(106, 595);
            bookOutButton.Name = "bookOutButton";
            bookOutButton.Size = new System.Drawing.Size(143, 56);
            bookOutButton.TabIndex = 14;
            bookOutButton.Text = "Book Out";
            bookOutButton.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.BackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(0, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(384, 114);
            label3.TabIndex = 4;
            label3.Text = "Stock Selections";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = System.Drawing.Color.FromArgb(255, 128, 128);
            label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(395, 2);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(647, 114);
            label4.TabIndex = 5;
            label4.Text = "Customer Details";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(489, 137);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(116, 20);
            label5.TabIndex = 6;
            label5.Text = "Customer Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(488, 232);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(113, 20);
            label6.TabIndex = 7;
            label6.Text = "Customer Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(489, 329);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(129, 20);
            label7.TabIndex = 8;
            label7.Text = "Customer Address";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(488, 434);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(130, 20);
            label8.TabIndex = 9;
            label8.Text = "Customer Number";
            // 
            // customerNameTextBox
            // 
            customerNameTextBox.Location = new System.Drawing.Point(489, 177);
            customerNameTextBox.Name = "customerNameTextBox";
            customerNameTextBox.Size = new System.Drawing.Size(279, 27);
            customerNameTextBox.TabIndex = 10;
            // 
            // customerEmailTextBox
            // 
            customerEmailTextBox.Location = new System.Drawing.Point(489, 266);
            customerEmailTextBox.Name = "customerEmailTextBox";
            customerEmailTextBox.Size = new System.Drawing.Size(279, 27);
            customerEmailTextBox.TabIndex = 11;
            // 
            // customerAddressTextBox
            // 
            customerAddressTextBox.Location = new System.Drawing.Point(489, 370);
            customerAddressTextBox.Name = "customerAddressTextBox";
            customerAddressTextBox.Size = new System.Drawing.Size(279, 27);
            customerAddressTextBox.TabIndex = 12;
            // 
            // customerNumberTextBox
            // 
            customerNumberTextBox.Location = new System.Drawing.Point(489, 467);
            customerNumberTextBox.Name = "customerNumberTextBox";
            customerNumberTextBox.Size = new System.Drawing.Size(279, 27);
            customerNumberTextBox.TabIndex = 13;
            // 
            // newInvBackButton
            // 
            newInvBackButton.AutoSize = true;
            newInvBackButton.BackColor = System.Drawing.Color.Transparent;
            newInvBackButton.Dock = System.Windows.Forms.DockStyle.Right;
            newInvBackButton.LinkColor = System.Drawing.Color.SlateGray;
            newInvBackButton.Location = new System.Drawing.Point(984, 0);
            newInvBackButton.Name = "newInvBackButton";
            newInvBackButton.Size = new System.Drawing.Size(56, 20);
            newInvBackButton.TabIndex = 19;
            newInvBackButton.TabStop = true;
            newInvBackButton.Text = "Home/";
            newInvBackButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            newInvBackButton.LinkClicked += newInvBackButton_LinkClicked;
            // 
            // bookOutsScreen
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1040, 696);
            ControlBox = false;
            Controls.Add(newInvBackButton);
            Controls.Add(customerNumberTextBox);
            Controls.Add(customerAddressTextBox);
            Controls.Add(customerEmailTextBox);
            Controls.Add(customerNameTextBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(panel1);
            Name = "bookOutsScreen";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "bookOutsScreen";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox productDropDownButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private roundedButton bookOutButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.TextBox customerEmailTextBox;
        private System.Windows.Forms.TextBox customerAddressTextBox;
        private System.Windows.Forms.TextBox customerNumberTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel newInvBackButton;
    }
}
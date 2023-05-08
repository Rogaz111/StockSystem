
namespace Store_Inventory
{
    partial class addSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addSupplier));
            panel1 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            supNametextBox = new System.Windows.Forms.TextBox();
            supAddtextBox = new System.Windows.Forms.TextBox();
            suppTeleTextBox = new System.Windows.Forms.TextBox();
            suppEmailTextBox = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            suppCodeTextBox = new System.Windows.Forms.TextBox();
            saveButton = new roundedButton();
            resetButton = new roundedButton();
            newInvBackButton = new System.Windows.Forms.LinkLabel();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(18, 109, 123);
            panel1.Location = new System.Drawing.Point(37, 39);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(362, 10);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(18, 109, 123);
            panel2.Location = new System.Drawing.Point(746, 39);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(362, 10);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(405, 24);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(335, 41);
            label1.TabIndex = 2;
            label1.Text = "Add New Suppliers";
            label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(69, 87);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(162, 62);
            label2.TabIndex = 3;
            label2.Text = "Supplier Name";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(432, 87);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(162, 62);
            label3.TabIndex = 4;
            label3.Text = "Supplier Address";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(69, 260);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(162, 62);
            label4.TabIndex = 5;
            label4.Text = "Supplier Telephone";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(432, 260);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(162, 62);
            label5.TabIndex = 6;
            label5.Text = "Supplier Email Address";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // supNametextBox
            // 
            supNametextBox.Location = new System.Drawing.Point(12, 170);
            supNametextBox.Multiline = true;
            supNametextBox.Name = "supNametextBox";
            supNametextBox.Size = new System.Drawing.Size(299, 53);
            supNametextBox.TabIndex = 7;
            supNametextBox.TextChanged += supNametextBox_TextChanged;
            // 
            // supAddtextBox
            // 
            supAddtextBox.Location = new System.Drawing.Point(369, 170);
            supAddtextBox.Multiline = true;
            supAddtextBox.Name = "supAddtextBox";
            supAddtextBox.Size = new System.Drawing.Size(299, 53);
            supAddtextBox.TabIndex = 8;
            supAddtextBox.TextChanged += supAddtextBox_TextChanged;
            // 
            // suppTeleTextBox
            // 
            suppTeleTextBox.Location = new System.Drawing.Point(12, 361);
            suppTeleTextBox.Multiline = true;
            suppTeleTextBox.Name = "suppTeleTextBox";
            suppTeleTextBox.Size = new System.Drawing.Size(299, 34);
            suppTeleTextBox.TabIndex = 9;
            suppTeleTextBox.TextChanged += suppTeleTextBox_TextChanged;
            // 
            // suppEmailTextBox
            // 
            suppEmailTextBox.Location = new System.Drawing.Point(369, 361);
            suppEmailTextBox.Multiline = true;
            suppEmailTextBox.Name = "suppEmailTextBox";
            suppEmailTextBox.Size = new System.Drawing.Size(299, 34);
            suppEmailTextBox.TabIndex = 10;
            suppEmailTextBox.TextChanged += suppEmailTextBox_TextChanged;
            // 
            // label6
            // 
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(258, 442);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(162, 62);
            label6.TabIndex = 11;
            label6.Text = "Supplier Code";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // suppCodeTextBox
            // 
            suppCodeTextBox.Location = new System.Drawing.Point(217, 529);
            suppCodeTextBox.Name = "suppCodeTextBox";
            suppCodeTextBox.Size = new System.Drawing.Size(251, 27);
            suppCodeTextBox.TabIndex = 12;
            suppCodeTextBox.TextChanged += suppCodeTextBox_TextChanged;
            // 
            // saveButton
            // 
            saveButton.BackColor = System.Drawing.SystemColors.GrayText;
            saveButton.CornerRadius = 15;
            saveButton.ForeColor = System.Drawing.Color.White;
            saveButton.Location = new System.Drawing.Point(139, 603);
            saveButton.Name = "saveButton";
            saveButton.Size = new System.Drawing.Size(172, 62);
            saveButton.TabIndex = 13;
            saveButton.Text = "SAVE";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButtton_Click;
            // 
            // resetButton
            // 
            resetButton.BackColor = System.Drawing.SystemColors.GrayText;
            resetButton.CornerRadius = 15;
            resetButton.ForeColor = System.Drawing.Color.White;
            resetButton.Location = new System.Drawing.Point(369, 603);
            resetButton.Name = "resetButton";
            resetButton.Size = new System.Drawing.Size(172, 62);
            resetButton.TabIndex = 14;
            resetButton.Text = "RESET";
            resetButton.UseVisualStyleBackColor = false;
            resetButton.Click += resetButton_Click;
            // 
            // newInvBackButton
            // 
            newInvBackButton.AutoSize = true;
            newInvBackButton.BackColor = System.Drawing.Color.Transparent;
            newInvBackButton.LinkColor = System.Drawing.Color.SteelBlue;
            newInvBackButton.Location = new System.Drawing.Point(942, 9);
            newInvBackButton.Name = "newInvBackButton";
            newInvBackButton.Size = new System.Drawing.Size(56, 20);
            newInvBackButton.TabIndex = 19;
            newInvBackButton.TabStop = true;
            newInvBackButton.Text = "Home/";
            newInvBackButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            newInvBackButton.LinkClicked += newInvBackButton_LinkClicked;
            // 
            // addSupplier
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new System.Drawing.Size(1040, 696);
            Controls.Add(newInvBackButton);
            Controls.Add(resetButton);
            Controls.Add(saveButton);
            Controls.Add(suppCodeTextBox);
            Controls.Add(label6);
            Controls.Add(suppEmailTextBox);
            Controls.Add(suppTeleTextBox);
            Controls.Add(supAddtextBox);
            Controls.Add(supNametextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximumSize = new System.Drawing.Size(1058, 743);
            MinimumSize = new System.Drawing.Size(1058, 743);
            Name = "addSupplier";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "addSupplier";
            Load += addSupplier_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox supNametextBox;
        private System.Windows.Forms.TextBox supAddtextBox;
        private System.Windows.Forms.TextBox suppTeleTextBox;
        private System.Windows.Forms.TextBox suppEmailTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox suppCodeTextBox;
        private roundedButton saveButton;
        private roundedButton resetButton;
        private System.Windows.Forms.LinkLabel newInvBackButton;
    }
}
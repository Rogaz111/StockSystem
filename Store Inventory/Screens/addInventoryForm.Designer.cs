
namespace Store_Inventory
{
    partial class addInventoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addInventoryForm));
            prodNameLabel = new System.Windows.Forms.Label();
            prodCodeLabel = new System.Windows.Forms.Label();
            prodQuanLabel = new System.Windows.Forms.Label();
            prodNameTextBox = new System.Windows.Forms.TextBox();
            prodCodeTextBox = new System.Windows.Forms.TextBox();
            prodQuanTextBox = new System.Windows.Forms.TextBox();
            productInfoHeader = new System.Windows.Forms.Label();
            prodPriceTextBox = new System.Windows.Forms.TextBox();
            prodPriceLabel = new System.Windows.Forms.Label();
            submitButton = new System.Windows.Forms.Button();
            newInvBackButton = new System.Windows.Forms.LinkLabel();
            resetButton = new System.Windows.Forms.Button();
            comboBox1 = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // prodNameLabel
            // 
            prodNameLabel.BackColor = System.Drawing.Color.Transparent;
            prodNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            prodNameLabel.Location = new System.Drawing.Point(29, 165);
            prodNameLabel.Name = "prodNameLabel";
            prodNameLabel.Size = new System.Drawing.Size(199, 37);
            prodNameLabel.TabIndex = 1;
            prodNameLabel.Text = "Product Name";
            prodNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            prodNameLabel.Click += label1_Click;
            // 
            // prodCodeLabel
            // 
            prodCodeLabel.BackColor = System.Drawing.Color.Transparent;
            prodCodeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            prodCodeLabel.Location = new System.Drawing.Point(288, 165);
            prodCodeLabel.Name = "prodCodeLabel";
            prodCodeLabel.Size = new System.Drawing.Size(199, 37);
            prodCodeLabel.TabIndex = 2;
            prodCodeLabel.Text = "Product Code";
            prodCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prodQuanLabel
            // 
            prodQuanLabel.BackColor = System.Drawing.Color.Transparent;
            prodQuanLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            prodQuanLabel.Location = new System.Drawing.Point(556, 165);
            prodQuanLabel.Name = "prodQuanLabel";
            prodQuanLabel.Size = new System.Drawing.Size(199, 37);
            prodQuanLabel.TabIndex = 3;
            prodQuanLabel.Text = "Product Quantity";
            prodQuanLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prodNameTextBox
            // 
            prodNameTextBox.Location = new System.Drawing.Point(29, 223);
            prodNameTextBox.Multiline = true;
            prodNameTextBox.Name = "prodNameTextBox";
            prodNameTextBox.Size = new System.Drawing.Size(199, 78);
            prodNameTextBox.TabIndex = 5;
            prodNameTextBox.TextChanged += prodNameTextBox_TextChanged;
            // 
            // prodCodeTextBox
            // 
            prodCodeTextBox.Location = new System.Drawing.Point(288, 223);
            prodCodeTextBox.Multiline = true;
            prodCodeTextBox.Name = "prodCodeTextBox";
            prodCodeTextBox.Size = new System.Drawing.Size(199, 78);
            prodCodeTextBox.TabIndex = 6;
            prodCodeTextBox.TextChanged += prodCodeTextBox_TextChanged;
            // 
            // prodQuanTextBox
            // 
            prodQuanTextBox.Location = new System.Drawing.Point(556, 223);
            prodQuanTextBox.Multiline = true;
            prodQuanTextBox.Name = "prodQuanTextBox";
            prodQuanTextBox.Size = new System.Drawing.Size(199, 78);
            prodQuanTextBox.TabIndex = 7;
            prodQuanTextBox.TextChanged += prodQuanTextBox_TextChanged;
            // 
            // productInfoHeader
            // 
            productInfoHeader.BackColor = System.Drawing.Color.Lavender;
            productInfoHeader.Location = new System.Drawing.Point(29, 109);
            productInfoHeader.Name = "productInfoHeader";
            productInfoHeader.Size = new System.Drawing.Size(965, 37);
            productInfoHeader.TabIndex = 9;
            productInfoHeader.Text = "Product Information";
            productInfoHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prodPriceTextBox
            // 
            prodPriceTextBox.Location = new System.Drawing.Point(795, 223);
            prodPriceTextBox.Multiline = true;
            prodPriceTextBox.Name = "prodPriceTextBox";
            prodPriceTextBox.Size = new System.Drawing.Size(199, 78);
            prodPriceTextBox.TabIndex = 11;
            prodPriceTextBox.TextChanged += prodPriceTextBox_TextChanged;
            // 
            // prodPriceLabel
            // 
            prodPriceLabel.BackColor = System.Drawing.Color.Transparent;
            prodPriceLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            prodPriceLabel.Location = new System.Drawing.Point(795, 165);
            prodPriceLabel.Name = "prodPriceLabel";
            prodPriceLabel.Size = new System.Drawing.Size(199, 37);
            prodPriceLabel.TabIndex = 10;
            prodPriceLabel.Text = "Product Price";
            prodPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // submitButton
            // 
            submitButton.BackColor = System.Drawing.SystemColors.GrayText;
            submitButton.CausesValidation = false;
            submitButton.ForeColor = System.Drawing.SystemColors.Control;
            submitButton.Location = new System.Drawing.Point(215, 608);
            submitButton.Name = "submitButton";
            submitButton.Size = new System.Drawing.Size(294, 59);
            submitButton.TabIndex = 17;
            submitButton.Text = "Add Item";
            submitButton.UseVisualStyleBackColor = false;
            submitButton.Click += submitButton_Click;
            // 
            // newInvBackButton
            // 
            newInvBackButton.AutoSize = true;
            newInvBackButton.BackColor = System.Drawing.Color.Transparent;
            newInvBackButton.LinkColor = System.Drawing.Color.SteelBlue;
            newInvBackButton.Location = new System.Drawing.Point(938, 9);
            newInvBackButton.Name = "newInvBackButton";
            newInvBackButton.Size = new System.Drawing.Size(56, 20);
            newInvBackButton.TabIndex = 18;
            newInvBackButton.TabStop = true;
            newInvBackButton.Text = "Home/";
            newInvBackButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            newInvBackButton.LinkClicked += newInvBackButton_LinkClicked;
            // 
            // resetButton
            // 
            resetButton.BackColor = System.Drawing.SystemColors.GrayText;
            resetButton.ForeColor = System.Drawing.SystemColors.Control;
            resetButton.Location = new System.Drawing.Point(515, 608);
            resetButton.Name = "resetButton";
            resetButton.Size = new System.Drawing.Size(294, 59);
            resetButton.TabIndex = 19;
            resetButton.Text = "RESET";
            resetButton.UseVisualStyleBackColor = false;
            resetButton.Click += resetButton_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(29, 367);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(199, 28);
            comboBox1.TabIndex = 20;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(29, 327);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(199, 37);
            label1.TabIndex = 21;
            label1.Text = "Select Supplier";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addInventoryForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1040, 696);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(resetButton);
            Controls.Add(newInvBackButton);
            Controls.Add(submitButton);
            Controls.Add(prodPriceTextBox);
            Controls.Add(prodPriceLabel);
            Controls.Add(productInfoHeader);
            Controls.Add(prodQuanTextBox);
            Controls.Add(prodCodeTextBox);
            Controls.Add(prodNameTextBox);
            Controls.Add(prodQuanLabel);
            Controls.Add(prodCodeLabel);
            Controls.Add(prodNameLabel);
            MaximumSize = new System.Drawing.Size(1058, 743);
            MinimumSize = new System.Drawing.Size(1058, 743);
            Name = "addInventoryForm";
            Text = "addInventoryForm";
            Load += addInventoryForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label prodNameLabel;
        private System.Windows.Forms.Label prodCodeLabel;
        private System.Windows.Forms.Label prodQuanLabel;
        private System.Windows.Forms.TextBox prodNameTextBox;
        private System.Windows.Forms.TextBox prodCodeTextBox;
        private System.Windows.Forms.TextBox prodQuanTextBox;
        private System.Windows.Forms.Label productInfoHeader;
        private System.Windows.Forms.TextBox prodPriceTextBox;
        private System.Windows.Forms.Label prodPriceLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.LinkLabel newInvBackButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}

namespace Store_Inventory
{
    partial class viewInventory
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
            comboBox1 = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            searchButton = new System.Windows.Forms.Button();
            resetButton = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(25, 71);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(248, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(25, 34);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(172, 20);
            label1.TabIndex = 2;
            label1.Text = "Search by Product Name";
            // 
            // searchButton
            // 
            searchButton.Location = new System.Drawing.Point(25, 641);
            searchButton.Name = "searchButton";
            searchButton.Size = new System.Drawing.Size(171, 43);
            searchButton.TabIndex = 4;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += button1_Click;
            // 
            // resetButton
            // 
            resetButton.Location = new System.Drawing.Point(225, 641);
            resetButton.Name = "resetButton";
            resetButton.Size = new System.Drawing.Size(172, 43);
            resetButton.TabIndex = 5;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(25, 118);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new System.Drawing.Size(1003, 270);
            dataGridView1.TabIndex = 6;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new System.Drawing.Point(972, 34);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new System.Drawing.Size(56, 20);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Home/";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // viewInventory
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1040, 696);
            Controls.Add(linkLabel1);
            Controls.Add(dataGridView1);
            Controls.Add(resetButton);
            Controls.Add(searchButton);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            MaximumSize = new System.Drawing.Size(1058, 743);
            MinimumSize = new System.Drawing.Size(1058, 743);
            Name = "viewInventory";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "viewInventory";
            Load += viewInventory_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
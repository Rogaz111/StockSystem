
namespace Store_Inventory
{
    partial class viewSuppliers
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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            linkLabel1 = new System.Windows.Forms.LinkLabel();
            button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(24, 69);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(316, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(24, 41);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(218, 25);
            label1.TabIndex = 1;
            label1.Text = "Search Supplier Below";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = System.Drawing.Color.MediumAquamarine;
            dataGridView1.Location = new System.Drawing.Point(24, 139);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new System.Drawing.Size(1004, 215);
            dataGridView1.TabIndex = 2;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new System.Drawing.Point(972, 41);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new System.Drawing.Size(56, 20);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Home/";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(24, 406);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(185, 59);
            button1.TabIndex = 9;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // viewSuppliers
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1040, 696);
            Controls.Add(button1);
            Controls.Add(linkLabel1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            MaximumSize = new System.Drawing.Size(1058, 743);
            MinimumSize = new System.Drawing.Size(1058, 743);
            Name = "viewSuppliers";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "viewSuppliers";
            Load += viewSuppliers_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button1;
    }
}
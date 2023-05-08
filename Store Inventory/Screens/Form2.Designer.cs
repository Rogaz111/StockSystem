
namespace Store_Inventory
{
    partial class Form2
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
            signOutButton = new System.Windows.Forms.Button();
            addInventoryButton = new roundedButton();
            addSupplierButton = new roundedButton();
            viewInvButton = new roundedButton();
            viewSuppButton = new roundedButton();
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            stockTakeButton = new roundedButton();
            panel2 = new System.Windows.Forms.Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // signOutButton
            // 
            signOutButton.BackColor = System.Drawing.SystemColors.Window;
            signOutButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            signOutButton.FlatAppearance.BorderSize = 5;
            signOutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            signOutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            signOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            signOutButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            signOutButton.ForeColor = System.Drawing.Color.Black;
            signOutButton.Location = new System.Drawing.Point(1037, 3);
            signOutButton.Name = "signOutButton";
            signOutButton.Size = new System.Drawing.Size(103, 52);
            signOutButton.TabIndex = 4;
            signOutButton.Text = "Sign Out";
            signOutButton.UseVisualStyleBackColor = false;
            signOutButton.Click += signOutButton_Click;
            // 
            // addInventoryButton
            // 
            addInventoryButton.BackColor = System.Drawing.Color.Transparent;
            addInventoryButton.CornerRadius = 50;
            addInventoryButton.ForeColor = System.Drawing.Color.Black;
            addInventoryButton.Location = new System.Drawing.Point(236, 46);
            addInventoryButton.Name = "addInventoryButton";
            addInventoryButton.Size = new System.Drawing.Size(160, 70);
            addInventoryButton.TabIndex = 5;
            addInventoryButton.Text = "Add Inventory";
            addInventoryButton.UseVisualStyleBackColor = false;
            addInventoryButton.Click += addInventoryButton_Click;
            // 
            // addSupplierButton
            // 
            addSupplierButton.BackColor = System.Drawing.Color.Transparent;
            addSupplierButton.CornerRadius = 50;
            addSupplierButton.ForeColor = System.Drawing.Color.Black;
            addSupplierButton.Location = new System.Drawing.Point(618, 46);
            addSupplierButton.Name = "addSupplierButton";
            addSupplierButton.Size = new System.Drawing.Size(160, 70);
            addSupplierButton.TabIndex = 6;
            addSupplierButton.Text = "Add Supplier";
            addSupplierButton.UseVisualStyleBackColor = false;
            addSupplierButton.Click += addSupplierButton_Click;
            // 
            // viewInvButton
            // 
            viewInvButton.BackColor = System.Drawing.Color.Transparent;
            viewInvButton.CornerRadius = 50;
            viewInvButton.ForeColor = System.Drawing.SystemColors.WindowText;
            viewInvButton.Location = new System.Drawing.Point(57, 46);
            viewInvButton.Name = "viewInvButton";
            viewInvButton.Size = new System.Drawing.Size(159, 70);
            viewInvButton.TabIndex = 7;
            viewInvButton.Text = "View Inventory";
            viewInvButton.UseVisualStyleBackColor = false;
            viewInvButton.Click += viewInvButton_Click;
            // 
            // viewSuppButton
            // 
            viewSuppButton.BackColor = System.Drawing.Color.Transparent;
            viewSuppButton.CornerRadius = 50;
            viewSuppButton.ForeColor = System.Drawing.SystemColors.WindowText;
            viewSuppButton.Location = new System.Drawing.Point(421, 46);
            viewSuppButton.Name = "viewSuppButton";
            viewSuppButton.Size = new System.Drawing.Size(159, 70);
            viewSuppButton.TabIndex = 8;
            viewSuppButton.Text = "View Suppliers";
            viewSuppButton.UseVisualStyleBackColor = false;
            viewSuppButton.Click += viewSuppButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Transparent;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(signOutButton);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1040, 53);
            panel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.White;
            label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(-30, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(1075, 53);
            label1.TabIndex = 5;
            label1.Text = "Inventory Application Home Screen";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stockTakeButton
            // 
            stockTakeButton.BackColor = System.Drawing.Color.Transparent;
            stockTakeButton.CornerRadius = 50;
            stockTakeButton.ForeColor = System.Drawing.Color.Black;
            stockTakeButton.Location = new System.Drawing.Point(800, 46);
            stockTakeButton.Name = "stockTakeButton";
            stockTakeButton.Size = new System.Drawing.Size(160, 70);
            stockTakeButton.TabIndex = 9;
            stockTakeButton.Text = "Book Outs";
            stockTakeButton.UseVisualStyleBackColor = false;
            stockTakeButton.Click += stockTakeButton_Click;
            // 
            // panel2
            // 
            panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            panel2.BackColor = System.Drawing.Color.FromArgb(194, 236, 116);
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel2.Controls.Add(viewInvButton);
            panel2.Controls.Add(stockTakeButton);
            panel2.Controls.Add(viewSuppButton);
            panel2.Controls.Add(addInventoryButton);
            panel2.Controls.Add(addSupplierButton);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(0, 53);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1040, 161);
            panel2.TabIndex = 10;
            // 
            // Form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(1040, 696);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximumSize = new System.Drawing.Size(1058, 743);
            MinimumSize = new System.Drawing.Size(1058, 743);
            Name = "Form2";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Store Home";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button signOutButton;
        private roundedButton addInventoryButton;
        private roundedButton addSupplierButton;
        private roundedButton viewInvButton;
        private roundedButton viewSuppButton;
        private System.Windows.Forms.Panel panel1;
        private roundedButton stockTakeButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}
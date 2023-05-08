
using System;

namespace Store_Inventory
{
    partial class Login_Screen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Screen));
            userNameTextBox = new System.Windows.Forms.TextBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            userPasswordTextBox = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            loginButton = new System.Windows.Forms.Button();
            rememberMeCheckBox = new System.Windows.Forms.CheckBox();
            signUpButton = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            firstNameTextBox = new System.Windows.Forms.TextBox();
            lastNameTextBox = new System.Windows.Forms.TextBox();
            deliveryTextBox = new System.Windows.Forms.TextBox();
            telephoneTextBox = new System.Windows.Forms.TextBox();
            labelFirstName = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            uniqueCode = new System.Windows.Forms.TextBox();
            uniqueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // userNameTextBox
            // 
            userNameTextBox.BackColor = System.Drawing.Color.AliceBlue;
            userNameTextBox.Location = new System.Drawing.Point(365, 45);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new System.Drawing.Size(294, 27);
            userNameTextBox.TabIndex = 0;
            userNameTextBox.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (System.Drawing.Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            pictureBox1.Location = new System.Drawing.Point(-2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(355, 698);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // userPasswordTextBox
            // 
            userPasswordTextBox.BackColor = System.Drawing.Color.AliceBlue;
            userPasswordTextBox.Location = new System.Drawing.Point(365, 130);
            userPasswordTextBox.Name = "userPasswordTextBox";
            userPasswordTextBox.PasswordChar = '*';
            userPasswordTextBox.Size = new System.Drawing.Size(294, 27);
            userPasswordTextBox.TabIndex = 2;
            userPasswordTextBox.TextChanged += userPasswordTextBox_TextChanged;
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(365, 22);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(157, 20);
            label1.TabIndex = 3;
            label1.Text = "Enter Email Address";
            label1.Click += label1_Click;
            // 
            // passwordLabel
            // 
            passwordLabel.Location = new System.Drawing.Point(365, 107);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(157, 20);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Enter Password";
            passwordLabel.Click += label2_Click;
            // 
            // loginButton
            // 
            loginButton.BackColor = System.Drawing.Color.AliceBlue;
            loginButton.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            loginButton.Location = new System.Drawing.Point(408, 379);
            loginButton.Name = "loginButton";
            loginButton.Size = new System.Drawing.Size(166, 57);
            loginButton.TabIndex = 5;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // rememberMeCheckBox
            // 
            rememberMeCheckBox.AutoSize = true;
            rememberMeCheckBox.Location = new System.Drawing.Point(365, 182);
            rememberMeCheckBox.Name = "rememberMeCheckBox";
            rememberMeCheckBox.Size = new System.Drawing.Size(132, 24);
            rememberMeCheckBox.TabIndex = 6;
            rememberMeCheckBox.Text = "Show Password";
            rememberMeCheckBox.UseVisualStyleBackColor = true;
            rememberMeCheckBox.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // signUpButton
            // 
            signUpButton.BackColor = System.Drawing.Color.AliceBlue;
            signUpButton.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            signUpButton.Location = new System.Drawing.Point(763, 379);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new System.Drawing.Size(166, 57);
            signUpButton.TabIndex = 7;
            signUpButton.Text = "Create Account";
            signUpButton.UseVisualStyleBackColor = false;
            signUpButton.Click += signUpButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.Blue;
            label3.Location = new System.Drawing.Point(365, 216);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(143, 20);
            label3.TabIndex = 8;
            label3.Text = "Click here to sign up";
            label3.Click += label3_Click;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.BackColor = System.Drawing.Color.AliceBlue;
            firstNameTextBox.Location = new System.Drawing.Point(694, 45);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new System.Drawing.Size(290, 27);
            firstNameTextBox.TabIndex = 9;
            firstNameTextBox.TextChanged += firstNameTextBox_TextChanged;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.BackColor = System.Drawing.Color.AliceBlue;
            lastNameTextBox.Location = new System.Drawing.Point(694, 130);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new System.Drawing.Size(290, 27);
            lastNameTextBox.TabIndex = 10;
            // 
            // deliveryTextBox
            // 
            deliveryTextBox.BackColor = System.Drawing.Color.AliceBlue;
            deliveryTextBox.Location = new System.Drawing.Point(694, 209);
            deliveryTextBox.Name = "deliveryTextBox";
            deliveryTextBox.Size = new System.Drawing.Size(290, 27);
            deliveryTextBox.TabIndex = 11;
            // 
            // telephoneTextBox
            // 
            telephoneTextBox.BackColor = System.Drawing.Color.AliceBlue;
            telephoneTextBox.Location = new System.Drawing.Point(694, 295);
            telephoneTextBox.Name = "telephoneTextBox";
            telephoneTextBox.Size = new System.Drawing.Size(290, 27);
            telephoneTextBox.TabIndex = 12;
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Location = new System.Drawing.Point(694, 22);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new System.Drawing.Size(118, 20);
            labelFirstName.TabIndex = 13;
            labelFirstName.Text = "Enter First Name";
            labelFirstName.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(694, 106);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(117, 20);
            label5.TabIndex = 14;
            label5.Text = "Enter Last Name";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new System.Drawing.Point(694, 186);
            label.Name = "label";
            label.Size = new System.Drawing.Size(158, 20);
            label.TabIndex = 15;
            label.Text = "Enter Delivery Address";
            label.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(694, 272);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(174, 20);
            label7.TabIndex = 16;
            label7.Text = "Enter Telephone Number";
            label7.Click += label7_Click;
            // 
            // uniqueCode
            // 
            uniqueCode.BackColor = System.Drawing.Color.AliceBlue;
            uniqueCode.Location = new System.Drawing.Point(365, 295);
            uniqueCode.Name = "uniqueCode";
            uniqueCode.PasswordChar = '*';
            uniqueCode.Size = new System.Drawing.Size(294, 27);
            uniqueCode.TabIndex = 17;
            uniqueCode.TextChanged += textBox1_TextChanged_1;
            // 
            // uniqueLabel
            // 
            uniqueLabel.AutoSize = true;
            uniqueLabel.Location = new System.Drawing.Point(365, 264);
            uniqueLabel.Name = "uniqueLabel";
            uniqueLabel.Size = new System.Drawing.Size(197, 20);
            uniqueLabel.TabIndex = 18;
            uniqueLabel.Text = "Enter Verification Code Here";
            // 
            // Login_Screen
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.LightGray;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            ClientSize = new System.Drawing.Size(1040, 696);
            Controls.Add(uniqueLabel);
            Controls.Add(uniqueCode);
            Controls.Add(label7);
            Controls.Add(label);
            Controls.Add(label5);
            Controls.Add(labelFirstName);
            Controls.Add(telephoneTextBox);
            Controls.Add(deliveryTextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(label3);
            Controls.Add(signUpButton);
            Controls.Add(rememberMeCheckBox);
            Controls.Add(loginButton);
            Controls.Add(passwordLabel);
            Controls.Add(label1);
            Controls.Add(userPasswordTextBox);
            Controls.Add(pictureBox1);
            Controls.Add(userNameTextBox);
            DoubleBuffered = true;
            MaximumSize = new System.Drawing.Size(1058, 743);
            MinimumSize = new System.Drawing.Size(1058, 743);
            Name = "Login_Screen";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Authentication Screen";
            Load += Login_Screen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox userPasswordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.CheckBox rememberMeCheckBox;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox deliveryTextBox;
        private System.Windows.Forms.TextBox telephoneTextBox;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox uniqueCode;
        private System.Windows.Forms.Label uniqueLabel;
    }
}


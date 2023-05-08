using Store_Inventory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Store_Inventory
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }


        // ON LOAD METHOD
        private void Form2_Load(object sender, EventArgs e)
        {
            Location = new Point(100, 100);
        }

        // SIGN OUT BUTTON
        private void signOutButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Sign Out?", "Sign Out", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Login_Screen Login_Screen = new Login_Screen();
                Login_Screen.Show();
                this.Hide();
            }
            else
            {

            }
        }

        //VIEW INVENTORY BUTTON
        private void viewInvButton_Click(object sender, EventArgs e)
        {
            //getSqlData();
            viewInventory viewInventory = new viewInventory();
            viewInventory.Show();
            this.Dispose();

        }

        private void viewInvButton_MouseEnter(object sender, EventArgs e)
        {
            viewInvButton.BackColor = Color.Blue; // set the hover color to blue
        }

        private void viewInvButton_MouseLeave(object sender, EventArgs e)
        {
            viewInvButton.BackColor = DefaultBackColor; // set the default color when mouse leaves the button
        }


        //VIEW SUPPLIER BUTTON
        private void viewSuppButton_Click(object sender, EventArgs e)
        {

            viewSuppliers viewSuppliers = new viewSuppliers();
            viewSuppliers.Show();
            this.Dispose();
        }
        private void viewSuppButton_MouseEnter(object sender, EventArgs e)
        {
            viewSuppButton.BackColor = Color.Blue; // set the hover color to blue
        }

        private void viewSuppButton_MouseLeave(object sender, EventArgs e)
        {
            viewSuppButton.BackColor = DefaultBackColor; // set the default color when mouse leaves the button
        }


        //ADD SUPPLIER BUTTON
        private void addSupplierButton_Click(object sender, EventArgs e)
        {

            addSupplier addSupplier = new addSupplier();
            addSupplier.Show();
            this.Dispose();
        }

        private void addSupplierButton_MouseEnter(object sender, EventArgs e)
        {
            addSupplierButton.BackColor = Color.Blue; // set the hover color to blue
        }
        private void addSupplierButton_MouseLeave(object sender, EventArgs e)
        {
            addSupplierButton.BackColor = DefaultBackColor; // set the hover color to blue
        }


        //ADD INVENTORY BUTTON
        private void addInventoryButton_Click(object sender, EventArgs e)
        {
            addInventoryForm addInventoryForm = new addInventoryForm();
            addInventoryForm.Show();
            this.Dispose();

        }
        private void addInventoryButton_MouseEnter(object sender, EventArgs e)
        {
            viewInvButton.BackColor = Color.Blue; // set the hover color to blue
        }

        private void addInventoryButton_MouseLeave(object sender, EventArgs e)
        {
            viewInvButton.BackColor = DefaultBackColor; // set the default color when mouse leaves the button
        }

        //BOOK OUT TAKE BUTTON
        private void stockTakeButton_Click(object sender, EventArgs e)
        {
            bookOutsScreen bookOutsScreen = new bookOutsScreen();
            bookOutsScreen.Show();
            this.Dispose();
        }
        
        private void stockTakeButton_MouseEnter(object sender, EventArgs e)
        {
            stockTakeButton.BackColor = Color.Blue; // set the hover color to blue
        }
        private void stockTakeButton_MouseLeave(object sender, EventArgs e)
        {
            stockTakeButton.BackColor = DefaultBackColor; // set the hover color to blue
        }
    }
}

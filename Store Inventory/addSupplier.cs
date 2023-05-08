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
    public partial class addSupplier : Form
    {
        public addSupplier()
        {
            InitializeComponent();
        }

        private void addSupplier_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        //HOME BUTTON
        private void newInvBackButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form2 ft2 = new Form2();
            ft2.Show();
        }

        private void supNametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void supAddtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void suppTeleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void suppEmailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void suppCodeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        // SAVE BUTTON
        private void saveButtton_Click(object sender, EventArgs e)
        {
            //Setting text container values for supplier

            string supName = supNametextBox.Text;
            string supAdd = supAddtextBox.Text;
            string supTelephone = suppTeleTextBox.Text;
            string supEmail = suppEmailTextBox.Text;
            string supCode = suppCodeTextBox.Text;

            // Call Insert Supplier Function 

            try
            {
                InsertSupplier(supName, supAdd, supTelephone, supEmail, supCode);
                MessageBox.Show("Successfully Created New Supplier");

                //Clear Fields after Execution

                supNametextBox.Text = "";
                supAddtextBox.Text = "";
                suppTeleTextBox.Text = "";
                suppEmailTextBox.Text = "";
                suppCodeTextBox.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error Occured: " + ex.Message);
                Program.LogException(ex);
            }

        }


        //Create Record in Database Supplier Table
        private void InsertSupplier(string supplierName, string supplierAddress, string supplierContact, string supplierEmail, string supplierCode)
        {
            // Create a connection to the SQL Server database
            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MyDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            // Create a SQL command with parameters for the values to be inserted
            SqlCommand command = new SqlCommand("INSERT INTO suppliersTable (supplierName, supplierAddress, supplierContact,supplierEmail,supplierCode,dateCreated) VALUES (@supplierName, @supplierAddress, @supplierContact,@supplierEmail,@supplierCode,@dateCreated)", connection);
            command.Parameters.AddWithValue("@supplierName", supplierName);
            command.Parameters.AddWithValue("@supplierAddress", supplierAddress);
            command.Parameters.AddWithValue("@supplierContact", supplierContact);
            command.Parameters.AddWithValue("@supplierEmail", supplierEmail);
            command.Parameters.AddWithValue("@supplierCode", supplierCode);
            command.Parameters.AddWithValue("@dateCreated", SqlDbType.Date).Value = DateTime.Now;

            // Open the database connection
            connection.Open();

            // Execute the SQL command to insert the data into the table
            command.ExecuteNonQuery();

            // Close the database connection
            connection.Close();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            supNametextBox.Text = "";
            supAddtextBox.Text = "";
            suppTeleTextBox.Text = "";
            suppEmailTextBox.Text = "";
            suppCodeTextBox.Text = "";
        }


    }
}

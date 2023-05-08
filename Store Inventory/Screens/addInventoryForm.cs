using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_Inventory
{
    public partial class addInventoryForm : Form
    {

        public addInventoryForm()
        {
            InitializeComponent();
        }

        public string supplierIdentity;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void prodNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void prodCodeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void prodQuanTextBox_TextChanged(object sender, EventArgs e)
        {
            // Get the text from the prodPriceTextBox
            string input = prodQuanTextBox.Text;

            // Define the regular expression pattern
            string pattern = @"^\d+$";

            // Check if the input matches the pattern
            if (Regex.IsMatch(input, pattern))
            {
                // Input is valid - do nothing
            }
            else
            {
                // Input is invalid - clear the text box
                prodQuanTextBox.Text = "";
            }

        }

        private void prodPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            // Get the text from the prodPriceTextBox
            string input = prodPriceTextBox.Text;

            // Define the regular expression pattern
            string pattern = @"^\d+$";

            // Check if the input matches the pattern
            if (Regex.IsMatch(input, pattern))
            {
                // Input is valid - do nothing
            }
            else
            {
                // Input is invalid - clear the text box
                prodPriceTextBox.Text = "";
            }
        }


        // BACK TO HOME BUTTON
        private void newInvBackButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form2 ft2 = new Form2();
            ft2.Show();
        }


        //SUBMIT BUTTON

        private void submitButton_Click(object sender, EventArgs e)
        {
            //Setting text container values for products
            string productname = prodNameTextBox.Text;
            string productcode = prodCodeTextBox.Text;
            string productQuantity = prodQuanTextBox.Text;
            decimal productPrice = Convert.ToDecimal(prodPriceTextBox.Text);

            //Create Records 

            try
            {
                InsertProduct(productname, productcode, productQuantity, productPrice);
                //InsertSupplier(supName, supAdd, supContact);
                MessageBox.Show("Product Loaded Successfully");
                //clear product fields after submissions
                prodNameTextBox.Text = "";
                prodCodeTextBox.Text = "";
                prodQuanTextBox.Text = "";
                prodPriceTextBox.Text = "";


                //clear supplier fields after submissions
                //suppNameTextBox.Text = "";
                //suppAddressTextBox.Text = "";
                //suppContactTextBox.Text = "";

            }
            catch (Exception error)
            {

                MessageBox.Show("Upload failed because: " + error.Message);
                Program.LogException(error);

            }

        }


        // RESET BUTTON
        private void resetButton_Click(object sender, EventArgs e)
        {
            prodNameTextBox.Text = "";
            prodCodeTextBox.Text = "";
            prodQuanTextBox.Text = "";
            prodPriceTextBox.Text = "";
        }



        //Create Record in Database Product Table Function
        private void InsertProduct(string productName, string productCode, string productQuantity, decimal productPrice)
        {

            //string supplierIdentifier = comboBox1.SelectedItem


            // Create a connection to the SQL Server database
            SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MyDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            // Create a SQL command with parameters for the values to be inserted
            SqlCommand command = new SqlCommand("INSERT INTO productTable (productName, productCode, productQuantity, productPrice,dateCreated,supplierName) VALUES (@productName, @productCode, @productQuantity, @productPrice,@dateCreated,@supplierName)", connection);
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productCode", productCode);
            command.Parameters.AddWithValue("@productQuantity", productQuantity);
            command.Parameters.AddWithValue("@productPrice", SqlDbType.Money).Value = productPrice;
            command.Parameters.AddWithValue("@dateCreated", SqlDbType.Date).Value = DateTime.Now;
            command.Parameters.AddWithValue("@supplierName", supplierIdentity);



            // Open the database connection
            connection.Open();

            // Execute the SQL command to insert the data into the table
            command.ExecuteNonQuery();

            // Close the database connection
            connection.Close();
        }

        private void addInventoryForm_Load(object sender, EventArgs e)
        {
            getSupplierData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            supplierIdentity = comboBox1.SelectedItem.ToString();
        }

        public void getSupplierData()
        {

            try
            {

                // Establish a connection to the SQL database
                string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MyDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                // Create a SQL query to retrieve data from the productTable
                string query = "SELECT DISTINCT supplierName FROM suppliersTable";
                SqlCommand command = new SqlCommand(query, connection);

                // Retrieve the data using a SqlDataReader
                SqlDataReader reader = command.ExecuteReader();

                // Clear the existing items in the combobox
                comboBox1.Items.Clear();

                // Add the retrieved data to the combobox
                while (reader.Read())
                {
                    string supplierName = reader["supplierName"].ToString();
                    string displayText = $"{supplierName}";
                    comboBox1.Items.Add(displayText);
                }



                // Close the reader and connection
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {

                Program.LogException(ex);

            }

        }
    }
}

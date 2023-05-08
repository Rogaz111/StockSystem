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
    public partial class viewSuppliers : Form
    {
        public viewSuppliers()
        {
            InitializeComponent();
        }


        private void viewSuppliers_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                Program.LogException(ex);
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void PopulateComboBox()
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve the selected value from the combo box.
                string selectedValue = comboBox1.SelectedItem.ToString();
                //string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                // Construct the SQL query using the selected value.
                string sql = "SELECT * FROM suppliersTable WHERE supplierName = '" + selectedValue + "'";

                // Create a new SqlConnection object to connect to the database.
                SqlConnection conn = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = MyDatabase; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");

                // Create a new SqlDataAdapter object to execute the SQL query and retrieve the data.
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);

                // Create a new DataTable object to hold the retrieved data.
                DataTable dt = new DataTable();

                // Use the SqlDataAdapter to fill the DataTable with the retrieved data.
                da.Fill(dt);

                // Bind the DataTable to the data grid view.
                dataGridView1.DataSource = dt;
                dataGridView1.ReadOnly = true;
            }
            catch (Exception ex)
            {
                Program.LogException(ex);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show();
            this.Hide();
        }
    }
}

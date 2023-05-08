using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Store_Inventory
{
    class Class1
    {
        public void CreateProductTable()
        {
            // Create a new DataTable with four columns
            DataTable productTable = new DataTable();
            DataColumn productNameColumn = new DataColumn("productName", typeof(string));
            DataColumn productCodeColumn = new DataColumn("productCode", typeof(string));
            DataColumn productQuantityColumn = new DataColumn("productQuantity", typeof(int));
            DataColumn productPriceColumn = new DataColumn("productPrice", typeof(decimal));
            productTable.Columns.Add(productNameColumn);
            productTable.Columns.Add(productCodeColumn);
            productTable.Columns.Add(productQuantityColumn);
            productTable.Columns.Add(productPriceColumn);

            // Add some rows to the productTable
            DataRow row1 = productTable.NewRow();
            row1["productName"] = "Product 1";
            row1["productCode"] = "P001";
            row1["productQuantity"] = 10;
            row1["productPrice"] = 10.99m;
            productTable.Rows.Add(row1);

            DataRow row2 = productTable.NewRow();
            row2["productName"] = "Product 2";
            row2["productCode"] = "P002";
            row2["productQuantity"] = 20;
            row2["productPrice"] = 20.99m;
            productTable.Rows.Add(row2);

            // Print out the contents of the productTable
            foreach (DataRow row in productTable.Rows)
            {
                Console.WriteLine("productName = {0}, productCode = {1}, productQuantity = {2}, productPrice = {3}",
                    row["productName"], row["productCode"], row["productQuantity"], row["productPrice"]);
            }
        }


        public DataTable GetProductTable()
        {
            DataTable productTable = new DataTable();

            // Specify your connection string
            string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MyDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            // Create a new SqlConnection and open it
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Create a new SqlCommand to retrieve the product data
                string query = "SELECT productName, productCode, productQuantity, productPrice FROM productTable";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Create a new SqlDataAdapter and use it to fill the DataTable with the retrieved data
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(productTable);
                    }
                }
            }

            return productTable;
        }
    }
}


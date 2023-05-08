using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_Inventory
{
    static class Program
    {

        private static string dbConnection = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MyDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        // Function For Retrieving Random Token From uniqueIdentity Table - SQL
        public static string GetRandomValue()
        {
            string valueUUID = "";

            try
            {
                using (SqlConnection connection = new SqlConnection(dbConnection))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SELECT TOP 1 * FROM uniqueIdentity ORDER BY NEWID()", connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Get the value from the column
                                object columnValue = reader["uniqueToken"];

                                // Use the value in a variable (you may need to cast it to the appropriate type)
                                valueUUID = (string)columnValue;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving the value: " + ex.Message);
            }

            return valueUUID;
        }

        //Global function for Error Handling

        public static void LogException(Exception ex)
        {
            // Create a timestamp for the error.
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            // Construct the error message with the timestamp and exception message.
            string errorMessage = "[" + timestamp + "] " + ":" + ex.Message;

            // Write the error message to a text file.
            string fileName = "error-log.txt";
            using (StreamWriter writer = new StreamWriter(fileName, true))
            {
                writer.WriteLine(errorMessage);
            }

            // Display the error message in a message box.
            MessageBox.Show("Exception Occured! Please consult administartor.");
        }

        public static void AddRoundRect(this GraphicsPath path, Rectangle rect, int radius)
        {
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(rect.Location, size);
            path.AddArc(arc, 180, 90);
            arc.X = rect.Right - diameter;
            path.AddArc(arc, 270, 90);
            arc.Y = rect.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            arc.X = rect.Left;
            path.AddArc(arc, 90, 90);
            path.CloseFigure();
        }


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login_Screen());
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_Inventory
{
    public partial class Login_Screen : Form
    {
        //private string valueUUID = "";
        public Login_Screen()
        {
            InitializeComponent();
            signUpButton.Visible = false;
            firstNameTextBox.Visible = false;
            lastNameTextBox.Visible = false;
            deliveryTextBox.Visible = false;
            telephoneTextBox.Visible = false;
            labelFirstName.Visible = false;
            label7.Visible = false;
            label.Visible = false;
            label5.Visible = false;
            uniqueLabel.Visible = false;
            uniqueCode.Visible = false;

        }

        private void Login_Screen_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (rememberMeCheckBox.Checked)
            {
                userPasswordTextBox.PasswordChar = '\0';
            }
            else
            {
                userPasswordTextBox.PasswordChar = '*';
            }

        }



        private void signUpButton_Click(object sender, EventArgs e)
        {

            //Get Text Field Values userName and userPassword and adding some validation to check if the fields are blank

            string userEmail = string.Empty;  //req
            string userPassword = string.Empty;  //req
            string userName = string.Empty;  //req
            string userLastName = string.Empty;  //req
            string userDeliveryAddress = string.Empty; //req
            string userTelephoneNumber = string.Empty;



            if (!string.IsNullOrEmpty(userNameTextBox.Text) &&
                    !string.IsNullOrEmpty(userPasswordTextBox.Text) &&
                         !string.IsNullOrEmpty(firstNameTextBox.Text) &&
                            !string.IsNullOrEmpty(lastNameTextBox.Text) &&
                     !string.IsNullOrEmpty(deliveryTextBox.Text))
            {
                userEmail = userNameTextBox.Text;
                userPassword = userPasswordTextBox.Text;
                userName = firstNameTextBox.Text;
                userLastName = lastNameTextBox.Text;
                userDeliveryAddress = deliveryTextBox.Text;
                userTelephoneNumber = telephoneTextBox.Text;
            }

            //BackEnd Configuration MSSQL

            string dbConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MyDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            using (SqlConnection connection = new SqlConnection(dbConnectionString))
            {
                try
                {
                    connection.Open();
                    // Use the connection for executing commands, etc.
                    using SqlCommand command = new SqlCommand("INSERT INTO authenticate(username, password) VALUES(@username, @password);", connection);
                    command.Parameters.AddWithValue("@username", userEmail);
                    command.Parameters.AddWithValue("@password", userPassword);
                    command.ExecuteNonQuery();

                    using SqlCommand command2 = new SqlCommand("INSERT INTO userInfo (firstname,lastname,email,deliveryAddress,telephone) VALUES(@firstname,@lastname,@email,@deliveryAddress,@telephone); SELECT SCOPE_IDENTITY()", connection);
                    command2.Parameters.AddWithValue("@firstname", userName);
                    command2.Parameters.AddWithValue("@lastname", userLastName);
                    command2.Parameters.AddWithValue("@email", userEmail);
                    command2.Parameters.AddWithValue("@deliveryAddress", userDeliveryAddress);
                    command2.Parameters.AddWithValue("@telephone", userTelephoneNumber);

                    command.ExecuteNonQuery();
                    command2.ExecuteNonQuery();
                    MessageBox.Show("Successfully Signed Up! \n\n You Should Receive an Email to verify your email address before logging in!");
                    connection.Close();
                }

                catch (Exception ex)
                {

                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            signUpButton.Visible = false;
            firstNameTextBox.Visible = false;
            lastNameTextBox.Visible = false;
            deliveryTextBox.Visible = false;
            telephoneTextBox.Visible = false;
            labelFirstName.Visible = false;
            label7.Visible = false;
            label.Visible = false;
            label5.Visible = false;
            passwordLabel.Visible = false;
            loginButton.Enabled = true;

            string GUID = Program.GetRandomValue();

            try
            {
                string smtpAddress = "smtp.gmail.com";
                string authPass = "sjpthbvzfmeomwul";
                string toAddress = userEmail; // email address entered by the user
                //string fromAddress = "devdeveloper647@gmail.com"; // replace with your email address
                string subject = "Welcome to our the Inventory";
                string body = "Dear " + userName + "," +
                    "" +
                    "\n\nThank you for signing up with us.\n\n" +
                    "Your verification code is: " + GUID + "\n\n" +
                    "Best regards,\nThe team.";

                using (SmtpClient smtpClient = new SmtpClient(smtpAddress, 587)) // replace with your SMTP server and port
                {
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = new NetworkCredential("devdeveloper647@gmail.com", authPass);
                    smtpClient.EnableSsl = true;
                    smtpClient.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;



                    using (MailMessage message = new MailMessage("devdeveloper647@gmail.com", toAddress, subject, body))
                    {
                        smtpClient.Send(message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while sending the email: " + ex.Message);
            }

            uniqueLabel.Visible = true;
            uniqueCode.Visible = true;
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            deliveryTextBox.Text = "";
            telephoneTextBox.Text = "";

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string userNameField = userNameTextBox.Text;
            string userPasswordField = userPasswordTextBox.Text;
            string verification = uniqueCode.Text;

            if (!string.IsNullOrEmpty(userNameField) && !string.IsNullOrEmpty(userPasswordField))
            {

                try
                {
                    using (SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MyDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand("SELECT username, password FROM authenticate WHERE username=@username AND password=@password", connection))
                        {
                            command.Parameters.AddWithValue("@username", userNameTextBox.Text);
                            command.Parameters.AddWithValue("@password", userPasswordTextBox.Text);

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    //uniqueCode.ReadOnly = true;
                                    MessageBox.Show("Login successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Form2 form2 = new Form2();
                                    form2.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Username or password is incorrect/Account Does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("Username or password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }


        }
        //443

        private void label3_Click(object sender, EventArgs e)
        {
            signUpButton.Visible = true;
            firstNameTextBox.Visible = true;
            lastNameTextBox.Visible = true;
            deliveryTextBox.Visible = true;
            telephoneTextBox.Visible = true;
            labelFirstName.Visible = true;
            label7.Visible = true;
            label.Visible = true;
            label5.Visible = true;
            loginButton.Enabled = true;


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void userPasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

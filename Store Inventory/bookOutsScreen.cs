using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_Inventory
{
    public partial class bookOutsScreen : Form
    {
        public bookOutsScreen()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Paint(object sender, PaintEventArgs e)
        {
            GraphicsPath roundedRectangle = new GraphicsPath();
            roundedRectangle.AddRoundRect(new Rectangle(0, 0, quantityTextBox.Width - 1, quantityTextBox.Height - 1), 10);

        }

        private void newInvBackButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show();
            this.Hide();
        }
    }
}

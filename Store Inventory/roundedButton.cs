using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_Inventory
{
    public class roundedButton : Button
    {
        private int cornerRadius = 15;

        public int CornerRadius
        {
            get { return cornerRadius; }
            set { cornerRadius = value; Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
            graphicsPath.AddArc(ClientSize.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90);
            graphicsPath.AddArc(ClientSize.Width - cornerRadius, ClientSize.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            graphicsPath.AddArc(0, ClientSize.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            graphicsPath.CloseFigure();
            this.Region = new Region(graphicsPath);

            base.OnPaint(e);
        }
    }
}

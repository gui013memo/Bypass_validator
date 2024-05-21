using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace OpenProtocolInterpreter.Sample
{
    public partial class CallBypassForm : Form
    {
        public CallBypassForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
            this.Paint += new PaintEventHandler(Form1_Paint);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //SetRoundedRegion();
        }
        private void SetRoundedRegion()
        {
            int radius = 10;  // Adjust the radius to your preference
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(this.Width - radius, 0, radius, radius), -90, 90);
            path.AddArc(new Rectangle(this.Width - radius, this.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, this.Height - radius, radius, radius), 90, 90);
            path.CloseFigure();
            this.Region = new Region(path);
        }


        private void button1_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                GraphicsPath path = new GraphicsPath();
                path.AddEllipse(0, 0, btn.Width, btn.Height);
                btn.Region = new Region(path);

                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.Clear(btn.Parent.BackColor);

                using (Brush brush = new SolidBrush(btn.BackColor))
                {
                    e.Graphics.FillEllipse(brush, 0, 0, btn.Width, btn.Height);
                }

                using (Pen pen = new Pen(btn.ForeColor, 2))
                {
                    e.Graphics.DrawEllipse(pen, 0, 0, btn.Width - 1, btn.Height - 1);
                }

                TextRenderer.DrawText(e.Graphics, btn.Text, btn.Font, btn.ClientRectangle, btn.ForeColor);
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            SetRoundedRegion();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            //SetRoundedRegion(); // Ensure the region updates when resizing

            this.Width = 70;
            this.Height = 25;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                CheckSQSBadge();
            });
            this.Invoke((MethodInvoker)delegate
            {
                checkingForm.Show();
            });

            logger.Log("Got out of CheckSQSBadge");

            this.Invoke((MethodInvoker)delegate
            {
                checkBadgeTimer.Start();
            });
        }
    }
}

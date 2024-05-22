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
        BadgeCheckingForm checkingForm;
        DriverForm driverForm;

        public CallBypassForm(BadgeCheckingForm badgeForm, DriverForm driverForm)
        {
            this.driverForm = driverForm;
            checkingForm = badgeForm;
            InitializeComponent();
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

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            SetRoundedRegion();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            //SetRoundedRegion(); // Ensure the region updates when resizing

            this.Width = 130;
            this.Height = 38;
        }

       

        private void bypassRequestButton_Click(object sender, EventArgs e)
        {
           // this.Invoke((MethodInvoker)delegate
            //{
                driverForm.CheckSQSBadge();
            //});
           // this.Invoke((MethodInvoker)delegate
           // {
                checkingForm.Show();
           // });

           // this.Invoke((MethodInvoker)delegate
           // {
                driverForm.checkBadgeTimer.Start();
           // });
        }
    }
}

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
        public bool isBypassOn;
        public bool bypassStopRequested = false;

        public CallBypassForm(BadgeCheckingForm badgeForm, DriverForm driverForm)
        {
            this.driverForm = driverForm;
            checkingForm = badgeForm;
            InitializeComponent();
            this.Paint += new PaintEventHandler(Form1_Paint);

            //focusTimer.Start();
        }

        private void SetRoundedRegion()
        {
            int radius = 10;
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

            this.Width = 130;
            this.Height = 38;
        }



        private void bypassRequestButton_Click(object sender, EventArgs e)
        {
           
        }

        private void bypassLabelBlinkingTimer_Tick(object sender, EventArgs e)
        {
            if (this.BackColor == Color.FromArgb(80, 94, 107))
                this.BackColor = Color.FromArgb(82, 130, 184);
            else
                this.BackColor = Color.FromArgb(80, 94, 107);
        }

        private void focusTimer_Tick(object sender, EventArgs e)
        {
            //    if (!this.Focused)
            //    {
            //        Console.WriteLine("callBypassForm lost focus, focusing...");
            //        this.Activate();
            //    }

            //    // Ensure a specific control has focus
            //    if (!bypassRequestButton.Focused)
            //    {
            //        Console.WriteLine("bypassRequestButton lost focus, focusing...");
            //        bypassRequestButton.Focus();
            //    }
        }

        private void callBypassButtonLabel_Click(object sender, EventArgs e)
        {
            Console.WriteLine("callBypassButtonLabelPressed");

            if (callBypassButtonLabel.Text == "BYPASS OFF")
            {
                this.Invoke((MethodInvoker)delegate
                {
                    bypassStopRequested = false;

                    driverForm.checkBadgeTimer.Start();
                    bypassLabelBlinkingTimer.Start();

                    isBypassOn = true;
                    callBypassButtonLabel.Text = "BYPASS ON";
                    callBypassButtonLabel.ForeColor = Color.Lime;

                    //bypassLabelBlinkingTimer.Start();
                });
            }
            else if (callBypassButtonLabel.Text == "BYPASS ON")
            {
                this.Invoke((MethodInvoker)delegate
                {
                    bypassStopRequested = false;

                    driverForm.SendCommandAllStations(false);

                    driverForm.firstBadgeReadingAux = true;
                    driverForm.firstTickDone = false;
                    checkingForm.retationAllowed = false;

                    checkingForm.shadeEffectTimer.Start();
                    driverForm.checkBadgeTimer.Stop();

                    driverForm.callBypassForm.callBypassButtonLabel.Text = "BYPASS OFF";
                    driverForm.callBypassForm.callBypassButtonLabel.ForeColor = Color.Yellow;

                    isBypassOn = false;
                });
            }
        }
    }
}

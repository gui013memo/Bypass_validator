﻿using System;
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
       // bool isBypassOn = false;

        public CallBypassForm(BadgeCheckingForm badgeForm, DriverForm driverForm)
        {
            this.driverForm = driverForm;
            checkingForm = badgeForm;
            InitializeComponent();
            this.Paint += new PaintEventHandler(Form1_Paint);
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
            if (bypassRequestButton.Text == "BYPASS OFF")
            {
                this.Invoke((MethodInvoker)delegate
                {
                    driverForm.checkBadgeTimer.Start();

                    isBypassOn = true;
                    bypassRequestButton.Text = "BYPASS ON";
                    bypassRequestButton.ForeColor = Color.Lime;

                    bypassLabelBlinkingTimer.Start();
                });
            }
            else if (bypassRequestButton.Text == "BYPASS ON")
            {
                driverForm.firstBadgeReadingAux = true;

                driverForm.firstTickDone = false;
                checkingForm.retationAllowed = false;
                checkingForm.shadeEffectTimer.Start();
                driverForm.checkBadgeTimer.Stop();

                driverForm.SendCommandAllStations(false);

                driverForm.callBypassForm.bypassRequestButton.Text = "BYPASS OFF";
                driverForm.callBypassForm.bypassRequestButton.ForeColor = Color.Yellow;

                isBypassOn = false;
                checkingForm.Hide();
            }
        }

        private void bypassLabelBlinkingTimer_Tick(object sender, EventArgs e)
        {

        }
    }
}

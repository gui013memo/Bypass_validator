using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenProtocolInterpreter.Sample
{
    public partial class HomeForm : Form
    {
        Color _red = Color.FromArgb(201, 44, 31);
        Color _grey = Color.FromArgb(51, 61, 70);
        Color _blue = Color.FromArgb(82, 130, 184); 

        DriverForm driverForm;

        bool vsOneTimerState = false;
        bool vsTwoTimerState = false;
        bool vsThreeTimerState = false;

        public enum VirtualStations
        {
            One,
            Two,
            Three
        }

        public enum vsStatus
        {
            None,
            Connecting,
            Connected,
            ConnFailed,
            Warning
        }

        public vsStatus vsOneState = vsStatus.None;
        public vsStatus vsTwoState = vsStatus.None;
        public vsStatus vsThreeState = vsStatus.None;

        public HomeForm(DriverForm driverForm)
        {
            this.driverForm = driverForm;
            InitializeComponent();
        }

        public void updateVsConnStatus(VirtualStations vs, vsStatus status)
        {
            switch (vs)
            {
                case VirtualStations.One:
                    switch (status)
                    {
                        case vsStatus.None:
                            vsOneState = vsStatus.None;
                            vsOneConnStateLabel.ForeColor = _grey;
                            vsOneConnStateLabel.BackColor = Color.Transparent;
                            vsOneTimer.Stop();
                            break;
                        case vsStatus.Connecting:
                            vsOneState = vsStatus.Connecting;
                            vsOneTimer.Start();
                            break;
                        case vsStatus.ConnFailed:
                            vsOneState = vsStatus.ConnFailed;
                            vsOneConnStateLabel.ForeColor = Color.Transparent;
                            vsOneConnStateLabel.BackColor = _red;
                            vsOneTimer.Stop();
                            break;
                        case vsStatus.Connected:
                            vsOneState = vsStatus.Connected;
                            vsOneTimer.Stop();
                            vsOneConnStateLabel.ForeColor = Color.Transparent;
                            vsOneConnStateLabel.BackColor = Color.Green;
                            break;
                        case vsStatus.Warning:
                            vsOneState = vsStatus.Warning;
                            vsOneTimer.Start();
                            break;
                    }
                    break;
                case VirtualStations.Two:
                    switch (status)
                    {
                        case vsStatus.None:
                            vsOneConnStateLabel.ForeColor = Color.FromArgb(51, 61, 70);
                            vsOneConnStateLabel.BackColor = Color.Transparent;
                            break;
                        case vsStatus.Connecting:
                            vsTwoTimer.Start();
                            break;
                    }
                    break;
            }
        }

        private void startOrStopButton_Click(object sender, EventArgs e)
        {
            driverForm.StartInterface(this, EventArgs.Empty);
        }

        private void startModeButton_Click(object sender, EventArgs e)
        {
            driverForm.startInterfaceButton_Click(this, EventArgs.Empty);
        }

        private void vsOneTimer_Tick(object sender, EventArgs e)
        {

            switch (vsOneState)
            {
                case vsStatus.Connecting:
                    if (!vsOneTimerState)
                    {
                        vsOneConnStateLabel.ForeColor = Color.Transparent;
                        vsOneConnStateLabel.BackColor = _blue;
                        this.Update();
                        vsOneTimerState = true;
                    }
                    else
                    {
                        vsOneConnStateLabel.ForeColor = _grey;
                        vsOneConnStateLabel.BackColor = Color.Transparent;
                        this.Update();
                        vsOneTimerState = false;
                    }
                    break;
                case vsStatus.Warning:
                    if (!vsOneTimerState)
                    {
                        vsOneConnStateLabel.ForeColor = Color.Transparent;
                        vsOneConnStateLabel.BackColor = Color.Yellow;
                        this.Update();
                        vsOneTimerState = true;
                    }
                    else
                    {
                        vsOneConnStateLabel.ForeColor = _grey;
                        vsOneConnStateLabel.BackColor = Color.Transparent;
                        this.Update();
                        vsOneTimerState = false;
                    }
                    break;
            }
        }

        private void vsTwoTimer_Tick(object sender, EventArgs e)
        {

        }

        private void vsThreeTimer_Tick(object sender, EventArgs e)
        {

        }
    }
}

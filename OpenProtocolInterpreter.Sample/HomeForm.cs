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

        public enum vsLabelStatus
        {
            None,
            Connecting,
            Connected,
            ConnFailed,
            Disconnected,
            Warning
        }

        public HomeForm(DriverForm driverForm)
        {
            this.driverForm = driverForm;
            InitializeComponent();
        }

        public void updateConnStatusLabels(VirtualStations vs, vsLabelStatus status)
        {
            switch (vs)
            {
                case VirtualStations.One:
                    switch (status)
                    {
                        case vsLabelStatus.None:
                            vsOneConnStateLabel.ForeColor = Color.FromArgb(51, 61, 70);
                            vsOneConnStateLabel.BackColor = Color.Transparent;
                            break;
                        case vsLabelStatus.Connecting:
                            vsOneConnectingTimer.Start();
                            break;
                        case vsLabelStatus.ConnFailed:
                            break;
                        case vsLabelStatus.Connected:
                            vsOneConnectingTimer.Stop();
                            vsOneConnStateLabel.ForeColor = Color.Transparent;
                            vsOneConnStateLabel.BackColor = Color.Green;
                            break;
                        case vsLabelStatus.Disconnected:
                            break;
                        case vsLabelStatus.Warning:

                            break;
                    }
                    break;
                case VirtualStations.Two:
                    switch (status)
                    {
                        case vsLabelStatus.None:
                            vsOneConnStateLabel.ForeColor = Color.FromArgb(51, 61, 70);
                            vsOneConnStateLabel.BackColor = Color.Transparent;
                            break;
                        case vsLabelStatus.Connecting:
                            vsTwoConnectingTimer.Start();
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

        private void vsOneConnectingTimer_Tick(object sender, EventArgs e)
        {
            if (!vsOneTimerState)
            {
                vsOneConnStateLabel.ForeColor = Color.Transparent;
                vsOneConnStateLabel.BackColor = Color.FromArgb(82, 130, 184);
                this.Update();
                vsOneTimerState = true;
            }
            else
            {
                updateConnStatusLabels(VirtualStations.One, vsLabelStatus.None);
                this.Update();
                vsOneTimerState = false;
            }

        }

        private void vsTwoConnectingTimer_Tick(object sender, EventArgs e)
        {

        }

        private void vsThreeConnectingTimer_Tick(object sender, EventArgs e)
        {

        }
    }
}

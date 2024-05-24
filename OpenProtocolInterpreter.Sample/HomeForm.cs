using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static OpenProtocolInterpreter.Sample.HomeForm;

namespace OpenProtocolInterpreter.Sample
{
    public partial class HomeForm : Form
    {
        public Color _red = Color.FromArgb(201, 44, 31);
        public Color _grey = Color.FromArgb(51, 61, 70);
        public Color _blue = Color.FromArgb(82, 130, 184);

        DriverForm driverForm;

        bool vsOneTimerState = false;
        bool vsTwoTimerState = false;
        bool vsThreeTimerState = false;

        public enum StartMode
        {
            Manual,
            Automatic
        }

        public StartMode currentMode = StartMode.Automatic;

        public enum VirtualStations
        {
            One,
            Two,
            Three
        }

        public enum VsStatus
        {
            None,
            Connecting,
            Connected,
            ConnFailed,
            Warning
        }

        VsStatus _vsOneState;
        VsStatus _vsTwoState;
        VsStatus _vsThreeState;

        public VsStatus vsOneState
        {
            get { return _vsOneState; }
            set
            {
                _vsOneState = value;
                updateManualVsButtons();
            }
        }
        public VsStatus vsTwoState
        {
            get { return _vsTwoState; }
            set
            {
                _vsTwoState = value;
                updateManualVsButtons();
            }
        }
        public VsStatus vsThreeState
        {
            get { return _vsThreeState; }
            set
            {
                _vsThreeState = value;
                updateManualVsButtons();
            }
        }

        public HomeForm(DriverForm driverForm)
        {
            this.driverForm = driverForm;
            InitializeComponent();
        }

        private void updateStartOrStopButton()
        {
            if (vsOneState != VsStatus.Connecting && vsTwoState != VsStatus.Connecting && vsThreeState != VsStatus.Connecting)
            {
                if (vsOneState != VsStatus.ConnFailed || vsTwoState == VsStatus.ConnFailed || vsThreeState == VsStatus.ConnFailed)
                {
                    startOrStopButton.Text = "STOP";
                    startOrStopButton.BackColor = _red;
                    startOrStopButton.ForeColor = Color.Transparent;
                }
                else
                {
                    startOrStopButton.Text = "START";
                    startOrStopButton.BackColor = Color.Green;
                    startOrStopButton.ForeColor = Color.Transparent;
                }
            }
        }

        public void updateVsConnStatus(VirtualStations vs, VsStatus status)
        {
            switch (vs)
            {
                case VirtualStations.One:
                    switch (status)
                    {
                        case VsStatus.None:
                            vsOneState = VsStatus.None;
                            vsOneConnStateLabel.ForeColor = _grey;
                            vsOneConnStateLabel.BackColor = Color.Transparent;
                            vsOneTimer.Stop();
                            break;
                        case VsStatus.Connecting:
                            vsOneState = VsStatus.Connecting;
                            vsOneTimer.Start();
                            break;
                        case VsStatus.ConnFailed:
                            vsOneState = VsStatus.ConnFailed;
                            vsOneConnStateLabel.ForeColor = Color.Transparent;
                            vsOneConnStateLabel.BackColor = _red;
                            vsOneTimer.Stop();
                            if (currentMode == StartMode.Automatic)
                                updateStartOrStopButton();
                            break;
                        case VsStatus.Connected:
                            vsOneState = VsStatus.Connected;
                            vsOneTimer.Stop();
                            vsOneConnStateLabel.ForeColor = Color.Transparent;
                            vsOneConnStateLabel.BackColor = Color.Green;
                            if (currentMode == StartMode.Automatic)
                                updateStartOrStopButton();
                            break;
                        case VsStatus.Warning:
                            vsOneState = VsStatus.Warning;
                            vsOneTimer.Start();
                            if (currentMode == StartMode.Automatic)
                                updateStartOrStopButton();
                            break;
                    }
                    break;
                case VirtualStations.Two:
                    switch (status)
                    {
                        case VsStatus.None:
                            vsOneConnStateLabel.ForeColor = Color.FromArgb(51, 61, 70);
                            vsOneConnStateLabel.BackColor = Color.Transparent;
                            break;
                        case VsStatus.Connecting:
                            vsTwoTimer.Start();
                            break;
                    }
                    break;
            }
        }

        private void startOrStopButton_Click(object sender, EventArgs e)
        {
            if (startOrStopButton.Text == "START")
            {
                startOrStopButton.Text = "CONNECTING";
                startOrStopButton.BackColor = Color.Yellow;
                startOrStopButton.ForeColor = Color.Black;

                driverForm.StartInterface();
            }
            else if (startOrStopButton.Text == "STOP")
            {
                driverForm.StopAllInterfaces();
                startOrStopButton.Text = "START";
                startOrStopButton.BackColor = Color.Green;
                startOrStopButton.ForeColor = Color.Transparent;
            }
            else if(startOrStopButton.Text == "CONNECTING")
            {
                DialogResult result = MessageBox.Show("Do you want to cancel the connection attempt?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
                if(result == DialogResult.Yes)
                {
                    startOrStopButton.Text = "START";
                    startOrStopButton.BackColor = Color.Green;
                    startOrStopButton.ForeColor = Color.Transparent;
                }
            }
        }

        private void ModeButton_Click(object sender, EventArgs e)
        {
            if (ModeButton.Text == "SET MANUAL")
            {
                currentMode = StartMode.Manual;
                startOrStopButton.Enabled = false;
                ModeButton.BackColor = Color.Gainsboro;
                ModeButton.ForeColor = _grey;

                vsOneStartOrStopButton.Enabled = true;
                vsTwoStartOrStopButton.Enabled = true;
                vsThreeStartOrStopButton.Enabled = true;

                updateManualVsButtons();
            }
            else if (ModeButton.Text == "SET AUTOMATIC")
            {
                currentMode = StartMode.Automatic;

                startOrStopButton.Enabled = true;
                if (_vsOneState == VsStatus.Connected || _vsOneState == VsStatus.Warning ||
                    _vsTwoState == VsStatus.Connected || _vsTwoState == VsStatus.Warning ||
                    _vsTwoState == VsStatus.Connected || _vsTwoState == VsStatus.Warning)
                {
                    startOrStopButton.Text = "STOP";
                }
                else if (_vsOneState == VsStatus.Connecting || _vsTwoState == VsStatus.Connecting || _vsThreeState == VsStatus.Connecting)
                {
                    startOrStopButton.Text = "CONNECTING";
                }
                else
                {
                    startOrStopButton.Text = "START";
                }

                vsOneStartOrStopButton.Enabled = false;
                vsTwoStartOrStopButton.Enabled = false;
                vsThreeStartOrStopButton.Enabled = false;

                vsOneStartOrStopButton.BackColor = Color.Gainsboro;
                vsOneStartOrStopButton.ForeColor = _grey;
                vsOneStartOrStopButton.Text = "AUTOMATIC";

                vsTwoStartOrStopButton.BackColor = Color.Gainsboro;
                vsTwoStartOrStopButton.ForeColor = _grey;
                vsTwoStartOrStopButton.Text = "AUTOMATIC";

                vsThreeStartOrStopButton.BackColor = Color.Gainsboro;
                vsThreeStartOrStopButton.ForeColor = _grey;
                vsThreeStartOrStopButton.Text = "AUTOMATIC";
            }
        }

        public void updateManualVsButtons()
        {
            if (currentMode == StartMode.Manual)
            {
                switch (_vsOneState)
                {
                    case VsStatus.None:
                        vsOneStartOrStopButton.BackColor = Color.Green;
                        vsOneStartOrStopButton.ForeColor = Color.Transparent;
                        vsOneStartOrStopButton.Text = "START";
                        break;
                    case VsStatus.Connected:
                        vsOneStartOrStopButton.BackColor = _red;
                        vsOneStartOrStopButton.ForeColor = Color.Transparent;
                        vsOneStartOrStopButton.Text = "STOP";
                        break;
                    case VsStatus.ConnFailed:
                        vsOneStartOrStopButton.BackColor = Color.Green;
                        vsOneStartOrStopButton.ForeColor = Color.Transparent;
                        vsOneStartOrStopButton.Text = "START";
                        break;
                    case VsStatus.Connecting:
                        vsOneStartOrStopButton.BackColor = Color.Gainsboro;
                        vsOneStartOrStopButton.ForeColor = _grey;
                        vsOneStartOrStopButton.Text = "CONNECTING";
                        break;
                }

                switch (_vsTwoState)
                {
                    case VsStatus.None:
                        vsTwoStartOrStopButton.BackColor = Color.Green;
                        vsTwoStartOrStopButton.ForeColor = Color.Transparent;
                        vsTwoStartOrStopButton.Text = "START";
                        break;
                    case VsStatus.Connected:
                        vsTwoStartOrStopButton.BackColor = _red;
                        vsTwoStartOrStopButton.ForeColor = Color.Transparent;
                        vsTwoStartOrStopButton.Text = "STOP";
                        break;
                    case VsStatus.ConnFailed:
                        vsTwoStartOrStopButton.BackColor = Color.Green;
                        vsTwoStartOrStopButton.ForeColor = Color.Transparent;
                        vsTwoStartOrStopButton.Text = "START";
                        break;
                    case VsStatus.Connecting:
                        vsTwoStartOrStopButton.BackColor = Color.Gainsboro;
                        vsTwoStartOrStopButton.ForeColor = _grey;
                        vsTwoStartOrStopButton.Text = "CONNECTING";
                        break;
                }

                switch (_vsThreeState)
                {
                    case VsStatus.None:
                        vsThreeStartOrStopButton.BackColor = Color.Green;
                        vsThreeStartOrStopButton.ForeColor = Color.Transparent;
                        vsThreeStartOrStopButton.Text = "START";
                        break;
                    case VsStatus.Connected:
                        vsThreeStartOrStopButton.BackColor = _red;
                        vsThreeStartOrStopButton.ForeColor = Color.Transparent;
                        vsThreeStartOrStopButton.Text = "STOP";
                        break;
                    case VsStatus.ConnFailed:
                        vsThreeStartOrStopButton.BackColor = Color.Green;
                        vsThreeStartOrStopButton.ForeColor = Color.Transparent;
                        vsThreeStartOrStopButton.Text = "START";
                        break;
                    case VsStatus.Connecting:
                        vsThreeStartOrStopButton.BackColor = Color.Gainsboro;
                        vsThreeStartOrStopButton.ForeColor = _grey;
                        vsThreeStartOrStopButton.Text = "CONNECTING";
                        break;
                }
            }
        }

        private void vsOneTimer_Tick(object sender, EventArgs e)
        {

            switch (vsOneState)
            {
                case VsStatus.Connecting:
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
                case VsStatus.Warning:
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

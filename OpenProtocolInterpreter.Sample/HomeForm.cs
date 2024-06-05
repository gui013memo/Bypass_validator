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
        Logger logger = new Logger();

        public Color _orange = Color.FromArgb(255, 128, 0);
        public Color _red = Color.FromArgb(201, 44, 31);
        public Color _grey = Color.FromArgb(51, 61, 70);
        public Color _blue = Color.FromArgb(82, 130, 184);

        DriverForm driverForm;

        bool vsOneTimerState = false;
        bool vsTwoTimerState = false;
        bool vsThreeTimerState = false;

        System.Timers.Timer vsOneTimer;


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
            Reconnecting,
            Connected,
            ConnFailed,
            Warning,
            ConnDropped
        }

        VsStatus _vsOneState = VsStatus.None;
        VsStatus _vsTwoState = VsStatus.None;
        VsStatus _vsThreeState = VsStatus.None;

        public bool vsOneThreadRunning = false;
        public bool vsTwoThreadRunning = false;
        public bool vsThreeThreadRunning = false;

        public bool vsOneStopRequest;
        public bool vsTwoStopRequest;
        public bool vsThreeStopRequest;

        public VsStatus vsOneState
        {
            get { return _vsOneState; }
            private set
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

        int i = 0;

        public HomeForm(DriverForm driverForm)
        {
            this.driverForm = driverForm;
            InitializeComponent();


            vsOneTimer = new System.Timers.Timer();
            vsOneTimer.Enabled = false;
            vsOneTimer.Interval = 150;
            vsOneTimer.Elapsed += vsOneTimer_Tick;
        }

        //Used for automatic mode
        private void updateStartOrStopButton()
        {
            if (currentMode == StartMode.Automatic)
            {
                startOrStopButton.Enabled = true;
                if (_vsOneState == VsStatus.Connected || _vsOneState == VsStatus.Warning ||
                    _vsTwoState == VsStatus.Connected || _vsTwoState == VsStatus.Warning ||
                    _vsTwoState == VsStatus.Connected || _vsTwoState == VsStatus.Warning)
                {
                    startOrStopButton.BackColor = _red;
                    startOrStopButton.ForeColor = Color.Transparent;
                    startOrStopButton.Text = "STOP";
                }
                else if (_vsOneState == VsStatus.Connecting || _vsTwoState == VsStatus.Connecting || _vsThreeState == VsStatus.Connecting)
                {
                    startOrStopButton.Text = "CONNECTING";
                    startOrStopButton.BackColor = Color.Yellow;
                    startOrStopButton.ForeColor = Color.Black;
                }
                else
                {
                    startOrStopButton.BackColor = Color.Green;
                    startOrStopButton.ForeColor = Color.Transparent;
                    startOrStopButton.Text = "START";
                }


            }
            else //Manual mode
            {
                startOrStopButton.Enabled = false;
                startOrStopButton.Text = "MANUAL ON";
                startOrStopButton.BackColor = Color.Gainsboro;
                startOrStopButton.ForeColor = _grey;


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
                            logger.Log("NEW vsOneStatus: " + status.ToString());
                            break;
                        case VsStatus.Connecting:
                            vsOneState = VsStatus.Connecting;
                            vsOneTimer.Start();
                            logger.Log("NEW vsOneStatus: " + status.ToString());
                            break;
                        case VsStatus.Reconnecting:
                            vsOneState = VsStatus.Reconnecting;
                            vsOneTimer.Start();
                            logger.Log("NEW vsOneStatus: " + status.ToString());
                            break;
                        case VsStatus.ConnFailed:
                            vsOneState = VsStatus.ConnFailed;
                            vsOneConnStateLabel.ForeColor = Color.Transparent;
                            vsOneConnStateLabel.BackColor = _red;
                            vsOneTimer.Stop();
                            if (currentMode == StartMode.Automatic)
                                updateStartOrStopButton();
                            logger.Log("NEW vsOneStatus: " + status.ToString());
                            break;
                        case VsStatus.Connected:
                            vsOneState = VsStatus.Connected;
                            vsOneTimer.Stop();
                            vsOneConnStateLabel.ForeColor = Color.Transparent;
                            vsOneConnStateLabel.BackColor = Color.Green;
                            if (currentMode == StartMode.Automatic)
                                updateStartOrStopButton();
                            logger.Log("NEW vsOneStatus: " + status.ToString());
                            break;
                        case VsStatus.Warning:
                            vsOneState = VsStatus.Warning;
                            vsOneTimer.Start();
                            if (currentMode == StartMode.Automatic)
                                updateStartOrStopButton();
                            logger.Log("NEW vsOneStatus: " + status.ToString());
                            break;
                        case VsStatus.ConnDropped:
                            vsOneState = VsStatus.ConnDropped;
                            vsOneTimer.Start();
                            if (currentMode == StartMode.Automatic)
                                updateStartOrStopButton();
                            logger.Log("NEW vsOneStatus: " + status.ToString());
                            break;
                    }
                    break;
                case VirtualStations.Two:
                    switch (status)
                    {
                        case VsStatus.None:
                            vsTwoState = VsStatus.None;
                            vsTwoConnStateLabel.ForeColor = _grey;
                            vsTwoConnStateLabel.BackColor = Color.Transparent;
                            vsTwoTimer.Stop();
                            logger.Log("NEW vsTwoStatus: " + status.ToString());
                            break;
                        case VsStatus.Connecting:
                            vsTwoState = VsStatus.Connecting;
                            vsTwoTimer.Start();
                            logger.Log("NEW vsTwoStatus: " + status.ToString());
                            break;
                        case VsStatus.Reconnecting:
                            vsTwoState = VsStatus.Reconnecting;
                            vsTwoTimer.Start();
                            logger.Log("NEW vsTwoStatus: " + status.ToString());
                            break;
                        case VsStatus.ConnFailed:
                            vsTwoState = VsStatus.ConnFailed;
                            vsTwoConnStateLabel.ForeColor = Color.Transparent;
                            vsTwoConnStateLabel.BackColor = _red;
                            vsTwoTimer.Stop();
                            if (currentMode == StartMode.Automatic)
                                updateStartOrStopButton();
                            logger.Log("NEW vsTwoStatus: " + status.ToString());
                            break;
                        case VsStatus.Connected:
                            vsTwoState = VsStatus.Connected;
                            vsTwoTimer.Stop();
                            vsTwoConnStateLabel.ForeColor = Color.Transparent;
                            vsTwoConnStateLabel.BackColor = Color.Green;
                            if (currentMode == StartMode.Automatic)
                                updateStartOrStopButton();
                            logger.Log("NEW vsTwoStatus: " + status.ToString());
                            break;
                        case VsStatus.Warning:
                            vsTwoState = VsStatus.Warning;
                            vsTwoTimer.Start();
                            if (currentMode == StartMode.Automatic)
                                updateStartOrStopButton();
                            logger.Log("NEW vsTwoStatus: " + status.ToString());
                            break;
                        case VsStatus.ConnDropped:
                            vsTwoState = VsStatus.ConnDropped;
                            vsTwoTimer.Start();
                            if (currentMode == StartMode.Automatic)
                                updateStartOrStopButton();
                            logger.Log("NEW vsTwoStatus: " + status.ToString());
                            break;
                    }
                    break;
                case VirtualStations.Three:
                    switch (status)
                    {
                        case VsStatus.None:
                            vsThreeState = VsStatus.None;
                            vsThreeConnStateLabel.ForeColor = _grey;
                            vsThreeConnStateLabel.BackColor = Color.Transparent;
                            vsThreeTimer.Stop();
                            logger.Log("NEW vsThreeStatus: " + status.ToString());
                            break;
                        case VsStatus.Connecting:
                            vsThreeState = VsStatus.Connecting;
                            vsThreeTimer.Start();
                            logger.Log("NEW vsThreeStatus: " + status.ToString());
                            break;
                        case VsStatus.Reconnecting:
                            vsThreeState = VsStatus.Reconnecting;
                            vsThreeTimer.Start();
                            logger.Log("NEW vsThreeStatus: " + status.ToString());
                            break;
                        case VsStatus.ConnFailed:
                            vsThreeState = VsStatus.ConnFailed;
                            vsThreeConnStateLabel.ForeColor = Color.Transparent;
                            vsThreeConnStateLabel.BackColor = _red;
                            vsThreeTimer.Stop();
                            if (currentMode == StartMode.Automatic)
                                updateStartOrStopButton();
                            logger.Log("NEW vsThreeStatus: " + status.ToString());
                            break;
                        case VsStatus.Connected:
                            vsThreeState = VsStatus.Connected;
                            vsThreeTimer.Stop();
                            vsThreeConnStateLabel.ForeColor = Color.Transparent;
                            vsThreeConnStateLabel.BackColor = Color.Green;
                            if (currentMode == StartMode.Automatic)
                                updateStartOrStopButton();
                            logger.Log("NEW vsThreeStatus: " + status.ToString());
                            break;
                        case VsStatus.Warning:
                            vsThreeState = VsStatus.Warning;
                            vsThreeTimer.Start();
                            if (currentMode == StartMode.Automatic)
                                updateStartOrStopButton();
                            logger.Log("NEW vsThreeStatus: " + status.ToString());
                            break;
                        case VsStatus.ConnDropped:
                            vsThreeState = VsStatus.ConnDropped;
                            vsThreeTimer.Start();
                            if (currentMode == StartMode.Automatic)
                                updateStartOrStopButton();
                            logger.Log("NEW vsThreeStatus: " + status.ToString());
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

                updateVsConnStatus(VirtualStations.One, VsStatus.Connecting);
                updateVsConnStatus(VirtualStations.Two, VsStatus.Connecting);
                updateVsConnStatus(VirtualStations.Three, VsStatus.Connecting);

                driverForm.StartAllInterfaces();
            }
            else if (startOrStopButton.Text == "STOP")
            {
                updateVsConnStatus(VirtualStations.One, VsStatus.None);
                updateVsConnStatus(VirtualStations.Two, VsStatus.None);
                updateVsConnStatus(VirtualStations.Three, VsStatus.None);

                driverForm.StopAllInterfaces();

                startOrStopButton.Text = "START";
                startOrStopButton.BackColor = Color.Green;
                startOrStopButton.ForeColor = Color.Transparent;
            }
            else if (startOrStopButton.Text == "CONNECTING")
            {
                DialogResult result = MessageBox.Show("Do you want to cancel the connection attempt?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    driverForm.StopConnAttempt(VirtualStations.One);
                    driverForm.StopConnAttempt(VirtualStations.Two);
                    driverForm.StopConnAttempt(VirtualStations.Three);

                    updateVsConnStatus(VirtualStations.One, VsStatus.None);
                    updateVsConnStatus(VirtualStations.Two, VsStatus.None);
                    updateVsConnStatus(VirtualStations.Three, VsStatus.None);

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
                ModeButton.Text = "SET AUTOMATIC";

                currentMode = StartMode.Manual;

                updateStartOrStopButton();
                updateManualVsButtons();
            }
            else if (ModeButton.Text == "SET AUTOMATIC")
            {
                ModeButton.Text = "SET MANUAL";

                currentMode = StartMode.Automatic;

                updateStartOrStopButton();
                updateManualVsButtons();
            }
        }

        public void updateManualVsButtons()
        {
            if (currentMode == StartMode.Manual)
            {
                vsOneStartOrStopButton.Enabled = true;
                vsTwoStartOrStopButton.Enabled = true;
                vsThreeStartOrStopButton.Enabled = true;

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
                        vsOneStartOrStopButton.BackColor = Color.Yellow;
                        vsOneStartOrStopButton.ForeColor = Color.Black;
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
                        vsTwoStartOrStopButton.BackColor = Color.Yellow;
                        vsTwoStartOrStopButton.ForeColor = Color.Black;
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
                        vsThreeStartOrStopButton.BackColor = Color.Yellow;
                        vsThreeStartOrStopButton.ForeColor = Color.Black;
                        vsThreeStartOrStopButton.Text = "CONNECTING";
                        break;
                }
            }
            else
            {
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

        private void vsOneTimer_Tick(object sender, EventArgs e)
        {
            switch (vsOneState)
            {
                case VsStatus.Connecting:
                    if (!vsOneTimerState)
                    {
                        vsOneConnStateLabel.ForeColor = Color.Transparent;
                        vsOneConnStateLabel.BackColor = _blue;
                        this.Invoke((MethodInvoker)delegate // ## PUT ABOUT CHANGE UI ELEMENTS FROM A THREAD ON DOC
                        {
                            this.Update();
                        });
                        vsOneTimerState = true;
                    }
                    else
                    {
                        vsOneConnStateLabel.ForeColor = _grey;
                        vsOneConnStateLabel.BackColor = Color.Transparent;
                        this.Invoke((MethodInvoker)delegate // ## PUT ABOUT CHANGE UI ELEMENTS FROM A THREAD ON DOC
                        {
                            this.Update();
                        });
                        vsOneTimerState = false;
                    }
                    break;
                case VsStatus.Reconnecting:
                    if (!vsOneTimerState)
                    {
                        vsOneConnStateLabel.ForeColor = Color.Transparent;
                        vsOneConnStateLabel.BackColor = _orange;
                        this.Invoke((MethodInvoker)delegate // ## PUT ABOUT CHANGE UI ELEMENTS FROM A THREAD ON DOC
                        {
                            this.Update();
                        });
                        vsOneTimerState = true;
                    }
                    else
                    {
                        vsOneConnStateLabel.ForeColor = _grey;
                        vsOneConnStateLabel.BackColor = Color.Transparent;
                        this.Invoke((MethodInvoker)delegate // ## PUT ABOUT CHANGE UI ELEMENTS FROM A THREAD ON DOC
                        {
                            this.Update();
                        });
                        vsOneTimerState = false;
                    }
                    break;
                case VsStatus.Warning:
                    if (!vsOneTimerState)
                    {
                        vsOneConnStateLabel.ForeColor = Color.Transparent;
                        vsOneConnStateLabel.BackColor = Color.Yellow;
                        this.Invoke((MethodInvoker)delegate // ## PUT ABOUT CHANGE UI ELEMENTS FROM A THREAD ON DOC
                        {
                            this.Update();
                        }); ;
                        vsOneTimerState = true;
                    }
                    else
                    {
                        vsOneConnStateLabel.ForeColor = _grey;
                        vsOneConnStateLabel.BackColor = Color.Transparent;
                        this.Invoke((MethodInvoker)delegate // ## PUT ABOUT CHANGE UI ELEMENTS FROM A THREAD ON DOC
                        {
                            this.Update();
                        });
                        vsOneTimerState = false;
                    }
                    break;
                case VsStatus.ConnDropped:
                    if (!vsOneTimerState)
                    {
                        vsOneConnStateLabel.ForeColor = Color.Transparent;
                        vsOneConnStateLabel.BackColor = _orange;
                        this.Invoke((MethodInvoker)delegate // ## PUT ABOUT CHANGE UI ELEMENTS FROM A THREAD ON DOC
                        {
                            this.Update();
                        });
                        vsOneTimerState = true;
                    }
                    else
                    {
                        vsOneConnStateLabel.ForeColor = _grey;
                        vsOneConnStateLabel.BackColor = Color.Transparent;
                        this.Invoke((MethodInvoker)delegate // ## PUT ABOUT CHANGE UI ELEMENTS FROM A THREAD ON DOC
                        {
                            this.Update();
                        });
                        vsOneTimerState = false;
                    }
                    break;
            }
        }

        private void vsTwoTimer_Tick(object sender, EventArgs e)
        {
            switch (vsTwoState)
            {
                case VsStatus.Connecting:
                    if (!vsTwoTimerState)
                    {
                        vsTwoConnStateLabel.ForeColor = Color.Transparent;
                        vsTwoConnStateLabel.BackColor = _blue;
                        this.Invoke((MethodInvoker)delegate // ## PUT ABOUT CHANGE UI ELEMENTS FROM A THREAD ON DOC
                        {
                            this.Update();
                        });
                        vsTwoTimerState = true;
                    }
                    else
                    {
                        vsTwoConnStateLabel.ForeColor = _grey;
                        vsTwoConnStateLabel.BackColor = Color.Transparent;
                        this.Invoke((MethodInvoker)delegate // ## PUT ABOUT CHANGE UI ELEMENTS FROM A THREAD ON DOC
                        {
                            this.Update();
                        });
                        vsTwoTimerState = false;
                    }
                    break;
                case VsStatus.Reconnecting:
                    if (!vsTwoTimerState)
                    {
                        vsTwoConnStateLabel.ForeColor = Color.Transparent;
                        vsTwoConnStateLabel.BackColor = _orange;
                        this.Invoke((MethodInvoker)delegate // ## PUT ABOUT CHANGE UI ELEMENTS FROM A THREAD ON DOC
                        {
                            this.Update();
                        });
                        vsTwoTimerState = true;
                    }
                    else
                    {
                        vsTwoConnStateLabel.ForeColor = _grey;
                        vsTwoConnStateLabel.BackColor = Color.Transparent;
                        this.Invoke((MethodInvoker)delegate // ## PUT ABOUT CHANGE UI ELEMENTS FROM A THREAD ON DOC
                        {
                            this.Update();
                        });
                        vsTwoTimerState = false;
                    }
                    break;
                case VsStatus.Warning:
                    if (!vsTwoTimerState)
                    {
                        vsTwoConnStateLabel.ForeColor = Color.Transparent;
                        vsTwoConnStateLabel.BackColor = Color.Yellow;
                        this.Invoke((MethodInvoker)delegate // ## PUT ABOUT CHANGE UI ELEMENTS FROM A THREAD ON DOC
                        {
                            this.Update();
                        }); ;
                        vsTwoTimerState = true;
                    }
                    else
                    {
                        vsTwoConnStateLabel.ForeColor = _grey;
                        vsTwoConnStateLabel.BackColor = Color.Transparent;
                        this.Invoke((MethodInvoker)delegate // ## PUT ABOUT CHANGE UI ELEMENTS FROM A THREAD ON DOC
                        {
                            this.Update();
                        });
                        vsTwoTimerState = false;
                    }
                    break;
                case VsStatus.ConnDropped:
                    if (!vsTwoTimerState)
                    {
                        vsTwoConnStateLabel.ForeColor = Color.Transparent;
                        vsTwoConnStateLabel.BackColor = _orange;
                        this.Invoke((MethodInvoker)delegate // ## PUT ABOUT CHANGE UI ELEMENTS FROM A THREAD ON DOC
                        {
                            this.Update();
                        });
                        vsTwoTimerState = true;
                    }
                    else
                    {
                        vsTwoConnStateLabel.ForeColor = _grey;
                        vsTwoConnStateLabel.BackColor = Color.Transparent;
                        this.Invoke((MethodInvoker)delegate // ## PUT ABOUT CHANGE UI ELEMENTS FROM A THREAD ON DOC
                        {
                            this.Update();
                        });
                        vsTwoTimerState = false;
                    }
                    break;
            }
        }

        private void vsThreeTimer_Tick(object sender, EventArgs e)
        {
            switch (vsThreeState)
            {
                case VsStatus.Connecting:
                    if (!vsThreeTimerState)
                    {
                        vsThreeConnStateLabel.ForeColor = Color.Transparent;
                        vsThreeConnStateLabel.BackColor = _blue;
                        this.Invoke((MethodInvoker)delegate // ## PUT ABOUT CHANGE UI ELEMENTS FROM A THREAD ON DOC
                        {
                            this.Update();
                        });
                        vsThreeTimerState = true;
                    }
                    else
                    {
                        vsThreeConnStateLabel.ForeColor = _grey;
                        vsThreeConnStateLabel.BackColor = Color.Transparent;
                        this.Invoke((MethodInvoker)delegate // ## PUT ABOUT CHANGE UI ELEMENTS FROM A THREAD ON DOC
                        {
                            this.Update();
                        });
                        vsThreeTimerState = false;
                    }
                    break;
                case VsStatus.Reconnecting:
                    if (!vsThreeTimerState)
                    {
                        vsThreeConnStateLabel.ForeColor = Color.Transparent;
                        vsThreeConnStateLabel.BackColor = _orange;
                        this.Invoke((MethodInvoker)delegate // ## PUT ABOUT CHANGE UI ELEMENTS FROM A THREAD ON DOC
                        {
                            this.Update();
                        });
                        vsThreeTimerState = true;
                    }
                    else
                    {
                        vsThreeConnStateLabel.ForeColor = _grey;
                        vsThreeConnStateLabel.BackColor = Color.Transparent;
                        this.Invoke((MethodInvoker)delegate // ## PUT ABOUT CHANGE UI ELEMENTS FROM A THREAD ON DOC
                        {
                            this.Update();
                        });
                        vsThreeTimerState = false;
                    }
                    break;
                case VsStatus.Warning:
                    if (!vsThreeTimerState)
                    {
                        vsThreeConnStateLabel.ForeColor = Color.Transparent;
                        vsThreeConnStateLabel.BackColor = Color.Yellow;
                        this.Invoke((MethodInvoker)delegate // ## PUT ABOUT CHANGE UI ELEMENTS FROM A THREAD ON DOC
                        {
                            this.Update();
                        }); ;
                        vsThreeTimerState = true;
                    }
                    else
                    {
                        vsThreeConnStateLabel.ForeColor = _grey;
                        vsThreeConnStateLabel.BackColor = Color.Transparent;
                        this.Invoke((MethodInvoker)delegate // ## PUT ABOUT CHANGE UI ELEMENTS FROM A THREAD ON DOC
                        {
                            this.Update();
                        });
                        vsThreeTimerState = false;
                    }
                    break;
                case VsStatus.ConnDropped:
                    if (!vsThreeTimerState)
                    {
                        vsThreeConnStateLabel.ForeColor = Color.Transparent;
                        vsThreeConnStateLabel.BackColor = _orange;
                        this.Invoke((MethodInvoker)delegate // ## PUT ABOUT CHANGE UI ELEMENTS FROM A THREAD ON DOC
                        {
                            this.Update();
                        });
                        vsThreeTimerState = true;
                    }
                    else
                    {
                        vsThreeConnStateLabel.ForeColor = _grey;
                        vsThreeConnStateLabel.BackColor = Color.Transparent;
                        this.Invoke((MethodInvoker)delegate // ## PUT ABOUT CHANGE UI ELEMENTS FROM A THREAD ON DOC
                        {
                            this.Update();
                        });
                        vsThreeTimerState = false;
                    }
                    break;
            }
        }

        private void vsOneStartOrStopButton_Click(object sender, EventArgs e)
        {
            if (vsOneStartOrStopButton.Text == "START")
            {
                updateVsConnStatus(VirtualStations.One, VsStatus.Connecting);
                driverForm.connectToController(VirtualStations.One);
            }
            else if (vsOneStartOrStopButton.Text == "STOP")
            {
                driverForm.SendCommand(VirtualStations.One, false);
                updateVsConnStatus(VirtualStations.One, VsStatus.None);
                driverForm.StopInterface(VirtualStations.One);
            }
            else if (vsOneStartOrStopButton.Text == "CONNECTING")
            {
                DialogResult result = MessageBox.Show("Do you want to cancel the connection attempt at VS 1?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    driverForm.SendCommandAllStations(false);
                    driverForm.StopConnAttempt(VirtualStations.One);
                    updateVsConnStatus(VirtualStations.One, VsStatus.None);
                }
            }
        }

        private void vsTwoStartOrStopButton_Click(object sender, EventArgs e)
        {
            if (vsTwoStartOrStopButton.Text == "START")
            {
                updateVsConnStatus(VirtualStations.Two, VsStatus.Connecting);
                driverForm.connectToController(VirtualStations.Two);
            }
            else if (vsTwoStartOrStopButton.Text == "STOP")
            {
                driverForm.SendCommand(VirtualStations.Two, false);
                updateVsConnStatus(VirtualStations.Two, VsStatus.None);
                driverForm.StopInterface(VirtualStations.Two);
            }
            else if (vsTwoStartOrStopButton.Text == "CONNECTING")
            {
                DialogResult result = MessageBox.Show("Do you want to cancel the connection attemptat VS 2?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    driverForm.SendCommandAllStations(false);
                    driverForm.StopConnAttempt(VirtualStations.Two);
                    updateVsConnStatus(VirtualStations.Two, VsStatus.None);
                }
            }
        }

        private void vsThreeStartOrStopButton_Click(object sender, EventArgs e)
        {
            if (vsThreeStartOrStopButton.Text == "START")
            {
                updateVsConnStatus(VirtualStations.Three, VsStatus.Connecting);
                driverForm.connectToController(VirtualStations.Three);
            }
            else if (vsThreeStartOrStopButton.Text == "STOP")
            {
                driverForm.SendCommand(VirtualStations.Three, false);
                updateVsConnStatus(VirtualStations.Three, VsStatus.None);
                driverForm.StopInterface(VirtualStations.Three);
            }
            else if (vsThreeStartOrStopButton.Text == "CONNECTING")
            {
                DialogResult result = MessageBox.Show("Do you want to cancel the connection attempt at VS 3?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    driverForm.SendCommandAllStations(false);
                    driverForm.StopConnAttempt(VirtualStations.Three);
                    updateVsConnStatus(VirtualStations.Three, VsStatus.None);
                }
            }
        }
    }
}

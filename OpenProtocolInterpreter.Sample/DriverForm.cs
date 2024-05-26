using OpenProtocolInterpreter.Communication;
using OpenProtocolInterpreter.IOInterface;
using OpenProtocolInterpreter.Job;
using OpenProtocolInterpreter.KeepAlive;
using OpenProtocolInterpreter.Sample.Driver;
using OpenProtocolInterpreter.Sample.Driver.Commands;
using OpenProtocolInterpreter.Sample.Driver.Events;
using OpenProtocolInterpreter.Sample.Driver.Helpers;
using OpenProtocolInterpreter.Sample.Ethernet;
using OpenProtocolInterpreter.Tightening;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using static OpenProtocolInterpreter.Sample.HomeForm;

namespace OpenProtocolInterpreter.Sample
{
    public partial class DriverForm : Form
    {
        private OpenProtocolDriver vsOneDriver;
        private OpenProtocolDriver vsTwoDriver;
        private OpenProtocolDriver vsThreeDriver;

        Logger logger = new Logger();

        string idLogsPath = "C:\\ProgramData\\Atlas Copco\\SQS\\LBMS\\log\\WorkerIdent_1";

        private bool mouseDown;
        private Point lastLocation;

        bool CheckSQSBadgeRunning = false;
        bool bypassAllowed = false;
        public bool idLogsPathOK;

        bool vsOneCancelReconn = false;

        public bool isSQSLogged = false;
        public string currentOperatorId = string.Empty;
        public string currentOperatorName = string.Empty;
        public string currentOperatorGroup = string.Empty;

        DateTime vsOneConnLostTimeStamp;

        HomeForm homeForm;
        SettingsForm settingsForm;
        AnalysisForm analysisForm;
        AboutForm aboutForm;
        CallBypassForm callBypassForm;
        BadgeCheckingForm checkingForm;

        SimpleTcpClient vsOneClient;

        Thread _vsOneThread;
        Thread _vsTwoThread;
        Thread _vsThreeThread;

        uint vsOneThreadQueue = 0;


        public DriverForm()
        {
            InitializeComponent();
            DriverFormInit();

            vsOneDriver = new OpenProtocolDriver();
            vsTwoDriver = new OpenProtocolDriver();
            vsThreeDriver = new OpenProtocolDriver();

            callBypassForm.Show();
        }

        private void DriverFormInit()
        {
            checkingForm = new BadgeCheckingForm(this);
            homeForm = new HomeForm(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            settingsForm = new SettingsForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            analysisForm = new AnalysisForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            aboutForm = new AboutForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            callBypassForm = new CallBypassForm(checkingForm, this);

            this.topPanel.MouseDown += new MouseEventHandler(topPanel_MouseDown); this.appNameLabel.MouseDown += new MouseEventHandler(topPanel_MouseDown);
            this.topPanel.MouseMove += new MouseEventHandler(topPanel_MouseMove); this.appNameLabel.MouseMove += new MouseEventHandler(topPanel_MouseMove);
            this.topPanel.MouseUp += new MouseEventHandler(topPanel_MouseUp); this.appNameLabel.MouseUp += new MouseEventHandler(topPanel_MouseUp);

            // MAKE THE GETTERS AND SETTERS TO CHANGE THIS ELEMENTS IN A FUNCTION, THE ELEMENTS MUST BE PRIVATE AND THE FUNCTION PUBLIC
            homeForm.vsOneConnStateLabel.ForeColor = Color.FromArgb(51, 61, 70);
            homeForm.vsOneConnStateLabel.BackColor = Color.Transparent;
            homeForm.vsTwoConnStateLabel.ForeColor = Color.FromArgb(51, 61, 70);
            homeForm.vsTwoConnStateLabel.BackColor = Color.Transparent;
            homeForm.vsThreeConnStateLabel.ForeColor = Color.FromArgb(51, 61, 70);
            homeForm.vsThreeConnStateLabel.BackColor = Color.Transparent;

            homeButton_Click(this, EventArgs.Empty);
        }

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void topPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void connectToController(VirtualStations vs)//PUT THIS ON DOCUMENTATION
        {
            switch (vs)
            {
                case VirtualStations.One:
                    vsOneThreadQueue++;
                    _vsOneThread = new Thread(() => WorkingThreadHandleTcpConnection(vs));//PUT THIS ON DOCUMENTATION
                    _vsOneThread.IsBackground = true;
                    homeForm.vsOneThreadRunning = true;
                    _vsOneThread.Start();
                    break;
                case VirtualStations.Two:
                    break;
                case VirtualStations.Three:
                    break;
            }
        }

        private void WorkingThreadHandleTcpConnection(VirtualStations vs)//PUT THIS ON DOCUMENTATION
        {
            Console.WriteLine("New WorkingThread started for vs: " + vs.ToString());

            switch (vs)
            {
                case VirtualStations.One: //PUT THIS ON DOCUMENTATION
                    
                    uint localThreadQueue = vsOneThreadQueue;
                    SimpleTcpClient localClient = null;

                    if (homeForm.vsOneState != VsStatus.Connected)
                    {
                        if (homeForm.vsOneState == VsStatus.ConnDropped || homeForm.vsOneState == VsStatus.Reconnecting)
                        {
                            this.Invoke((MethodInvoker)delegate // ## PUT ABOUT CHANGE UI ELEMENTS FROM A THREAD ON DOC
                            {
                                homeForm.updateVsConnStatus(vs, VsStatus.Reconnecting); // this call must happen to auto reconnection work
                            });
                        }

                        try
                        {
                            Console.WriteLine("trying to conn localClient for vsOne inside of WorkingThread function");
                            localClient = new Ethernet.SimpleTcpClient().Connect(homeForm.vsOneIpTextBox.Text, int.Parse(homeForm.vsOnePortTextBox.Text));
                            Console.WriteLine("vsOne Connected");

                            if (vsOneCancelReconn)
                            {
                                Console.WriteLine("vsOneCancelReconn was TRUE on TRY block inside of WorkingThreadHandleTcpConnection, exiting from thread");
                                break;
                            }

                            if (localThreadQueue != vsOneThreadQueue)
                            {
                                Console.WriteLine($"localThreadQueue is different from vsOneThreadQueue, this thread is not the latest, exiting from thread. localThreadQueue: {localThreadQueue}, vsOneThreadQueue: {vsOneThreadQueue}");
                                break;
                            }

                        }
                        catch (Exception ex)
                        {
                            if (vsOneCancelReconn)
                            {
                                Console.WriteLine("vsOneCancelReconn was TRUE on CATCH block inside of WorkingThreadHandleTcpConnection, exiting from thread");
                                break;
                            }

                            if (localThreadQueue != vsOneThreadQueue)
                            {
                                Console.WriteLine($"localThreadQueue is different from vsOneThreadQueue, this thread is not the latest, exiting from thread. localThreadQueue: {localThreadQueue}, vsOneThreadQueue: {vsOneThreadQueue}");
                                break;
                            }

                            Console.WriteLine("vsOne not connected");

                            if (homeForm.vsOneState == VsStatus.Reconnecting)
                            {
                                Console.WriteLine("The system is on RECONNECTING MODE for vsOne. The conn has been dropped at " + vsOneConnLostTimeStamp.ToString("HH:mm:ss") + " - The system is trying to reconnect...");
                                if (!vsOneCancelReconn)
                                {
                                    WorkingThreadHandleTcpConnection(vs);
                                }
                                else
                                {
                                    Console.WriteLine("vsOneCancelReconn was TRUE at WorkingThreadHandleTcpConnection reconn attempt, stopping the reconnection attempt");
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("THE EXCEPTION: " + ex.ToString());
                                this.Invoke((MethodInvoker)delegate // ## PUT ABOUT CHANGE UI ELEMENTS FROM A THREAD ON DOC
                                {
                                    if (ex.Message.Contains("refused"))
                                    {
                                        analysisForm.errorsTextBox.Text += DateTime.Now.ToString("HH:mm:ss") + " TCP conn failed at VS1 \r\n";
                                        MessageBox.Show("The connection has been refused at Virtual Station One\r\nCheck the Open Protocol settings on controller", "CONNECTION REFUSED", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                    homeForm.updateVsConnStatus(vs, VsStatus.ConnFailed);
                                });
                            }
                            break;
                        }

                        //if (homeForm.vsOneStopRequest)
                        //{
                        //    homeForm.updateVsConnStatus(vs, VsStatus.None);
                        //}

                        if (vsOneDriver.BeginCommunication(localClient))
                        {
                            this.Invoke((MethodInvoker)delegate
                            {
                                vsOneKeepAliveTimer.Start();//Implement connection watchdog
                                homeForm.updateVsConnStatus(vs, VsStatus.Connected);
                            });
                        }
                        else
                        {
                            if (vsOneDriver.startCommErrorMessage.Contains("Client is already connected")) // Already handling this -> if (homeForm.vsOneState != VsStatus.Connected) 
                            {
                                this.Invoke((MethodInvoker)delegate
                                {
                                    analysisForm.errorsTextBox.Text += DateTime.Now.ToString("HH:mm:ss") + " Client is already connected\r\n";
                                });
                            }
                            else if (vsOneDriver.startCommErrorMessage.Contains("MidRevisionUnsupported"))
                            {
                                this.Invoke((MethodInvoker)delegate
                                {
                                    homeForm.updateVsConnStatus(vs, VsStatus.ConnDropped);
                                    analysisForm.errorsTextBox.Text += DateTime.Now.ToString("HH:mm:ss") + " MidRevisionUnsupported\r\n";

                                    vsOneDriver.StopCommunication();
                                    StartInterface();
                                    analysisForm.errorsTextBox.Text += DateTime.Now.ToString("HH:mm:ss") + " Reply from controller was MidRevisionUnsupported, restarting connection attempt\r\n";
                                });
                            }
                            else if (vsOneDriver.startCommErrorMessage.Contains("Reply from controller was NULL, probably by TIMEOUT"))
                            {
                                this.Invoke((MethodInvoker)delegate
                                {
                                    homeForm.updateVsConnStatus(vs, VsStatus.ConnDropped);
                                    analysisForm.errorsTextBox.Text += DateTime.Now.ToString("HH:mm:ss") + " Reply from controller was NULL, probably by TIMEOUT on MID 0002 answer waiting, restarting connection attempt\r\n";
                                });
                                vsOneDriver.StopCommunication();
                                StartInterface();
                            }
                            else
                            {
                                this.Invoke((MethodInvoker)delegate
                                {
                                    homeForm.updateVsConnStatus(vs, VsStatus.ConnDropped);
                                    analysisForm.errorsTextBox.Text += DateTime.Now.ToString("HH:mm:ss") + "TCP OK, but Open Protocol comm not started by unknow reason, restarting connection attempt\r\n";
                                });
                                vsOneDriver.StopCommunication();
                                StartInterface();
                            }
                        }

                    }
                    break;

                case VirtualStations.Two:
                    break;

                case VirtualStations.Three:
                    break;
            }
        }

        public void StopConnAttempt(VirtualStations vs)
        {
            switch (vs)
            {
                case VirtualStations.One:
                    _vsOneThread = null;
                    vsOneCancelReconn = true;
                    break;
            }
        }


        public void StartInterface()
        {// Make the handle to start manual or automatic mode @@@
            connectToController(VirtualStations.One);
            //connectToController(VirtualStations.Two);
            //connectToController(VirtualStations.Three);

            vsOneCancelReconn = false;
        }

        public void StopAllInterfaces()
        {
            vsOneDriver.StopCommunication();
            vsOneKeepAliveTimer.Stop();

            if (homeForm.vsOneState == VsStatus.Reconnecting || homeForm.vsOneState == VsStatus.ConnDropped)
            {
                vsOneCancelReconn = true; 
            }
        }

        public void StopInterface(OpenProtocolDriver driver)
        {
            driver.StopCommunication();
        }

        private void vsOneKeepAliveTimer_Tick(object sender, EventArgs e)
        {
            if (vsOneDriver.KeepAlive.ElapsedMilliseconds > 5000) //10 sec
            {
                Console.WriteLine($"Sending Keep Alive...");
                var pack = vsOneDriver.SendAndWaitForResponse(new Mid9999().Pack(), TimeSpan.FromSeconds(5));

                if (pack != null && pack.Header.Mid == Mid9999.MID)
                {
                    Console.WriteLine($"Keep Alive Received");
                }
                else
                {
                    Console.WriteLine($"Keep Alive Not Received, connection lost. Stopping keepAliveTimer and trying to connect again by StartInterface method");

                    if (pack.Header != null)
                        Console.WriteLine($"Pack: {pack.Header.ToString()}");

                    StopAllInterfaces();
                    homeForm.updateVsConnStatus(VirtualStations.One, VsStatus.ConnDropped);

                    vsOneConnLostTimeStamp = DateTime.Now;

                    vsOneKeepAliveTimer.Stop();
                    StartInterface();
                }

            }
        }

        /// <summary>
        /// Tightening subscribe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void startInterfaceButton_Click(object sender, EventArgs e)
        {
            var pack = vsOneDriver.SendAndWaitForResponse(new Mid0210().Pack(), TimeSpan.FromSeconds(5));


            if (pack != null)
            {
                if (pack.Header.Mid == Mid0004.MID)
                {
                    var mid04 = pack as Mid0004;

                    string str = $@"Error while subscribing (MID 0004):
                                       Error Code: <{mid04.ErrorCode}>
                                       Failed MID: <{mid04.FailedMid}>";

                    logger.Log(str);
                    MessageBox.Show(str);
                }
                else
                {
                    logger.Log("MID 0210 accepted");

                    //register command
                    vsOneDriver.AddUpdateOnReceivedCommand(typeof(Mid0211), OnTighteningReceived);
                }

            }


        }

        public void BtnSendJob_Click(object sender, EventArgs e)
        {
            new SendJobCommand(vsOneDriver).Execute(true);
        }

        public void SendJobCommandFunction(bool setReset)
        {
            new SendJobCommand(vsOneDriver).Execute(setReset);
        }

        /// <summary>
        /// Async method from controller, MID 0061 (Last Tightening)
        /// Basically, on every tightening this method will be called!
        /// </summary>
        /// <param name="e"></param>
        private void OnTighteningReceived(MIDIncome e)
        {
            logger.Log("MID211 received");

            vsOneDriver.SendMessage(e.Mid.BuildAckPackage());

            var externallyMonitoredRelayStatus = e.Mid as Mid0211;



            //consoleTextBox.Text = ("EXTERNAL_MONITORED_1: \r\n" + externallyMonitoredRelayStatus.StatusDigInOne.ToString());


            if (externallyMonitoredRelayStatus.StatusDigInOne)
            {
                logger.Log("DigInOne = HIGH");



                CheckSQSBadge();

                this.Invoke((MethodInvoker)delegate
                {
                    checkingForm.Show();
                    checkBadgeTimer.Start();
                });

            }
            else if (externallyMonitoredRelayStatus.StatusDigInOne == false)
            {
                logger.Log("DigInOne is FALSE, checkingForm is being hidden and checkBadgeTimer is being stopped");

                if (checkingForm.Visible)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        checkingForm.Hide();
                    });
                }

                this.Invoke((MethodInvoker)delegate
                {
                    checkBadgeTimer.Stop();
                });


            }
        }

        public void CheckSQSBadge()
        {
            logger.Log("CheckSQSBadge func called");

            CheckSQSBadgeRunning = true;

            string targetKeyOut = "[WorkerIdent.1.1] SendKeyOut - Command [OperatorCode] Destination [Ident.1] Value [] - Worker";

            string targetKeyIn = "[WorkerIdent.1.1] SetOperatorGrid - [FisPdaStatus.1][Device1] [True]";


            if (idLogsPath != null)
            {
                idLogsPathOK = true;
                isSQSLogged = true;
                logger.Log("isSQSLogged = TRUE");

                string[] files = Directory.GetFiles(idLogsPath);
                var latestFile = files.OrderByDescending(file => new FileInfo(file).LastWriteTime).FirstOrDefault();

                List<string> lines = new List<string>();
                using (var reader = new StreamReader(latestFile))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }
                }

                lines.Reverse();

                string keyOutOccurrence = lines.FirstOrDefault(line => line.Contains(targetKeyOut));
                var keyOutBaseIndex = lines.IndexOf(keyOutOccurrence);

                string keyInOccurrence = lines.FirstOrDefault(line => line.Contains(targetKeyIn));
                var keyInBaseIndex = lines.IndexOf(keyInOccurrence);

                if (keyOutBaseIndex > keyInBaseIndex)
                {
                    string rawOperatorKeyAndKeyGroup = lines.ElementAt(keyInBaseIndex + 1);
                    string rawOperatorName = lines.ElementAt(keyInBaseIndex + 8);

                    int operatorIdOffset = 46 + rawOperatorKeyAndKeyGroup.IndexOf("Mem=0:");
                    int operatorGroupOffset = 10 + rawOperatorKeyAndKeyGroup.IndexOf("keygroup");
                    int operatorNameOffset = 7 + rawOperatorName.IndexOf("Value");

                    currentOperatorId = rawOperatorKeyAndKeyGroup.Substring(operatorIdOffset, (rawOperatorKeyAndKeyGroup.IndexOf("keygroup") - (operatorIdOffset + 2)));
                    currentOperatorGroup = rawOperatorKeyAndKeyGroup.Substring(operatorGroupOffset, (rawOperatorKeyAndKeyGroup.LastIndexOf("]") - operatorGroupOffset));
                    currentOperatorName = rawOperatorName.Substring(operatorNameOffset, (rawOperatorName.LastIndexOf("]") - operatorNameOffset));

                    if (currentOperatorGroup == "Master_Admin" && !bypassAllowed)
                    {
                        // new SendJobCommand(vsOneDriver).Execute(true);
                        bypassAllowed = true;
                        checkingForm.shadeEffectTimer.Start();
                    }
                    else if (currentOperatorGroup == "Operator" && bypassAllowed)
                    {
                        // new SendJobCommand(vsOneDriver).Execute(false);
                        bypassAllowed = false;
                    }

                    //MessageBox.Show("keyInBaseIndex: " + keyInBaseIndex);
                    //MessageBox.Show("currentOperatorId: " + currentOperatorId);
                    //MessageBox.Show("currentOperatorId: " + currentOperatorGroup);
                    //MessageBox.Show("currentOperatorName: " + currentOperatorName);
                }
                else
                {
                    if (bypassAllowed)
                    {
                        new SendJobCommand(vsOneDriver).Execute(false);
                        bypassAllowed = false;
                    }
                    logger.Log("isSQSLogged = FALSE");
                    isSQSLogged = false;
                    //MessageBox.Show("KeyOut first than KeyIn! \r\nKeyOut: " + keyOutBaseIndex + "\r\nKeyIn: " + keyInBaseIndex);
                }
            }
            else
            {
                checkBadgeTimer.Stop();
                idLogsPathOK = false;
                MessageBox.Show("idLogsPath is NULL");
                logger.Log("idLogsPath is null");
                return;
            }

            this.Invoke((MethodInvoker)delegate
            {
                checkingForm.UpdateSQSStatus();
            });

            CheckSQSBadgeRunning = false;
        }

        public string ChooseFolder()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                return folderBrowserDialog.SelectedPath;
            }
            else
            {
                return null;
            }
        }

        private void checkBadgeTimer_Tick(object sender, EventArgs e)
        {
            logger.Log("checkBadgeTimer_Tick hitted");
            if (!CheckSQSBadgeRunning)
            {
                logger.Log("CheckSQSBadgeRunning is false, calling CheckSQSBadge()");

                CheckSQSBadge();

                this.Invoke((MethodInvoker)delegate
                {
                    checkingForm.TopMost = true;
                });
            }
            logger.Log("CheckSQSBadgeRunning is true, skipping CheckSQSBadge()");
        }

        private void hideCheckingFormTime_Tick(object sender, EventArgs e)
        {
            hideCheckingFormTimer.Stop();

        }

        private void closeMainFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeMainForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ClearHighlightedButtons()
        {
            homeButton.BackgroundImage = Properties.Resources.Home_icon_svg___Copy___Copy;
            settingsButton.BackgroundImage = Properties.Resources.settings___small1;
            analysisButton.BackgroundImage = Properties.Resources.back_and_fourth;
            aboutButton.BackgroundImage = Properties.Resources.about_small;
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            ClearHighlightedButtons();

            this.formLoaderPanel.Controls.Clear();

            this.formLoaderPanel.Controls.Add(homeForm);
            homeForm.Show();

            homeButton.BackgroundImage = Properties.Resources.Home_icon_Highlighted;
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            ClearHighlightedButtons();

            this.formLoaderPanel.Controls.Clear();

            this.formLoaderPanel.Controls.Add(settingsForm);
            settingsForm.Show();

            settingsButton.BackgroundImage = Properties.Resources.settings___small11;
        }

        private void AnalysisButton_Click(object sender, EventArgs e)
        {
            ClearHighlightedButtons();

            this.formLoaderPanel.Controls.Clear();

            this.formLoaderPanel.Controls.Add(analysisForm);
            analysisForm.Show();

            analysisButton.BackgroundImage = Properties.Resources.back_and_fourth_Highlighted;
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            ClearHighlightedButtons();

            this.formLoaderPanel.Controls.Clear();

            this.formLoaderPanel.Controls.Add(aboutForm);
            aboutForm.Show();

            aboutButton.BackgroundImage = Properties.Resources.about_small_highlighted;
        }

        private void appNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void vsTwoKeepAliveTimer_Tick(object sender, EventArgs e)
        {
            if (vsTwoDriver.KeepAlive.ElapsedMilliseconds > 10000) //10 sec
            {
                Console.WriteLine($"Sending Keep Alive...");
                var pack = vsTwoDriver.SendAndWaitForResponse(new Mid9999().Pack(), TimeSpan.FromSeconds(10));
                if (pack != null && pack.Header.Mid == Mid9999.MID)
                {
                    Console.WriteLine($"Keep Alive Received");
                }
                else
                    Console.WriteLine($"Keep Alive Not Received");
            }
        }

        private void vsThreeKeepAliveTimer_Tick(object sender, EventArgs e)
        {
            if (vsThreeDriver.KeepAlive.ElapsedMilliseconds > 10000) //10 sec
            {
                Console.WriteLine($"Sending Keep Alive...");
                var pack = vsThreeDriver.SendAndWaitForResponse(new Mid9999().Pack(), TimeSpan.FromSeconds(10));
                if (pack != null && pack.Header.Mid == Mid9999.MID)
                {
                    Console.WriteLine($"Keep Alive Received");
                }
                else
                    Console.WriteLine($"Keep Alive Not Received");
            }
        }
    }
}
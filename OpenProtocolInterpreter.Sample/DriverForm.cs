using OpenProtocolInterpreter.Communication;
using OpenProtocolInterpreter.IOInterface;
using OpenProtocolInterpreter.Job;
using OpenProtocolInterpreter.KeepAlive;
using OpenProtocolInterpreter.Sample.Driver;
using OpenProtocolInterpreter.Sample.Driver.Commands;
using OpenProtocolInterpreter.Sample.Driver.Events;
using OpenProtocolInterpreter.Sample.Driver.Helpers;
using OpenProtocolInterpreter.Tightening;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace OpenProtocolInterpreter.Sample
{
    public partial class DriverForm : Form
    {
        private readonly Timer _keepAliveTimer;
        private OpenProtocolDriver driver;

        BadgeCheckingForm checkingForm;

        Logger logger = new Logger();

        string idLogsPath = "C:\\ProgramData\\Atlas Copco\\SQS\\LBMS\\log\\WorkerIdent_1";
        //string idLogsPath = "C:\\ProgramData\\Atlas Copco\\SQS\\LBMS\\log\\WorkerIdent_1";

        bool bypassAllowed = false;
        public bool idLogsPathOK;

        public bool isSQSLogged = false;
        public string currentOperatorId = string.Empty;
        public string currentOperatorName = string.Empty;
        public string currentOperatorGroup = string.Empty;

        public DriverForm()
        {
            InitializeComponent();
            _keepAliveTimer = new Timer();
            _keepAliveTimer.Tick += KeepAliveTimer_Tick;
            _keepAliveTimer.Interval = 1000;

            checkingForm = new BadgeCheckingForm(this);

            //checkingForm.Show();
        }

        private void BtnConnection_Click(object sender, EventArgs e)
        {
            //Added list of mids i want to use in my interpreter, every another will be desconsidered
            driver = new OpenProtocolDriver(new Type[]
            {

                typeof(Mid0211),
                typeof(Mid0002),
                typeof(Mid0005),
                typeof(Mid0004),
                typeof(Mid0003),

                typeof(ParameterSet.Mid0011),
                typeof(ParameterSet.Mid0013),

                typeof(Mid0035),
                typeof(Mid0031),

                typeof(Alarm.Mid0071),
                typeof(Alarm.Mid0074),
                typeof(Alarm.Mid0076),

                typeof(Vin.Mid0052),

                typeof(Mid0061),
                typeof(Mid0065),

                typeof(Time.Mid0081),

                typeof(Mid9999)
            }); ;

            var client = new Ethernet.SimpleTcpClient().Connect(textIp.Text, (int)numericPort.Value);
            if (driver.BeginCommunication(client))
            {
                _keepAliveTimer.Start();
                connectionStatus.Text = "Connected!";
                connectionStatus.BackColor = Color.Green;
            }
            else
            {
                driver = null;
                connectionStatus.Text = "Disconnected!";
                connectionStatus.BackColor = Color.Red;
            }
        }

        private void KeepAliveTimer_Tick(object sender, EventArgs e)
        {
            if (driver.KeepAlive.ElapsedMilliseconds > 10000) //10 sec
            {
                Console.WriteLine($"Sending Keep Alive...");
                var pack = driver.SendAndWaitForResponse(new Mid9999().Pack(), TimeSpan.FromSeconds(10));
                if (pack != null && pack.Header.Mid == Mid9999.MID)
                {
                    lastMessageArrived.Text = Mid9999.MID.ToString();
                    Console.WriteLine($"Keep Alive Received");
                }
                else
                    Console.WriteLine($"Keep Alive Not Received");
            }
        }

        /// <summary>
        /// Job info subscribe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnJobInfoSubscribe_Click(object sender, EventArgs e)
        {
            Console.WriteLine($"Sending Job Info Subscribe...");
            var pack = driver.SendAndWaitForResponse(new Mid0034().Pack(), TimeSpan.FromSeconds(10));

            if (pack != null)
            {
                if (pack.Header.Mid == Mid0004.MID)
                {
                    var mid04 = pack as Mid0004;
                    Console.WriteLine($@"Error while subscribing (MID 0004):
                                         Error Code: <{mid04.ErrorCode}>
                                         Failed MID: <{mid04.FailedMid}>");
                }
                else
                    Console.WriteLine($"Job Info Subscribe accepted!");
            }

            driver.AddUpdateOnReceivedCommand(typeof(Mid0035), OnJobInfoReceived);
        }

        /// <summary>
        /// Tightening subscribe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startInterfaceButton_Click(object sender, EventArgs e)
        {
            var pack = driver.SendAndWaitForResponse(new Mid0210().Pack(), TimeSpan.FromSeconds(5));


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
                    driver.AddUpdateOnReceivedCommand(typeof(Mid0211), OnTighteningReceived);
                }

            }


        }


        public void BtnSendJob_Click(object sender, EventArgs e)
        {
            new SendJobCommand(driver).Execute(true);
        }

        public void SendJobCommandFunction(bool setReset)
        {
            new SendJobCommand(driver).Execute(setReset);
        }

        /// <summary>
        /// Async method from controller, MID 0035 (Job Info)
        /// </summary>
        /// <param name="e"></param>
        private void OnJobInfoReceived(MIDIncome e)
        {
            driver.SendMessage(e.Mid.BuildAckPackage());

            var jobInfo = e.Mid as Mid0035;
            lastMessageArrived.Text = Mid0035.MID.ToString();
            Console.WriteLine($@"JOB INFO RECEIVED (MID 0035): 
                                 Job ID: <{jobInfo.JobId}>
                                 Job Status: <{(int)jobInfo.JobStatus}> ({jobInfo.JobStatus.ToString()})
                                 Job Batch Mode: <{(int)jobInfo.JobBatchMode}> ({jobInfo.JobBatchMode.ToString()})
                                 Job Batch Size: <{jobInfo.JobBatchSize}>
                                 Job Batch Counter: <{jobInfo.JobBatchCounter}>
                                 TimeStamp: <{jobInfo.TimeStamp.ToString("yyyy-MM-dd:HH:mm:ss")}>");
        }

        /// <summary>
        /// Async method from controller, MID 0061 (Last Tightening)
        /// Basically, on every tightening this method will be called!
        /// </summary>
        /// <param name="e"></param>
        private void OnTighteningReceived(MIDIncome e)
        {
            logger.Log("MID211 received");

            driver.SendMessage(e.Mid.BuildAckPackage());

            var externallyMonitoredRelayStatus = e.Mid as Mid0211;



            //consoleTextBox.Text = ("EXTERNAL_MONITORED_1: \r\n" + externallyMonitoredRelayStatus.StatusDigInOne.ToString());

            lastMessageArrived.Text = Mid0211.MID.ToString();

            if (externallyMonitoredRelayStatus.StatusDigInOne)
            {
                logger.Log("DigInOne = HIGH");



                CheckSQSBadge();

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

        private void CheckSQSBadge()
        {

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
                        new SendJobCommand(driver).Execute(true);
                        bypassAllowed = true;
                        hideCheckingFormTime.Start();
                    }
                    else if (currentOperatorGroup == "Operator" && bypassAllowed)
                    {
                        new SendJobCommand(driver).Execute(false);
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
                        new SendJobCommand(driver).Execute(false);
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
            CheckSQSBadge();

            this.Invoke((MethodInvoker)delegate
            {
                checkingForm.TopMost = true;
            });
            //checkingForm.Focus();

            logger.Log("timer hitted");
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void setToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SendJobCommand(driver).Execute(true);
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SendJobCommand(driver).Execute(false);
        }

        private void changeSQSDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            idLogsPath = ChooseFolder();
        }

        private void hideCheckingFormTime_Tick(object sender, EventArgs e)
        {
            hideCheckingFormTime.Stop();

        }
    }
}
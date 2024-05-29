using OpenProtocolInterpreter.Sample.Driver.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenProtocolInterpreter.Sample
{
    public partial class BadgeCheckingForm : Form
    {
        DriverForm DriverForm;

        Logger logger = new Logger();

        public int bypassScrennRetationTime = 600;
        private int _bypassScrennRetationTime;
        public bool retationAllowed = false;

        public BadgeCheckingForm(DriverForm driverForm)
        {
            _bypassScrennRetationTime = bypassScrennRetationTime;

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            DriverForm = driverForm;
            this.Paint += new PaintEventHandler(Form1_Paint);
        }

        private void SetRoundedRegion()
        {
            int radius = 18;  // Adjust the radius to your preference
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

        public void UpdateSQSStatus()
        {
            if (DriverForm.isSQSLogged)
            {
                operatorNameLabel.Text = DriverForm.currentOperatorName.Substring(0, 18) + ":" + DriverForm.currentOperatorId;
                operatorNameLabel.Location = new Point(133 - (DriverForm.currentOperatorId.Length * 13), 150);

                if (DriverForm.currentOperatorGroup.Contains("Master"))
                {
                    logger.Log("Operador autorizado");

                    this.BackColor = Color.FromArgb(0, 192, 0);
                    cancelBypassButton.BackColor = Color.FromArgb(158, 163, 168);

                    operatorStatusLabel.Location = new Point(111, 87);
                    operatorStatusLabel.Text = "OPERADOR AUTORIZADO";
                }
                else
                {
                    logger.Log("Operador não autorizado");

                    this.BackColor = Color.FromArgb(201, 44, 31);
                    cancelBypassButton.BackColor = Color.FromArgb(158, 163, 168);

                    operatorStatusLabel.Location = new Point(60, 87);
                    operatorStatusLabel.Text = "OPERADOR NÃO AUTORIZADO";
                }
            }
            else
            {
                this.BackColor = Color.FromArgb(158, 163, 168);
                cancelBypassButton.BackColor = Color.FromArgb(201, 44, 31);

                logger.Log("Sem cracha logado");

                operatorStatusLabel.Location = new Point(70, 87);
                operatorStatusLabel.Text = "LOGAR CRACHA OPERADOR";

                operatorNameLabel.Text = string.Empty;
            }
        }

        private void cancelBypassButton_Click(object sender, EventArgs e)
        {
            DriverForm.firstBadgeReadingAux = true;

            DriverForm.firstTickDone = false;
            retationAllowed = false;
            shadeEffectTimer.Start();
            DriverForm.checkBadgeTimer.Stop();

            DriverForm.SendCommandAllStations(false);

            DriverForm.callBypassForm.isBypassOn = false;
            DriverForm.callBypassForm.bypassRequestButton.Text = "BYPASS OFF";
            DriverForm.callBypassForm.bypassRequestButton.ForeColor = Color.Yellow;
        }

        private void shadeEffectTimer_Tick(object sender, EventArgs e)
        {
            if (_bypassScrennRetationTime != 0 && retationAllowed)
            {
                Thread.Sleep(bypassScrennRetationTime);
                _bypassScrennRetationTime = 0;
            }

            if (this.Opacity > 0.20)
                this.Opacity = this.Opacity - 0.10;
            else
            {
                shadeEffectTimer.Stop();
                this.Hide();
                this.Opacity = 1.00;
                _bypassScrennRetationTime = bypassScrennRetationTime;
            }
        }
    }
}

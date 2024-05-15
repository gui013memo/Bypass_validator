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
    public partial class BadgeCheckingForm : Form
    {
        bool setResetRelayOne = false;
        DriverForm DriverForm;

        Logger logger = new Logger();

        public BadgeCheckingForm(DriverForm driverForm)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            DriverForm = driverForm;
        }

        public void UpdateSQSStatus()
        {
            if (DriverForm.isSQSLogged)
            {
                if (DriverForm.currentOperatorGroup.Contains("Master"))
                {
                    logger.Log("Operador autorizado");

                    operatorStatusLabel.Text = "OPERADOR AUTORIZADO";
                    operatorStatusLabel.BackColor = Color.Lime;
                    operatorStatusLabel.ForeColor = Color.Black;

                    bypassRequestedLabel.ForeColor = Color.Green;

                    operatorNameLabel.Text = DriverForm.currentOperatorName;
                    OperatorIdLabel.Text = DriverForm.currentOperatorId;

                }
                else
                {
                    logger.Log("Operador não autorizado");

                    operatorStatusLabel.Text = "OPERADOR NÃO AUTORIZADO";
                    operatorStatusLabel.BackColor = Color.Red;
                    operatorStatusLabel.ForeColor = Color.White;

                    bypassRequestedLabel.ForeColor = Color.Red;

                    operatorNameLabel.Text = DriverForm.currentOperatorName;
                    OperatorIdLabel.Text = DriverForm.currentOperatorId;
                }
            }
            else
            {
                logger.Log("Sem crachá logado");

                operatorStatusLabel.Text = "LOGAR CRACHÁ OPERADOR";

                operatorStatusLabel.BackColor = Color.Yellow;
                operatorStatusLabel.ForeColor = Color.Black;

                bypassRequestedLabel.ForeColor = Color.Blue;

                operatorNameLabel.Text = string.Empty;
                OperatorIdLabel.Text = string.Empty;
            }
        }


    }
}

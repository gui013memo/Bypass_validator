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

        public HomeForm(DriverForm driverForm)
        {
            this.driverForm = driverForm;
            InitializeComponent();
        }

        private void startOrStopButton_Click(object sender, EventArgs e)
        {
            vsOneConnStateLabel.ForeColor = Color.FromArgb(82, 130, 184);
            vsOneConnStateLabel.BackColor = Color.White;

            vsTwoConnStateLabel.ForeColor = Color.FromArgb(82, 130, 184);
            vsTwoConnStateLabel.BackColor = Color.White;

            vsThreeConnStateLabel.ForeColor = Color.FromArgb(82, 130, 184);
            vsThreeConnStateLabel.BackColor = Color.White;

            this.Update();

            driverForm.StartInterface(this, EventArgs.Empty);
        }

        private void startModeButton_Click(object sender, EventArgs e)
        {
            driverForm.startInterfaceButton_Click(this, EventArgs.Empty);   
        }
    }
}

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
    public partial class AnalysisForm : Form
    {
        public AnalysisForm()
        {
            InitializeComponent();

            vsOneTrafficTextBox.Text = string.Empty;
            vsTwoTrafficTextBox.Text = string.Empty;
            vsThreeTrafficTextBox.Text = string.Empty;
            errorsTextBox.Text = string.Empty;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            label1.Focus();
        }
    }
}

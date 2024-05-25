namespace OpenProtocolInterpreter.Sample
{
    partial class AnalysisForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnalysisForm));
            this.vs1Label = new System.Windows.Forms.Label();
            this.nodeOneToolaLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.opHistoryVS1Label = new System.Windows.Forms.Label();
            this.vsOneTrafficTextBox = new System.Windows.Forms.TextBox();
            this.ipAndPortVS1Label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.errorsTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.vsTwoTrafficTextBox = new System.Windows.Forms.TextBox();
            this.vs2Label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.vsThreeTrafficTextBox = new System.Windows.Forms.TextBox();
            this.vs3Label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // vs1Label
            // 
            this.vs1Label.AutoSize = true;
            this.vs1Label.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vs1Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.vs1Label.Location = new System.Drawing.Point(0, 0);
            this.vs1Label.Name = "vs1Label";
            this.vs1Label.Size = new System.Drawing.Size(38, 21);
            this.vs1Label.TabIndex = 12;
            this.vs1Label.Text = "VS1";
            // 
            // nodeOneToolaLabel
            // 
            this.nodeOneToolaLabel.AutoSize = true;
            this.nodeOneToolaLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nodeOneToolaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.nodeOneToolaLabel.Location = new System.Drawing.Point(44, 6);
            this.nodeOneToolaLabel.Name = "nodeOneToolaLabel";
            this.nodeOneToolaLabel.Size = new System.Drawing.Size(117, 21);
            this.nodeOneToolaLabel.TabIndex = 11;
            this.nodeOneToolaLabel.Text = "ETD STR (Left)";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.opHistoryVS1Label);
            this.panel1.Controls.Add(this.vsOneTrafficTextBox);
            this.panel1.Controls.Add(this.vs1Label);
            this.panel1.Controls.Add(this.nodeOneToolaLabel);
            this.panel1.Controls.Add(this.ipAndPortVS1Label);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.panel1.Location = new System.Drawing.Point(10, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 163);
            this.panel1.TabIndex = 20;
            // 
            // opHistoryVS1Label
            // 
            this.opHistoryVS1Label.AutoSize = true;
            this.opHistoryVS1Label.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opHistoryVS1Label.Location = new System.Drawing.Point(59, 43);
            this.opHistoryVS1Label.Name = "opHistoryVS1Label";
            this.opHistoryVS1Label.Size = new System.Drawing.Size(79, 19);
            this.opHistoryVS1Label.TabIndex = 15;
            this.opHistoryVS1Label.Text = "OP History";
            this.opHistoryVS1Label.Click += new System.EventHandler(this.label3_Click);
            // 
            // vsOneTrafficTextBox
            // 
            this.vsOneTrafficTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsOneTrafficTextBox.Location = new System.Drawing.Point(4, 61);
            this.vsOneTrafficTextBox.Multiline = true;
            this.vsOneTrafficTextBox.Name = "vsOneTrafficTextBox";
            this.vsOneTrafficTextBox.ReadOnly = true;
            this.vsOneTrafficTextBox.Size = new System.Drawing.Size(202, 99);
            this.vsOneTrafficTextBox.TabIndex = 14;
            this.vsOneTrafficTextBox.Text = resources.GetString("vsOneTrafficTextBox.Text");
            this.vsOneTrafficTextBox.Enter += new System.EventHandler(this.textBox5_Enter);
            // 
            // ipAndPortVS1Label
            // 
            this.ipAndPortVS1Label.AutoSize = true;
            this.ipAndPortVS1Label.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipAndPortVS1Label.Location = new System.Drawing.Point(26, 25);
            this.ipAndPortVS1Label.Name = "ipAndPortVS1Label";
            this.ipAndPortVS1Label.Size = new System.Drawing.Size(148, 21);
            this.ipAndPortVS1Label.TabIndex = 3;
            this.ipAndPortVS1Label.Text = "172.16.110.21:4545";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.errorsTextBox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.panel2.Location = new System.Drawing.Point(225, 181);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(209, 163);
            this.panel2.TabIndex = 22;
            // 
            // errorsTextBox
            // 
            this.errorsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorsTextBox.Location = new System.Drawing.Point(4, 30);
            this.errorsTextBox.Multiline = true;
            this.errorsTextBox.Name = "errorsTextBox";
            this.errorsTextBox.ReadOnly = true;
            this.errorsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.errorsTextBox.Size = new System.Drawing.Size(202, 130);
            this.errorsTextBox.TabIndex = 16;
            this.errorsTextBox.Text = resources.GetString("errorsTextBox.Text");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.label6.Location = new System.Drawing.Point(26, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "Errors and warnings";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.vsTwoTrafficTextBox);
            this.panel3.Controls.Add(this.vs2Label);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label4);
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.panel3.Location = new System.Drawing.Point(225, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(209, 163);
            this.panel3.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "OP History";
            // 
            // vsTwoTrafficTextBox
            // 
            this.vsTwoTrafficTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsTwoTrafficTextBox.Location = new System.Drawing.Point(4, 61);
            this.vsTwoTrafficTextBox.Multiline = true;
            this.vsTwoTrafficTextBox.Name = "vsTwoTrafficTextBox";
            this.vsTwoTrafficTextBox.ReadOnly = true;
            this.vsTwoTrafficTextBox.Size = new System.Drawing.Size(202, 99);
            this.vsTwoTrafficTextBox.TabIndex = 14;
            this.vsTwoTrafficTextBox.Text = resources.GetString("vsTwoTrafficTextBox.Text");
            // 
            // vs2Label
            // 
            this.vs2Label.AutoSize = true;
            this.vs2Label.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vs2Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.vs2Label.Location = new System.Drawing.Point(0, 0);
            this.vs2Label.Name = "vs2Label";
            this.vs2Label.Size = new System.Drawing.Size(38, 21);
            this.vs2Label.TabIndex = 12;
            this.vs2Label.Text = "VS2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.label3.Location = new System.Drawing.Point(44, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "ETD STR (Left)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "172.16.110.21:4545";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.vsThreeTrafficTextBox);
            this.panel4.Controls.Add(this.vs3Label);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label8);
            this.panel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.panel4.Location = new System.Drawing.Point(10, 181);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(209, 163);
            this.panel4.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "OP History";
            // 
            // vsThreeTrafficTextBox
            // 
            this.vsThreeTrafficTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsThreeTrafficTextBox.Location = new System.Drawing.Point(4, 61);
            this.vsThreeTrafficTextBox.Multiline = true;
            this.vsThreeTrafficTextBox.Name = "vsThreeTrafficTextBox";
            this.vsThreeTrafficTextBox.ReadOnly = true;
            this.vsThreeTrafficTextBox.Size = new System.Drawing.Size(202, 99);
            this.vsThreeTrafficTextBox.TabIndex = 14;
            this.vsThreeTrafficTextBox.Text = resources.GetString("vsThreeTrafficTextBox.Text");
            // 
            // vs3Label
            // 
            this.vs3Label.AutoSize = true;
            this.vs3Label.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vs3Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.vs3Label.Location = new System.Drawing.Point(0, 0);
            this.vs3Label.Name = "vs3Label";
            this.vs3Label.Size = new System.Drawing.Size(38, 21);
            this.vs3Label.TabIndex = 12;
            this.vs3Label.Text = "VS3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.label7.Location = new System.Drawing.Point(44, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "ETD STR (Left)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 21);
            this.label8.TabIndex = 3;
            this.label8.Text = "172.16.110.21:4545";
            // 
            // AnalysisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(445, 356);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnalysisForm";
            this.Text = "AnalysisForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label vs1Label;
        private System.Windows.Forms.Label nodeOneToolaLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label opHistoryVS1Label;
        private System.Windows.Forms.TextBox vsOneTrafficTextBox;
        private System.Windows.Forms.Label ipAndPortVS1Label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox vsTwoTrafficTextBox;
        private System.Windows.Forms.Label vs2Label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox vsThreeTrafficTextBox;
        private System.Windows.Forms.Label vs3Label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox errorsTextBox;
    }
}
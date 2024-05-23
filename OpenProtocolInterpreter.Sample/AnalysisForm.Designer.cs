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
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.ipAndPortVS1Label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.vs2Label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.vs3Label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.errorsTextBox = new System.Windows.Forms.TextBox();
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
            this.panel1.Controls.Add(this.textBox5);
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
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(4, 61);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(202, 99);
            this.textBox5.TabIndex = 14;
            this.textBox5.Text = resources.GetString("textBox5.Text");
            this.textBox5.Enter += new System.EventHandler(this.textBox5_Enter);
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.textBox1);
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
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(4, 61);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(202, 99);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = resources.GetString("textBox1.Text");
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
            this.panel4.Controls.Add(this.textBox2);
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
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(4, 61);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(202, 99);
            this.textBox2.TabIndex = 14;
            this.textBox2.Text = resources.GetString("textBox2.Text");
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
            // errorsTextBox
            // 
            this.errorsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorsTextBox.Location = new System.Drawing.Point(4, 30);
            this.errorsTextBox.Multiline = true;
            this.errorsTextBox.Name = "errorsTextBox";
            this.errorsTextBox.ReadOnly = true;
            this.errorsTextBox.Size = new System.Drawing.Size(202, 130);
            this.errorsTextBox.TabIndex = 16;
            this.errorsTextBox.Text = "VS1 18:01:22 S MID 0212: Command refused by controller (Client already connected)" +
    "\r\n";
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
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label ipAndPortVS1Label;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label vs2Label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label vs3Label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox errorsTextBox;
    }
}
namespace OpenProtocolInterpreter.Sample
{
    partial class DriverForm
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.connectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolstripLast = new System.Windows.Forms.ToolStripStatusLabel();
            this.lastMessageArrived = new System.Windows.Forms.ToolStripStatusLabel();
            this.textIp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnection = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericPort = new System.Windows.Forms.NumericUpDown();
            this.checkBadgeTimer = new System.Windows.Forms.Timer(this.components);
            this.hideCheckingFormTime = new System.Windows.Forms.Timer(this.components);
            this.topPanel = new System.Windows.Forms.Panel();
            this.yellowStripPanel = new System.Windows.Forms.Panel();
            this.closeMainFormButton = new System.Windows.Forms.Button();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPort)).BeginInit();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionStatus,
            this.toolstripLast,
            this.lastMessageArrived});
            this.statusStrip1.Location = new System.Drawing.Point(0, 209);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(247, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // connectionStatus
            // 
            this.connectionStatus.BackColor = System.Drawing.Color.Red;
            this.connectionStatus.Name = "connectionStatus";
            this.connectionStatus.Size = new System.Drawing.Size(79, 17);
            this.connectionStatus.Text = "Disconnected";
            // 
            // toolstripLast
            // 
            this.toolstripLast.Name = "toolstripLast";
            this.toolstripLast.Size = new System.Drawing.Size(96, 17);
            this.toolstripLast.Text = "Last Mid Arrived:";
            // 
            // lastMessageArrived
            // 
            this.lastMessageArrived.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lastMessageArrived.Name = "lastMessageArrived";
            this.lastMessageArrived.Size = new System.Drawing.Size(57, 17);
            this.lastMessageArrived.Spring = true;
            this.lastMessageArrived.Text = "Last MID";
            // 
            // textIp
            // 
            this.textIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIp.Location = new System.Drawing.Point(60, 61);
            this.textIp.Name = "textIp";
            this.textIp.Size = new System.Drawing.Size(149, 22);
            this.textIp.TabIndex = 2;
            this.textIp.Text = "10.127.1.21";
            this.textIp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Controller IP";
            // 
            // btnConnection
            // 
            this.btnConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnection.Location = new System.Drawing.Point(6, 138);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(230, 49);
            this.btnConnection.TabIndex = 4;
            this.btnConnection.Text = "Connect";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.BtnConnection_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Port:";
            // 
            // numericPort
            // 
            this.numericPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericPort.Location = new System.Drawing.Point(61, 184);
            this.numericPort.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numericPort.Name = "numericPort";
            this.numericPort.Size = new System.Drawing.Size(148, 22);
            this.numericPort.TabIndex = 7;
            this.numericPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericPort.Value = new decimal(new int[] {
            4545,
            0,
            0,
            0});
            // 
            // checkBadgeTimer
            // 
            this.checkBadgeTimer.Interval = 250;
            this.checkBadgeTimer.Tick += new System.EventHandler(this.checkBadgeTimer_Tick);
            // 
            // hideCheckingFormTime
            // 
            this.hideCheckingFormTime.Interval = 1500;
            this.hideCheckingFormTime.Tick += new System.EventHandler(this.hideCheckingFormTime_Tick);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(63)))), ((int)(((byte)(72)))));
            this.topPanel.Controls.Add(this.closeMainFormButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(247, 34);
            this.topPanel.TabIndex = 8;
            // 
            // yellowStripPanel
            // 
            this.yellowStripPanel.BackColor = System.Drawing.Color.Gold;
            this.yellowStripPanel.Location = new System.Drawing.Point(0, 28);
            this.yellowStripPanel.Name = "yellowStripPanel";
            this.yellowStripPanel.Size = new System.Drawing.Size(249, 5);
            this.yellowStripPanel.TabIndex = 9;
            // 
            // closeMainFormButton
            // 
            this.closeMainFormButton.FlatAppearance.BorderSize = 0;
            this.closeMainFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeMainFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeMainFormButton.ForeColor = System.Drawing.Color.White;
            this.closeMainFormButton.Location = new System.Drawing.Point(222, 0);
            this.closeMainFormButton.Name = "closeMainFormButton";
            this.closeMainFormButton.Size = new System.Drawing.Size(25, 25);
            this.closeMainFormButton.TabIndex = 0;
            this.closeMainFormButton.Text = "X";
            this.closeMainFormButton.UseVisualStyleBackColor = true;
            this.closeMainFormButton.Click += new System.EventHandler(this.closeMainFormButton_Click);
            // 
            // portTextBox
            // 
            this.portTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portTextBox.Location = new System.Drawing.Point(60, 110);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(149, 22);
            this.portTextBox.TabIndex = 10;
            this.portTextBox.Text = "4545";
            this.portTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DriverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(247, 231);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.yellowStripPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.numericPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConnection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textIp);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DriverForm";
            this.Text = "OPBC";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPort)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel connectionStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolstripLast;
        private System.Windows.Forms.TextBox textIp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericPort;
        private System.Windows.Forms.ToolStripStatusLabel lastMessageArrived;
        private System.Windows.Forms.Timer checkBadgeTimer;
        private System.Windows.Forms.Timer hideCheckingFormTime;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel yellowStripPanel;
        private System.Windows.Forms.Button closeMainFormButton;
        private System.Windows.Forms.TextBox portTextBox;
    }
}


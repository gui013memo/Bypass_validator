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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.startInterfaceButton = new System.Windows.Forms.Button();
            this.consoleTextBox = new System.Windows.Forms.TextBox();
            this.btnJobInfoSubscribe = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAbortJob = new System.Windows.Forms.Button();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.btnSendProduct = new System.Windows.Forms.Button();
            this.btnSendJob = new System.Windows.Forms.Button();
            this.numericJob = new System.Windows.Forms.NumericUpDown();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.checkBadgeTimer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPort)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericJob)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionStatus,
            this.toolstripLast,
            this.lastMessageArrived});
            this.statusStrip1.Location = new System.Drawing.Point(0, 331);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(871, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // connectionStatus
            // 
            this.connectionStatus.BackColor = System.Drawing.Color.Red;
            this.connectionStatus.Name = "connectionStatus";
            this.connectionStatus.Size = new System.Drawing.Size(99, 20);
            this.connectionStatus.Text = "Disconnected";
            // 
            // toolstripLast
            // 
            this.toolstripLast.Name = "toolstripLast";
            this.toolstripLast.Size = new System.Drawing.Size(120, 20);
            this.toolstripLast.Text = "Last Mid Arrived:";
            // 
            // lastMessageArrived
            // 
            this.lastMessageArrived.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lastMessageArrived.Name = "lastMessageArrived";
            this.lastMessageArrived.Size = new System.Drawing.Size(632, 20);
            this.lastMessageArrived.Spring = true;
            this.lastMessageArrived.Text = "Last MID";
            // 
            // textIp
            // 
            this.textIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIp.Location = new System.Drawing.Point(48, 15);
            this.textIp.Margin = new System.Windows.Forms.Padding(4);
            this.textIp.Name = "textIp";
            this.textIp.Size = new System.Drawing.Size(212, 26);
            this.textIp.TabIndex = 2;
            this.textIp.Text = "10.127.1.21";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP:";
            // 
            // btnConnection
            // 
            this.btnConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnection.Location = new System.Drawing.Point(513, 12);
            this.btnConnection.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(133, 28);
            this.btnConnection.TabIndex = 4;
            this.btnConnection.Text = "Connect";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.BtnConnection_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(279, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Port:";
            // 
            // numericPort
            // 
            this.numericPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericPort.Location = new System.Drawing.Point(333, 16);
            this.numericPort.Margin = new System.Windows.Forms.Padding(4);
            this.numericPort.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numericPort.Name = "numericPort";
            this.numericPort.Size = new System.Drawing.Size(160, 26);
            this.numericPort.TabIndex = 7;
            this.numericPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericPort.Value = new decimal(new int[] {
            4545,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.startInterfaceButton);
            this.groupBox1.Controls.Add(this.consoleTextBox);
            this.groupBox1.Controls.Add(this.btnJobInfoSubscribe);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 64);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(839, 105);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Subscribes";
            // 
            // startInterfaceButton
            // 
            this.startInterfaceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startInterfaceButton.Location = new System.Drawing.Point(153, 26);
            this.startInterfaceButton.Margin = new System.Windows.Forms.Padding(4);
            this.startInterfaceButton.Name = "startInterfaceButton";
            this.startInterfaceButton.Size = new System.Drawing.Size(137, 63);
            this.startInterfaceButton.TabIndex = 11;
            this.startInterfaceButton.Text = "START INTERFACE";
            this.startInterfaceButton.UseVisualStyleBackColor = true;
            this.startInterfaceButton.Click += new System.EventHandler(this.startInterfaceButton_Click);
            // 
            // consoleTextBox
            // 
            this.consoleTextBox.Location = new System.Drawing.Point(328, 0);
            this.consoleTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.consoleTextBox.Multiline = true;
            this.consoleTextBox.Name = "consoleTextBox";
            this.consoleTextBox.Size = new System.Drawing.Size(504, 105);
            this.consoleTextBox.TabIndex = 10;
            // 
            // btnJobInfoSubscribe
            // 
            this.btnJobInfoSubscribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJobInfoSubscribe.Location = new System.Drawing.Point(8, 26);
            this.btnJobInfoSubscribe.Margin = new System.Windows.Forms.Padding(4);
            this.btnJobInfoSubscribe.Name = "btnJobInfoSubscribe";
            this.btnJobInfoSubscribe.Size = new System.Drawing.Size(137, 63);
            this.btnJobInfoSubscribe.TabIndex = 10;
            this.btnJobInfoSubscribe.Text = "Job Info Subscribe";
            this.btnJobInfoSubscribe.UseVisualStyleBackColor = true;
            this.btnJobInfoSubscribe.Click += new System.EventHandler(this.BtnJobInfoSubscribe_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnAbortJob);
            this.groupBox2.Controls.Add(this.txtProduct);
            this.groupBox2.Controls.Add(this.btnSendProduct);
            this.groupBox2.Controls.Add(this.btnSendJob);
            this.groupBox2.Controls.Add(this.numericJob);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 182);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(839, 123);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Commands";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(671, 46);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 63);
            this.button2.TabIndex = 13;
            this.button2.Text = "TEST IDs";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(525, 46);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 63);
            this.button1.TabIndex = 12;
            this.button1.Text = "Choose SQS directory";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAbortJob
            // 
            this.btnAbortJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbortJob.Location = new System.Drawing.Point(8, 62);
            this.btnAbortJob.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbortJob.Name = "btnAbortJob";
            this.btnAbortJob.Size = new System.Drawing.Size(224, 28);
            this.btnAbortJob.TabIndex = 12;
            this.btnAbortJob.Text = "Abort Job";
            this.btnAbortJob.UseVisualStyleBackColor = true;
            this.btnAbortJob.Click += new System.EventHandler(this.BtnAbortJob_Click);
            // 
            // txtProduct
            // 
            this.txtProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduct.Location = new System.Drawing.Point(240, 63);
            this.txtProduct.Margin = new System.Windows.Forms.Padding(4);
            this.txtProduct.MaxLength = 25;
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(212, 26);
            this.txtProduct.TabIndex = 10;
            // 
            // btnSendProduct
            // 
            this.btnSendProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendProduct.Location = new System.Drawing.Point(267, 25);
            this.btnSendProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnSendProduct.Name = "btnSendProduct";
            this.btnSendProduct.Size = new System.Drawing.Size(133, 28);
            this.btnSendProduct.TabIndex = 11;
            this.btnSendProduct.Text = "Send Product";
            this.btnSendProduct.UseVisualStyleBackColor = true;
            this.btnSendProduct.Click += new System.EventHandler(this.BtnSendProduct_Click);
            // 
            // btnSendJob
            // 
            this.btnSendJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendJob.Location = new System.Drawing.Point(99, 26);
            this.btnSendJob.Margin = new System.Windows.Forms.Padding(4);
            this.btnSendJob.Name = "btnSendJob";
            this.btnSendJob.Size = new System.Drawing.Size(133, 28);
            this.btnSendJob.TabIndex = 10;
            this.btnSendJob.Text = "Send Job";
            this.btnSendJob.UseVisualStyleBackColor = true;
            this.btnSendJob.Click += new System.EventHandler(this.BtnSendJob_Click);
            // 
            // numericJob
            // 
            this.numericJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericJob.Location = new System.Drawing.Point(8, 26);
            this.numericJob.Margin = new System.Windows.Forms.Padding(4);
            this.numericJob.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericJob.Name = "numericJob";
            this.numericJob.Size = new System.Drawing.Size(83, 26);
            this.numericJob.TabIndex = 10;
            this.numericJob.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // checkBadgeTimer
            // 
            this.checkBadgeTimer.Interval = 250;
            this.checkBadgeTimer.Tick += new System.EventHandler(this.checkBadgeTimer_Tick);
            // 
            // DriverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 357);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numericPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConnection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textIp);
            this.Controls.Add(this.statusStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DriverForm";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericPort)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericJob)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button startInterfaceButton;
        private System.Windows.Forms.Button btnJobInfoSubscribe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripStatusLabel lastMessageArrived;
        private System.Windows.Forms.Button btnSendJob;
        private System.Windows.Forms.NumericUpDown numericJob;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Button btnSendProduct;
        private System.Windows.Forms.Button btnAbortJob;
        private System.Windows.Forms.TextBox consoleTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer checkBadgeTimer;
    }
}


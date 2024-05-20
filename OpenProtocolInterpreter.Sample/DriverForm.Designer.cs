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
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnection = new System.Windows.Forms.Button();
            this.portLabel = new System.Windows.Forms.Label();
            this.checkBadgeTimer = new System.Windows.Forms.Timer(this.components);
            this.hideCheckingFormTime = new System.Windows.Forms.Timer(this.components);
            this.topPanel = new System.Windows.Forms.Panel();
            this.closeMainFormButton = new System.Windows.Forms.Button();
            this.yellowStripPanel = new System.Windows.Forms.Panel();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ipTextBox
            // 
            this.ipTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipTextBox.Location = new System.Drawing.Point(52, 65);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(149, 22);
            this.ipTextBox.TabIndex = 2;
            this.ipTextBox.Text = "10.127.1.21";
            this.ipTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Controller IP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnConnection
            // 
            this.btnConnection.BackColor = System.Drawing.Color.Red;
            this.btnConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnection.ForeColor = System.Drawing.Color.White;
            this.btnConnection.Location = new System.Drawing.Point(37, 142);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(179, 40);
            this.btnConnection.TabIndex = 4;
            this.btnConnection.Text = "STOP";
            this.btnConnection.UseVisualStyleBackColor = false;
            this.btnConnection.Click += new System.EventHandler(this.BtnConnection_Click);
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portLabel.Location = new System.Drawing.Point(105, 90);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(39, 21);
            this.portLabel.TabIndex = 6;
            this.portLabel.Text = "Port";
            this.portLabel.Click += new System.EventHandler(this.label2_Click);
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
            this.topPanel.Controls.Add(this.yellowStripPanel);
            this.topPanel.Controls.Add(this.closeMainFormButton);
            this.topPanel.Controls.Add(this.label3);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(239, 28);
            this.topPanel.TabIndex = 8;
            // 
            // closeMainFormButton
            // 
            this.closeMainFormButton.FlatAppearance.BorderSize = 0;
            this.closeMainFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeMainFormButton.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeMainFormButton.ForeColor = System.Drawing.Color.White;
            this.closeMainFormButton.Location = new System.Drawing.Point(214, 2);
            this.closeMainFormButton.Name = "closeMainFormButton";
            this.closeMainFormButton.Size = new System.Drawing.Size(25, 25);
            this.closeMainFormButton.TabIndex = 0;
            this.closeMainFormButton.Text = "X";
            this.closeMainFormButton.UseVisualStyleBackColor = true;
            this.closeMainFormButton.Click += new System.EventHandler(this.closeMainFormButton_Click);
            // 
            // yellowStripPanel
            // 
            this.yellowStripPanel.BackColor = System.Drawing.Color.Gold;
            this.yellowStripPanel.Location = new System.Drawing.Point(0, 26);
            this.yellowStripPanel.Name = "yellowStripPanel";
            this.yellowStripPanel.Size = new System.Drawing.Size(249, 4);
            this.yellowStripPanel.TabIndex = 9;
            // 
            // portTextBox
            // 
            this.portTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portTextBox.Location = new System.Drawing.Point(52, 110);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(149, 22);
            this.portTextBox.TabIndex = 10;
            this.portTextBox.Text = "4545";
            this.portTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.portTextBox.TextChanged += new System.EventHandler(this.portTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "OPBC";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.BackColor = System.Drawing.Color.Transparent;
            this.versionLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.versionLabel.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(63)))), ((int)(((byte)(72)))));
            this.versionLabel.Location = new System.Drawing.Point(204, 186);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(31, 15);
            this.versionLabel.TabIndex = 12;
            this.versionLabel.Text = "1.0.0";
            // 
            // DriverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(239, 204);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.btnConnection);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ipTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DriverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OPBC";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Timer checkBadgeTimer;
        private System.Windows.Forms.Timer hideCheckingFormTime;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel yellowStripPanel;
        private System.Windows.Forms.Button closeMainFormButton;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label versionLabel;
    }
}


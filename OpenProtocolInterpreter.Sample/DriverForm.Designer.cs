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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DriverForm));
            this.checkBadgeTimer = new System.Windows.Forms.Timer(this.components);
            this.hideCheckingFormTimer = new System.Windows.Forms.Timer(this.components);
            this.topPanel = new System.Windows.Forms.Panel();
            this.yellowStripPanel = new System.Windows.Forms.Panel();
            this.appNameLabel = new System.Windows.Forms.Label();
            this.closeMainFormButton = new System.Windows.Forms.Button();
            this.minimizeMainFormButton = new System.Windows.Forms.Button();
            this.formLoaderPanel = new System.Windows.Forms.Panel();
            this.versionLabel = new System.Windows.Forms.Label();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.aboutButton = new System.Windows.Forms.Button();
            this.analysisButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.vsOneKeepAliveTimer = new System.Windows.Forms.Timer(this.components);
            this.topPanel.SuspendLayout();
            this.sidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBadgeTimer
            // 
            this.checkBadgeTimer.Interval = 250;
            this.checkBadgeTimer.Tick += new System.EventHandler(this.checkBadgeTimer_Tick);
            // 
            // hideCheckingFormTimer
            // 
            this.hideCheckingFormTimer.Interval = 1500;
            this.hideCheckingFormTimer.Tick += new System.EventHandler(this.hideCheckingFormTime_Tick);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(63)))), ((int)(((byte)(72)))));
            this.topPanel.Controls.Add(this.yellowStripPanel);
            this.topPanel.Controls.Add(this.appNameLabel);
            this.topPanel.Controls.Add(this.closeMainFormButton);
            this.topPanel.Controls.Add(this.minimizeMainFormButton);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(515, 35);
            this.topPanel.TabIndex = 8;
            // 
            // yellowStripPanel
            // 
            this.yellowStripPanel.BackColor = System.Drawing.Color.Gold;
            this.yellowStripPanel.Location = new System.Drawing.Point(0, 30);
            this.yellowStripPanel.Margin = new System.Windows.Forms.Padding(2);
            this.yellowStripPanel.Name = "yellowStripPanel";
            this.yellowStripPanel.Size = new System.Drawing.Size(515, 7);
            this.yellowStripPanel.TabIndex = 9;
            // 
            // appNameLabel
            // 
            this.appNameLabel.AutoSize = true;
            this.appNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.appNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appNameLabel.Font = new System.Drawing.Font("Microsoft New Tai Lue", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.appNameLabel.Location = new System.Drawing.Point(0, 3);
            this.appNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.appNameLabel.Name = "appNameLabel";
            this.appNameLabel.Size = new System.Drawing.Size(351, 29);
            this.appNameLabel.TabIndex = 11;
            this.appNameLabel.Text = "Open Protocol Bypass Controller";
            this.appNameLabel.Click += new System.EventHandler(this.appNameLabel_Click);
            // 
            // closeMainFormButton
            // 
            this.closeMainFormButton.FlatAppearance.BorderSize = 0;
            this.closeMainFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeMainFormButton.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeMainFormButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.closeMainFormButton.Location = new System.Drawing.Point(491, 0);
            this.closeMainFormButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeMainFormButton.Name = "closeMainFormButton";
            this.closeMainFormButton.Size = new System.Drawing.Size(19, 26);
            this.closeMainFormButton.TabIndex = 0;
            this.closeMainFormButton.Text = "X";
            this.closeMainFormButton.UseVisualStyleBackColor = true;
            this.closeMainFormButton.Click += new System.EventHandler(this.closeMainFormButton_Click);
            // 
            // minimizeMainFormButton
            // 
            this.minimizeMainFormButton.FlatAppearance.BorderSize = 0;
            this.minimizeMainFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeMainFormButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeMainFormButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.minimizeMainFormButton.Location = new System.Drawing.Point(459, -5);
            this.minimizeMainFormButton.Margin = new System.Windows.Forms.Padding(2);
            this.minimizeMainFormButton.Name = "minimizeMainFormButton";
            this.minimizeMainFormButton.Size = new System.Drawing.Size(28, 33);
            this.minimizeMainFormButton.TabIndex = 12;
            this.minimizeMainFormButton.Text = "_";
            this.minimizeMainFormButton.UseVisualStyleBackColor = true;
            this.minimizeMainFormButton.Click += new System.EventHandler(this.minimizeMainForm_Click);
            // 
            // formLoaderPanel
            // 
            this.formLoaderPanel.BackColor = System.Drawing.Color.Silver;
            this.formLoaderPanel.Location = new System.Drawing.Point(64, 39);
            this.formLoaderPanel.Margin = new System.Windows.Forms.Padding(2);
            this.formLoaderPanel.Name = "formLoaderPanel";
            this.formLoaderPanel.Size = new System.Drawing.Size(446, 350);
            this.formLoaderPanel.TabIndex = 13;
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.BackColor = System.Drawing.Color.Transparent;
            this.versionLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.versionLabel.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.versionLabel.Location = new System.Drawing.Point(4, 346);
            this.versionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(31, 15);
            this.versionLabel.TabIndex = 12;
            this.versionLabel.Text = "1.0.0";
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.sidePanel.Controls.Add(this.aboutButton);
            this.sidePanel.Controls.Add(this.analysisButton);
            this.sidePanel.Controls.Add(this.settingsButton);
            this.sidePanel.Controls.Add(this.homeButton);
            this.sidePanel.Controls.Add(this.versionLabel);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 35);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(2);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(60, 360);
            this.sidePanel.TabIndex = 12;
            // 
            // aboutButton
            // 
            this.aboutButton.BackgroundImage = global::OpenProtocolInterpreter.Sample.Properties.Resources.about_small;
            this.aboutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.aboutButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.aboutButton.FlatAppearance.BorderSize = 0;
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.aboutButton.Location = new System.Drawing.Point(0, 114);
            this.aboutButton.Margin = new System.Windows.Forms.Padding(2);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(60, 31);
            this.aboutButton.TabIndex = 16;
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // analysisButton
            // 
            this.analysisButton.BackgroundImage = global::OpenProtocolInterpreter.Sample.Properties.Resources.back_and_fourth;
            this.analysisButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.analysisButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.analysisButton.FlatAppearance.BorderSize = 0;
            this.analysisButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.analysisButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analysisButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.analysisButton.Location = new System.Drawing.Point(0, 72);
            this.analysisButton.Margin = new System.Windows.Forms.Padding(2);
            this.analysisButton.Name = "analysisButton";
            this.analysisButton.Size = new System.Drawing.Size(60, 42);
            this.analysisButton.TabIndex = 15;
            this.analysisButton.UseVisualStyleBackColor = true;
            this.analysisButton.Click += new System.EventHandler(this.AnalysisButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.BackgroundImage = global::OpenProtocolInterpreter.Sample.Properties.Resources.settings___small1;
            this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsButton.FlatAppearance.BorderSize = 0;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.settingsButton.Location = new System.Drawing.Point(0, 34);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(2);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(60, 38);
            this.settingsButton.TabIndex = 14;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.BackgroundImage = global::OpenProtocolInterpreter.Sample.Properties.Resources.Home_icon_svg___Copy___Copy;
            this.homeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.homeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.homeButton.Location = new System.Drawing.Point(0, 0);
            this.homeButton.Margin = new System.Windows.Forms.Padding(2);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(60, 34);
            this.homeButton.TabIndex = 13;
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // vsOneKeepAliveTimer
            // 
            this.vsOneKeepAliveTimer.Interval = 1000;
            this.vsOneKeepAliveTimer.Tick += new System.EventHandler(this.vsOneKeepAliveTimer_Tick);
            // 
            // DriverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(515, 395);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.formLoaderPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DriverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OPBC";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel yellowStripPanel;
        private System.Windows.Forms.Button closeMainFormButton;
        private System.Windows.Forms.Label appNameLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button minimizeMainFormButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button analysisButton;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Panel formLoaderPanel;
        public System.Windows.Forms.Timer checkBadgeTimer;
        public System.Windows.Forms.Timer hideCheckingFormTimer;
        private System.Windows.Forms.Timer vsOneKeepAliveTimer;
    }
}


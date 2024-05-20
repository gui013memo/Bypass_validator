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
            this.checkBadgeTimer = new System.Windows.Forms.Timer(this.components);
            this.hideCheckingFormTime = new System.Windows.Forms.Timer(this.components);
            this.topPanel = new System.Windows.Forms.Panel();
            this.yellowStripPanel = new System.Windows.Forms.Panel();
            this.closeMainFormButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.versionLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.formLoaderPanel = new System.Windows.Forms.Panel();
            this.topPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.topPanel.Controls.Add(this.label3);
            this.topPanel.Controls.Add(this.closeMainFormButton);
            this.topPanel.Controls.Add(this.button3);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(518, 37);
            this.topPanel.TabIndex = 8;
            this.topPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.topPanel_Paint);
            // 
            // yellowStripPanel
            // 
            this.yellowStripPanel.BackColor = System.Drawing.Color.Gold;
            this.yellowStripPanel.Location = new System.Drawing.Point(0, 33);
            this.yellowStripPanel.Name = "yellowStripPanel";
            this.yellowStripPanel.Size = new System.Drawing.Size(800, 3);
            this.yellowStripPanel.TabIndex = 9;
            // 
            // closeMainFormButton
            // 
            this.closeMainFormButton.FlatAppearance.BorderSize = 0;
            this.closeMainFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeMainFormButton.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeMainFormButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.closeMainFormButton.Location = new System.Drawing.Point(490, 0);
            this.closeMainFormButton.Name = "closeMainFormButton";
            this.closeMainFormButton.Size = new System.Drawing.Size(25, 34);
            this.closeMainFormButton.TabIndex = 0;
            this.closeMainFormButton.Text = "X";
            this.closeMainFormButton.UseVisualStyleBackColor = true;
            this.closeMainFormButton.Click += new System.EventHandler(this.closeMainFormButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.label3.Location = new System.Drawing.Point(3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(320, 27);
            this.label3.TabIndex = 11;
            this.label3.Text = "Open Protocol Bypass Controller";
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Matura MT Script Capitals", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.button3.Location = new System.Drawing.Point(459, -5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(37, 43);
            this.button3.TabIndex = 12;
            this.button3.Text = "_";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.BackColor = System.Drawing.Color.Transparent;
            this.versionLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.versionLabel.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.versionLabel.Location = new System.Drawing.Point(4, 325);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(31, 15);
            this.versionLabel.TabIndex = 12;
            this.versionLabel.Text = "1.0.0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.homeButton);
            this.panel2.Controls.Add(this.versionLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(81, 345);
            this.panel2.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(473, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.BackgroundImage = global::OpenProtocolInterpreter.Sample.Properties.Resources.about_small;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.button9.Location = new System.Drawing.Point(0, 150);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(81, 40);
            this.button9.TabIndex = 16;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.BackgroundImage = global::OpenProtocolInterpreter.Sample.Properties.Resources.back_and_fourth;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.button8.Location = new System.Drawing.Point(0, 95);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(81, 55);
            this.button8.TabIndex = 15;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.BackgroundImage = global::OpenProtocolInterpreter.Sample.Properties.Resources.settings___small1;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.button7.Location = new System.Drawing.Point(0, 45);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(81, 50);
            this.button7.TabIndex = 14;
            this.button7.UseVisualStyleBackColor = true;
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
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(81, 45);
            this.homeButton.TabIndex = 13;
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            this.homeButton.Leave += new System.EventHandler(this.homeButton_Leave_1);
            // 
            // formLoaderPanel
            // 
            this.formLoaderPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.formLoaderPanel.Location = new System.Drawing.Point(81, 37);
            this.formLoaderPanel.Name = "formLoaderPanel";
            this.formLoaderPanel.Size = new System.Drawing.Size(437, 345);
            this.formLoaderPanel.TabIndex = 13;
            // 
            // DriverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(518, 382);
            this.Controls.Add(this.formLoaderPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DriverForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OPBC";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer checkBadgeTimer;
        private System.Windows.Forms.Timer hideCheckingFormTime;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel yellowStripPanel;
        private System.Windows.Forms.Button closeMainFormButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel formLoaderPanel;
    }
}


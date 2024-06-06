namespace OpenProtocolInterpreter.Sample
{
    partial class HomeForm
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.startOrStopButton = new System.Windows.Forms.Button();
            this.startModeLabel = new System.Windows.Forms.Label();
            this.ModeButton = new System.Windows.Forms.Button();
            this.controlLabel = new System.Windows.Forms.Label();
            this.vsThreePanel = new System.Windows.Forms.Panel();
            this.vsThreeConnStateLabel = new System.Windows.Forms.Label();
            this.vsThreeToolLabel = new System.Windows.Forms.Label();
            this.vsThreePortTextBox = new System.Windows.Forms.TextBox();
            this.vsThreeStartOrStopButton = new System.Windows.Forms.Button();
            this.vsThreeIpTextBox = new System.Windows.Forms.TextBox();
            this.vsThreeControllerIpLabel = new System.Windows.Forms.Label();
            this.vsThreePortLabel = new System.Windows.Forms.Label();
            this.vsTwoPanel = new System.Windows.Forms.Panel();
            this.vsTwoConnStateLabel = new System.Windows.Forms.Label();
            this.vsTwoToolLabel = new System.Windows.Forms.Label();
            this.vsTwoPortTextBox = new System.Windows.Forms.TextBox();
            this.vsTwoStartOrStopButton = new System.Windows.Forms.Button();
            this.vsTwoIpTextBox = new System.Windows.Forms.TextBox();
            this.vsTwoControllerIpLabel = new System.Windows.Forms.Label();
            this.vsTwoPortLabel = new System.Windows.Forms.Label();
            this.vsOnePanel = new System.Windows.Forms.Panel();
            this.vsOneConnStateLabel = new System.Windows.Forms.Label();
            this.vsOneToolLabel = new System.Windows.Forms.Label();
            this.vsOnePortTextBox = new System.Windows.Forms.TextBox();
            this.vsOneStartOrStopButton = new System.Windows.Forms.Button();
            this.vsOneIpTextBox = new System.Windows.Forms.TextBox();
            this.vsOneControllerIpLabel = new System.Windows.Forms.Label();
            this.vsOnePortLabel = new System.Windows.Forms.Label();
            this.vsTwoTimer = new System.Windows.Forms.Timer(this.components);
            this.vsThreeTimer = new System.Windows.Forms.Timer(this.components);
            this.panel5.SuspendLayout();
            this.vsThreePanel.SuspendLayout();
            this.vsTwoPanel.SuspendLayout();
            this.vsOnePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Controls.Add(this.startOrStopButton);
            this.panel5.Controls.Add(this.startModeLabel);
            this.panel5.Controls.Add(this.ModeButton);
            this.panel5.Controls.Add(this.controlLabel);
            this.panel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.panel5.Location = new System.Drawing.Point(227, 181);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(209, 163);
            this.panel5.TabIndex = 19;
            // 
            // startOrStopButton
            // 
            this.startOrStopButton.BackColor = System.Drawing.Color.Green;
            this.startOrStopButton.FlatAppearance.BorderSize = 0;
            this.startOrStopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startOrStopButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.startOrStopButton.Location = new System.Drawing.Point(15, 33);
            this.startOrStopButton.Name = "startOrStopButton";
            this.startOrStopButton.Size = new System.Drawing.Size(179, 40);
            this.startOrStopButton.TabIndex = 12;
            this.startOrStopButton.Text = "START";
            this.startOrStopButton.UseVisualStyleBackColor = false;
            this.startOrStopButton.Click += new System.EventHandler(this.startOrStopButton_Click);
            // 
            // startModeLabel
            // 
            this.startModeLabel.AutoSize = true;
            this.startModeLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startModeLabel.Location = new System.Drawing.Point(50, 89);
            this.startModeLabel.Name = "startModeLabel";
            this.startModeLabel.Size = new System.Drawing.Size(110, 21);
            this.startModeLabel.TabIndex = 11;
            this.startModeLabel.Text = "START MODE";
            // 
            // ModeButton
            // 
            this.ModeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(130)))), ((int)(((byte)(184)))));
            this.ModeButton.FlatAppearance.BorderSize = 0;
            this.ModeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.ModeButton.Location = new System.Drawing.Point(17, 109);
            this.ModeButton.Name = "ModeButton";
            this.ModeButton.Size = new System.Drawing.Size(179, 40);
            this.ModeButton.TabIndex = 4;
            this.ModeButton.Text = "SET MANUAL";
            this.ModeButton.UseVisualStyleBackColor = false;
            this.ModeButton.Click += new System.EventHandler(this.ModeButton_Click);
            // 
            // controlLabel
            // 
            this.controlLabel.AutoSize = true;
            this.controlLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlLabel.Location = new System.Drawing.Point(63, 9);
            this.controlLabel.Name = "controlLabel";
            this.controlLabel.Size = new System.Drawing.Size(84, 21);
            this.controlLabel.TabIndex = 6;
            this.controlLabel.Text = "CONTROL";
            // 
            // vsThreePanel
            // 
            this.vsThreePanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.vsThreePanel.Controls.Add(this.vsThreeConnStateLabel);
            this.vsThreePanel.Controls.Add(this.vsThreeToolLabel);
            this.vsThreePanel.Controls.Add(this.vsThreePortTextBox);
            this.vsThreePanel.Controls.Add(this.vsThreeStartOrStopButton);
            this.vsThreePanel.Controls.Add(this.vsThreeIpTextBox);
            this.vsThreePanel.Controls.Add(this.vsThreeControllerIpLabel);
            this.vsThreePanel.Controls.Add(this.vsThreePortLabel);
            this.vsThreePanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.vsThreePanel.Location = new System.Drawing.Point(12, 181);
            this.vsThreePanel.Name = "vsThreePanel";
            this.vsThreePanel.Size = new System.Drawing.Size(209, 163);
            this.vsThreePanel.TabIndex = 17;
            // 
            // vsThreeConnStateLabel
            // 
            this.vsThreeConnStateLabel.AutoSize = true;
            this.vsThreeConnStateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.vsThreeConnStateLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsThreeConnStateLabel.ForeColor = System.Drawing.Color.Transparent;
            this.vsThreeConnStateLabel.Location = new System.Drawing.Point(0, 0);
            this.vsThreeConnStateLabel.Name = "vsThreeConnStateLabel";
            this.vsThreeConnStateLabel.Size = new System.Drawing.Size(39, 21);
            this.vsThreeConnStateLabel.TabIndex = 13;
            this.vsThreeConnStateLabel.Text = "VS3";
            // 
            // vsThreeToolLabel
            // 
            this.vsThreeToolLabel.AutoSize = true;
            this.vsThreeToolLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsThreeToolLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.vsThreeToolLabel.Location = new System.Drawing.Point(44, 6);
            this.vsThreeToolLabel.Name = "vsThreeToolLabel";
            this.vsThreeToolLabel.Size = new System.Drawing.Size(116, 21);
            this.vsThreeToolLabel.TabIndex = 11;
            this.vsThreeToolLabel.Text = "ETV STB (Left)";
            // 
            // vsThreePortTextBox
            // 
            this.vsThreePortTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsThreePortTextBox.Location = new System.Drawing.Point(30, 93);
            this.vsThreePortTextBox.Name = "vsThreePortTextBox";
            this.vsThreePortTextBox.Size = new System.Drawing.Size(149, 22);
            this.vsThreePortTextBox.TabIndex = 10;
            this.vsThreePortTextBox.Text = "4546";
            this.vsThreePortTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vsThreeStartOrStopButton
            // 
            this.vsThreeStartOrStopButton.BackColor = System.Drawing.Color.Gainsboro;
            this.vsThreeStartOrStopButton.Enabled = false;
            this.vsThreeStartOrStopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsThreeStartOrStopButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.vsThreeStartOrStopButton.Location = new System.Drawing.Point(15, 120);
            this.vsThreeStartOrStopButton.Name = "vsThreeStartOrStopButton";
            this.vsThreeStartOrStopButton.Size = new System.Drawing.Size(179, 40);
            this.vsThreeStartOrStopButton.TabIndex = 4;
            this.vsThreeStartOrStopButton.Text = "AUTOMATIC";
            this.vsThreeStartOrStopButton.UseVisualStyleBackColor = false;
            this.vsThreeStartOrStopButton.Click += new System.EventHandler(this.vsThreeStartOrStopButton_Click);
            // 
            // vsThreeIpTextBox
            // 
            this.vsThreeIpTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsThreeIpTextBox.Location = new System.Drawing.Point(30, 48);
            this.vsThreeIpTextBox.Name = "vsThreeIpTextBox";
            this.vsThreeIpTextBox.Size = new System.Drawing.Size(149, 22);
            this.vsThreeIpTextBox.TabIndex = 2;
            this.vsThreeIpTextBox.Text = "172.16.110.21";
            this.vsThreeIpTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vsThreeControllerIpLabel
            // 
            this.vsThreeControllerIpLabel.AutoSize = true;
            this.vsThreeControllerIpLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsThreeControllerIpLabel.Location = new System.Drawing.Point(55, 27);
            this.vsThreeControllerIpLabel.Name = "vsThreeControllerIpLabel";
            this.vsThreeControllerIpLabel.Size = new System.Drawing.Size(97, 21);
            this.vsThreeControllerIpLabel.TabIndex = 3;
            this.vsThreeControllerIpLabel.Text = "Controller IP";
            // 
            // vsThreePortLabel
            // 
            this.vsThreePortLabel.AutoSize = true;
            this.vsThreePortLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsThreePortLabel.Location = new System.Drawing.Point(83, 73);
            this.vsThreePortLabel.Name = "vsThreePortLabel";
            this.vsThreePortLabel.Size = new System.Drawing.Size(39, 21);
            this.vsThreePortLabel.TabIndex = 6;
            this.vsThreePortLabel.Text = "Port";
            // 
            // vsTwoPanel
            // 
            this.vsTwoPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.vsTwoPanel.Controls.Add(this.vsTwoConnStateLabel);
            this.vsTwoPanel.Controls.Add(this.vsTwoToolLabel);
            this.vsTwoPanel.Controls.Add(this.vsTwoPortTextBox);
            this.vsTwoPanel.Controls.Add(this.vsTwoStartOrStopButton);
            this.vsTwoPanel.Controls.Add(this.vsTwoIpTextBox);
            this.vsTwoPanel.Controls.Add(this.vsTwoControllerIpLabel);
            this.vsTwoPanel.Controls.Add(this.vsTwoPortLabel);
            this.vsTwoPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.vsTwoPanel.Location = new System.Drawing.Point(227, 12);
            this.vsTwoPanel.Name = "vsTwoPanel";
            this.vsTwoPanel.Size = new System.Drawing.Size(209, 163);
            this.vsTwoPanel.TabIndex = 18;
            // 
            // vsTwoConnStateLabel
            // 
            this.vsTwoConnStateLabel.AutoSize = true;
            this.vsTwoConnStateLabel.BackColor = System.Drawing.Color.Transparent;
            this.vsTwoConnStateLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsTwoConnStateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.vsTwoConnStateLabel.Location = new System.Drawing.Point(0, 0);
            this.vsTwoConnStateLabel.Name = "vsTwoConnStateLabel";
            this.vsTwoConnStateLabel.Size = new System.Drawing.Size(39, 21);
            this.vsTwoConnStateLabel.TabIndex = 13;
            this.vsTwoConnStateLabel.Text = "VS2";
            // 
            // vsTwoToolLabel
            // 
            this.vsTwoToolLabel.AutoSize = true;
            this.vsTwoToolLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsTwoToolLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.vsTwoToolLabel.Location = new System.Drawing.Point(44, 6);
            this.vsTwoToolLabel.Name = "vsTwoToolLabel";
            this.vsTwoToolLabel.Size = new System.Drawing.Size(129, 21);
            this.vsTwoToolLabel.TabIndex = 11;
            this.vsTwoToolLabel.Text = "ETD STR (Right)";
            // 
            // vsTwoPortTextBox
            // 
            this.vsTwoPortTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsTwoPortTextBox.Location = new System.Drawing.Point(30, 93);
            this.vsTwoPortTextBox.Name = "vsTwoPortTextBox";
            this.vsTwoPortTextBox.Size = new System.Drawing.Size(149, 22);
            this.vsTwoPortTextBox.TabIndex = 10;
            this.vsTwoPortTextBox.Text = "4545";
            this.vsTwoPortTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vsTwoStartOrStopButton
            // 
            this.vsTwoStartOrStopButton.BackColor = System.Drawing.Color.Gainsboro;
            this.vsTwoStartOrStopButton.Enabled = false;
            this.vsTwoStartOrStopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsTwoStartOrStopButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.vsTwoStartOrStopButton.Location = new System.Drawing.Point(15, 120);
            this.vsTwoStartOrStopButton.Name = "vsTwoStartOrStopButton";
            this.vsTwoStartOrStopButton.Size = new System.Drawing.Size(179, 40);
            this.vsTwoStartOrStopButton.TabIndex = 4;
            this.vsTwoStartOrStopButton.Text = "AUTOMATIC";
            this.vsTwoStartOrStopButton.UseVisualStyleBackColor = false;
            this.vsTwoStartOrStopButton.Click += new System.EventHandler(this.vsTwoStartOrStopButton_Click);
            // 
            // vsTwoIpTextBox
            // 
            this.vsTwoIpTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsTwoIpTextBox.Location = new System.Drawing.Point(30, 48);
            this.vsTwoIpTextBox.Name = "vsTwoIpTextBox";
            this.vsTwoIpTextBox.Size = new System.Drawing.Size(149, 22);
            this.vsTwoIpTextBox.TabIndex = 2;
            this.vsTwoIpTextBox.Text = "172.16.110.22";
            this.vsTwoIpTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vsTwoControllerIpLabel
            // 
            this.vsTwoControllerIpLabel.AutoSize = true;
            this.vsTwoControllerIpLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsTwoControllerIpLabel.Location = new System.Drawing.Point(55, 27);
            this.vsTwoControllerIpLabel.Name = "vsTwoControllerIpLabel";
            this.vsTwoControllerIpLabel.Size = new System.Drawing.Size(97, 21);
            this.vsTwoControllerIpLabel.TabIndex = 3;
            this.vsTwoControllerIpLabel.Text = "Controller IP";
            // 
            // vsTwoPortLabel
            // 
            this.vsTwoPortLabel.AutoSize = true;
            this.vsTwoPortLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsTwoPortLabel.Location = new System.Drawing.Point(83, 73);
            this.vsTwoPortLabel.Name = "vsTwoPortLabel";
            this.vsTwoPortLabel.Size = new System.Drawing.Size(39, 21);
            this.vsTwoPortLabel.TabIndex = 6;
            this.vsTwoPortLabel.Text = "Port";
            // 
            // vsOnePanel
            // 
            this.vsOnePanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.vsOnePanel.Controls.Add(this.vsOneConnStateLabel);
            this.vsOnePanel.Controls.Add(this.vsOneToolLabel);
            this.vsOnePanel.Controls.Add(this.vsOnePortTextBox);
            this.vsOnePanel.Controls.Add(this.vsOneStartOrStopButton);
            this.vsOnePanel.Controls.Add(this.vsOneIpTextBox);
            this.vsOnePanel.Controls.Add(this.vsOneControllerIpLabel);
            this.vsOnePanel.Controls.Add(this.vsOnePortLabel);
            this.vsOnePanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.vsOnePanel.Location = new System.Drawing.Point(12, 12);
            this.vsOnePanel.Name = "vsOnePanel";
            this.vsOnePanel.Size = new System.Drawing.Size(209, 163);
            this.vsOnePanel.TabIndex = 16;
            // 
            // vsOneConnStateLabel
            // 
            this.vsOneConnStateLabel.AutoSize = true;
            this.vsOneConnStateLabel.BackColor = System.Drawing.Color.Green;
            this.vsOneConnStateLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsOneConnStateLabel.ForeColor = System.Drawing.Color.Transparent;
            this.vsOneConnStateLabel.Location = new System.Drawing.Point(0, 0);
            this.vsOneConnStateLabel.Name = "vsOneConnStateLabel";
            this.vsOneConnStateLabel.Size = new System.Drawing.Size(39, 21);
            this.vsOneConnStateLabel.TabIndex = 12;
            this.vsOneConnStateLabel.Text = "VS1";
            // 
            // vsOneToolLabel
            // 
            this.vsOneToolLabel.AutoSize = true;
            this.vsOneToolLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsOneToolLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.vsOneToolLabel.Location = new System.Drawing.Point(44, 6);
            this.vsOneToolLabel.Name = "vsOneToolLabel";
            this.vsOneToolLabel.Size = new System.Drawing.Size(117, 21);
            this.vsOneToolLabel.TabIndex = 11;
            this.vsOneToolLabel.Text = "ETD STR (Left)";
            // 
            // vsOnePortTextBox
            // 
            this.vsOnePortTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsOnePortTextBox.Location = new System.Drawing.Point(30, 93);
            this.vsOnePortTextBox.Name = "vsOnePortTextBox";
            this.vsOnePortTextBox.Size = new System.Drawing.Size(149, 22);
            this.vsOnePortTextBox.TabIndex = 10;
            this.vsOnePortTextBox.Text = "4545";
            this.vsOnePortTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vsOneStartOrStopButton
            // 
            this.vsOneStartOrStopButton.BackColor = System.Drawing.Color.Gainsboro;
            this.vsOneStartOrStopButton.Enabled = false;
            this.vsOneStartOrStopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsOneStartOrStopButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(61)))), ((int)(((byte)(70)))));
            this.vsOneStartOrStopButton.Location = new System.Drawing.Point(15, 120);
            this.vsOneStartOrStopButton.Name = "vsOneStartOrStopButton";
            this.vsOneStartOrStopButton.Size = new System.Drawing.Size(179, 40);
            this.vsOneStartOrStopButton.TabIndex = 4;
            this.vsOneStartOrStopButton.Text = "AUTOMATIC";
            this.vsOneStartOrStopButton.UseVisualStyleBackColor = false;
            this.vsOneStartOrStopButton.Click += new System.EventHandler(this.vsOneStartOrStopButton_Click);
            // 
            // vsOneIpTextBox
            // 
            this.vsOneIpTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsOneIpTextBox.Location = new System.Drawing.Point(30, 48);
            this.vsOneIpTextBox.Name = "vsOneIpTextBox";
            this.vsOneIpTextBox.Size = new System.Drawing.Size(149, 22);
            this.vsOneIpTextBox.TabIndex = 2;
            this.vsOneIpTextBox.Text = "172.16.110.21";
            this.vsOneIpTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // vsOneControllerIpLabel
            // 
            this.vsOneControllerIpLabel.AutoSize = true;
            this.vsOneControllerIpLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsOneControllerIpLabel.Location = new System.Drawing.Point(55, 27);
            this.vsOneControllerIpLabel.Name = "vsOneControllerIpLabel";
            this.vsOneControllerIpLabel.Size = new System.Drawing.Size(97, 21);
            this.vsOneControllerIpLabel.TabIndex = 3;
            this.vsOneControllerIpLabel.Text = "Controller IP";
            // 
            // vsOnePortLabel
            // 
            this.vsOnePortLabel.AutoSize = true;
            this.vsOnePortLabel.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsOnePortLabel.Location = new System.Drawing.Point(83, 73);
            this.vsOnePortLabel.Name = "vsOnePortLabel";
            this.vsOnePortLabel.Size = new System.Drawing.Size(39, 21);
            this.vsOnePortLabel.TabIndex = 6;
            this.vsOnePortLabel.Text = "Port";
            // 
            // vsTwoTimer
            // 
            this.vsTwoTimer.Interval = 150;
            this.vsTwoTimer.Tick += new System.EventHandler(this.vsTwoTimer_Tick);
            // 
            // vsThreeTimer
            // 
            this.vsThreeTimer.Interval = 150;
            this.vsThreeTimer.Tick += new System.EventHandler(this.vsThreeTimer_Tick);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(445, 356);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.vsThreePanel);
            this.Controls.Add(this.vsTwoPanel);
            this.Controls.Add(this.vsOnePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.vsThreePanel.ResumeLayout(false);
            this.vsThreePanel.PerformLayout();
            this.vsTwoPanel.ResumeLayout(false);
            this.vsTwoPanel.PerformLayout();
            this.vsOnePanel.ResumeLayout(false);
            this.vsOnePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.TextBox vsOneIpTextBox;
        public System.Windows.Forms.TextBox vsOnePortTextBox;
        public System.Windows.Forms.TextBox vsThreePortTextBox;
        public System.Windows.Forms.TextBox vsThreeIpTextBox;
        public System.Windows.Forms.TextBox vsTwoPortTextBox;
        public System.Windows.Forms.TextBox vsTwoIpTextBox;
        public System.Windows.Forms.Label vsOneConnStateLabel;
        public System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.Button startOrStopButton;
        public System.Windows.Forms.Label startModeLabel;
        public System.Windows.Forms.Button ModeButton;
        public System.Windows.Forms.Label controlLabel;
        public System.Windows.Forms.Panel vsThreePanel;
        public System.Windows.Forms.Label vsThreeConnStateLabel;
        public System.Windows.Forms.Label vsThreeToolLabel;
        public System.Windows.Forms.Button vsThreeStartOrStopButton;
        public System.Windows.Forms.Label vsThreeControllerIpLabel;
        public System.Windows.Forms.Label vsThreePortLabel;
        public System.Windows.Forms.Panel vsTwoPanel;
        public System.Windows.Forms.Label vsTwoConnStateLabel;
        public System.Windows.Forms.Label vsTwoToolLabel;
        public System.Windows.Forms.Button vsTwoStartOrStopButton;
        public System.Windows.Forms.Label vsTwoControllerIpLabel;
        public System.Windows.Forms.Label vsTwoPortLabel;
        public System.Windows.Forms.Panel vsOnePanel;
        public System.Windows.Forms.Label vsOneToolLabel;
        public System.Windows.Forms.Button vsOneStartOrStopButton;
        public System.Windows.Forms.Label vsOneControllerIpLabel;
        public System.Windows.Forms.Label vsOnePortLabel;
        private System.Windows.Forms.Timer vsTwoTimer;
        private System.Windows.Forms.Timer vsThreeTimer;
    }
}
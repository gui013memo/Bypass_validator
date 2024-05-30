namespace OpenProtocolInterpreter.Sample
{
    partial class BadgeCheckingForm
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
            this.bypassRequestedLabel = new System.Windows.Forms.Label();
            this.operatorStatusLabel = new System.Windows.Forms.Label();
            this.operatorNameLabel = new System.Windows.Forms.Label();
            this.shadeEffectTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // bypassRequestedLabel
            // 
            this.bypassRequestedLabel.AutoSize = true;
            this.bypassRequestedLabel.BackColor = System.Drawing.Color.Transparent;
            this.bypassRequestedLabel.Font = new System.Drawing.Font("Consolas", 60F, System.Drawing.FontStyle.Bold);
            this.bypassRequestedLabel.ForeColor = System.Drawing.Color.White;
            this.bypassRequestedLabel.Location = new System.Drawing.Point(22, 0);
            this.bypassRequestedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bypassRequestedLabel.Name = "bypassRequestedLabel";
            this.bypassRequestedLabel.Size = new System.Drawing.Size(744, 94);
            this.bypassRequestedLabel.TabIndex = 0;
            this.bypassRequestedLabel.Text = "BYPASS REQUESTED";
            // 
            // operatorStatusLabel
            // 
            this.operatorStatusLabel.AutoSize = true;
            this.operatorStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.operatorStatusLabel.Font = new System.Drawing.Font("Consolas", 38F, System.Drawing.FontStyle.Bold);
            this.operatorStatusLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.operatorStatusLabel.Location = new System.Drawing.Point(111, 90);
            this.operatorStatusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.operatorStatusLabel.Name = "operatorStatusLabel";
            this.operatorStatusLabel.Size = new System.Drawing.Size(557, 60);
            this.operatorStatusLabel.TabIndex = 1;
            this.operatorStatusLabel.Text = "OPERADOR AUTORIZADO";
            // 
            // operatorNameLabel
            // 
            this.operatorNameLabel.AutoSize = true;
            this.operatorNameLabel.Font = new System.Drawing.Font("Consolas", 36F);
            this.operatorNameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.operatorNameLabel.Location = new System.Drawing.Point(120, 150);
            this.operatorNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.operatorNameLabel.Name = "operatorNameLabel";
            this.operatorNameLabel.Size = new System.Drawing.Size(544, 56);
            this.operatorNameLabel.TabIndex = 2;
            this.operatorNameLabel.Text = "Operador sem Cadas:2";
            this.operatorNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shadeEffectTimer
            // 
            this.shadeEffectTimer.Interval = 50;
            this.shadeEffectTimer.Tick += new System.EventHandler(this.shadeEffectTimer_Tick);
            // 
            // BadgeCheckingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(794, 225);
            this.Controls.Add(this.bypassRequestedLabel);
            this.Controls.Add(this.operatorStatusLabel);
            this.Controls.Add(this.operatorNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(10, 795);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BadgeCheckingForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "BadgeCheckingForm";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bypassRequestedLabel;
        private System.Windows.Forms.Label operatorStatusLabel;
        private System.Windows.Forms.Label operatorNameLabel;
        public System.Windows.Forms.Timer shadeEffectTimer;
    }
}
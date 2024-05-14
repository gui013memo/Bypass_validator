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
            this.bypassRequestedLabel = new System.Windows.Forms.Label();
            this.operatorStatusLabel = new System.Windows.Forms.Label();
            this.operatorNameLabel = new System.Windows.Forms.Label();
            this.OperatorIdLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bypassRequestedLabel
            // 
            this.bypassRequestedLabel.AutoSize = true;
            this.bypassRequestedLabel.Font = new System.Drawing.Font("Consolas", 60F, System.Drawing.FontStyle.Bold);
            this.bypassRequestedLabel.ForeColor = System.Drawing.Color.Blue;
            this.bypassRequestedLabel.Location = new System.Drawing.Point(22, 47);
            this.bypassRequestedLabel.Name = "bypassRequestedLabel";
            this.bypassRequestedLabel.Size = new System.Drawing.Size(930, 117);
            this.bypassRequestedLabel.TabIndex = 0;
            this.bypassRequestedLabel.Text = "BYPASS REQUESTED";
            // 
            // operatorStatusLabel
            // 
            this.operatorStatusLabel.AutoSize = true;
            this.operatorStatusLabel.BackColor = System.Drawing.Color.Yellow;
            this.operatorStatusLabel.Font = new System.Drawing.Font("Consolas", 38F);
            this.operatorStatusLabel.ForeColor = System.Drawing.Color.Black;
            this.operatorStatusLabel.Location = new System.Drawing.Point(46, 193);
            this.operatorStatusLabel.Name = "operatorStatusLabel";
            this.operatorStatusLabel.Size = new System.Drawing.Size(872, 75);
            this.operatorStatusLabel.TabIndex = 1;
            this.operatorStatusLabel.Text = "OPERADOR NÃO AUTORIZADO:";
            // 
            // operatorNameLabel
            // 
            this.operatorNameLabel.AutoSize = true;
            this.operatorNameLabel.Font = new System.Drawing.Font("Consolas", 40F);
            this.operatorNameLabel.Location = new System.Drawing.Point(119, 303);
            this.operatorNameLabel.Name = "operatorNameLabel";
            this.operatorNameLabel.Size = new System.Drawing.Size(700, 79);
            this.operatorNameLabel.TabIndex = 2;
            this.operatorNameLabel.Text = "Guilherme Oliveira";
            // 
            // OperatorIdLabel
            // 
            this.OperatorIdLabel.AutoSize = true;
            this.OperatorIdLabel.Font = new System.Drawing.Font("Consolas", 38F);
            this.OperatorIdLabel.Location = new System.Drawing.Point(210, 392);
            this.OperatorIdLabel.Name = "OperatorIdLabel";
            this.OperatorIdLabel.Size = new System.Drawing.Size(522, 75);
            this.OperatorIdLabel.TabIndex = 3;
            this.OperatorIdLabel.Text = "ID: 2406292014";
            // 
            // BadgeCheckingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1040, 510);
            this.Controls.Add(this.OperatorIdLabel);
            this.Controls.Add(this.operatorNameLabel);
            this.Controls.Add(this.operatorStatusLabel);
            this.Controls.Add(this.bypassRequestedLabel);
            this.Name = "BadgeCheckingForm";
            this.Text = "BadgeCheckingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bypassRequestedLabel;
        private System.Windows.Forms.Label operatorStatusLabel;
        private System.Windows.Forms.Label operatorNameLabel;
        private System.Windows.Forms.Label OperatorIdLabel;
    }
}
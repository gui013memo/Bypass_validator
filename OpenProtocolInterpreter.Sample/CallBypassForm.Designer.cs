using System.Drawing;
using System.Windows.Forms;

namespace OpenProtocolInterpreter.Sample
{
    partial class CallBypassForm
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
            this.bypassLabelBlinkingTimer = new System.Windows.Forms.Timer(this.components);
            this.focusTimer = new System.Windows.Forms.Timer(this.components);
            this.callBypassButtonLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bypassLabelBlinkingTimer
            // 
            this.bypassLabelBlinkingTimer.Interval = 500;
            this.bypassLabelBlinkingTimer.Tick += new System.EventHandler(this.bypassLabelBlinkingTimer_Tick);
            // 
            // focusTimer
            // 
            this.focusTimer.Tick += new System.EventHandler(this.focusTimer_Tick);
            // 
            // callBypassButtonLabel
            // 
            this.callBypassButtonLabel.AutoSize = true;
            this.callBypassButtonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.callBypassButtonLabel.ForeColor = System.Drawing.Color.Yellow;
            this.callBypassButtonLabel.Location = new System.Drawing.Point(13, 12);
            this.callBypassButtonLabel.Name = "callBypassButtonLabel";
            this.callBypassButtonLabel.Size = new System.Drawing.Size(103, 17);
            this.callBypassButtonLabel.TabIndex = 0;
            this.callBypassButtonLabel.Text = "BYPASS OFF";
            this.callBypassButtonLabel.Click += new System.EventHandler(this.callBypassButtonLabel_Click);
            // 
            // CallBypassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(130, 40);
            this.Controls.Add(this.callBypassButtonLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(1016, 1027);
            this.Name = "CallBypassForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Timer bypassLabelBlinkingTimer;
        private Timer focusTimer;
        private Label callBypassButtonLabel;
    }
}
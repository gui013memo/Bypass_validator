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
            this.bypassRequestButton = new System.Windows.Forms.Button();
            this.bypassLabelBlinkingTimer = new System.Windows.Forms.Timer(this.components);
            this.focusTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // bypassRequestButton
            // 
            this.bypassRequestButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(107)))));
            this.bypassRequestButton.FlatAppearance.BorderSize = 0;
            this.bypassRequestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bypassRequestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bypassRequestButton.ForeColor = System.Drawing.Color.Yellow;
            this.bypassRequestButton.Location = new System.Drawing.Point(5, 2);
            this.bypassRequestButton.Name = "bypassRequestButton";
            this.bypassRequestButton.Size = new System.Drawing.Size(120, 35);
            this.bypassRequestButton.TabIndex = 0;
            this.bypassRequestButton.Text = "BYPASS OFF";
            this.bypassRequestButton.UseVisualStyleBackColor = true;
            this.bypassRequestButton.Click += new System.EventHandler(this.bypassRequestButton_Click);
            // 
            // bypassLabelBlinkingTimer
            // 
            this.bypassLabelBlinkingTimer.Tick += new System.EventHandler(this.bypassLabelBlinkingTimer_Tick);
            // 
            // focusTimer
            // 
            this.focusTimer.Tick += new System.EventHandler(this.focusTimer_Tick);
            // 
            // CallBypassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(130, 40);
            this.Controls.Add(this.bypassRequestButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(1016, 1027);
            this.Name = "CallBypassForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        public Button bypassRequestButton;
        private Timer bypassLabelBlinkingTimer;
        private Timer focusTimer;
    }
}
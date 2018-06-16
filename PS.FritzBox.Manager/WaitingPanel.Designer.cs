namespace PS.FritzBox.Manager
{
    partial class WaitingPanel
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWaitingMessage = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lblWaitingMessage
            // 
            this.lblWaitingMessage.Location = new System.Drawing.Point(23, 15);
            this.lblWaitingMessage.Name = "lblWaitingMessage";
            this.lblWaitingMessage.Size = new System.Drawing.Size(474, 36);
            this.lblWaitingMessage.TabIndex = 0;
            this.lblWaitingMessage.Text = "label1";
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(26, 55);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(471, 23);
            this.progress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progress.TabIndex = 1;
            // 
            // WaitingPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.progress);
            this.Controls.Add(this.lblWaitingMessage);
            this.Name = "WaitingPanel";
            this.Size = new System.Drawing.Size(512, 89);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWaitingMessage;
        private System.Windows.Forms.ProgressBar progress;
    }
}

namespace PS.FritzBox.Manager.Modules
{
    partial class OnlineMonitorModule
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OnlineMonitorModule));
            this.imlConnectionState = new System.Windows.Forms.ImageList(this.components);
            this.imlUpDown = new System.Windows.Forms.ImageList(this.components);
            this.gbxConnectionInfo = new System.Windows.Forms.GroupBox();
            this.lblIPAddress = new System.Windows.Forms.Label();
            this.lblPortMappings = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDNSServers = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUpstreamMax = new System.Windows.Forms.Label();
            this.lblDownStreamMax = new System.Windows.Forms.Label();
            this.lblConnectionState = new System.Windows.Forms.Label();
            this.lblConnectionType = new System.Windows.Forms.Label();
            this.gbxReconnect = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnReconnect = new System.Windows.Forms.Button();
            this.gbxWorkLoad = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxConnectionInfo.SuspendLayout();
            this.gbxReconnect.SuspendLayout();
            this.gbxWorkLoad.SuspendLayout();
            this.SuspendLayout();
            // 
            // imlConnectionState
            // 
            this.imlConnectionState.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlConnectionState.ImageStream")));
            this.imlConnectionState.TransparentColor = System.Drawing.Color.Transparent;
            this.imlConnectionState.Images.SetKeyName(0, "icons8-verbunden-32.png");
            this.imlConnectionState.Images.SetKeyName(1, "icons8-getrennt-32.png");
            // 
            // imlUpDown
            // 
            this.imlUpDown.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlUpDown.ImageStream")));
            this.imlUpDown.TransparentColor = System.Drawing.Color.Transparent;
            this.imlUpDown.Images.SetKeyName(0, "icons8-sortieren-runter-32.png");
            this.imlUpDown.Images.SetKeyName(1, "icons8-sortieren-hoch-32.png");
            // 
            // gbxConnectionInfo
            // 
            this.gbxConnectionInfo.Controls.Add(this.lblIPAddress);
            this.gbxConnectionInfo.Controls.Add(this.lblPortMappings);
            this.gbxConnectionInfo.Controls.Add(this.label3);
            this.gbxConnectionInfo.Controls.Add(this.lblDNSServers);
            this.gbxConnectionInfo.Controls.Add(this.label1);
            this.gbxConnectionInfo.Controls.Add(this.lblUpstreamMax);
            this.gbxConnectionInfo.Controls.Add(this.lblDownStreamMax);
            this.gbxConnectionInfo.Controls.Add(this.lblConnectionState);
            this.gbxConnectionInfo.Controls.Add(this.lblConnectionType);
            this.gbxConnectionInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxConnectionInfo.Location = new System.Drawing.Point(0, 0);
            this.gbxConnectionInfo.Name = "gbxConnectionInfo";
            this.gbxConnectionInfo.Size = new System.Drawing.Size(605, 89);
            this.gbxConnectionInfo.TabIndex = 0;
            this.gbxConnectionInfo.TabStop = false;
            this.gbxConnectionInfo.Text = "Internet connection";
            // 
            // lblIPAddress
            // 
            this.lblIPAddress.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblIPAddress.ImageIndex = 1;
            this.lblIPAddress.Location = new System.Drawing.Point(436, 25);
            this.lblIPAddress.Name = "lblIPAddress";
            this.lblIPAddress.Size = new System.Drawing.Size(100, 13);
            this.lblIPAddress.TabIndex = 18;
            this.lblIPAddress.Text = "000.000.000";
            this.lblIPAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPortMappings
            // 
            this.lblPortMappings.Location = new System.Drawing.Point(118, 63);
            this.lblPortMappings.Name = "lblPortMappings";
            this.lblPortMappings.Size = new System.Drawing.Size(418, 13);
            this.lblPortMappings.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Port mappings:";
            // 
            // lblDNSServers
            // 
            this.lblDNSServers.Location = new System.Drawing.Point(118, 44);
            this.lblDNSServers.Name = "lblDNSServers";
            this.lblDNSServers.Size = new System.Drawing.Size(418, 13);
            this.lblDNSServers.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "DNS-Servers:";
            // 
            // lblUpstreamMax
            // 
            this.lblUpstreamMax.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUpstreamMax.ImageIndex = 1;
            this.lblUpstreamMax.ImageList = this.imlUpDown;
            this.lblUpstreamMax.Location = new System.Drawing.Point(330, 25);
            this.lblUpstreamMax.Name = "lblUpstreamMax";
            this.lblUpstreamMax.Size = new System.Drawing.Size(100, 13);
            this.lblUpstreamMax.TabIndex = 13;
            this.lblUpstreamMax.Text = "      0,0 Mbit/s";
            this.lblUpstreamMax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDownStreamMax
            // 
            this.lblDownStreamMax.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDownStreamMax.ImageIndex = 0;
            this.lblDownStreamMax.ImageList = this.imlUpDown;
            this.lblDownStreamMax.Location = new System.Drawing.Point(224, 25);
            this.lblDownStreamMax.Name = "lblDownStreamMax";
            this.lblDownStreamMax.Size = new System.Drawing.Size(100, 13);
            this.lblDownStreamMax.TabIndex = 12;
            this.lblDownStreamMax.Text = "      0,0 Mbit/s";
            this.lblDownStreamMax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblConnectionState
            // 
            this.lblConnectionState.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblConnectionState.ImageIndex = 1;
            this.lblConnectionState.ImageList = this.imlConnectionState;
            this.lblConnectionState.Location = new System.Drawing.Point(118, 25);
            this.lblConnectionState.Name = "lblConnectionState";
            this.lblConnectionState.Size = new System.Drawing.Size(100, 13);
            this.lblConnectionState.TabIndex = 11;
            this.lblConnectionState.Text = "      Disconnected";
            this.lblConnectionState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblConnectionType
            // 
            this.lblConnectionType.Location = new System.Drawing.Point(12, 25);
            this.lblConnectionType.Name = "lblConnectionType";
            this.lblConnectionType.Size = new System.Drawing.Size(100, 13);
            this.lblConnectionType.TabIndex = 10;
            this.lblConnectionType.Text = "DSL";
            // 
            // gbxReconnect
            // 
            this.gbxReconnect.Controls.Add(this.btnReconnect);
            this.gbxReconnect.Controls.Add(this.label11);
            this.gbxReconnect.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxReconnect.Location = new System.Drawing.Point(0, 89);
            this.gbxReconnect.Name = "gbxReconnect";
            this.gbxReconnect.Size = new System.Drawing.Size(605, 89);
            this.gbxReconnect.TabIndex = 1;
            this.gbxReconnect.TabStop = false;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.Location = new System.Drawing.Point(12, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(587, 27);
            this.label11.TabIndex = 10;
            this.label11.Text = resources.GetString("label11.Text");
            // 
            // btnReconnect
            // 
            this.btnReconnect.Location = new System.Drawing.Point(15, 56);
            this.btnReconnect.Name = "btnReconnect";
            this.btnReconnect.Size = new System.Drawing.Size(75, 23);
            this.btnReconnect.TabIndex = 11;
            this.btnReconnect.Text = "Reconnect";
            this.btnReconnect.UseVisualStyleBackColor = true;
            // 
            // gbxWorkLoad
            // 
            this.gbxWorkLoad.Controls.Add(this.label2);
            this.gbxWorkLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxWorkLoad.Location = new System.Drawing.Point(0, 178);
            this.gbxWorkLoad.Name = "gbxWorkLoad";
            this.gbxWorkLoad.Size = new System.Drawing.Size(605, 312);
            this.gbxWorkLoad.TabIndex = 2;
            this.gbxWorkLoad.TabStop = false;
            this.gbxWorkLoad.Text = "Current workload of the internet conneciton";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(587, 46);
            this.label2.TabIndex = 11;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // OnlineMonitorModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbxWorkLoad);
            this.Controls.Add(this.gbxReconnect);
            this.Controls.Add(this.gbxConnectionInfo);
            this.Icon = global::PS.FritzBox.Manager.Properties.Resources.icons8_flächendiagramm_32;
            this.Name = "OnlineMonitorModule";
            this.Size = new System.Drawing.Size(605, 490);
            this.gbxConnectionInfo.ResumeLayout(false);
            this.gbxReconnect.ResumeLayout(false);
            this.gbxWorkLoad.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imlConnectionState;
        private System.Windows.Forms.ImageList imlUpDown;
        private System.Windows.Forms.GroupBox gbxConnectionInfo;
        private System.Windows.Forms.Label lblIPAddress;
        private System.Windows.Forms.Label lblPortMappings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDNSServers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUpstreamMax;
        private System.Windows.Forms.Label lblDownStreamMax;
        private System.Windows.Forms.Label lblConnectionState;
        private System.Windows.Forms.Label lblConnectionType;
        private System.Windows.Forms.GroupBox gbxReconnect;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnReconnect;
        private System.Windows.Forms.GroupBox gbxWorkLoad;
        private System.Windows.Forms.Label label2;
    }
}

namespace PS.FritzBox.Manager
{
    partial class FrmMain
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.miProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.stateBar = new PS.Windows.Forms.StatusBar();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeNavigation = new System.Windows.Forms.TreeView();
            this.imlTree = new System.Windows.Forms.ImageList(this.components);
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lvModules = new System.Windows.Forms.ListView();
            this.clmModuleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtPath = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miProgram,
            this.miAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // miProgram
            // 
            this.miProgram.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miExit});
            this.miProgram.Name = "miProgram";
            this.miProgram.Size = new System.Drawing.Size(65, 20);
            this.miProgram.Text = "&Program";
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(92, 22);
            this.miExit.Text = "&Exit";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // miAbout
            // 
            this.miAbout.Name = "miAbout";
            this.miAbout.Size = new System.Drawing.Size(24, 20);
            this.miAbout.Text = "?";
            this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
            // 
            // stateBar
            // 
            this.stateBar.Location = new System.Drawing.Point(0, 537);
            this.stateBar.Name = "stateBar";
            this.stateBar.Size = new System.Drawing.Size(784, 24);
            this.stateBar.SizingGrip = false;
            this.stateBar.StateColor = System.Drawing.SystemColors.Control;
            this.stateBar.StateText = "";
            this.stateBar.TabIndex = 1;
            this.stateBar.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeNavigation);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pnlMain);
            this.splitContainer1.Size = new System.Drawing.Size(784, 513);
            this.splitContainer1.SplitterDistance = 175;
            this.splitContainer1.TabIndex = 2;
            // 
            // treeNavigation
            // 
            this.treeNavigation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeNavigation.ImageIndex = 0;
            this.treeNavigation.ImageList = this.imlTree;
            this.treeNavigation.Location = new System.Drawing.Point(0, 0);
            this.treeNavigation.Name = "treeNavigation";
            this.treeNavigation.SelectedImageIndex = 0;
            this.treeNavigation.Size = new System.Drawing.Size(175, 513);
            this.treeNavigation.TabIndex = 0;
            this.treeNavigation.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeNavigation_AfterSelect);
            // 
            // imlTree
            // 
            this.imlTree.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlTree.ImageStream")));
            this.imlTree.TransparentColor = System.Drawing.Color.Transparent;
            this.imlTree.Images.SetKeyName(0, "icons8-internet-32.png");
            this.imlTree.Images.SetKeyName(1, "icons8-zuhause-32.png");
            this.imlTree.Images.SetKeyName(2, "icons8-wlan-32.png");
            this.imlTree.Images.SetKeyName(3, "icons8-systemaufgabe-32.png");
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.lvModules);
            this.pnlMain.Controls.Add(this.txtPath);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(605, 513);
            this.pnlMain.TabIndex = 0;
            // 
            // lvModules
            // 
            this.lvModules.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvModules.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmModuleName,
            this.clmDescription});
            this.lvModules.FullRowSelect = true;
            this.lvModules.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvModules.Location = new System.Drawing.Point(-1, 22);
            this.lvModules.MultiSelect = false;
            this.lvModules.Name = "lvModules";
            this.lvModules.Size = new System.Drawing.Size(605, 490);
            this.lvModules.SmallImageList = this.imlTree;
            this.lvModules.TabIndex = 1;
            this.lvModules.UseCompatibleStateImageBehavior = false;
            this.lvModules.View = System.Windows.Forms.View.Details;
            this.lvModules.DoubleClick += new System.EventHandler(this.lvModules_DoubleClick);
            // 
            // clmModuleName
            // 
            this.clmModuleName.Text = "Modulename";
            this.clmModuleName.Width = 150;
            // 
            // clmDescription
            // 
            this.clmDescription.Text = "Description";
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtPath.Location = new System.Drawing.Point(0, 0);
            this.txtPath.Multiline = true;
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(603, 20);
            this.txtPath.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.stateBar);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FrmMain";
            this.Text = "PS FritzBox Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miProgram;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripMenuItem miAbout;
        private PS.Windows.Forms.StatusBar stateBar;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeNavigation;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.ImageList imlTree;
        private System.Windows.Forms.ListView lvModules;
        private System.Windows.Forms.ColumnHeader clmModuleName;
        private System.Windows.Forms.ColumnHeader clmDescription;
    }
}


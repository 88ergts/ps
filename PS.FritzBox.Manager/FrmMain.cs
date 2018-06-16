using PS.FritzBox.API;
using PS.FritzBox.Manager.Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PS.FritzBox.Manager
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            Properties.Settings.Default.Upgrade();
            this.clmDescription.Width = -2;
            this.lvModules.SizeChanged += (sender, e) => this.clmDescription.Width = -2;
            this._connectionSettings.Timeout = 10;
        }

        /// <summary>
        /// the modules
        /// </summary>
        private ModuleBase[] _modules;

        /// <summary>
        /// the connection settings
        /// </summary>
        ConnectionSettings _connectionSettings = new ConnectionSettings();

        /// <summary>
        /// the current module
        /// </summary>
        private ModuleBase _currentModule = null;

        private void miAbout_Click(object sender, EventArgs e)
        {
            PS.Windows.Forms.AboutDialog dlgAbout = new Windows.Forms.AboutDialog();
            dlgAbout.ShowDialog();
        }

        protected async override void OnShown(EventArgs e)
        {
            Control ctrl = this.ShowWaintingPanel("Searching for devices in the local network. Please wait...");
            DeviceLocator locator = new DeviceLocator();
            IEnumerable<FritzDevice> devices = await locator.DiscoverAsync();
    
            this.Controls.Remove(ctrl);
            if (devices.Count() == 0)
            {
                MessageBox.Show("No Fritz!Box devices found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                FritzDevice device = this.ShowConnectionSettings(devices);
                this.BuildTree(device);
            }

            base.OnShown(e);
        }

        private Control ShowWaintingPanel(string message)
        {
            WaitingPanel panel = new WaitingPanel(message);
            panel.Left = (this.Width - panel.Width) / 2;
            panel.Top = (this.Height - panel.Height) / 2;
            this.Controls.Add(panel);
            panel.BringToFront();
            return panel;
        }

        /// <summary>
        /// Method to show the connection settings
        /// </summary>
        private FritzDevice ShowConnectionSettings(IEnumerable<FritzDevice> devices)
        {
            FrmConnectionSettings settings = new FrmConnectionSettings();
            settings.ConnectionSettings = this._connectionSettings;
            settings.Devices = devices;
            settings.StartPosition = FormStartPosition.CenterParent;
            settings.ShowDialog();

            return settings.SelectedDevice;
        }

        /// <summary>
        /// Method to build the tree
        /// </summary>
        private void BuildTree(FritzDevice device)
        {
            // add category nodes
            this.BuildCategoryNode("System", ModuleCategory.System);
            this.BuildCategoryNode("Internet", ModuleCategory.Internet);
            this.BuildCategoryNode("Home Network", ModuleCategory.HomeNetwork);
            this.BuildCategoryNode("WLAN", ModuleCategory.WLAN);

            this._modules = this.GetModules();
            foreach(ModuleBase module in this._modules)
            {
                this.AppendModule(module, device);
            }
        }

        /// <summary>
        /// Method to build a root node
        /// </summary>
        /// <param name="title">the title</param>
        /// <param name="category">the category</param>
        private void BuildCategoryNode(string title, ModuleCategory category)
        {
            TreeNode node = this.treeNavigation.Nodes.Add(title);
            node.Tag = category;
            node.ImageIndex = (Int32)category;
            node.SelectedImageIndex = node.ImageIndex;
        }

        /// <summary>
        /// Method to append a module to the tree
        /// </summary>
        /// <param name="module">the module</param>
        private void AppendModule(ModuleBase module, FritzDevice device)
        {
            foreach(TreeNode categoryNode in this.treeNavigation.Nodes)
            {
                if(categoryNode.Tag.Equals(module.Category))
                {
                    TreeNode moduleNode = categoryNode.Nodes.Add(module.Name);
                    moduleNode.Tag = module;
                    this.imlTree.Images.Add(module.Icon);
                    moduleNode.ImageIndex =
                    moduleNode.SelectedImageIndex = this.imlTree.Images.Count-1;
                    module.ConnectionSettings = this._connectionSettings;
                    module.FritzDevice = device;
                }
            }
        }

        /// <summary>
        /// Method to get the valid modules
        /// </summary>
        /// <returns></returns>
        private ModuleBase[] GetModules()
        {
            return new ModuleBase[]
            {                
                new OnlineMonitorModule(),
                new PortMappingsModule(),
                new InternetEventsModule(),
                new DynamicDNSModule(),
                new HomeNetworkOverviewModule()
            };
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// eventhandler after select
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeNavigation_AfterSelect(object sender, TreeViewEventArgs e)
        {
            this.txtPath.Text = e.Node.FullPath;
            this.pnlMain.Controls.Remove(this._currentModule);
            if(e.Node.Tag is ModuleBase)
            {
                ModuleBase module = e.Node.Tag as ModuleBase;
                this._currentModule = module;
                this._currentModule.Height = this.lvModules.Height;
                this._currentModule.Width = this.lvModules.Width;
                this._currentModule.Top = this.lvModules.Top;
                this._currentModule.Left = this.lvModules.Left;
                this._currentModule.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;                            
                this.pnlMain.Controls.Add(module);
                module.BringToFront();
                module.RefreshData();
            }
            else
            {
                this.lvModules.Items.Clear();
                foreach(TreeNode moduleNode in e.Node.Nodes)
                {
                    ModuleBase module = moduleNode.Tag as ModuleBase;
                    ListViewItem item = this.lvModules.Items.Add(module.Name, moduleNode.ImageIndex);
                    item.SubItems.Add(module.Description);
                    item.Tag = moduleNode;
                }
            }
        }

        private void lvModules_DoubleClick(object sender, EventArgs e)
        {
            if(this.lvModules.SelectedItems != null)
            {
                Point mousePoint = lvModules.PointToClient(Cursor.Position);
                ListViewItem item = lvModules.GetItemAt(mousePoint.X, mousePoint.Y);
                if(item != null)
                {
                    TreeNode node = item.Tag as TreeNode;
                    this.treeNavigation.SelectedNode = node;
                    this.treeNavigation.Focus();
                }
            }
        }
    }
}

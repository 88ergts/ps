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
            this.BuildTree();            
        }

        /// <summary>
        /// the modules
        /// </summary>
        private ModuleBase[] _modules;

        /// <summary>
        /// the current module
        /// </summary>
        private ModuleBase _currentModule = null;

        private void miAbout_Click(object sender, EventArgs e)
        {
            PS.Windows.Forms.AboutDialog dlgAbout = new Windows.Forms.AboutDialog();
            dlgAbout.ShowDialog();
        }

        /// <summary>
        /// Method to build the tree
        /// </summary>
        private void BuildTree()
        {
            // add category nodes
            this.BuildCategoryNode("System", ModuleCategory.System);
            this.BuildCategoryNode("Internet", ModuleCategory.Internet);
            this.BuildCategoryNode("Home Network", ModuleCategory.HomeNetwork);
            this.BuildCategoryNode("WLAN", ModuleCategory.WLAN);

            this._modules = this.GetModules();
            foreach(ModuleBase module in this._modules)
            {
                this.AppendModule(module);
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

        }

        /// <summary>
        /// Method to append a module to the tree
        /// </summary>
        /// <param name="module">the module</param>
        private void AppendModule(ModuleBase module)
        {
            foreach(TreeNode categoryNode in this.treeNavigation.Nodes)
            {
                if(categoryNode.Tag.Equals(module.Category))
                {
                    TreeNode moduleNode = categoryNode.Nodes.Add(module.Name);
                    moduleNode.Tag = module;                    
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
                new DeviceLogModule(),
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
                this._currentModule.Height = this.pnlMain.Height - this.txtPath.Height;
                this._currentModule.Width = this.pnlMain.Width;
                this._currentModule.Top = this.txtPath.Top + this.txtPath.Height;
                this.pnlMain.Controls.Add(module);
            }
        }
    }
}

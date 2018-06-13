using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PS.FritzBox.API;

namespace PS.FritzBox.Manager.Modules
{
    /// <summary>
    /// base class for modules
    /// </summary>
    public partial class ModuleBase : UserControl
    {
        public ModuleBase()
        {
            InitializeComponent();
           // this.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
        }

        /// <summary>
        /// Gets or sets the module category
        /// </summary>
        public ModuleCategory Category { get; set; } = ModuleCategory.Unknown;

        /// <summary>
        /// Gets or sets the connection settings
        /// </summary>
        public ConnectionSettings ConnectionSettings { get; set; }

        /// <summary>
        /// Gets or sets the description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the icon
        /// </summary>
        public Image Icon { get; set; }

        /// <summary>
        /// Method to refresh the viewd data
        /// </summary>
        public async virtual void RefreshData()
        {
        }
    }
}

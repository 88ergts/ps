using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PS.FritzBox.Manager.Modules
{
    public partial class PortMappingsModule : ModuleBase
    {
        public PortMappingsModule()
        {
            InitializeComponent();
            this.Category = ModuleCategory.Internet;
            this.Name = "Port mappings";
            this.Description = "Allows modification of port mapping settings.";
        }
    }
}

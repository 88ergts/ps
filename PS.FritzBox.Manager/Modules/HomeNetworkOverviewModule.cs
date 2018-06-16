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
    public partial class HomeNetworkOverviewModule : ModuleBase
    {
        public HomeNetworkOverviewModule()
        {
            InitializeComponent();
            this.Category = ModuleCategory.HomeNetwork;
            this.Name = "Overview";
            this.Description = "Lists connected devices.";          
        }
    }
}

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
    public partial class OnlineMonitorModule : ModuleBase
    {
        public OnlineMonitorModule()
        {
            InitializeComponent();
            this.Category = ModuleCategory.Internet;
            this.Name = "Online Monitor";
            this.Description = "The online monitor provides information about your Internet connection and enabled additional functions.";
        }
    }
}

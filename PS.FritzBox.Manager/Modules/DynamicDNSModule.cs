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
    public partial class DynamicDNSModule : ModuleBase
    {
        public DynamicDNSModule()
        {
            InitializeComponent();
            this.Name = "Dynamic DNS";
            this.Description = "Managing settings for dynamic dns access.";
            this.Category = ModuleCategory.Internet;
        }
    }
}

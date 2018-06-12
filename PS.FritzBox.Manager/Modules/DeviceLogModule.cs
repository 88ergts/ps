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
    public partial class DeviceLogModule : ModuleBase
    {
        public DeviceLogModule()
        {
            InitializeComponent();
            this.Category = ModuleCategory.System;
            this.Name = "DeviceLog";
        }
    }
}

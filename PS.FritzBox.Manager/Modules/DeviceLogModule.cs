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
    public partial class InternetEventsModule : ModuleBase
    {
        public InternetEventsModule()
        {
            InitializeComponent();
            this.Category = ModuleCategory.Internet;
            this.Name = "Events";
            this.Description = "Views device event log.";
        }

        /// <summary>
        /// Method to refresh the viewed data
        /// </summary>
        public override async void RefreshData()
        {
            // show waiter...
            try
            {
                if (this.FritzDevice.ContainsService<DeviceInfoClient>())
                {
                    var client = await this.FritzDevice.GetServiceClient<DeviceInfoClient>(this.ConnectionSettings);

                    var log = await client.GetDeviceLogAsync();

                    this.rtbLog.Clear();
                    foreach (var entry in log)
                        this.rtbLog.Text += $"{entry}{Environment.NewLine}";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Failed reading device log.{Environment.NewLine}{ex}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
    }
}

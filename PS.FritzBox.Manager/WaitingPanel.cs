using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PS.FritzBox.Manager
{
    public partial class WaitingPanel : UserControl
    {
        public WaitingPanel(string message)
        {
            InitializeComponent();
            this.lblWaitingMessage.Text = message;
        }

        /// <summary>
        /// Method to update the message
        /// </summary>
        /// <param name="message">the updated message</param>
        public void UpdateMessage(string message)
        {
            this.lblWaitingMessage.Text = message;
        }
    }
}

using PS.FritzBox.API;
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
    public partial class FrmConnectionSettings : Form
    {
        public FrmConnectionSettings()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets or sets the connection settings
        /// </summary>
        public ConnectionSettings ConnectionSettings { get; set; }

        /// <summary>
        /// overidden load method
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLoad(EventArgs e)
        {
            this.txtBaseUrl.Text = this.ConnectionSettings.BaseUrl;
            this.txtPassword.Text = this.ConnectionSettings.Password;
            this.txtUserName.Text = this.ConnectionSettings.UserName;
            base.OnLoad(e);
        }

        /// <summary>
        /// Method to validate the inputs
        /// </summary>
        private void ValidateInputs()
        {
            bool urlValid = Uri.TryCreate(this.txtBaseUrl.Text, UriKind.Absolute, out Uri result);
            bool userDataValid = true;
            if(!String.IsNullOrEmpty(this.txtPassword.Text))
            {
                userDataValid = !String.IsNullOrEmpty(this.txtUserName.Text);
            }

            this.btnOK.Enabled = urlValid && userDataValid;
        }

        private void txtBaseUrl_TextChanged(object sender, EventArgs e)
        {
            if (sender == this.txtUserName)
                this.ConnectionSettings.UserName = this.txtUserName.Text;
            else if (sender == this.txtPassword)
                this.ConnectionSettings.Password = this.txtPassword.Text;
            else if (sender == this.txtBaseUrl)
                this.ConnectionSettings.BaseUrl = this.txtBaseUrl.Text;

            this.ValidateInputs();
        }
    }
}

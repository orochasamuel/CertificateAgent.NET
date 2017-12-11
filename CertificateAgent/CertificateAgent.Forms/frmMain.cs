using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CertificateAgent.Core;

namespace CertificateAgent.Forms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnChooseCertificate_Click(object sender, EventArgs e)
        {
            var choose = DigitalCertificateAgent.ChooseCertificate();

            txtSerialNumber.Text = choose.GetSerialNumberString();
            dtpExpirationTime.Value = Convert.ToDateTime(choose.GetExpirationDateString());
            txtFriendlyName.Text = choose.FriendlyName;
        }
    }
}

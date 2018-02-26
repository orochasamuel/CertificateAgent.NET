using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CertificateAgent.Core;

namespace CertificateAgent.Forms
{
    public partial class frmMain : Form
    {
        private X509Certificate2 _certificate;

        public frmMain()
        {
            InitializeComponent();
        }

        private void PopulateForm(X509Certificate2 certificate)
        {
            txtSerialNumber.Text = certificate.GetSerialNumberString();
            dtpExpirationTime.Value = Convert.ToDateTime(certificate.GetExpirationDateString());
            txtFriendlyName.Text = certificate.FriendlyName;
            lblIsValid.Text = DigitalCertificateAgent.IsValid(certificate) ? "VÁLIDO" : "INVÁLIDO";
        }

        private void btnChooseCertificate_Click(object sender, EventArgs e)
        {
            try
            {
                _certificate = DigitalCertificateAgent.ChooseCertificate();
                PopulateForm(_certificate);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show(exception.Message);
            }
        }

        private void btnExportToBase64String_Click(object sender, EventArgs e)
        {
            if (_certificate is null)
            {
                MessageBox.Show("O certificado não foi selecionado!");
                return;
            }

            txtResult.ResetText();
            txtResult.Text = DigitalCertificateAgent.ConvertToBase64(DigitalCertificateAgent.ConvertToBytes(_certificate, txtPassword.Text));
        }

        private void btnImportFromBase64String_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not implemented!");
        }
    }
}

namespace CertificateAgent.Forms
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnChooseCertificate = new System.Windows.Forms.Button();
            this.txtFriendlyName = new System.Windows.Forms.TextBox();
            this.lblFriendlyName = new System.Windows.Forms.Label();
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpExpirationTime = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnExportToBase64String = new System.Windows.Forms.Button();
            this.btnImportFromBase64String = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChooseCertificate
            // 
            this.btnChooseCertificate.BackColor = System.Drawing.Color.White;
            this.btnChooseCertificate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseCertificate.Location = new System.Drawing.Point(12, 12);
            this.btnChooseCertificate.Name = "btnChooseCertificate";
            this.btnChooseCertificate.Size = new System.Drawing.Size(100, 110);
            this.btnChooseCertificate.TabIndex = 0;
            this.btnChooseCertificate.Text = "&Selecionar certificado";
            this.btnChooseCertificate.UseVisualStyleBackColor = false;
            this.btnChooseCertificate.Click += new System.EventHandler(this.btnChooseCertificate_Click);
            // 
            // txtFriendlyName
            // 
            this.txtFriendlyName.Location = new System.Drawing.Point(6, 81);
            this.txtFriendlyName.Name = "txtFriendlyName";
            this.txtFriendlyName.ReadOnly = true;
            this.txtFriendlyName.Size = new System.Drawing.Size(357, 20);
            this.txtFriendlyName.TabIndex = 1;
            // 
            // lblFriendlyName
            // 
            this.lblFriendlyName.AutoSize = true;
            this.lblFriendlyName.Location = new System.Drawing.Point(3, 65);
            this.lblFriendlyName.Name = "lblFriendlyName";
            this.lblFriendlyName.Size = new System.Drawing.Size(81, 13);
            this.lblFriendlyName.TabIndex = 2;
            this.lblFriendlyName.Text = "Nome Amigável";
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.Location = new System.Drawing.Point(6, 42);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.ReadOnly = true;
            this.txtSerialNumber.Size = new System.Drawing.Size(236, 20);
            this.txtSerialNumber.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data de Validade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número de Série";
            // 
            // dtpExpirationTime
            // 
            this.dtpExpirationTime.CustomFormat = "dddd, dd \'de\' MMMM \'de\' yyyy \'às\' HH:mm";
            this.dtpExpirationTime.Enabled = false;
            this.dtpExpirationTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpExpirationTime.Location = new System.Drawing.Point(248, 42);
            this.dtpExpirationTime.Name = "dtpExpirationTime";
            this.dtpExpirationTime.Size = new System.Drawing.Size(300, 20);
            this.dtpExpirationTime.TabIndex = 3;
            this.dtpExpirationTime.Value = new System.DateTime(2017, 12, 11, 4, 48, 17, 0);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpExpirationTime);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtFriendlyName);
            this.groupBox1.Controls.Add(this.txtSerialNumber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblFriendlyName);
            this.groupBox1.Location = new System.Drawing.Point(118, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 110);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Certificado";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnImportFromBase64String);
            this.groupBox2.Controls.Add(this.btnExportToBase64String);
            this.groupBox2.Controls.Add(this.groupBoxResult);
            this.groupBox2.Location = new System.Drawing.Point(12, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(660, 321);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Conversão";
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.txtResult);
            this.groupBoxResult.Location = new System.Drawing.Point(162, 19);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(492, 296);
            this.groupBoxResult.TabIndex = 2;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Resultado";
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.SystemColors.Control;
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.Location = new System.Drawing.Point(3, 16);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(486, 277);
            this.txtResult.TabIndex = 0;
            // 
            // btnExportToBase64String
            // 
            this.btnExportToBase64String.BackColor = System.Drawing.Color.White;
            this.btnExportToBase64String.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportToBase64String.Location = new System.Drawing.Point(6, 19);
            this.btnExportToBase64String.Name = "btnExportToBase64String";
            this.btnExportToBase64String.Size = new System.Drawing.Size(150, 25);
            this.btnExportToBase64String.TabIndex = 3;
            this.btnExportToBase64String.Text = "Exportar p/ Base64String";
            this.btnExportToBase64String.UseVisualStyleBackColor = false;
            this.btnExportToBase64String.Click += new System.EventHandler(this.btnExportToBase64String_Click);
            // 
            // btnImportFromBase64String
            // 
            this.btnImportFromBase64String.BackColor = System.Drawing.Color.White;
            this.btnImportFromBase64String.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportFromBase64String.Location = new System.Drawing.Point(6, 50);
            this.btnImportFromBase64String.Name = "btnImportFromBase64String";
            this.btnImportFromBase64String.Size = new System.Drawing.Size(150, 25);
            this.btnImportFromBase64String.TabIndex = 3;
            this.btnImportFromBase64String.Text = "Importar de Base64String";
            this.btnImportFromBase64String.UseVisualStyleBackColor = false;
            this.btnImportFromBase64String.Click += new System.EventHandler(this.btnImportFromBase64String_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(369, 81);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(179, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Senha";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnChooseCertificate);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Certificate Agent";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChooseCertificate;
        private System.Windows.Forms.TextBox txtFriendlyName;
        private System.Windows.Forms.Label lblFriendlyName;
        private System.Windows.Forms.TextBox txtSerialNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpExpirationTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExportToBase64String;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnImportFromBase64String;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
    }
}
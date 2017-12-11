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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChooseCertificate
            // 
            this.btnChooseCertificate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnChooseCertificate.FlatAppearance.BorderSize = 0;
            this.btnChooseCertificate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseCertificate.ForeColor = System.Drawing.Color.White;
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
            this.txtFriendlyName.Size = new System.Drawing.Size(542, 20);
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
            this.groupBox1.Controls.Add(this.txtFriendlyName);
            this.groupBox1.Controls.Add(this.txtSerialNumber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblFriendlyName);
            this.groupBox1.Location = new System.Drawing.Point(118, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 110);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Certificado";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnChooseCertificate);
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Certificate Agent - DEMO";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}
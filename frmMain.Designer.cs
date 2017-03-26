namespace CryptoCram
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
            this.components = new System.ComponentModel.Container();
            this.btnSelect = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.lstFilesSelected = new System.Windows.Forms.ListBox();
            this.lblEncrypt = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.dtpDecrypt = new System.Windows.Forms.DateTimePicker();
            this.btnRemoveSelectedFile = new System.Windows.Forms.Button();
            this.process1 = new System.Diagnostics.Process();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtHour = new System.Windows.Forms.TextBox();
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.lblFirstDelineator = new System.Windows.Forms.Label();
            this.lblSecondDelineator = new System.Windows.Forms.Label();
            this.txtSeconds = new System.Windows.Forms.TextBox();
            this.cmbMeridian = new System.Windows.Forms.ComboBox();
            this.grpDecrypt = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grpDecrypt.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(22, 12);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Select File";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lstFilesSelected
            // 
            this.lstFilesSelected.FormattingEnabled = true;
            this.lstFilesSelected.Location = new System.Drawing.Point(22, 62);
            this.lstFilesSelected.Name = "lstFilesSelected";
            this.lstFilesSelected.Size = new System.Drawing.Size(302, 173);
            this.lstFilesSelected.TabIndex = 1;
            // 
            // lblEncrypt
            // 
            this.lblEncrypt.AutoSize = true;
            this.lblEncrypt.Location = new System.Drawing.Point(19, 46);
            this.lblEncrypt.Name = "lblEncrypt";
            this.lblEncrypt.Size = new System.Drawing.Size(79, 13);
            this.lblEncrypt.TabIndex = 2;
            this.lblEncrypt.Text = "Files to Encrypt";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(249, 241);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(22, 356);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 4;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // dtpDecrypt
            // 
            this.dtpDecrypt.Location = new System.Drawing.Point(22, 294);
            this.dtpDecrypt.Name = "dtpDecrypt";
            this.dtpDecrypt.Size = new System.Drawing.Size(200, 20);
            this.dtpDecrypt.TabIndex = 5;
            // 
            // btnRemoveSelectedFile
            // 
            this.btnRemoveSelectedFile.Location = new System.Drawing.Point(121, 241);
            this.btnRemoveSelectedFile.Name = "btnRemoveSelectedFile";
            this.btnRemoveSelectedFile.Size = new System.Drawing.Size(122, 23);
            this.btnRemoveSelectedFile.TabIndex = 7;
            this.btnRemoveSelectedFile.Text = "Remove Selected File";
            this.btnRemoveSelectedFile.UseVisualStyleBackColor = true;
            this.btnRemoveSelectedFile.Click += new System.EventHandler(this.btnRemoveSelectedFile_Click);
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 19);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // txtHour
            // 
            this.txtHour.Location = new System.Drawing.Point(6, 46);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(41, 20);
            this.txtHour.TabIndex = 9;
            // 
            // txtMinutes
            // 
            this.txtMinutes.Location = new System.Drawing.Point(69, 46);
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.Size = new System.Drawing.Size(44, 20);
            this.txtMinutes.TabIndex = 10;
            // 
            // lblFirstDelineator
            // 
            this.lblFirstDelineator.AutoSize = true;
            this.lblFirstDelineator.Location = new System.Drawing.Point(53, 49);
            this.lblFirstDelineator.Name = "lblFirstDelineator";
            this.lblFirstDelineator.Size = new System.Drawing.Size(10, 13);
            this.lblFirstDelineator.TabIndex = 11;
            this.lblFirstDelineator.Text = ":";
            // 
            // lblSecondDelineator
            // 
            this.lblSecondDelineator.AutoSize = true;
            this.lblSecondDelineator.Location = new System.Drawing.Point(119, 49);
            this.lblSecondDelineator.Name = "lblSecondDelineator";
            this.lblSecondDelineator.Size = new System.Drawing.Size(10, 13);
            this.lblSecondDelineator.TabIndex = 13;
            this.lblSecondDelineator.Text = ":";
            // 
            // txtSeconds
            // 
            this.txtSeconds.Location = new System.Drawing.Point(135, 46);
            this.txtSeconds.Name = "txtSeconds";
            this.txtSeconds.Size = new System.Drawing.Size(44, 20);
            this.txtSeconds.TabIndex = 14;
            // 
            // cmbMeridian
            // 
            this.cmbMeridian.FormattingEnabled = true;
            this.cmbMeridian.Items.AddRange(new object[] {
            "PM"});
            this.cmbMeridian.Location = new System.Drawing.Point(185, 45);
            this.cmbMeridian.Name = "cmbMeridian";
            this.cmbMeridian.Size = new System.Drawing.Size(42, 21);
            this.cmbMeridian.TabIndex = 15;
            this.cmbMeridian.Text = "AM";
            // 
            // grpDecrypt
            // 
            this.grpDecrypt.Controls.Add(this.dateTimePicker1);
            this.grpDecrypt.Controls.Add(this.cmbMeridian);
            this.grpDecrypt.Controls.Add(this.txtHour);
            this.grpDecrypt.Controls.Add(this.txtSeconds);
            this.grpDecrypt.Controls.Add(this.txtMinutes);
            this.grpDecrypt.Controls.Add(this.lblSecondDelineator);
            this.grpDecrypt.Controls.Add(this.lblFirstDelineator);
            this.grpDecrypt.Location = new System.Drawing.Point(22, 274);
            this.grpDecrypt.Name = "grpDecrypt";
            this.grpDecrypt.Size = new System.Drawing.Size(262, 76);
            this.grpDecrypt.TabIndex = 16;
            this.grpDecrypt.TabStop = false;
            this.grpDecrypt.Text = "Decrypt file on";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 395);
            this.Controls.Add(this.grpDecrypt);
            this.Controls.Add(this.btnRemoveSelectedFile);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblEncrypt);
            this.Controls.Add(this.lstFilesSelected);
            this.Controls.Add(this.btnSelect);
            this.Name = "frmMain";
            this.Text = "CryptoCram";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpDecrypt.ResumeLayout(false);
            this.grpDecrypt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.ListBox lstFilesSelected;
        private System.Windows.Forms.Label lblEncrypt;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.DateTimePicker dtpDecrypt;
        private System.Windows.Forms.Button btnRemoveSelectedFile;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblFirstDelineator;
        private System.Windows.Forms.TextBox txtMinutes;
        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.ComboBox cmbMeridian;
        private System.Windows.Forms.TextBox txtSeconds;
        private System.Windows.Forms.Label lblSecondDelineator;
        private System.Windows.Forms.GroupBox grpDecrypt;
        private System.Windows.Forms.Timer timer1;
    }
}


namespace PrinterDrivesList
{
    partial class frmPrintMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrintMap));
            this.btnExport = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtDrivesNPrinters = new System.Windows.Forms.TextBox();
            this.btnRetrieveData = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCreatePrintBat = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpPrintServers = new System.Windows.Forms.GroupBox();
            this.rdoPPT = new System.Windows.Forms.RadioButton();
            this.rdoOlean = new System.Windows.Forms.RadioButton();
            this.rdoHouston = new System.Windows.Forms.RadioButton();
            this.txtPrintBatch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpPrintServers.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(559, 98);
            this.btnExport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(155, 27);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "• Export To Text";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(95, 358);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(324, 22);
            this.txtUserName.TabIndex = 1;
            // 
            // txtDrivesNPrinters
            // 
            this.txtDrivesNPrinters.Location = new System.Drawing.Point(15, 66);
            this.txtDrivesNPrinters.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDrivesNPrinters.Multiline = true;
            this.txtDrivesNPrinters.Name = "txtDrivesNPrinters";
            this.txtDrivesNPrinters.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDrivesNPrinters.Size = new System.Drawing.Size(524, 277);
            this.txtDrivesNPrinters.TabIndex = 2;
            // 
            // btnRetrieveData
            // 
            this.btnRetrieveData.Location = new System.Drawing.Point(559, 66);
            this.btnRetrieveData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRetrieveData.Name = "btnRetrieveData";
            this.btnRetrieveData.Size = new System.Drawing.Size(155, 27);
            this.btnRetrieveData.TabIndex = 0;
            this.btnRetrieveData.Text = "• Retrieve Data";
            this.btnRetrieveData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRetrieveData.UseVisualStyleBackColor = true;
            this.btnRetrieveData.Click += new System.EventHandler(this.RetrieveData_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(12, 361);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(77, 17);
            this.lblUsername.TabIndex = 3;
            this.lblUsername.Text = "Username:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(564, 318);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(155, 27);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCreatePrintBat
            // 
            this.btnCreatePrintBat.Location = new System.Drawing.Point(12, 123);
            this.btnCreatePrintBat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreatePrintBat.Name = "btnCreatePrintBat";
            this.btnCreatePrintBat.Size = new System.Drawing.Size(155, 27);
            this.btnCreatePrintBat.TabIndex = 6;
            this.btnCreatePrintBat.Text = "• Export Print Batch";
            this.btnCreatePrintBat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreatePrintBat.UseVisualStyleBackColor = true;
            this.btnCreatePrintBat.Click += new System.EventHandler(this.btnCreatePrintBat_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(83, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(398, 23);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Printer, PST && Mapped Drives Data Tool";
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.Location = new System.Drawing.Point(85, 38);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(343, 16);
            this.lblSubTitle.TabIndex = 9;
            this.lblSubTitle.Text = "Data Retrieval tool for exporting to text and batch file.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PrinterPSTDrivesList.Properties.Resources.PrinterDrivesPST;
            this.pictureBox1.Location = new System.Drawing.Point(15, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // grpPrintServers
            // 
            this.grpPrintServers.Controls.Add(this.rdoPPT);
            this.grpPrintServers.Controls.Add(this.rdoOlean);
            this.grpPrintServers.Controls.Add(this.rdoHouston);
            this.grpPrintServers.Controls.Add(this.btnCreatePrintBat);
            this.grpPrintServers.Location = new System.Drawing.Point(552, 145);
            this.grpPrintServers.Margin = new System.Windows.Forms.Padding(4);
            this.grpPrintServers.Name = "grpPrintServers";
            this.grpPrintServers.Padding = new System.Windows.Forms.Padding(4);
            this.grpPrintServers.Size = new System.Drawing.Size(197, 167);
            this.grpPrintServers.TabIndex = 14;
            this.grpPrintServers.TabStop = false;
            this.grpPrintServers.Text = "Print Servers";
            // 
            // rdoPPT
            // 
            this.rdoPPT.AutoSize = true;
            this.rdoPPT.Location = new System.Drawing.Point(12, 87);
            this.rdoPPT.Name = "rdoPPT";
            this.rdoPPT.Size = new System.Drawing.Size(105, 21);
            this.rdoPPT.TabIndex = 8;
            this.rdoPPT.TabStop = true;
            this.rdoPPT.Text = "DRPPTW03";
            this.rdoPPT.UseVisualStyleBackColor = true;
            // 
            // rdoOlean
            // 
            this.rdoOlean.AutoSize = true;
            this.rdoOlean.Location = new System.Drawing.Point(12, 59);
            this.rdoOlean.Margin = new System.Windows.Forms.Padding(4);
            this.rdoOlean.Name = "rdoOlean";
            this.rdoOlean.Size = new System.Drawing.Size(152, 21);
            this.rdoOlean.TabIndex = 7;
            this.rdoOlean.Text = "USOANCW029SRV";
            this.rdoOlean.UseVisualStyleBackColor = true;
            // 
            // rdoHouston
            // 
            this.rdoHouston.AutoSize = true;
            this.rdoHouston.Checked = true;
            this.rdoHouston.Location = new System.Drawing.Point(12, 31);
            this.rdoHouston.Margin = new System.Windows.Forms.Padding(4);
            this.rdoHouston.Name = "rdoHouston";
            this.rdoHouston.Size = new System.Drawing.Size(172, 21);
            this.rdoHouston.TabIndex = 7;
            this.rdoHouston.TabStop = true;
            this.rdoHouston.Text = "USHOUAMW6145SRV";
            this.rdoHouston.UseVisualStyleBackColor = true;
            // 
            // txtPrintBatch
            // 
            this.txtPrintBatch.Location = new System.Drawing.Point(15, 400);
            this.txtPrintBatch.Multiline = true;
            this.txtPrintBatch.Name = "txtPrintBatch";
            this.txtPrintBatch.Size = new System.Drawing.Size(404, 68);
            this.txtPrintBatch.TabIndex = 15;
            // 
            // frmPrintMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 396);
            this.Controls.Add(this.txtPrintBatch);
            this.Controls.Add(this.grpPrintServers);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSubTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtDrivesNPrinters);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnRetrieveData);
            this.Controls.Add(this.btnExport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPrintMap";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.frmPrintMap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpPrintServers.ResumeLayout(false);
            this.grpPrintServers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtDrivesNPrinters;
        private System.Windows.Forms.Button btnRetrieveData;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCreatePrintBat;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpPrintServers;
        private System.Windows.Forms.RadioButton rdoOlean;
        private System.Windows.Forms.RadioButton rdoHouston;
        private System.Windows.Forms.RadioButton rdoPPT;
        private System.Windows.Forms.TextBox txtPrintBatch;
    }
}


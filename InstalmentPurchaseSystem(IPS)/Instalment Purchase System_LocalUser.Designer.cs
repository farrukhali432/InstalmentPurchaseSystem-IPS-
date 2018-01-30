namespace InstalmentPurchaseSystem_IPS_
{
    partial class frmInstalmentPurchaseSystem_LocalUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInstalmentPurchaseSystem_LocalUser));
            this.lblInstmntPurchsSys = new System.Windows.Forms.Label();
            this.lblWelcme = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.rbCustomerRecords = new System.Windows.Forms.RadioButton();
            this.rbDefaulters = new System.Windows.Forms.RadioButton();
            this.gbSelect = new System.Windows.Forms.GroupBox();
            this.pbIpS = new System.Windows.Forms.PictureBox();
            this.gbSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIpS)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInstmntPurchsSys
            // 
            this.lblInstmntPurchsSys.AutoSize = true;
            this.lblInstmntPurchsSys.Font = new System.Drawing.Font("Forte", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstmntPurchsSys.Location = new System.Drawing.Point(42, 29);
            this.lblInstmntPurchsSys.Name = "lblInstmntPurchsSys";
            this.lblInstmntPurchsSys.Size = new System.Drawing.Size(473, 30);
            this.lblInstmntPurchsSys.TabIndex = 0;
            this.lblInstmntPurchsSys.Text = "INSTALMENT PURCHASE SYSTEM";
            // 
            // lblWelcme
            // 
            this.lblWelcme.AutoSize = true;
            this.lblWelcme.Font = new System.Drawing.Font("Forte", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcme.ForeColor = System.Drawing.Color.DimGray;
            this.lblWelcme.Location = new System.Drawing.Point(224, 75);
            this.lblWelcme.Name = "lblWelcme";
            this.lblWelcme.Size = new System.Drawing.Size(117, 22);
            this.lblWelcme.TabIndex = 1;
            this.lblWelcme.Text = "WELCOME";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(14, 129);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(40, 16);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(58, 126);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 5;
            // 
            // btnAdmin
            // 
            this.btnAdmin.Location = new System.Drawing.Point(330, 296);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(75, 23);
            this.btnAdmin.TabIndex = 4;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = true;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(34, 122);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 3;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // rbCustomerRecords
            // 
            this.rbCustomerRecords.AutoSize = true;
            this.rbCustomerRecords.Location = new System.Drawing.Point(24, 30);
            this.rbCustomerRecords.Name = "rbCustomerRecords";
            this.rbCustomerRecords.Size = new System.Drawing.Size(112, 17);
            this.rbCustomerRecords.TabIndex = 1;
            this.rbCustomerRecords.TabStop = true;
            this.rbCustomerRecords.Text = "Customer Records";
            this.rbCustomerRecords.UseVisualStyleBackColor = true;
            // 
            // rbDefaulters
            // 
            this.rbDefaulters.AutoSize = true;
            this.rbDefaulters.Location = new System.Drawing.Point(24, 67);
            this.rbDefaulters.Name = "rbDefaulters";
            this.rbDefaulters.Size = new System.Drawing.Size(73, 17);
            this.rbDefaulters.TabIndex = 2;
            this.rbDefaulters.TabStop = true;
            this.rbDefaulters.Text = "Defaulters";
            this.rbDefaulters.UseVisualStyleBackColor = true;
            // 
            // gbSelect
            // 
            this.gbSelect.Controls.Add(this.rbDefaulters);
            this.gbSelect.Controls.Add(this.rbCustomerRecords);
            this.gbSelect.Controls.Add(this.btnShow);
            this.gbSelect.Location = new System.Drawing.Point(90, 174);
            this.gbSelect.Name = "gbSelect";
            this.gbSelect.Size = new System.Drawing.Size(140, 157);
            this.gbSelect.TabIndex = 8;
            this.gbSelect.TabStop = false;
            this.gbSelect.Text = "Select";
            // 
            // pbIpS
            // 
            this.pbIpS.Image = global::InstalmentPurchaseSystem_IPS_.Properties.Resources.IPS_Image___2_;
            this.pbIpS.Location = new System.Drawing.Point(273, 95);
            this.pbIpS.Name = "pbIpS";
            this.pbIpS.Size = new System.Drawing.Size(252, 198);
            this.pbIpS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIpS.TabIndex = 9;
            this.pbIpS.TabStop = false;
            // 
            // frmInstalmentPurchaseSystem_LocalUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(554, 358);
            this.Controls.Add(this.pbIpS);
            this.Controls.Add(this.gbSelect);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblWelcme);
            this.Controls.Add(this.lblInstmntPurchsSys);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmInstalmentPurchaseSystem_LocalUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instalment Purchase System_LocalUser";
            this.gbSelect.ResumeLayout(false);
            this.gbSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIpS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstmntPurchsSys;
        private System.Windows.Forms.Label lblWelcme;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btnAdmin;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.RadioButton rbCustomerRecords;
        private System.Windows.Forms.RadioButton rbDefaulters;
        private System.Windows.Forms.GroupBox gbSelect;
        private System.Windows.Forms.PictureBox pbIpS;
    }
}


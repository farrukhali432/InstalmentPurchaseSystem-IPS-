namespace InstalmentPurchaseSystem_IPS_
{
    partial class frmCustomerRecords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerRecords));
            this.pbIpS = new System.Windows.Forms.PictureBox();
            this.lblWelcme = new System.Windows.Forms.Label();
            this.lblInstmntPurchsSys = new System.Windows.Forms.Label();
            this.gbCustomerRecords = new System.Windows.Forms.GroupBox();
            this.dgvCustomerRecords = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbIpS)).BeginInit();
            this.gbCustomerRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // pbIpS
            // 
            this.pbIpS.Image = global::InstalmentPurchaseSystem_IPS_.Properties.Resources.IPS_Image___2_;
            this.pbIpS.Location = new System.Drawing.Point(459, 55);
            this.pbIpS.Name = "pbIpS";
            this.pbIpS.Size = new System.Drawing.Size(240, 166);
            this.pbIpS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIpS.TabIndex = 7;
            this.pbIpS.TabStop = false;
            // 
            // lblWelcme
            // 
            this.lblWelcme.AutoSize = true;
            this.lblWelcme.Font = new System.Drawing.Font("Forte", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcme.ForeColor = System.Drawing.Color.DimGray;
            this.lblWelcme.Location = new System.Drawing.Point(275, 74);
            this.lblWelcme.Name = "lblWelcme";
            this.lblWelcme.Size = new System.Drawing.Size(117, 22);
            this.lblWelcme.TabIndex = 6;
            this.lblWelcme.Text = "WELCOME";
            // 
            // lblInstmntPurchsSys
            // 
            this.lblInstmntPurchsSys.AutoSize = true;
            this.lblInstmntPurchsSys.Font = new System.Drawing.Font("Forte", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstmntPurchsSys.Location = new System.Drawing.Point(102, 22);
            this.lblInstmntPurchsSys.Name = "lblInstmntPurchsSys";
            this.lblInstmntPurchsSys.Size = new System.Drawing.Size(473, 30);
            this.lblInstmntPurchsSys.TabIndex = 5;
            this.lblInstmntPurchsSys.Text = "INSTALMENT PURCHASE SYSTEM";
            // 
            // gbCustomerRecords
            // 
            this.gbCustomerRecords.Controls.Add(this.dgvCustomerRecords);
            this.gbCustomerRecords.Location = new System.Drawing.Point(7, 223);
            this.gbCustomerRecords.Name = "gbCustomerRecords";
            this.gbCustomerRecords.Size = new System.Drawing.Size(691, 219);
            this.gbCustomerRecords.TabIndex = 8;
            this.gbCustomerRecords.TabStop = false;
            this.gbCustomerRecords.Text = "Customer Records";
            // 
            // dgvCustomerRecords
            // 
            this.dgvCustomerRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomerRecords.Location = new System.Drawing.Point(3, 16);
            this.dgvCustomerRecords.Name = "dgvCustomerRecords";
            this.dgvCustomerRecords.Size = new System.Drawing.Size(685, 200);
            this.dgvCustomerRecords.TabIndex = 0;
            // 
            // frmCustomerRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(704, 446);
            this.Controls.Add(this.gbCustomerRecords);
            this.Controls.Add(this.pbIpS);
            this.Controls.Add(this.lblWelcme);
            this.Controls.Add(this.lblInstmntPurchsSys);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCustomerRecords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Records";
            ((System.ComponentModel.ISupportInitialize)(this.pbIpS)).EndInit();
            this.gbCustomerRecords.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbIpS;
        private System.Windows.Forms.Label lblWelcme;
        private System.Windows.Forms.Label lblInstmntPurchsSys;
        private System.Windows.Forms.GroupBox gbCustomerRecords;
        private System.Windows.Forms.DataGridView dgvCustomerRecords;

    }
}
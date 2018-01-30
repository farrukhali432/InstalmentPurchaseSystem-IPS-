namespace InstalmentPurchaseSystem_IPS_
{
    partial class frmDefaulters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDefaulters));
            this.lblInstmntPurchsSys = new System.Windows.Forms.Label();
            this.lblWelcme = new System.Windows.Forms.Label();
            this.gbDefaulters = new System.Windows.Forms.GroupBox();
            this.dgvDefaulters = new System.Windows.Forms.DataGridView();
            this.pbIpS = new System.Windows.Forms.PictureBox();
            this.gbDefaulters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDefaulters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIpS)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInstmntPurchsSys
            // 
            this.lblInstmntPurchsSys.AutoSize = true;
            this.lblInstmntPurchsSys.Font = new System.Drawing.Font("Forte", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstmntPurchsSys.Location = new System.Drawing.Point(101, 22);
            this.lblInstmntPurchsSys.Name = "lblInstmntPurchsSys";
            this.lblInstmntPurchsSys.Size = new System.Drawing.Size(473, 30);
            this.lblInstmntPurchsSys.TabIndex = 1;
            this.lblInstmntPurchsSys.Text = "INSTALMENT PURCHASE SYSTEM";
            // 
            // lblWelcme
            // 
            this.lblWelcme.AutoSize = true;
            this.lblWelcme.Font = new System.Drawing.Font("Forte", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcme.ForeColor = System.Drawing.Color.DimGray;
            this.lblWelcme.Location = new System.Drawing.Point(274, 74);
            this.lblWelcme.Name = "lblWelcme";
            this.lblWelcme.Size = new System.Drawing.Size(117, 22);
            this.lblWelcme.TabIndex = 2;
            this.lblWelcme.Text = "WELCOME";
            // 
            // gbDefaulters
            // 
            this.gbDefaulters.Controls.Add(this.dgvDefaulters);
            this.gbDefaulters.Location = new System.Drawing.Point(4, 217);
            this.gbDefaulters.Name = "gbDefaulters";
            this.gbDefaulters.Size = new System.Drawing.Size(697, 221);
            this.gbDefaulters.TabIndex = 3;
            this.gbDefaulters.TabStop = false;
            this.gbDefaulters.Text = "Defaulters";
            // 
            // dgvDefaulters
            // 
            this.dgvDefaulters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDefaulters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDefaulters.Location = new System.Drawing.Point(3, 16);
            this.dgvDefaulters.Name = "dgvDefaulters";
            this.dgvDefaulters.Size = new System.Drawing.Size(691, 202);
            this.dgvDefaulters.TabIndex = 0;
            // 
            // pbIpS
            // 
            this.pbIpS.Image = global::InstalmentPurchaseSystem_IPS_.Properties.Resources.IPS_Image___2_;
            this.pbIpS.Location = new System.Drawing.Point(458, 55);
            this.pbIpS.Name = "pbIpS";
            this.pbIpS.Size = new System.Drawing.Size(240, 166);
            this.pbIpS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIpS.TabIndex = 4;
            this.pbIpS.TabStop = false;
            // 
            // frmDefaulters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(704, 446);
            this.Controls.Add(this.pbIpS);
            this.Controls.Add(this.gbDefaulters);
            this.Controls.Add(this.lblWelcme);
            this.Controls.Add(this.lblInstmntPurchsSys);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmDefaulters";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Defaulters";
            this.gbDefaulters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDefaulters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIpS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstmntPurchsSys;
        private System.Windows.Forms.Label lblWelcme;
        private System.Windows.Forms.GroupBox gbDefaulters;
        private System.Windows.Forms.DataGridView dgvDefaulters;
        private System.Windows.Forms.PictureBox pbIpS;
    }
}
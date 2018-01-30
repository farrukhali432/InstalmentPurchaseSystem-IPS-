namespace InstalmentPurchaseSystem_IPS_
{
    partial class frmSearch_DeleteCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearch_DeleteCustomer));
            this.lblWelcme = new System.Windows.Forms.Label();
            this.lblInstmntPurchsSys = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbSearchOrDelete = new System.Windows.Forms.GroupBox();
            this.pbIpS = new System.Windows.Forms.PictureBox();
            this.gbSearchOrDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIpS)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcme
            // 
            this.lblWelcme.AutoSize = true;
            this.lblWelcme.Font = new System.Drawing.Font("Forte", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcme.ForeColor = System.Drawing.Color.DimGray;
            this.lblWelcme.Location = new System.Drawing.Point(262, 64);
            this.lblWelcme.Name = "lblWelcme";
            this.lblWelcme.Size = new System.Drawing.Size(117, 22);
            this.lblWelcme.TabIndex = 20;
            this.lblWelcme.Text = "WELCOME";
            // 
            // lblInstmntPurchsSys
            // 
            this.lblInstmntPurchsSys.AutoSize = true;
            this.lblInstmntPurchsSys.Font = new System.Drawing.Font("Forte", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstmntPurchsSys.Location = new System.Drawing.Point(84, 20);
            this.lblInstmntPurchsSys.Name = "lblInstmntPurchsSys";
            this.lblInstmntPurchsSys.Size = new System.Drawing.Size(473, 30);
            this.lblInstmntPurchsSys.TabIndex = 19;
            this.lblInstmntPurchsSys.Text = "INSTALMENT PURCHASE SYSTEM";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(131, 27);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(118, 20);
            this.txtCustomerId.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Customer ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Customer Name:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(131, 57);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(118, 20);
            this.txtCustomerName.TabIndex = 24;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(91, 116);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(172, 116);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // gbSearchOrDelete
            // 
            this.gbSearchOrDelete.Controls.Add(this.btnDelete);
            this.gbSearchOrDelete.Controls.Add(this.btnSearch);
            this.gbSearchOrDelete.Controls.Add(this.label2);
            this.gbSearchOrDelete.Controls.Add(this.txtCustomerName);
            this.gbSearchOrDelete.Controls.Add(this.label1);
            this.gbSearchOrDelete.Controls.Add(this.txtCustomerId);
            this.gbSearchOrDelete.Location = new System.Drawing.Point(51, 89);
            this.gbSearchOrDelete.Name = "gbSearchOrDelete";
            this.gbSearchOrDelete.Size = new System.Drawing.Size(301, 156);
            this.gbSearchOrDelete.TabIndex = 28;
            this.gbSearchOrDelete.TabStop = false;
            this.gbSearchOrDelete.Text = "Search Or Delete";
            // 
            // pbIpS
            // 
            this.pbIpS.Image = global::InstalmentPurchaseSystem_IPS_.Properties.Resources.IPS_Image___2_;
            this.pbIpS.Location = new System.Drawing.Point(385, 53);
            this.pbIpS.Name = "pbIpS";
            this.pbIpS.Size = new System.Drawing.Size(254, 152);
            this.pbIpS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIpS.TabIndex = 21;
            this.pbIpS.TabStop = false;
            // 
            // frmSearch_DeleteCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(646, 256);
            this.Controls.Add(this.gbSearchOrDelete);
            this.Controls.Add(this.pbIpS);
            this.Controls.Add(this.lblWelcme);
            this.Controls.Add(this.lblInstmntPurchsSys);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSearch_DeleteCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search/Delete Customer";
            this.gbSearchOrDelete.ResumeLayout(false);
            this.gbSearchOrDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIpS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbIpS;
        private System.Windows.Forms.Label lblWelcme;
        private System.Windows.Forms.Label lblInstmntPurchsSys;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbSearchOrDelete;
    }
}
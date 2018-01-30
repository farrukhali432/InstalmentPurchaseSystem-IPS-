namespace InstalmentPurchaseSystem_IPS_
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.lblWelcme = new System.Windows.Forms.Label();
            this.lblInstmntPurchsSys = new System.Windows.Forms.Label();
            this.pbIpS = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtbxUserName = new System.Windows.Forms.TextBox();
            this.txtbxPassword = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbIpS)).BeginInit();
            this.gbLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcme
            // 
            this.lblWelcme.AutoSize = true;
            this.lblWelcme.Font = new System.Drawing.Font("Forte", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcme.ForeColor = System.Drawing.Color.DimGray;
            this.lblWelcme.Location = new System.Drawing.Point(193, 67);
            this.lblWelcme.Name = "lblWelcme";
            this.lblWelcme.Size = new System.Drawing.Size(117, 22);
            this.lblWelcme.TabIndex = 9;
            this.lblWelcme.Text = "WELCOME";
            // 
            // lblInstmntPurchsSys
            // 
            this.lblInstmntPurchsSys.AutoSize = true;
            this.lblInstmntPurchsSys.Font = new System.Drawing.Font("Forte", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstmntPurchsSys.Location = new System.Drawing.Point(30, 25);
            this.lblInstmntPurchsSys.Name = "lblInstmntPurchsSys";
            this.lblInstmntPurchsSys.Size = new System.Drawing.Size(473, 30);
            this.lblInstmntPurchsSys.TabIndex = 8;
            this.lblInstmntPurchsSys.Text = "INSTALMENT PURCHASE SYSTEM";
            // 
            // pbIpS
            // 
            this.pbIpS.Image = global::InstalmentPurchaseSystem_IPS_.Properties.Resources.IPS_Image___2_;
            this.pbIpS.Location = new System.Drawing.Point(298, 92);
            this.pbIpS.Name = "pbIpS";
            this.pbIpS.Size = new System.Drawing.Size(240, 267);
            this.pbIpS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIpS.TabIndex = 10;
            this.pbIpS.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(78, 174);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtbxUserName
            // 
            this.txtbxUserName.Location = new System.Drawing.Point(78, 38);
            this.txtbxUserName.Name = "txtbxUserName";
            this.txtbxUserName.Size = new System.Drawing.Size(100, 20);
            this.txtbxUserName.TabIndex = 1;
            // 
            // txtbxPassword
            // 
            this.txtbxPassword.Location = new System.Drawing.Point(78, 88);
            this.txtbxPassword.Name = "txtbxPassword";
            this.txtbxPassword.Size = new System.Drawing.Size(100, 20);
            this.txtbxPassword.TabIndex = 2;
            this.txtbxPassword.UseSystemPasswordChar = true;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(12, 41);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(60, 13);
            this.lblUserName.TabIndex = 14;
            this.lblUserName.Text = "UserName:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(19, 91);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 15;
            this.lblPassword.Text = "Password:";
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.lblPassword);
            this.gbLogin.Controls.Add(this.lblUserName);
            this.gbLogin.Controls.Add(this.txtbxPassword);
            this.gbLogin.Controls.Add(this.txtbxUserName);
            this.gbLogin.Controls.Add(this.btnLogin);
            this.gbLogin.Location = new System.Drawing.Point(21, 118);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(209, 218);
            this.gbLogin.TabIndex = 16;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "Login";
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(563, 371);
            this.Controls.Add(this.gbLogin);
            this.Controls.Add(this.pbIpS);
            this.Controls.Add(this.lblWelcme);
            this.Controls.Add(this.lblInstmntPurchsSys);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbIpS)).EndInit();
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbIpS;
        private System.Windows.Forms.Label lblWelcme;
        private System.Windows.Forms.Label lblInstmntPurchsSys;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtbxUserName;
        private System.Windows.Forms.TextBox txtbxPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.GroupBox gbLogin;
    }
}
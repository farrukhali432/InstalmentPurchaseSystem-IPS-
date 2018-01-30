namespace InstalmentPurchaseSystem_IPS_
{
    partial class frmInstalmentPurchaseSystem_Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInstalmentPurchaseSystem_Admin));
            this.lblWelcme = new System.Windows.Forms.Label();
            this.lblInstmntPurchsSys = new System.Windows.Forms.Label();
            this.mnuStrp = new System.Windows.Forms.MenuStrip();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.placeOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cashMemoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vendorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbQuickLinks = new System.Windows.Forms.GroupBox();
            this.lnklblLogOut = new System.Windows.Forms.LinkLabel();
            this.lnklblDefaulter = new System.Windows.Forms.LinkLabel();
            this.lnklblSearch = new System.Windows.Forms.LinkLabel();
            this.lnklblCashMemo = new System.Windows.Forms.LinkLabel();
            this.lnklblAdd = new System.Windows.Forms.LinkLabel();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.pbIpS = new System.Windows.Forms.PictureBox();
            this.mnuStrp.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbQuickLinks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIpS)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcme
            // 
            this.lblWelcme.AutoSize = true;
            this.lblWelcme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcme.ForeColor = System.Drawing.Color.DimGray;
            this.lblWelcme.Location = new System.Drawing.Point(623, 90);
            this.lblWelcme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcme.Name = "lblWelcme";
            this.lblWelcme.Size = new System.Drawing.Size(160, 31);
            this.lblWelcme.TabIndex = 11;
            this.lblWelcme.Text = "WELCOME";
            // 
            // lblInstmntPurchsSys
            // 
            this.lblInstmntPurchsSys.AutoSize = true;
            this.lblInstmntPurchsSys.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstmntPurchsSys.Location = new System.Drawing.Point(399, 49);
            this.lblInstmntPurchsSys.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstmntPurchsSys.Name = "lblInstmntPurchsSys";
            this.lblInstmntPurchsSys.Size = new System.Drawing.Size(611, 39);
            this.lblInstmntPurchsSys.TabIndex = 10;
            this.lblInstmntPurchsSys.Text = "INSTALMENT PURCHASE SYSTEM";
            // 
            // mnuStrp
            // 
            this.mnuStrp.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.mnuStrp.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuStrp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem,
            this.productOrderToolStripMenuItem,
            this.cashMemoToolStripMenuItem,
            this.vendorsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mnuStrp.Location = new System.Drawing.Point(0, 0);
            this.mnuStrp.Name = "mnuStrp";
            this.mnuStrp.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.mnuStrp.Size = new System.Drawing.Size(1280, 28);
            this.mnuStrp.TabIndex = 13;
            this.mnuStrp.Text = "Main Menu";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.customerToolStripMenuItem.Text = "Customers";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // productOrderToolStripMenuItem
            // 
            this.productOrderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.placeOrderToolStripMenuItem,
            this.updateToolStripMenuItem1});
            this.productOrderToolStripMenuItem.Name = "productOrderToolStripMenuItem";
            this.productOrderToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.productOrderToolStripMenuItem.Text = "ProductOrder";
            // 
            // placeOrderToolStripMenuItem
            // 
            this.placeOrderToolStripMenuItem.Name = "placeOrderToolStripMenuItem";
            this.placeOrderToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.placeOrderToolStripMenuItem.Text = "PlaceOrder";
            this.placeOrderToolStripMenuItem.Click += new System.EventHandler(this.placeOrderToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem1
            // 
            this.updateToolStripMenuItem1.Name = "updateToolStripMenuItem1";
            this.updateToolStripMenuItem1.Size = new System.Drawing.Size(157, 26);
            this.updateToolStripMenuItem1.Text = "Update";
            // 
            // cashMemoToolStripMenuItem
            // 
            this.cashMemoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paymentsToolStripMenuItem1});
            this.cashMemoToolStripMenuItem.Name = "cashMemoToolStripMenuItem";
            this.cashMemoToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.cashMemoToolStripMenuItem.Text = "CashMemo";
            // 
            // paymentsToolStripMenuItem1
            // 
            this.paymentsToolStripMenuItem1.Name = "paymentsToolStripMenuItem1";
            this.paymentsToolStripMenuItem1.Size = new System.Drawing.Size(147, 26);
            this.paymentsToolStripMenuItem1.Text = "Payments";
            this.paymentsToolStripMenuItem1.Click += new System.EventHandler(this.paymentsToolStripMenuItem1_Click);
            // 
            // vendorsToolStripMenuItem
            // 
            this.vendorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1});
            this.vendorsToolStripMenuItem.Name = "vendorsToolStripMenuItem";
            this.vendorsToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.vendorsToolStripMenuItem.Text = "Vendors";
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(112, 26);
            this.addToolStripMenuItem1.Text = "Add";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(16, 459);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1779, 433);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Records";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 19);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1771, 410);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gbQuickLinks
            // 
            this.gbQuickLinks.Controls.Add(this.lnklblLogOut);
            this.gbQuickLinks.Controls.Add(this.lnklblDefaulter);
            this.gbQuickLinks.Controls.Add(this.lnklblSearch);
            this.gbQuickLinks.Controls.Add(this.lnklblCashMemo);
            this.gbQuickLinks.Controls.Add(this.lnklblAdd);
            this.gbQuickLinks.Location = new System.Drawing.Point(24, 119);
            this.gbQuickLinks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbQuickLinks.Name = "gbQuickLinks";
            this.gbQuickLinks.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbQuickLinks.Size = new System.Drawing.Size(155, 315);
            this.gbQuickLinks.TabIndex = 16;
            this.gbQuickLinks.TabStop = false;
            this.gbQuickLinks.Text = "Quick Links";
            // 
            // lnklblLogOut
            // 
            this.lnklblLogOut.AutoSize = true;
            this.lnklblLogOut.Location = new System.Drawing.Point(41, 281);
            this.lnklblLogOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnklblLogOut.Name = "lnklblLogOut";
            this.lnklblLogOut.Size = new System.Drawing.Size(59, 17);
            this.lnklblLogOut.TabIndex = 21;
            this.lnklblLogOut.TabStop = true;
            this.lnklblLogOut.Text = "Log Out";
            this.lnklblLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblLogOut_LinkClicked);
            // 
            // lnklblDefaulter
            // 
            this.lnklblDefaulter.AutoSize = true;
            this.lnklblDefaulter.Location = new System.Drawing.Point(37, 225);
            this.lnklblDefaulter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnklblDefaulter.Name = "lnklblDefaulter";
            this.lnklblDefaulter.Size = new System.Drawing.Size(73, 17);
            this.lnklblDefaulter.TabIndex = 20;
            this.lnklblDefaulter.TabStop = true;
            this.lnklblDefaulter.Text = "Defaulters";
            this.lnklblDefaulter.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblDefaulter_LinkClicked);
            // 
            // lnklblSearch
            // 
            this.lnklblSearch.AutoSize = true;
            this.lnklblSearch.Location = new System.Drawing.Point(41, 161);
            this.lnklblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnklblSearch.Name = "lnklblSearch";
            this.lnklblSearch.Size = new System.Drawing.Size(53, 17);
            this.lnklblSearch.TabIndex = 19;
            this.lnklblSearch.TabStop = true;
            this.lnklblSearch.Text = "Search";
            this.lnklblSearch.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblSearch_LinkClicked);
            // 
            // lnklblCashMemo
            // 
            this.lnklblCashMemo.AutoSize = true;
            this.lnklblCashMemo.Location = new System.Drawing.Point(41, 98);
            this.lnklblCashMemo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnklblCashMemo.Name = "lnklblCashMemo";
            this.lnklblCashMemo.Size = new System.Drawing.Size(78, 17);
            this.lnklblCashMemo.TabIndex = 18;
            this.lnklblCashMemo.TabStop = true;
            this.lnklblCashMemo.Text = "CashMemo";
            this.lnklblCashMemo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblCashMemo_LinkClicked);
            // 
            // lnklblAdd
            // 
            this.lnklblAdd.AutoSize = true;
            this.lnklblAdd.Location = new System.Drawing.Point(41, 44);
            this.lnklblAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnklblAdd.Name = "lnklblAdd";
            this.lnklblAdd.Size = new System.Drawing.Size(33, 17);
            this.lnklblAdd.TabIndex = 17;
            this.lnklblAdd.TabStop = true;
            this.lnklblAdd.Text = "Add";
            this.lnklblAdd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblAdd_LinkClicked);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(264, 166);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker.TabIndex = 17;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(209, 175);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(42, 17);
            this.lblDate.TabIndex = 18;
            this.lblDate.Text = "Date:";
            // 
            // pbIpS
            // 
            this.pbIpS.Image = global::InstalmentPurchaseSystem_IPS_.Properties.Resources.IPS_Image___2_;
            this.pbIpS.Location = new System.Drawing.Point(1025, 43);
            this.pbIpS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbIpS.Name = "pbIpS";
            this.pbIpS.Size = new System.Drawing.Size(741, 338);
            this.pbIpS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIpS.TabIndex = 12;
            this.pbIpS.TabStop = false;
            // 
            // frmInstalmentPurchaseSystem_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1280, 907);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.gbQuickLinks);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pbIpS);
            this.Controls.Add(this.lblWelcme);
            this.Controls.Add(this.lblInstmntPurchsSys);
            this.Controls.Add(this.mnuStrp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuStrp;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmInstalmentPurchaseSystem_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instalment Purchase System_Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInstalmentPurchaseSystem_Admin_Load);
            this.mnuStrp.ResumeLayout(false);
            this.mnuStrp.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbQuickLinks.ResumeLayout(false);
            this.gbQuickLinks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIpS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbIpS;
        private System.Windows.Forms.Label lblWelcme;
        private System.Windows.Forms.Label lblInstmntPurchsSys;
        private System.Windows.Forms.MenuStrip mnuStrp;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbQuickLinks;
        private System.Windows.Forms.LinkLabel lnklblLogOut;
        private System.Windows.Forms.LinkLabel lnklblDefaulter;
        private System.Windows.Forms.LinkLabel lnklblSearch;
        private System.Windows.Forms.LinkLabel lnklblCashMemo;
        private System.Windows.Forms.LinkLabel lnklblAdd;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ToolStripMenuItem productOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem placeOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cashMemoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentsToolStripMenuItem1;
    }
}
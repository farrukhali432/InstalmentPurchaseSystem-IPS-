namespace InstalmentPurchaseSystem_IPS_
{
    partial class frmProductOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductOrder));
            this.lblWelcme = new System.Windows.Forms.Label();
            this.lblInstmntPurchsSys = new System.Windows.Forms.Label();
            this.pbIpS = new System.Windows.Forms.PictureBox();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblModelNo = new System.Windows.Forms.Label();
            this.txtModelNo = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.cbxQuantity = new System.Windows.Forms.ComboBox();
            this.lblPrincipalAmount = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.msktxtPrincipalAmount = new System.Windows.Forms.MaskedTextBox();
            this.msktxtTotalAmount = new System.Windows.Forms.MaskedTextBox();
            this.lblTotalInstalment = new System.Windows.Forms.Label();
            this.txtTotalInstalments = new System.Windows.Forms.TextBox();
            this.lblInstalmentMode = new System.Windows.Forms.Label();
            this.rbWeekly = new System.Windows.Forms.RadioButton();
            this.rbMonthly = new System.Windows.Forms.RadioButton();
            this.rbYearly = new System.Windows.Forms.RadioButton();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.gbProductOrderDetail = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbIpS)).BeginInit();
            this.gbProductOrderDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcme
            // 
            this.lblWelcme.AutoSize = true;
            this.lblWelcme.Font = new System.Drawing.Font("Forte", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcme.ForeColor = System.Drawing.Color.DimGray;
            this.lblWelcme.Location = new System.Drawing.Point(352, 69);
            this.lblWelcme.Name = "lblWelcme";
            this.lblWelcme.Size = new System.Drawing.Size(117, 22);
            this.lblWelcme.TabIndex = 14;
            this.lblWelcme.Text = "WELCOME";
            // 
            // lblInstmntPurchsSys
            // 
            this.lblInstmntPurchsSys.AutoSize = true;
            this.lblInstmntPurchsSys.Font = new System.Drawing.Font("Forte", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstmntPurchsSys.Location = new System.Drawing.Point(174, 21);
            this.lblInstmntPurchsSys.Name = "lblInstmntPurchsSys";
            this.lblInstmntPurchsSys.Size = new System.Drawing.Size(473, 30);
            this.lblInstmntPurchsSys.TabIndex = 13;
            this.lblInstmntPurchsSys.Text = "INSTALMENT PURCHASE SYSTEM";
            // 
            // pbIpS
            // 
            this.pbIpS.Image = global::InstalmentPurchaseSystem_IPS_.Properties.Resources.IPS_Image___2_;
            this.pbIpS.Location = new System.Drawing.Point(545, 54);
            this.pbIpS.Name = "pbIpS";
            this.pbIpS.Size = new System.Drawing.Size(137, 152);
            this.pbIpS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIpS.TabIndex = 15;
            this.pbIpS.TabStop = false;
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(110, 14);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.ReadOnly = true;
            this.txtCustomerId.Size = new System.Drawing.Size(118, 20);
            this.txtCustomerId.TabIndex = 0;
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Location = new System.Drawing.Point(29, 18);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(68, 13);
            this.lblCustomerId.TabIndex = 17;
            this.lblCustomerId.Text = "Customer ID:";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(22, 64);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(78, 13);
            this.lblProductName.TabIndex = 19;
            this.lblProductName.Text = "Product Name:";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(110, 60);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(118, 20);
            this.txtProductName.TabIndex = 1;
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Items.AddRange(new object[] {
            "Bike",
            "Furniture",
            "ElectronicsItems",
            "Others"});
            this.cbxCategory.Location = new System.Drawing.Point(107, 101);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(121, 21);
            this.cbxCategory.TabIndex = 2;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(44, 104);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(52, 13);
            this.lblCategory.TabIndex = 21;
            this.lblCategory.Text = "Category:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(25, 203);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 25;
            this.lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(110, 199);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(118, 41);
            this.txtDescription.TabIndex = 4;
            // 
            // lblModelNo
            // 
            this.lblModelNo.AutoSize = true;
            this.lblModelNo.Location = new System.Drawing.Point(32, 157);
            this.lblModelNo.Name = "lblModelNo";
            this.lblModelNo.Size = new System.Drawing.Size(56, 13);
            this.lblModelNo.TabIndex = 23;
            this.lblModelNo.Text = "Model No:";
            // 
            // txtModelNo
            // 
            this.txtModelNo.Location = new System.Drawing.Point(110, 153);
            this.txtModelNo.Name = "txtModelNo";
            this.txtModelNo.Size = new System.Drawing.Size(118, 20);
            this.txtModelNo.TabIndex = 3;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(36, 275);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(49, 13);
            this.lblQuantity.TabIndex = 27;
            this.lblQuantity.Text = "Quantity:";
            // 
            // cbxQuantity
            // 
            this.cbxQuantity.FormattingEnabled = true;
            this.cbxQuantity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbxQuantity.Location = new System.Drawing.Point(107, 267);
            this.cbxQuantity.Name = "cbxQuantity";
            this.cbxQuantity.Size = new System.Drawing.Size(121, 21);
            this.cbxQuantity.TabIndex = 5;
            // 
            // lblPrincipalAmount
            // 
            this.lblPrincipalAmount.AutoSize = true;
            this.lblPrincipalAmount.Location = new System.Drawing.Point(248, 16);
            this.lblPrincipalAmount.Name = "lblPrincipalAmount";
            this.lblPrincipalAmount.Size = new System.Drawing.Size(89, 13);
            this.lblPrincipalAmount.TabIndex = 30;
            this.lblPrincipalAmount.Text = "Principal Amount:";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(248, 60);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(73, 13);
            this.lblTotalAmount.TabIndex = 32;
            this.lblTotalAmount.Text = "Total Amount:";
            // 
            // msktxtPrincipalAmount
            // 
            this.msktxtPrincipalAmount.Location = new System.Drawing.Point(343, 13);
            this.msktxtPrincipalAmount.Mask = "0000000";
            this.msktxtPrincipalAmount.Name = "msktxtPrincipalAmount";
            this.msktxtPrincipalAmount.Size = new System.Drawing.Size(103, 20);
            this.msktxtPrincipalAmount.TabIndex = 6;
            // 
            // msktxtTotalAmount
            // 
            this.msktxtTotalAmount.Location = new System.Drawing.Point(343, 57);
            this.msktxtTotalAmount.Mask = "0000000";
            this.msktxtTotalAmount.Name = "msktxtTotalAmount";
            this.msktxtTotalAmount.Size = new System.Drawing.Size(103, 20);
            this.msktxtTotalAmount.TabIndex = 7;
            // 
            // lblTotalInstalment
            // 
            this.lblTotalInstalment.AutoSize = true;
            this.lblTotalInstalment.Location = new System.Drawing.Point(253, 203);
            this.lblTotalInstalment.Name = "lblTotalInstalment";
            this.lblTotalInstalment.Size = new System.Drawing.Size(90, 13);
            this.lblTotalInstalment.TabIndex = 36;
            this.lblTotalInstalment.Text = "Total Instalments:";
            // 
            // txtTotalInstalments
            // 
            this.txtTotalInstalments.Location = new System.Drawing.Point(347, 199);
            this.txtTotalInstalments.Name = "txtTotalInstalments";
            this.txtTotalInstalments.Size = new System.Drawing.Size(99, 20);
            this.txtTotalInstalments.TabIndex = 11;
            // 
            // lblInstalmentMode
            // 
            this.lblInstalmentMode.AutoSize = true;
            this.lblInstalmentMode.Location = new System.Drawing.Point(248, 101);
            this.lblInstalmentMode.Name = "lblInstalmentMode";
            this.lblInstalmentMode.Size = new System.Drawing.Size(88, 13);
            this.lblInstalmentMode.TabIndex = 37;
            this.lblInstalmentMode.Text = "Instalment Mode:";
            // 
            // rbWeekly
            // 
            this.rbWeekly.AutoSize = true;
            this.rbWeekly.Location = new System.Drawing.Point(323, 129);
            this.rbWeekly.Name = "rbWeekly";
            this.rbWeekly.Size = new System.Drawing.Size(61, 17);
            this.rbWeekly.TabIndex = 8;
            this.rbWeekly.TabStop = true;
            this.rbWeekly.Text = "Weekly";
            this.rbWeekly.UseVisualStyleBackColor = true;
            // 
            // rbMonthly
            // 
            this.rbMonthly.AutoSize = true;
            this.rbMonthly.Location = new System.Drawing.Point(323, 149);
            this.rbMonthly.Name = "rbMonthly";
            this.rbMonthly.Size = new System.Drawing.Size(62, 17);
            this.rbMonthly.TabIndex = 9;
            this.rbMonthly.TabStop = true;
            this.rbMonthly.Text = "Monthly";
            this.rbMonthly.UseVisualStyleBackColor = true;
            // 
            // rbYearly
            // 
            this.rbYearly.AutoSize = true;
            this.rbYearly.Location = new System.Drawing.Point(323, 170);
            this.rbYearly.Name = "rbYearly";
            this.rbYearly.Size = new System.Drawing.Size(54, 17);
            this.rbYearly.TabIndex = 10;
            this.rbYearly.TabStop = true;
            this.rbYearly.Text = "Yearly";
            this.rbYearly.UseVisualStyleBackColor = true;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(353, 284);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(75, 23);
            this.btnPlaceOrder.TabIndex = 12;
            this.btnPlaceOrder.Text = "PlaceOrder";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(434, 284);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 13;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // gbProductOrderDetail
            // 
            this.gbProductOrderDetail.Controls.Add(this.btCancel);
            this.gbProductOrderDetail.Controls.Add(this.btnPlaceOrder);
            this.gbProductOrderDetail.Controls.Add(this.rbYearly);
            this.gbProductOrderDetail.Controls.Add(this.rbMonthly);
            this.gbProductOrderDetail.Controls.Add(this.rbWeekly);
            this.gbProductOrderDetail.Controls.Add(this.lblInstalmentMode);
            this.gbProductOrderDetail.Controls.Add(this.lblTotalInstalment);
            this.gbProductOrderDetail.Controls.Add(this.txtTotalInstalments);
            this.gbProductOrderDetail.Controls.Add(this.msktxtTotalAmount);
            this.gbProductOrderDetail.Controls.Add(this.msktxtPrincipalAmount);
            this.gbProductOrderDetail.Controls.Add(this.lblTotalAmount);
            this.gbProductOrderDetail.Controls.Add(this.lblPrincipalAmount);
            this.gbProductOrderDetail.Controls.Add(this.cbxQuantity);
            this.gbProductOrderDetail.Controls.Add(this.lblQuantity);
            this.gbProductOrderDetail.Controls.Add(this.lblDescription);
            this.gbProductOrderDetail.Controls.Add(this.txtDescription);
            this.gbProductOrderDetail.Controls.Add(this.lblModelNo);
            this.gbProductOrderDetail.Controls.Add(this.txtModelNo);
            this.gbProductOrderDetail.Controls.Add(this.lblCategory);
            this.gbProductOrderDetail.Controls.Add(this.cbxCategory);
            this.gbProductOrderDetail.Controls.Add(this.lblProductName);
            this.gbProductOrderDetail.Controls.Add(this.txtProductName);
            this.gbProductOrderDetail.Controls.Add(this.lblCustomerId);
            this.gbProductOrderDetail.Controls.Add(this.txtCustomerId);
            this.gbProductOrderDetail.Location = new System.Drawing.Point(23, 104);
            this.gbProductOrderDetail.Name = "gbProductOrderDetail";
            this.gbProductOrderDetail.Size = new System.Drawing.Size(515, 329);
            this.gbProductOrderDetail.TabIndex = 43;
            this.gbProductOrderDetail.TabStop = false;
            this.gbProductOrderDetail.Text = "Product Order Detail";
            // 
            // frmProductOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(687, 438);
            this.Controls.Add(this.gbProductOrderDetail);
            this.Controls.Add(this.pbIpS);
            this.Controls.Add(this.lblWelcme);
            this.Controls.Add(this.lblInstmntPurchsSys);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmProductOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Order";
            ((System.ComponentModel.ISupportInitialize)(this.pbIpS)).EndInit();
            this.gbProductOrderDetail.ResumeLayout(false);
            this.gbProductOrderDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbIpS;
        private System.Windows.Forms.Label lblWelcme;
        private System.Windows.Forms.Label lblInstmntPurchsSys;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblModelNo;
        private System.Windows.Forms.TextBox txtModelNo;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.ComboBox cbxQuantity;
        private System.Windows.Forms.Label lblPrincipalAmount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.MaskedTextBox msktxtPrincipalAmount;
        private System.Windows.Forms.MaskedTextBox msktxtTotalAmount;
        private System.Windows.Forms.Label lblTotalInstalment;
        private System.Windows.Forms.TextBox txtTotalInstalments;
        private System.Windows.Forms.Label lblInstalmentMode;
        private System.Windows.Forms.RadioButton rbWeekly;
        private System.Windows.Forms.RadioButton rbMonthly;
        private System.Windows.Forms.RadioButton rbYearly;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.GroupBox gbProductOrderDetail;
    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstalmentPurchaseSystem_IPS_
{
    public partial class frmCashMemo : Form
    {
        public frmCashMemo()
        {
            InitializeComponent();
        }

        private void frmCashMemo_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        { this.Hide();
            MessageBox.Show("AMOUNT RECEIVED","VERIFICATION");
           
        }

       
    }
}

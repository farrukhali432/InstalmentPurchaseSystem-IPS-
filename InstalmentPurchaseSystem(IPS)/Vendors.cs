using System;
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
    public partial class frmVendors : Form
    {
        public frmVendors()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("REcord Saved","Saved");
        }

        private void cbProductCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

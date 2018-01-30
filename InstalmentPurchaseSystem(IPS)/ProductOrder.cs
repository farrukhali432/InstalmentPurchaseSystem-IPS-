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
    public partial class frmProductOrder : Form
    {
        public frmProductOrder()
        {
            InitializeComponent();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        { this.Hide();
            frmCashMemo obj_frmCashMemo = new frmCashMemo();
            obj_frmCashMemo.ShowDialog();
           
        }
    }
}

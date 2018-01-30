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
    public partial class frmSearch_DeleteCustomer : Form
    {
        public frmSearch_DeleteCustomer()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSearch obj_frmSearch = new frmSearch();
            obj_frmSearch.ShowDialog();
        }
    }
}

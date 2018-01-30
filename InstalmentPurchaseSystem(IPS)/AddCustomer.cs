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
    public partial class frmAddCustomer : Form
    {
        public frmAddCustomer()
        {
            InitializeComponent();
        }

        private void btnSaveAndNext_Click(object sender, EventArgs e)
        { this.Hide();
            frmProductOrder obj_frmProductOrder = new frmProductOrder();
            obj_frmProductOrder.ShowDialog();
           
        }

        
    }
}

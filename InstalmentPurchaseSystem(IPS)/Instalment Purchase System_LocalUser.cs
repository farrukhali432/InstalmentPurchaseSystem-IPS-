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
    public partial class frmInstalmentPurchaseSystem_LocalUser : Form
    {
        public frmInstalmentPurchaseSystem_LocalUser()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (rbCustomerRecords.Checked == true)
            {
                frmCustomerRecords frmCustomerRecords_obj = new frmCustomerRecords();
                frmCustomerRecords_obj.ShowDialog();
                
            }
            else
            {
                frmDefaulters frmDefaulters_obj = new frmDefaulters();
                frmDefaulters_obj.ShowDialog();
            }
            

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmAdmin frmAdmin_obj = new frmAdmin();
            frmAdmin_obj.ShowDialog();
            

             
           
            
        }
    }
}

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
    public partial class frmInstalmentPurchaseSystem_Admin : Form
    { frmAddCustomer obj_frmAddCustomer = new frmAddCustomer();
        public frmInstalmentPurchaseSystem_Admin()
        {
            InitializeComponent();
            
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
          DialogResult obj_DialogResult =  MessageBox.Show("Do You Want To Exit?","Exit!",MessageBoxButtons.YesNo,MessageBoxIcon.Question); 
               if(obj_DialogResult==DialogResult.Yes)
               {
               Application.Exit();
               }
            
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddCustomer obj_frmAddCustomer = new frmAddCustomer();
            obj_frmAddCustomer.ShowDialog(); 
        }

        private void lnklblAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddCustomer obj_frmAddCustomer = new frmAddCustomer();
            obj_frmAddCustomer.ShowDialog();
        }

        private void placeOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductOrder obj_frmProductOrder = new frmProductOrder();
            obj_frmProductOrder.ShowDialog();
        }

        private void paymentsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCashMemo obj_frmCashMemo = new frmCashMemo();
            obj_frmCashMemo.ShowDialog();
        }

        private void lnklblCashMemo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCashMemo obj_frmCashMemo = new frmCashMemo();
            obj_frmCashMemo.ShowDialog();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearch_DeleteCustomer obj_frmSearch_DeleteCustomer = new frmSearch_DeleteCustomer();
            obj_frmSearch_DeleteCustomer.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearch_DeleteCustomer obj_frmSearch_DeleteCustomer = new frmSearch_DeleteCustomer();
            obj_frmSearch_DeleteCustomer.ShowDialog();
        }

        private void lnklblSearch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSearch_DeleteCustomer obj_frmSearch_DeleteCustomer = new frmSearch_DeleteCustomer();
            obj_frmSearch_DeleteCustomer.ShowDialog();
        }

        private void lnklblLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult obj_DialogResult = MessageBox.Show("Do You Want To Exit?", "Exit!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (obj_DialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lnklblDefaulter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDefaulters frmDefaulters_obj = new frmDefaulters();
            frmDefaulters_obj.ShowDialog();
        }

        private void frmInstalmentPurchaseSystem_Admin_Load(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmVendors obj_frmVendors = new frmVendors();
            obj_frmVendors.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

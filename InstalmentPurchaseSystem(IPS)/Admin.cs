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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtbxUserName.Text == "" || txtbxPassword.Text == "")
            {
                MessageBox.Show("Please Fill UserName Or Password","Empty Field",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                if (txtbxUserName.Text == "admin" && txtbxPassword.Text == "admin")
                {
                    MessageBox.Show("Login Successful", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                     this.Hide();
                    frmInstalmentPurchaseSystem_Admin obj_frmInstalmentPurchaseSystem_Admin = new frmInstalmentPurchaseSystem_Admin();
                    obj_frmInstalmentPurchaseSystem_Admin.ShowDialog();
                   
                }
                else
                {
                    MessageBox.Show("Incorrect UserName or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}

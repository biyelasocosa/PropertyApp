using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

namespace PropertyApp
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnRegister_Click(object sender, EventArgs e)
        {
            Tenant ten = new Tenant(txtName.Text, txtSurname.Text, txtEmail.Text, txtPassword.Text, txtPhone.Text, "Active", 3);
            int x = bll.InsertTenant(ten);
            if(x > 0)
            {
                MessageBox.Show("Registered Successfully! \n Login using Email: " + txtEmail.Text + "And Password: " + txtPassword.Text);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }
    }
}

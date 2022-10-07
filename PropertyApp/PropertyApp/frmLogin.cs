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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable dt = bll.Login(txtEmail.Text, txtPassword.Text);
            string role = dt.Rows[0]["RoleDescription"].ToString();
            if (dt.Rows.Count > 0)
            {
                if (role == "Admin")
                {
                    frmAdmin form = new frmAdmin();
                    form.Show();
                    this.Hide();
                }
                else if (role == "Agent")
                {

                }
                else if (role == "Tenant")
                {

                }
            }
            else if (dt.Rows.Count == 0)
            {
                txtEmail.Clear();
                txtPassword.Clear();
                lblError.Visible = true;
            }
        }
    }
}

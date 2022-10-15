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

        public static DataTable dtLog = null;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            dtLog = bll.Login(txtEmail.Text, txtPassword.Text);
            if (dtLog.Rows.Count > 0)
            {
                string user = dtLog.Rows[0]["Description"].ToString();
                if (user == "Admin")
                {
                    frmAdmin admin = new frmAdmin();
                    admin.Show();
                    this.Hide();
                }
                else if (user == "Agent")
                {
                    frmAgent agent = new frmAgent();
                    agent.Show();
                    this.Hide();
                }
                else if (user == "Tenant")
                {
                    frmTenant tenant = new frmTenant();
                    tenant.Show();
                    this.Hide();
                }
            }
            else if (dtLog.Rows.Count == 0)
            {
                txtEmail.Clear();
                txtPassword.Clear();
                lblError.Visible = true;
            }
        }
    }
}

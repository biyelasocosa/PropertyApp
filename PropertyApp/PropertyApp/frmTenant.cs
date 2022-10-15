using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropertyApp
{
    public partial class frmTenant : Form
    {
        public frmTenant()
        {
            InitializeComponent();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            ucTenant1.BringToFront();
        }

        private void frmTenant_Load(object sender, EventArgs e)
        {
            DataTable dt = frmLogin.dtLog;
            lblUserID.Text = dt.Rows[0]["UserID"].ToString();
            lblFullname.Text = dt.Rows[0]["Name"].ToString() + " " + dt.Rows[0]["Surname"].ToString();
            lblUser.Text = "(" + dt.Rows[0]["Description"].ToString() + ")";
        }
    }
}

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
    public partial class frmAgent : Form
    {
        public frmAgent()
        {
            InitializeComponent();
        }

        private void btnRental_Click(object sender, EventArgs e)
        {
            ucRental1.BringToFront();
            pnlRental.BackColor = Color.Gold;
            pnlProperty.BackColor = Color.MidnightBlue;
        }

        private void btnProperty_Click(object sender, EventArgs e)
        {
            ucProperty1.BringToFront();
            pnlProperty.BackColor = Color.Gold;
            pnlRental.BackColor = Color.MidnightBlue;
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            frmLogin.dtLog = null;
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        private void frmAgent_Load(object sender, EventArgs e)
        {
            DataTable dt = frmLogin.dtLog;
            lblUserID.Text = dt.Rows[0]["UserID"].ToString();
            lblFullname.Text = dt.Rows[0]["Name"].ToString() + " " + dt.Rows[0]["Surname"].ToString();
            lblUser.Text = "(" + dt.Rows[0]["Description"].ToString() + ")";
        }
    }
}

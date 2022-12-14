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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            DataTable dt = frmLogin.dtLog;
            lblAdminID.Text = dt.Rows[0]["UserID"].ToString();
            lblFullname.Text = dt.Rows[0]["Name"].ToString() + " " + dt.Rows[0]["Surname"].ToString();
            lblUser.Text = "(" + dt.Rows[0]["Description"].ToString() + ")";

            ucDefault1.BringToFront();
        }

        private void btnPropertyType_Click(object sender, EventArgs e)
        {
            ucPropertyType1.BringToFront();
            
            pnlPropertyType.BackColor = Color.Gold;
            pnlProperty.BackColor = Color.MidnightBlue;
            pnlProvince.BackColor = Color.MidnightBlue;
            pnlCity.BackColor = Color.MidnightBlue;
            pnlSurbub.BackColor = Color.MidnightBlue;
            pnlAgency.BackColor = Color.MidnightBlue;
            pnlAgent.BackColor = Color.MidnightBlue;
        }

        private void btnProperty_Click(object sender, EventArgs e)
        {
            
            ucProperty1.BringToFront();

            pnlProperty.BackColor = Color.Gold;
            pnlPropertyType.BackColor = Color.MidnightBlue;
            pnlProvince.BackColor = Color.MidnightBlue;
            pnlCity.BackColor = Color.MidnightBlue;
            pnlSurbub.BackColor = Color.MidnightBlue;
            pnlAgency.BackColor = Color.MidnightBlue;
            pnlAgent.BackColor = Color.MidnightBlue;
        }

        private void btnProvince_Click(object sender, EventArgs e)
        {
            ucProvince1.BringToFront();

            pnlProvince.BackColor = Color.Gold;
            pnlPropertyType.BackColor = Color.MidnightBlue;
            pnlProperty.BackColor = Color.MidnightBlue;
            pnlCity.BackColor = Color.MidnightBlue;
            pnlSurbub.BackColor = Color.MidnightBlue;
            pnlAgency.BackColor = Color.MidnightBlue;
            pnlAgent.BackColor = Color.MidnightBlue;
        }

        private void btnCity_Click(object sender, EventArgs e)
        {
            ucCity1.BringToFront();

            pnlCity.BackColor = Color.Gold;
            pnlPropertyType.BackColor = Color.MidnightBlue;
            pnlProperty.BackColor = Color.MidnightBlue;
            pnlProvince.BackColor = Color.MidnightBlue;
            pnlSurbub.BackColor = Color.MidnightBlue;
            pnlAgency.BackColor = Color.MidnightBlue;
            pnlAgent.BackColor = Color.MidnightBlue;
        }

        private void btnSurbub_Click(object sender, EventArgs e)
        {
            ucSurbub1.BringToFront();

            pnlSurbub.BackColor = Color.Gold;
            pnlPropertyType.BackColor = Color.MidnightBlue;
            pnlProperty.BackColor = Color.MidnightBlue;
            pnlProvince.BackColor = Color.MidnightBlue;
            pnlCity.BackColor = Color.MidnightBlue;
            pnlAgency.BackColor = Color.MidnightBlue;
            pnlAgent.BackColor = Color.MidnightBlue;
        }

        private void btnAgency_Click(object sender, EventArgs e)
        {
            ucAgency1.BringToFront();

            pnlAgency.BackColor = Color.Gold;
            pnlPropertyType.BackColor = Color.MidnightBlue;
            pnlProperty.BackColor = Color.MidnightBlue;
            pnlProvince.BackColor = Color.MidnightBlue;
            pnlCity.BackColor = Color.MidnightBlue;
            pnlSurbub.BackColor = Color.MidnightBlue;
            pnlAgent.BackColor = Color.MidnightBlue;
        }

        private void btnAgent_Click(object sender, EventArgs e)
        {
            ucAgent1.BringToFront();

            pnlAgent.BackColor = Color.Gold;
            pnlPropertyType.BackColor = Color.MidnightBlue;
            pnlProperty.BackColor = Color.MidnightBlue;
            pnlProvince.BackColor = Color.MidnightBlue;
            pnlCity.BackColor = Color.MidnightBlue;
            pnlSurbub.BackColor = Color.MidnightBlue;
            pnlAgency.BackColor = Color.MidnightBlue;
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            frmLogin.dtLog = null;
            frmLogin log = new frmLogin();
            log.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmAdmin form = new frmAdmin();
            form.Refresh();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmReport report = new frmReport();
            report.Show();
            this.Hide();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            ucUser1.BringToFront();
        }
    }
}

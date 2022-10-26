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
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            ucUserReport1.BringToFront();
        }

        private void btnProperty_Click(object sender, EventArgs e)
        {
            ucPropertyReport1.BringToFront();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {

        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            ucLocationReport1.BringToFront();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmAdmin admin = new frmAdmin();
            admin.Show();
            this.Hide();
        }
    }
}

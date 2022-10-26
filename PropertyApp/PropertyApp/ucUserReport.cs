using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

namespace PropertyApp
{
    public partial class ucUserReport : UserControl
    {
        public ucUserReport()
        {
            InitializeComponent();
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();
        public void LoadcmbUserStatus()
        {
            cmbUserStatus.Items.Add("Active");
            cmbUserStatus.Items.Add("In-Active");
        }
        public void LoadcmbUserType()
        {
            cmbUserType.DataSource = bll.LoadUserType();
            cmbUserType.DisplayMember = "Description";
            cmbUserType.ValueMember = "UserTypeID";
        }
        private void ucUserReport_Load(object sender, EventArgs e)
        {
            LoadcmbUserStatus();
            LoadcmbUserType();
        }

        private void btnDisplayUser_Click(object sender, EventArgs e)
        {
            dgvReport.DataSource = bll.GetUserByStatus(cmbUserStatus.SelectedItem.ToString());
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void cmbUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int usertype;
            Int32.TryParse(cmbUserType.SelectedValue.ToString(), out usertype);

            dgvReport.DataSource = bll.GetUserType(usertype);
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbUserStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

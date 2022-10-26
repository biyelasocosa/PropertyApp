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
    public partial class ucUser : UserControl
    {
        public ucUser()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();

        private void ucUser_Load(object sender, EventArgs e)
        {
            LoadcmbStatus();
            GetUser();
        }

        private void btnSoft_Click(object sender, EventArgs e)
        {
            int userid;
            Int32.TryParse(dgvUser.SelectedRows[0].Cells["UserID"].Value.ToString(), out userid);

            string desc = dgvUser.SelectedRows[0].Cells["Description"].Value.ToString();
            if (desc == "Admin")
            {
                int x = bll.UpdateAdmin(userid);
                if(x > 0)
                {
                    MessageBox.Show("Archived");
                    GetUser();
                }
            }
            //else if (desc == "Agent")
            //{
            //    int x = bll.UpdateAgent(userid);
            //    if (x > 0)
            //    {
            //        MessageBox.Show("Archived");
            //        GetUser();
            //    }
            //}
            //else if (desc == "Tenant")
            //{
            //    int x = bll.Upda(userid);
            //    if (x > 0)
            //    {
            //        MessageBox.Show("Archived");
            //        GetUser();
            //    }
            //}
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            int userid;
            Int32.TryParse(dgvUser.SelectedRows[0].Cells["UserID"].Value.ToString(), out userid);

            string desc = dgvUser.SelectedRows[0].Cells["Description"].Value.ToString();
            if(desc == "Admin")
            {
                int x = bll.DeleteAdmin(userid);
                if(x > 0)
                {
                    MessageBox.Show("Deleted Permanant");
                    GetUser();
                }
            }
            else if(desc == "Agent")
            {
                int x = bll.DeleteAgent(userid);
                if(x > 0)
                {
                    MessageBox.Show("Deleted Permanant");
                    GetUser();
                }
            }
            else if(desc == "Tenant")
            {
                int x = bll.DeleteTenant(userid);
                if(x > 0)
                {
                    MessageBox.Show("Deleted Permanant");
                    GetUser();
                }
            }
        }
        public void GetUser()
        {
            dgvUser.DataSource = bll.GetUser();
            dgvUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            dgvUser.DataSource = bll.GetUserByStatus(cmbUserStatus.SelectedItem.ToString());
            dgvUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void LoadcmbStatus()
        {
            cmbUserStatus.Items.Add("Active");
            cmbUserStatus.Items.Add("In-Active");
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //lblDesc.Text = dgvUser.SelectedRows[0].Cells["Description"].Value.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace PropertyApp
{
    public partial class ucTenant : UserControl
    {
        public ucTenant()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();

        private void Tenant_Load(object sender, EventArgs e)
        {
            LoadcmbStatus();
        }
        public void LoadcmbStatus()
        {
            cmbStatus.Items.Add("Active");
            cmbStatus.Items.Add("In-Active");
        }
        private void btnApply_Click(object sender, EventArgs e)
        {
            Tenant ten = new Tenant(txtName.Text, txtSurname.Text, txtEmail.Text, txtPassword.Text, txtPhone.Text, cmbStatus.SelectedItem.ToString(), 3);
            int x = bll.InsertTenant(ten);
            if(x > 0)
            {
                MessageBox.Show(x + " Applied Successfully");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int tenantId;
            Int32.TryParse(dgvTenant.SelectedRows[0].Cells["TenantID"].Value.ToString(), out tenantId);
            Tenant ten = new Tenant(tenantId, txtEmail.Text, txtPhone.Text, cmbStatus.SelectedItem.ToString());

            int x = bll.UpdateTenant(ten);
            if(x > 0)
            {
                MessageBox.Show(x + "Updated");
                dgvTenant.DataSource = bll.GetTenant();
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            dgvTenant.DataSource = bll.GetTenant();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int tenantId;
            Int32.TryParse(dgvTenant.SelectedRows[0].Cells["TenantID"].Value.ToString(), out tenantId);

            int x = bll.DeleteTenant(tenantId);
            if(x > 0)
            {
                MessageBox.Show(x + " Deleted");
                dgvTenant.DataSource = bll.GetTenant();
            }
        }

        private void dgvTenant_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvTenant.SelectedRows.Count > 0)
            {
                txtName.Text = dgvTenant.SelectedRows[0].Cells["Name"].Value.ToString();
                txtSurname.Text = dgvTenant.SelectedRows[0].Cells["Surname"].Value.ToString();
                txtEmail.Text = dgvTenant.SelectedRows[0].Cells["Email"].Value.ToString();
                txtPassword.Text = dgvTenant.SelectedRows[0].Cells["Password"].Value.ToString();
                txtPhone.Text = dgvTenant.SelectedRows[0].Cells["Phone"].Value.ToString();
                cmbStatus.Text = dgvTenant.SelectedRows[0].Cells["Status"].Value.ToString();
            }
        }
    }
}

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
    public partial class ucAgent : UserControl
    {
        public ucAgent()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();

        private void ucAgent_Load(object sender, EventArgs e)
        {
            LoadCmbAgency();
            LoadStatus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Agent agent = new Agent(txtName.Text, txtSurname.Text, txtEmail.Text, txtPassword.Text, txtPhone.Text, cmbStatus.SelectedItem.ToString(), int.Parse(cmbAgency.SelectedValue.ToString()));
            int x = bll.InsertAgent(agent);
            if(x > 0)
            {
                MessageBox.Show(x + " Saved");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int agentId;
            Int32.TryParse(dgvAgent.SelectedRows[0].Cells["AgentID"].Value.ToString(), out agentId);
            Agent agent = new Agent(agentId, txtEmail.Text, txtPhone.Text, cmbStatus.SelectedItem.ToString());

            int x = bll.UpdateAgent(agent);
            if(x > 0)
            {
                MessageBox.Show(x + " Updated");
                dgvAgent.DataSource = bll.GetAgent();
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            dgvAgent.DataSource = bll.GetAgent();
            dgvAgent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int agentId;
            Int32.TryParse(dgvAgent.SelectedRows[0].Cells["AgentID"].Value.ToString(), out agentId);

            int x = bll.DeleteAgent(agentId);
            if(x > 0)
            {
                MessageBox.Show(x + " Deleted");
                dgvAgent.DataSource = bll.GetAgent();
            }
        }
        public void LoadCmbAgency()
        {
            cmbAgency.DataSource = bll.GetAgency();
            cmbAgency.DisplayMember = "AgencyName";
            cmbAgency.ValueMember = "AgencyID"; 
        }
        public void LoadStatus()
        {
            cmbStatus.Items.Add("Active");
            cmbStatus.Items.Add("In-Active");
        }

        private void dgvAgent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvAgent.SelectedRows.Count > 0)
            {
                txtName.Text = dgvAgent.SelectedRows[0].Cells["Name"].Value.ToString();
                txtSurname.Text = dgvAgent.SelectedRows[0].Cells["Surname"].Value.ToString(); 
                txtEmail.Text = dgvAgent.SelectedRows[0].Cells["Email"].Value.ToString();
                txtPassword.Text = dgvAgent.SelectedRows[0].Cells["Password"].Value.ToString();
                txtPhone.Text = dgvAgent.SelectedRows[0].Cells["Phone"].Value.ToString();
                cmbStatus.Text = dgvAgent.SelectedRows[0].Cells["Status"].Value.ToString();
                cmbAgency.Text = dgvAgent.SelectedRows[0].Cells["AgencyName"].Value.ToString();
            }
        }
    }
}

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
    public partial class ucPropertyAgent : UserControl
    {
        public ucPropertyAgent()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void ucPropertyAgent_Load(object sender, EventArgs e)
        {
            LoadcmbProperty();
            LoadcmbAgent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PropertyAgent propertyAgent = new PropertyAgent(int.Parse(cmbProperty.SelectedValue.ToString()), int.Parse(cmbAgent.SelectedValue.ToString()), dtpDate.Text);
            int x = bll.InsertPropertyAgent(propertyAgent);
            if(x > 0)
            {
                MessageBox.Show(x + " Added");
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            dgvPropertyAgent.DataSource = bll.GetPropertyAgent();
            dgvPropertyAgent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void LoadcmbProperty()
        {
            cmbProperty.DataSource = bll.GetProperty();
            cmbProperty.DisplayMember = "Description";
            cmbProperty.ValueMember = "PropertyID";
        }
        public void LoadcmbAgent()
        {
            cmbAgent.DataSource = bll.GetAgent();
            cmbAgent.DisplayMember = "Fullname";
            cmbAgent.ValueMember = "AgentID";
        }
    }
}

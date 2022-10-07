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
    public partial class ucAgency : UserControl
    {
        public ucAgency()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void ucAgency_Load(object sender, EventArgs e)
        {
            LoadCmbSurbub();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Agency agency = new Agency(txtName.Text, int.Parse(cmbSurbub.SelectedValue.ToString()));
            int x = bll.InsertAgency(agency);
            if(x > 0)
            {
                MessageBox.Show(x + " Added");
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            dgvAgency.DataSource = bll.GetAgency();
            dgvAgency.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void LoadCmbSurbub()
        {
            cmbSurbub.DataSource = bll.GetSurbub();
            cmbSurbub.DisplayMember = "SurbubDescription";
            cmbSurbub.ValueMember = "SurbubID";
        }
    }
}

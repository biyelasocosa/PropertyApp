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
    public partial class ucRental : UserControl
    {
        public ucRental()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        public void LoadcmbProperty()
        {
            cmbProperty.DataSource = bll.GetProperty();
            cmbProperty.DisplayMember = "Description";
            cmbProperty.ValueMember = "PropertyID";
        }
        public void LoadcmbTenant()
        {
            //cmbTenant.DataSource = bll.GetTenant();
            cmbTenant.DisplayMember = "FullName";
            cmbTenant.ValueMember = "TenantID";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Rental rent = new Rental(int.Parse(cmbProperty.SelectedValue.ToString()), int.Parse(cmbProperty.SelectedValue.ToString()), dtpStartDate.Text, dtpEndDate.Text);
            int x = bll.InsertRental(rent);
            if(x > 0)
            {
                MessageBox.Show(x + " Rental Saved");
            }
        }

        private void ucRental_Load(object sender, EventArgs e)
        {
            //LoadcmbProperty();
            //LoadcmbTenant();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int rentId;
            Int32.TryParse(dgvRental.SelectedRows[0].Cells["RentalID"].Value.ToString(), out rentId);

            Rental rent = new Rental(rentId, dtpStartDate.Text, dtpEndDate.Text);
            int x = bll.UpdateRental(rent);
            if(x > 0)
            {
                MessageBox.Show(x + " Updated");
                dgvRental.DataSource = bll.GetRental();
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            dgvRental.DataSource = bll.GetRental();
        }
    }
}

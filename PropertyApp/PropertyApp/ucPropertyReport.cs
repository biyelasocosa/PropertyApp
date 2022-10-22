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
using System.IO;

namespace PropertyApp
{
    public partial class ucPropertyReport : UserControl
    {
        public ucPropertyReport()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnList_Click(object sender, EventArgs e)
        {
            dgvReport.DataSource = bll.GetProperty();
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ucPropertyReport_Load(object sender, EventArgs e)
        {
            LoadcmbPropertyType();
        }

        private void btnSearchProperty_Click(object sender, EventArgs e)
        {
            dgvReport.DataSource = bll.GetPropertyByDesc(txtProperty.Text);
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnListPropertyType_Click(object sender, EventArgs e)
        {
            dgvReport.DataSource = bll.GetPropertyType();
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void cmbPropertyType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int usertype;
            Int32.TryParse(cmbPropertyType.SelectedValue.ToString(), out usertype);

            dgvReport.DataSource = bll.GetByPropertyType(usertype);
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvReport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvReport.SelectedRows.Count > 0)
            {
                byte[] image = (byte[])dgvReport.SelectedRows[0].Cells["Image"].Value;
                MemoryStream ms = new MemoryStream(image);
                imgProperty.Image = Image.FromStream(ms);
            }
        }
        public void LoadcmbPropertyType()
        {
            cmbPropertyType.DataSource = bll.GetPropertyType();
            cmbPropertyType.DisplayMember = "PropertyTypeDescription";
            cmbPropertyType.ValueMember = "PropertyTypeID";
        }

    }
}

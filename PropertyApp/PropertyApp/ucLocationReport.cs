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
    public partial class ucLocationReport : UserControl
    {
        public ucLocationReport()
        {
            InitializeComponent();
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnSurbub_Click(object sender, EventArgs e)
        {
            dgvReport.DataSource = bll.GetSurbub();
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnCity_Click(object sender, EventArgs e)
        {
            dgvReport.DataSource = bll.GetCity();
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnProvince_Click(object sender, EventArgs e)
        {
            dgvReport.DataSource = bll.GetProvince();
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ucLocationReport_Load(object sender, EventArgs e)
        {
            cmbProvince.DataSource = bll.GetProvince();
            cmbProvince.DisplayMember = "Description";
            cmbProvince.ValueMember = "ProvinceID";
        }

        private void cmbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            int province;
            Int32.TryParse(cmbProvince.SelectedValue.ToString(), out province);

            dgvReport.DataSource = bll.GetByPropertyType(province);
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnSearchCity_Click(object sender, EventArgs e)
        {
            dgvReport.DataSource = bll.GetByCityDesc(txtCity.Text);
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvReport.DataSource = bll.GetBySurbubDesc(txtSurbub.Text);
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}

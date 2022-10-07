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
    public partial class ucCity : UserControl
    {
        public ucCity()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ucCity_Load(object sender, EventArgs e)
        {
            LoadCmbProvince();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            City city = new City(txtDescription.Text, int.Parse(cmbProvince.SelectedValue.ToString()));
            int x = bll.InsertCity(city);
            if(x > 0)
            {
                MessageBox.Show(x + " Saved");
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            dgvCity.DataSource = bll.GetCity();
            dgvCity.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void LoadCmbProvince()
        {
            cmbProvince.DataSource = bll.GetProvince();
            cmbProvince.DisplayMember = "Description";
            cmbProvince.ValueMember = "ProvinceID";
        }
    }
}

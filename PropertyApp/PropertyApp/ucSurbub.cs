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
    public partial class ucSurbub : UserControl
    {
        public ucSurbub()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void ucSurbub_Load(object sender, EventArgs e)
        {
            LoadCmbCity();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Surbub surb = new Surbub(txtDescription.Text, txtPostalCode.Text, int.Parse(cmbCity.SelectedValue.ToString()));
            int x = bll.InsertSurbub(surb);
            if(x > 0)
            {
                MessageBox.Show(x + " Saved");
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            dgvSurbub.DataSource = bll.GetSurbub();
            dgvSurbub.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        } 
        public void LoadCmbCity()
        {
            cmbCity.DataSource = bll.GetCity();
            cmbCity.DisplayMember = "CityDescription";
            cmbCity.ValueMember = "CityID";
        }
    }
}

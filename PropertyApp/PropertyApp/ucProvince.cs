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
    public partial class ucProvince : UserControl
    {
        public ucProvince()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void button1_Click(object sender, EventArgs e)
        {
            Province prov = new Province(txtDescription.Text);
            int x = bll.InsertProvince(prov);
            if(x > 0)
            {
                MessageBox.Show(x + " Added");
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            dgvProvince.DataSource = bll.GetProvince();
            dgvProvince.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}

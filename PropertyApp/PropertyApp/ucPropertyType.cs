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
    public partial class ucPropertyType : UserControl
    {
        public ucPropertyType()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnSave_Click(object sender, EventArgs e)
        {
            PropertyType type = new PropertyType(txtDescription.Text);
            int x = bll.InsertPropertyType(type);
            if (x > 0)
            {
                MessageBox.Show(x + " Saved");
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            dgvPropertyType.DataSource = bll.GetPropertyType();
            dgvPropertyType.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ucPropertyType_Load(object sender, EventArgs e)
        {

        }
    }
}

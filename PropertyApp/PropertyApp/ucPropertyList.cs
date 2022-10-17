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
    public partial class ucPropertyList : UserControl
    {
        public ucPropertyList()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void ucPropertyList_Load(object sender, EventArgs e)
        {
            LoadPropertyList();
        }
        public void LoadPropertyList()
        {
            dgvPropertyList.DataSource = bll.GetProperty();
            dgvPropertyList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvPropertyList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvPropertyList.SelectedRows.Count > 0)
            {
                lblDescription.Text = dgvPropertyList.SelectedRows[0].Cells["Description"].Value.ToString();
                lblPrice.Text = "R" + dgvPropertyList.SelectedRows[0].Cells["Price"].Value.ToString();
                lblPropertyType.Text = dgvPropertyList.SelectedRows[0].Cells["PropertyType"].Value.ToString();
                lblSurbub.Text = dgvPropertyList.SelectedRows[0].Cells["Surbub"].Value.ToString();
                lblStatus.Text = dgvPropertyList.SelectedRows[0].Cells["Status"].Value.ToString();


                byte[] image = (byte[]) dgvPropertyList.SelectedRows[0].Cells["Image"].Value;
                MemoryStream ms = new MemoryStream(image);
                imgProperty.Image = Image.FromStream(ms);   
            }
            else
            {

            }
        }
    }
}

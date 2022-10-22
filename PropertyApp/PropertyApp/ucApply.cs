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
    public partial class ucApply : UserControl
    {
        public ucApply()
        {
            InitializeComponent();
        }
        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void ucApply_Load(object sender, EventArgs e)
        {
            dgvRental.DataSource = bll.GetProperty();
            dgvRental.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvRental.DataSource = bll.GetPropertyByDesc(txtSearch.Text);
            dgvRental.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvRental_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRental.SelectedRows.Count > 0)
            {
                lblPropertyID.Text = dgvRental.SelectedRows[0].Cells["PropertyID"].Value.ToString();

                byte[] image = (byte[])dgvRental.SelectedRows[0].Cells["Image"].Value;
                MemoryStream ms = new MemoryStream(image);
                imgProperty.Image = Image.FromStream(ms);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            btnApply.Visible = false;
            btnRent.Visible = true;
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            DataTable dt = frmLogin.dtLog;
            int tenId = int.Parse(dt.Rows[0]["UserID"].ToString());

            Rental rent = new Rental(int.Parse(lblPropertyID.Text), tenId, dtpStartDate.Text, dtpEndDate.Text);
            int x = bll.InsertRental(rent);
            if(x > 0)
            {
                MessageBox.Show("Rental Successful");
            }
        }
    }
}

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
using System.IO;

namespace PropertyApp
{
    public partial class ucProperty : UserControl
    {
        public ucProperty()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        BusinessLogicLayer bll = new BusinessLogicLayer();

        private void ucProperty_Load(object sender, EventArgs e)
        {
            LoadCmbPropertyType();
            LoadCmbSurbub();
            LoadCmbStatus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            
            //Property propty = new Property(txtDescription.Text, double.Parse(txtPrice.Text.ToString()),image, int.Parse(cmbPropertyType.SelectedValue.ToString()), cmbStatus.SelectedItem.ToString(), int.Parse(cmbSurbub.SelectedValue.ToString()));
            //int x = bll.InsertProperty(propty);
            //if(x > 0)
            //{
            //    MessageBox.Show(x + " Saved");
            //}
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            dgvProperty.DataSource = bll.GetProperty();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog fileDialog  = new OpenFileDialog())
            {
                
                if(fileDialog.ShowDialog() == DialogResult.OK)
                {
                    imgProperty.Image = Image.FromFile(fileDialog.FileName);
                }
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            MemoryStream mstream = new MemoryStream();
            imgProperty.Image.Save(mstream, imgProperty.Image.RawFormat);

        }
        public void LoadCmbPropertyType()
        {
            cmbPropertyType.DataSource = bll.GetPropertyType();
            cmbPropertyType.DisplayMember = "PropertyTypeDescription";
            cmbPropertyType.ValueMember = "PropertyTypeID";
        }
        public void LoadCmbSurbub()
        {
            cmbSurbub.DataSource = bll.GetSurbub();
            cmbSurbub.DisplayMember = "SurbubDescription";
            cmbSurbub.ValueMember = "SurbubID";
        }
        public void LoadCmbStatus()
        {
            cmbStatus.Items.Add("Available");
            cmbStatus.Items.Add("Unavailable");
        }

    }
}

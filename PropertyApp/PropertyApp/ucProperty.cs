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
            try
            {
                MemoryStream ms = new MemoryStream();
                imgProperty.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                byte[] image = ms.GetBuffer();

                Property property = new Property(txtDescription.Text, double.Parse(txtPrice.Text.ToString()), image, int.Parse(cmbPropertyType.SelectedValue.ToString()), cmbStatus.SelectedItem.ToString(), int.Parse(cmbSurbub.SelectedValue.ToString()));
                int x = bll.InsertPropety(property);
                if(x > 0)
                {
                    MessageBox.Show(x + " Saved");
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Something Went Wrong");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int propertyId;
            Int32.TryParse(dgvProperty.SelectedRows[0].Cells["PropertyID"].Value.ToString(), out propertyId);
            Property property = new Property(propertyId, int.Parse(cmbPropertyType.SelectedValue.ToString()), double.Parse(txtPrice.Text), cmbStatus.SelectedItem.ToString());
            
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

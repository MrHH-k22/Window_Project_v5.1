using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Window_Project_v5._1.Properties;

namespace Window_Project_v5._1.Forms
{
    public partial class FSellDetail : Form
    {
        ProductDAO productDAO = new ProductDAO();
        ImageDAO imageDAO = new ImageDAO();

        private string[] imgLocations = new string[4];

        public FSellDetail()
        {
            InitializeComponent();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnImage1_Click(object sender, EventArgs e)
        {
            OpenImageDialog(btnImage1, 0);
        }

        private void btnImage2_Click(object sender, EventArgs e)
        {
            OpenImageDialog(btnImage2, 1);
        }

        private void btnImage3_Click(object sender, EventArgs e)
        {
            OpenImageDialog(btnImage3, 2);
        }

        private void btnImage4_Click(object sender, EventArgs e)
        {
            OpenImageDialog(btnImage4, 3);
        }

        private void OpenImageDialog(Bunifu.UI.WinForms.BunifuImageButton button, int index)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocations[index] = dialog.FileName;
                button.Image = System.Drawing.Image.FromFile(imgLocations[index]);
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            Product product = new Product(txtCondition.Text, txtStatus.Text, StringToDouble(txtBuyPrice.Text), StringToDouble(txtSellPrice.Text), txtProductTitle.Text, txtDescription.Text);       
            productDAO.Add(product);
            //Add images to Productimages
            product = productDAO.GetLastProduct(); 
            foreach (string imgLocation in imgLocations)
            {
                if (string.IsNullOrEmpty(imgLocation))
                {
                    break;
                }
                imageDAO.Add(product.Id, imgLocation);
            }
            this.Close();
        }

        private double StringToDouble(string str)
        {
            decimal decimalResult;
            if (decimal.TryParse(str, out decimalResult))
            {
                if (decimalResult >= -9999999.99m && decimalResult <= 9999999.99m)
                {
                    return (double)decimalResult;
                }
            }
            MessageBox.Show("The value of price is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return -1;
        }
    }
}

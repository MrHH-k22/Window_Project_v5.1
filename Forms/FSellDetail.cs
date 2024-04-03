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
        private ProductDAO productDAO = new ProductDAO();
        private ImageDAO imageDAO = new ImageDAO();
        private Account acc = new Account();
        private AccountDAO accountDAO = new AccountDAO();
        private string selectedValue = null;
        private bool edit = false;
        private Product pd;
        private string[] imgLocations = new string[4];

        public FSellDetail()
        {
            InitializeComponent();
        }

        public FSellDetail(Product pd)
        {
            InitializeComponent();
            this.pd = pd;
            txtCondition.Text = pd.Condition.ToString();
            txtStatus.Text = pd.Status.ToString();
            txtBuyPrice.Text = pd.OriginalPrice.ToString();
            txtSellPrice.Text = pd.SalePrice.ToString();
            txtProductTitle.Text = pd.Name.ToString();
            txtDescription.Text = pd.Description.ToString();
            txtBrand.Text = pd.Brand.ToString();
            ddCategory.SelectedItem = pd.Category.ToString();
            selectedValue = pd.Category.ToString();
            acc = accountDAO.Retrieve(pd.SellerID);
            edit = true;
            btnPost.Text = "Update product";
        }

        public FSellDetail(Account acc)
        {
            InitializeComponent();
            this.acc = acc;
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

        private void ddCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ddCategory.SelectedItem != null)
            {
                selectedValue = ddCategory.SelectedItem.ToString();
            }
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            //string category = ddCategories.SelectedValue.ToString();
            Product product = new Product(txtCondition.Text, txtStatus.Text, StringToDouble(txtBuyPrice.Text), StringToDouble(txtSellPrice.Text), txtProductTitle.Text, txtDescription.Text, txtBrand.Text, selectedValue, acc.Id);
            if (!edit)
            {
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
            } else
            {
                //Update product
                pd.Condition = txtCondition.Text;
                pd.Status = txtStatus.Text;
                pd.Brand = txtBrand.Text;
                pd.OriginalPrice = StringToDouble(txtBuyPrice.Text);
                pd.SalePrice = StringToDouble(txtSellPrice.Text);
                pd.Description = txtDescription.Text;
                pd.Category = selectedValue;
                pd.Name = txtProductTitle.Text;
                productDAO.Update(pd);
                //Update Images
                imageDAO.Delete(pd.Id);
                foreach (string imgLocation in imgLocations)
                {
                    if (string.IsNullOrEmpty(imgLocation))
                    {
                        break;
                    }
                    imageDAO.Add(pd.Id, imgLocation);
                }
            }
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

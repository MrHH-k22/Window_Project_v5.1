using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
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
        private string selectedCategory = null;
        private string selectedArea = null;
        private bool edit = false;
        private Product pd;
        private string[] imgLocations = new string[4];

        public FSellDetail()
        {
            InitializeComponent();
            containerMenu.Visible = false;
        }

        public FSellDetail(Product pd)
        {
            InitializeComponent();
            edit = true;
            containerMenu.Visible = false;
            this.pd = pd;
            selectedCategory = pd.Category;
            txtProductTitle.Text = pd.Name; 
            txtType.Text = pd.Type; 
            txtBuyPrice.Text = pd.OriginalPrice.ToString(); 
            txtSellPrice.Text = pd.SalePrice.ToString(); 
            selectedArea = pd.Area; 
            txtCondition.Text = pd.Condition; 
            txtStatus.Text = pd.Status; 
            txtSupportPolicy.Text = pd.SupportPolicy; 
            txtBrand.Text = pd.Brand; 
            txtOrigin.Text = pd.Origin; 
            txtMaterial.Text = pd.Material; 
            txtSize.Text = pd.Size; 
            txtFunctionalities.Text = pd.Functionality; 
            txtDescription.Text = pd.Description;
            btnPost.Text = "Update product";
            ddCategory.SelectedItem = pd.Category;
            ddArea.SelectedItem = pd.Area;
        }

        public FSellDetail(Account acc)
        {
            InitializeComponent();
            containerMenu.Visible = false;
            this.acc = acc;
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void OpenImageDialog(Guna.UI2.WinForms.Guna2ImageButton button, int index)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "All files(*.*)|*.*|png files(*.png)|*.png|jpg files(*.jpg)|*.jpg";

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
            double decimalResult;
            if (double.TryParse(str, out decimalResult))
            {
                    return (double)decimalResult;
            }
            MessageBox.Show("The value of price is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return -1;
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSize_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaterial_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBrand_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOrigin_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSellPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuyPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtType_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCondition_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSupportPolicy_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProductTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void ddCategory_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (ddCategory.SelectedItem != null)
            {
                selectedCategory = ddCategory.SelectedItem.ToString();
            }
        }

        private void panelMiddle_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnImage1_Click_1(object sender, EventArgs e)
        {
            OpenImageDialog(btnImage1, 0);
        }

        private void btnImage2_Click_1(object sender, EventArgs e)
        {
            OpenImageDialog(btnImage2, 1);
        }

        private void btnImage3_Click_1(object sender, EventArgs e)
        {
            OpenImageDialog(btnImage3, 2);
        }

        private void btnImage4_Click_1(object sender, EventArgs e)
        {
            OpenImageDialog(btnImage4, 3);
        }

        private void btnPost_Click_1(object sender, EventArgs e)
        {
            //string category = ddCategories.SelectedValue.ToString();
            Product product = new Product(selectedCategory, txtProductTitle.Text, txtType.Text, StringToDouble(txtBuyPrice.Text), StringToDouble(txtSellPrice.Text), selectedArea, txtCondition.Text, txtStatus.Text, txtSupportPolicy.Text, txtBrand.Text, txtOrigin.Text, txtMaterial.Text, txtSize.Text, txtFunctionalities.Text, txtDescription.Text, acc.Id);
            if (!edit)
            {
                product.PostedTime = DateTime.Now;
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
            }
            else
            {
                //Update product
                pd.Category = selectedCategory;
                pd.Name = txtProductTitle.Text;
                pd.Type = txtType.Text;
                pd.OriginalPrice = StringToDouble(txtBuyPrice.Text);
                pd.SalePrice = StringToDouble(txtSellPrice.Text);
                pd.Area = selectedArea;
                pd.Condition = txtCondition.Text;
                pd.Status = txtStatus.Text;
                pd.SupportPolicy = txtSupportPolicy.Text;
                pd.Brand = txtBrand.Text;
                pd.Origin = txtOrigin.Text;
                pd.Material = txtMaterial.Text;
                pd.Size = txtSize.Text;
                pd.Functionality = txtFunctionalities.Text;
                pd.Description = txtDescription.Text;
                productDAO.Update(pd, true);
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
            this.Hide();
            FBuy f = new FBuy(acc);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FBuy f = new FBuy(acc);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void ddArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddArea.SelectedItem != null)
            {
                selectedArea = ddArea.SelectedItem.ToString();
            }
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            this.Hide();
            FCart f = new FCart(acc);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnPostProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            FSellDetail f = new FSellDetail(acc);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (containerMenu.Visible == false)
            {
                containerMenu.Visible = true;
            }
            else
            {
                containerMenu.Visible = false;
            }
        }

        private void btnPurchasesOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            FTrackOrder f = new FTrackOrder(acc);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnSalesOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            FProductManagement f = new FProductManagement(acc);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnSavedProducts_Click(object sender, EventArgs e)
        {
            this.Hide();
            FSaveList f = new FSaveList(acc);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnOrderAnalysis_Click(object sender, EventArgs e)
        {
            this.Hide();
            FOrderAnalysis f = new FOrderAnalysis(acc);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            this.Hide();
            FInformation f = new FInformation(acc);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            this.Hide();
            FMoney f = new FMoney(acc);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FSignin f = new FSignin();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            this.Hide();
            FBuy f = new FBuy(acc);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }
    }
}

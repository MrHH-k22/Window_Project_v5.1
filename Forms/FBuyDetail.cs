using Bunifu.Framework.UI;
using Bunifu.UI.WinForms;
using Guna.UI2.WinForms;
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

namespace Window_Project_v5._1.Forms
{
    public partial class FBuyDetail : Form
    {
        private ImageDAO imageDAO = new ImageDAO();
        private ProductDAO productDAO = new ProductDAO();
        private FavoriteDAO favoriteDAO = new FavoriteDAO();
        private Account account = new Account();
        private AccountDAO accountDAO = new AccountDAO();
        private Product product = new Product();


        public FBuyDetail()
        {
            InitializeComponent();
        }

        public FBuyDetail(Product pd,Account acc)
        {
            InitializeComponent();
            account = acc;
 
            product = pd;
            pd.ViewCount++;
            productDAO.Update(pd);
            lblProductName.Text = pd.Name;
            lblSellPrice.Text = pd.SalePrice.ToString("N0") + " VND";
            lblBuyPrice.Text = pd.OriginalPrice.ToString("N0") + " VND";
            lblCondition.Text = "Condition: " + pd.Condition.ToString() + "%";
            lblBrand.Text = "Brand: " + pd.Brand.ToString();
            lblCategory.Text = "Category: " + pd.Category.ToString();
            txtStatus.Text = pd.Status.ToString();
            txtDescription.Text = pd.Description.ToString();
            txtSupportPolicy.Text = pd.SupportPolicy.ToString();
            lblArea.Text = "Area: " + pd.Area.ToString();
            lblOrigin.Text = "Origin: " + pd.Origin.ToString();
            lblMaterial.Text = "Material: " + pd.Material.ToString();
            lblSize.Text = "Size: " + pd.Size.ToString();
            txtFunctionalities.Text = pd.Functionality.ToString();
            DataTable ImageTable = imageDAO.GetImageProduct(pd.Id);

            int pictureBoxIndex = 0;

            foreach (DataRow row in ImageTable.Rows)
            {
                if (pictureBoxIndex >= 4) // If we have more images than PictureBoxes
                    break;

                byte[] imageData = (byte[])row["Image"]; // Access the "Image" column

                // Load image into PictureBox
                MemoryStream ms = new MemoryStream(imageData);

                // Assign pictureBox variable based on index
                Guna2ImageButton pictureBox = null;

                switch (pictureBoxIndex)
                {
                    
                    case 0:
                        pictureBox = btnImage1;
                        break;
                    case 1:
                        pictureBox = btnImage2;
                        break;
                    case 2:
                        pictureBox = btnImage3;
                        break;
                    case 3:
                        pictureBox = btnImage4;
                        break;
                    
                }

                // Assign image to PictureBox and make it visible
                pictureBox.Image = Image.FromStream(ms);
                pictureBox.Visible = true;

                pictureBoxIndex++;
            }

            // Hide any remaining PictureBoxes
            for (int i = pictureBoxIndex; i < 4; i++)
            {
                switch (i)
                {
                    case 0:
                        btnImage1.Visible = false;
                        break;
                    case 1:
                        btnImage2.Visible = false;
                        break;
                    case 2:
                        btnImage3.Visible = false;
                        break;
                    case 3:
                        btnImage4.Visible = false;
                        break;
                }
            }

            //check button save
            if (favoriteDAO.checkProductinFavorite(account.Id, product.Id))
            {
                btnSave.Text = "Saved";
                btnSave.FillColor = Color.WhiteSmoke;
                btnSave.ForeColor = Color.Red;
            }
            else
            {
                btnSave.Text = "Save";
                btnSave.FillColor = Color.Red;
                btnSave.ForeColor = Color.WhiteSmoke;
            }
            //check seller
            if(account.Id == product.SellerID)
            {
                btnSave.Visible = false;
                btnBuy.Visible = false;
            }

            Account seller = accountDAO.Retrieve(product.SellerID);
            lblAvatarName.Text = seller.Name;
            convertByte(pbAvatar, seller.Avatar);

        }

        private void convertByte(PictureBox pic, byte[] imageData)
        {

            if (imageData != null && imageData.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    // Attempt to create Image object
                    try
                    {
                        pic.Image = Image.FromStream(ms);
                    }
                    catch (ArgumentException ex)
                    {
                        // Handle ArgumentException
                        Console.WriteLine("Failed to create Image object: " + ex.Message);
                    }
                }
            }
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (favoriteDAO.checkProductinFavorite(account.Id, product.Id))
            {
                favoriteDAO.delete(account.Id, product.Id);
                btnSave.Text = "Save";

                btnSave.FillColor = Color.Red;
                btnSave.ForeColor = Color.WhiteSmoke;
            }
            else
            {
                favoriteDAO.add(account.Id, product.Id);
                btnSave.Text = "Saved";

                btnSave.FillColor = Color.WhiteSmoke;
                btnSave.ForeColor = Color.Red;
            }
        }


        private void btnBuy_Click(object sender, EventArgs e)
        {
            // Prompt the user with a message box
            DialogResult result = MessageBox.Show("Are you sure you want to buy this product?", "BUY PRODUCT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check if the user clicked "Yes"
            if (result == DialogResult.Yes)
            {
  
                if(account.Money < product.SalePrice)
                {
                    MessageBox.Show("You dont have enough money to buy!");
                }
                else
                {
                    // Proceed with the purchase
                    account.Money -= product.SalePrice;
                    accountDAO.update(account);
                    //get seller
                    Account Seller = accountDAO.Retrieve(product.SellerID);
                    Seller.Money += product.SalePrice;
                    accountDAO.update(Seller);
                    if (favoriteDAO.checkProductinFavorite(account.Id, product.Id))
                    {
                        favoriteDAO.delete(account.Id, product.Id);
                    }
                    product.BuyerID = account.Id;
                    product.OrderCondition = (int)ordercondition.WaitforConfirmation;
                    productDAO.Update(product);
                }
                this.Close();
            }
        }

        private void btnImage1_Click(object sender, EventArgs e)
        {

        }

        private void btnImage2_Click(object sender, EventArgs e)
        {
            Bunifu.UI.WinForms.BunifuImageButton temp = new Bunifu.UI.WinForms.BunifuImageButton();
            temp.Image = btnImage1.Image;
            btnImage1.Image = btnImage2.Image;
            btnImage2.Image = temp.Image;
        }

        private void btnImage3_Click(object sender, EventArgs e)
        {
            Bunifu.UI.WinForms.BunifuImageButton temp = new Bunifu.UI.WinForms.BunifuImageButton();
            temp.Image = btnImage1.Image;
            btnImage1.Image = btnImage3.Image;
            btnImage3.Image = temp.Image;
        }

        private void btnImage4_Click(object sender, EventArgs e)
        {
            Bunifu.UI.WinForms.BunifuImageButton temp = new Bunifu.UI.WinForms.BunifuImageButton();
            temp.Image = btnImage1.Image;
            btnImage1.Image = btnImage4.Image;
            btnImage4.Image = temp.Image;
        }
    }
}

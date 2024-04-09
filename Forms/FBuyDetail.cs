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
        private CartDAO cartDAO = new CartDAO();
        private Account account = new Account();
        private AccountDAO accountDAO = new AccountDAO();
        private Product product = new Product();


        public FBuyDetail()
        {
            InitializeComponent();
            containerMenu.Visible = false;
        }

        public FBuyDetail(Product pd,Account acc)
        {
            InitializeComponent();
            containerMenu.Visible = false;
            account = accountDAO.Retrieve(acc.Id);
            product = pd;
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


        private void btnImage1_Click(object sender, EventArgs e)
        {

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

        private void btnImage2_Click(object sender, EventArgs e)
        {
            Bunifu.UI.WinForms.BunifuImageButton temp = new Bunifu.UI.WinForms.BunifuImageButton();
            temp.Image = btnImage2.Image;
            btnImage2.Image = btnImage2.Image;
            btnImage2.Image = temp.Image;
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

                if (account.Money < product.SalePrice)
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

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            if (cartDAO.checkProductinCart(account.Id, product.Id))
            {
                cartDAO.delete(account.Id, product.Id);
                btnAddtoCart.Text = "Add to cart";
            }
            else
            {
                cartDAO.add(account.Id, product.Id);
                btnAddtoCart.Text = "Already in your cart";
            }
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            this.Hide();
            FCart f = new FCart(account);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnPostProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            FSellDetail f = new FSellDetail(account);
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
            FTrackOrder f = new FTrackOrder(account);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnSalesOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            FProductManagement f = new FProductManagement(account);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnSavedProducts_Click(object sender, EventArgs e)
        {
            this.Hide();
            FSaveList f = new FSaveList(account);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnOrderAnalysis_Click(object sender, EventArgs e)
        {
            this.Hide();
            FOrderAnalysis f = new FOrderAnalysis(account);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            this.Hide();
            FInformation f = new FInformation(account);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            this.Hide();
            FMoney f = new FMoney(account);
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

        private void FBuyDetail_Load(object sender, EventArgs e)
        {
            product.ViewCount++;
            productDAO.Update(product);
            lblProductName.Text = product.Name;
            lblSellPrice.Text = product.SalePrice.ToString("N0") + " VND";
            lblBuyPrice.Text = product.OriginalPrice.ToString("N0") + " VND";
            txtStatus.Text = product.Status.ToString();
            txtDescription.Text = product.Description.ToString();
            txtSupportPolicy.Text = product.SupportPolicy.ToString();
            txtFunctionalities.Text = product.Functionality.ToString();
            lblArea.Text = "Area: " + product.Area;
            lblOrigin.Text = "Origin: " + product.Origin;
            lblMaterial.Text = "Material: " + product.Material;
            lblSize.Text = "Size: " + product.Size;
            lblCondition.Text = "Condition: " + product.Condition + "%";
            lblBrand.Text = "Brand: " + product.Brand;
            lblCategory.Text = "Category: " + product.Category;
            lblType.Text = "Type: " + product.Type;
            DataTable ImageTable = imageDAO.GetImageProduct(product.Id);

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
            //check cart
            if (cartDAO.checkProductinCart(account.Id, product.Id))
            {
                btnAddtoCart.Text = "Already in your cart";
            }
            else
            {
                btnAddtoCart.Text = "Add to cart";
            }
            //check seller
            if (account.Id == product.SellerID)
            {
                btnSave.Visible = false;
                btnBuy.Visible = false;
            }

            Account seller = accountDAO.Retrieve(product.SellerID);
            lblAvatarName.Text = seller.Name;
            convertByte(pbAvatar, seller.Avatar);
        }
    }
}

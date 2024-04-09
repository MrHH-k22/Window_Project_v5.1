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

namespace Window_Project_v5._1.Forms
{
    public partial class UCProductBuy : UserControl
    {
        private ImageDAO imageDAO = new ImageDAO();
        private AccountDAO accountDAO = new AccountDAO();
        private ProductDAO productDAO = new ProductDAO();
        private CartDAO cartDAO = new CartDAO();
        private FavoriteDAO favoriteDAO = new FavoriteDAO();
        private Account account = new Account();
        private Product product;
        private bool checkCart; // false for favorite, true for cart

        public UCProductBuy()
        {
            InitializeComponent();
            SetEventForAllControls(this);
            this.Controls.Remove(btnRate);

        }

        public UCProductBuy(Product pd, Account acc)
        {
            InitializeComponent();
            SetEventForAllControls(this);
            InitializeUCProductBuy(pd, acc);

        }

        public UCProductBuy(Product pd, Account acc, bool checkCart)
        {
            InitializeComponent();
            SetEventForAllControls(this);
            InitializeUCProductBuy(pd, acc);
            this.checkCart = checkCart;
        }

        private void InitializeUCProductBuy(Product pd, Account acc)
        {
            this.Dock = DockStyle.Top;
            btnRate.Visible = false;
            this.product = pd;
            account = acc;
            lblPrice.Text = pd.SalePrice.ToString();
            lblProductCondition.Visible = false;
            lblProductName.Text = pd.Name;
            int a = 0;
            if(btnRate.Visible == true)
            {
                a = 1;
            }


            byte[] imageData = imageDAO.GetImageProductData(pd.Id);

            if (imageData != null && imageData.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    // Attempt to create Image object
                    try
                    {
                        pbProduct.Image = Image.FromStream(ms);
                    }
                    catch (ArgumentException ex)
                    {
                        // Handle ArgumentException
                        Console.WriteLine("Failed to create Image object: " + ex.Message);
                    }
                }
            }
        }




        private void UCProductBuy_Load(object sender, EventArgs e)
        {
            SetEventForAllControls(this);
            Account seller = accountDAO.Retrieve(product.SellerID);
            lblSellerName.Text = "Seller name: " + seller.Name;
            
            if(product.OrderCondition == (int)ordercondition.Completed)
            {
                btnCancel.Visible = false;
                btnRate.Visible = true;
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (product.BuyerID != 0)
            {
                account.Money += product.SalePrice;
                accountDAO.update(account);
                //get seller
                Account Seller = accountDAO.Retrieve(product.SellerID);
                Seller.Money -= product.SalePrice;
                accountDAO.update(Seller);
                //add to account cancelled list
                if (product.Id != null)
                {
                    account.CancelledList.Add(product.Id);
                }
                //
                product.OrderCondition = (int)ordercondition.Cancelled;
                productDAO.Update(product);
                productDAO.DeleteBuyerID(product);
            } else
            {
                if (checkCart)
                {
                    cartDAO.delete(account.Id, product.Id);
                } else
                {
                    favoriteDAO.delete(account.Id, product.Id);
                }
            }
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            FBuyDetail trackDetail = new FBuyDetail(product, account);
            trackDetail.Show();
        }


        private void UCProductBuy_MouseEnter(object sender, EventArgs e)
        {
            panelBody.BorderColor = Color.Black;
        }

        private void UCProductBuy_MouseLeave(object sender, EventArgs e)
        {
            panelBody.BorderColor = Color.FromArgb(250, 250, 250);
        }

        private void SetEventForAllControls(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                control.MouseEnter += UCProductBuy_MouseEnter;
                control.MouseLeave += UCProductBuy_MouseLeave;
                if (control.HasChildren)
                {
                    SetEventForAllControls(control);
                }
            }
        }

        private void btnRate_Click(object sender, EventArgs e)
        {
            FRating f = new FRating(product);
            f.Show();
        }
    }
}

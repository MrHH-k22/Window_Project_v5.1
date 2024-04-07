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
        private Account account = new Account();
        private AccountDAO accountDAO = new AccountDAO();
        private Product product;
        private ProductDAO productDAO = new ProductDAO();
        private CartDAO cartDAO = new CartDAO();

        public UCProductBuy()
        {
            InitializeComponent();
        }

        public UCProductBuy(Product pd, Account acc)
        {
            InitializeComponent();
            this.Dock = DockStyle.Top;
            this.Controls.Remove(btnRate);
            this.product = pd;
            account = acc;
            lblPrice.Text = pd.SalePrice.ToString();
            lblProductCondition.Visible = false;
            lblProductName.Text = pd.Name;

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
            Account seller = accountDAO.Retrieve(product.SellerID);
            lblSellerName.Text = "Seller name: " + seller.Name;
            btnFunction.Enabled = false;
            if (product.OrderCondition == (int)ordercondition.WaitforConfirmation)
            {
                btnFunction.Text = "Wait for confirmation";
            }
            else if (product.OrderCondition == (int)ordercondition.Delivering)
            {
                btnFunction.Text = "Delivering";
            }
            else if (product.OrderCondition == (int)ordercondition.Completed)
            {
                btnFunction.Text = "Completed";
            }
            if(product.OrderCondition == (int)ordercondition.Completed)
            {
                this.Controls.Remove(btnCancel);
                this.Controls.Add(btnRate);
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
                cartDAO.delete(account.Id, product.Id);
            }
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            FBuyDetail trackDetail = new FBuyDetail(product, account);
            trackDetail.Show();
        }

        private void btnRate_Click(object sender, EventArgs e)
        {
            FRating f = new FRating(product);
            f.Show();
        }
    }
}

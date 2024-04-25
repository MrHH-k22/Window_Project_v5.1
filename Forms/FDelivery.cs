using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Window_Project_v5._1.Forms
{
    public partial class FDelivery : Form
    {
        private List<Product> products = new List<Product>();
        private AccountDAO accountDAO = new AccountDAO();
        private FavoriteDAO favoriteDAO = new FavoriteDAO();
        private ProductDAO productDAO = new ProductDAO();
        private CartDAO cartDAO = new CartDAO();
        private Account acc = new Account();
        private double total = 0;
        private int payMethod = -1;

        public FDelivery()
        {
            InitializeComponent();
            containerMenu.Visible = false;
        }

        public FDelivery(Account acc, List<Product> products)
        {
            InitializeComponent();
            containerMenu.Visible = false;
            this.acc = accountDAO.Retrieve(acc.Id);
            this.products = products;
        }

        private void FDelivery_Load(object sender, EventArgs e)
        {
            foreach (Product p in products)
            {
                UCProductCart uc = new UCProductCart(p, acc);
                uc.cbSelected.Visible = false;
                total += p.SalePrice;
                flpCartList.Controls.Add(uc);
            }
            if (acc.Money < total)
            {
                rbtnCash.Checked = true;
                rbtnOnline.Checked = false;
                rbtnOnline.Enabled = false;
            }
            txtAddress.Text = acc.Address;
            txtPhone.Text = acc.Phone;
            lblPrice.Text = total.ToString("N0") + " VND";
            lblNoOfItems.Text = products.Count.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            this.Hide();
            FCart f = new FCart(acc);
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

        private void btnPost_Click(object sender, EventArgs e)
        {
            this.Hide();
            FSellDetail f = new FSellDetail(acc);
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

        private void rbtnOnline_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbtnOnline.Checked)
            {
                payMethod = 1;
                rbtnCash.Checked = false;
            }
        }

        private void rbtnCash_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbtnCash.Checked)
            {
                payMethod = 0;
                rbtnOnline.Checked = false;
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Phone has not been filled in", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Address has not been filled in", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (payMethod == -1)
            {
                MessageBox.Show("Payment Method has not been chosen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Prompt the user with a message box
                DialogResult result = MessageBox.Show("Are you sure you want to buy these product?", "BUY PRODUCT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Check if the user clicked "Yes"
                if (result == DialogResult.Yes)
                {
                    foreach (Product product in products)
                    {
                        // Update Buyer money
                        Account buyer = accountDAO.Retrieve(acc.Id);
                        if (payMethod == 1)
                        {
                            buyer.Money -= total;
                            accountDAO.update(buyer);
                        }
                        //  Update Seller money
                        Account seller = accountDAO.Retrieve(product.SellerID);
                        seller.Money += product.SalePrice;
                        accountDAO.update(seller);
                        // Update product
                        product.ContactPhone = txtPhone.Text;
                        product.DeliveryAddress = txtAddress.Text;
                        // Proceed with the purchase
                        if (favoriteDAO.checkProductinFavorite(acc.Id, product.Id))
                        {
                            favoriteDAO.delete(acc.Id, product.Id);
                        } 
                        if (cartDAO.checkProductinCart(acc.Id, product.Id))
                        {
                            cartDAO.delete(acc.Id, product.Id);
                        }
                        product.BuyerID = acc.Id;
                        product.OrderCondition = (int)ordercondition.WaitforConfirmation;
                        productDAO.Update(product);
                    }
                }
            }
            this.Hide();
            FCart f = new FCart(acc);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void llblApplyVoucher_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}

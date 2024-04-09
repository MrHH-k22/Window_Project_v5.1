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
            txtAddress.Text = acc.Address;
            txtPhone.Text = acc.Phone;
            foreach (Product p in products)
            {
                total += p.SalePrice;
            }
            lblPrice.Text = total.ToString("N0") + " VND";

            if (acc.Money < total)
            {
                rbtnCash.Checked = true;
                rbtnOnline.Enabled = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Phone has not been filled in", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(string.IsNullOrEmpty(txtAddress.Text))
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
                        // Proceed with the purchase
                        if (favoriteDAO.checkProductinFavorite(acc.Id, product.Id))
                        {
                            favoriteDAO.delete(acc.Id, product.Id);
                        }
                        product.BuyerID = acc.Id;
                        product.OrderCondition = (int)ordercondition.WaitforConfirmation;
                        productDAO.Update(product);
                    }
                }

                this.Close();
            }
        }

        private void rbtnCash_CheckedChanged(object sender, EventArgs e)
        {
            payMethod = 0;
        }

        private void rbtnOnline_CheckedChanged(object sender, EventArgs e)
        {
            payMethod = 1;
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            this.Hide();
            FCart f = new FCart();
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
            FTrackOrder f = new FTrackOrder();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnSalesOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            FProductManagement f = new FProductManagement();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnSavedProducts_Click(object sender, EventArgs e)
        {
            this.Hide();
            FSaveList f = new FSaveList();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnOrderAnalysis_Click(object sender, EventArgs e)
        {
            this.Hide();
            FOrderAnalysis f = new FOrderAnalysis();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            this.Hide();
            FInformation f = new FInformation();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            this.Hide();
            FMoney f = new FMoney();
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
            FSellDetail f = new FSellDetail();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }
    }
}

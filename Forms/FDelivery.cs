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
        private bool payOnline = false;

        public FDelivery()
        {
            InitializeComponent();
        }

        public FDelivery(Account acc, List<Product> products)
        {
            InitializeComponent();
            this.acc = accountDAO.Retrieve(acc.Id);
            this.products = products;
        }

        private void FDelivery_Load(object sender, EventArgs e)
        {
            acc.Money = -1;
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
            if (string.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Address has not been filled in", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(txtPhone.Text))
            {
                MessageBox.Show("Phone has not been filled in", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            payOnline = false;
        }

        private void rbtnOnline_CheckedChanged(object sender, EventArgs e)
        {
            payOnline = true;
        }
    }
}

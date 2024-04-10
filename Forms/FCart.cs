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

namespace Window_Project_v5._1.Forms
{
    public partial class FCart : Form
    {
        private AccountDAO accountDAO = new AccountDAO();
        private CartDAO cartDAO = new CartDAO();
        private Account account = new Account();
        private List<Product> products = new List<Product>();

        public FCart()
        {
            InitializeComponent();
            containerMenu.Visible = false;
        }

        public FCart(Account acc)
        {
            InitializeComponent();
            containerMenu.Visible = false;
            account = accountDAO.Retrieve(acc.Id);
        }

        private void FCart_Load(object sender, EventArgs e)
        {
            products = cartDAO.loadListWithAccountID(account.Id);
            double total = 0;
            foreach (var pd in products)
            {
                if (pd.BuyerID == 0)
                {
                    UCProductBuy uc = new UCProductBuy(pd, account);
                    total += pd.SalePrice;
                    flpCartList.Controls.Add(uc);
                } else
                {
                    cartDAO.delete(account.Id, pd.Id);
                }
            }
            lblTotalMoney.Text = total.ToString("N0") + " VND";
            lblNoOfItems.Text = products.Count.ToString();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            FDelivery delivery = new FDelivery(account, products);
            delivery.Show();
            FCart_Load(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
    }
}

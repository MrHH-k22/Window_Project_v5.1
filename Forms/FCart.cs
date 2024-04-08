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
        }

        public FCart(Account acc)
        {
            InitializeComponent();
            account = accountDAO.Retrieve(acc.Id);
        }

        private void FCart_Load(object sender, EventArgs e)
        {
            products = cartDAO.loadListWithAccountID(account.Id);
            double total = 0;
            foreach (var pd in products)
            {
                if (pd.BuyerID != 0)
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
    }
}

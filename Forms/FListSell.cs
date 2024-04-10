using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Window_Project_v5._1.Forms
{
    public partial class FListSell : Form
    {
        ProductDAO productDAO = new ProductDAO();
        Account acc = new Account();

        public FListSell()
        {
            InitializeComponent();
            containerMenu.Visible = false;
        }

        public FListSell(Account acc)
        {
            InitializeComponent();
            containerMenu.Visible = false;
            this.acc = acc;
        }

        private void FListSell_Load(object sender, EventArgs e)
        {
            List<Product> products = productDAO.LoadListWithCondition("", acc.Id);
            foreach (var pd in products)
            {
                UCProductSell uc = new UCProductSell(pd, acc);
                uc.btnFunction.Visible = false;
                flpProduct.Controls.Add(uc);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            flpProduct.Controls.Clear();
            List<Product> products = productDAO.LoadListWithCondition(txtSearch.Text, acc.Id);
            foreach (var pd in products)
            {
                UCProductSell uc = new UCProductSell(pd, acc);
                uc.btnFunction.Visible = false;
                flpProduct.Controls.Add(uc);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FSellDetail fSellDetail = new FSellDetail(acc);
            fSellDetail.Show();
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

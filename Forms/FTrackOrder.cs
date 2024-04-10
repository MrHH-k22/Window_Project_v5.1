using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Window_Project_v5._1.Forms
{
    public partial class FTrackOrder : Form
    {
        Account account = new Account();
        ProductDAO productDAO = new ProductDAO();

        public FTrackOrder()
        {
            InitializeComponent();
            containerMenu.Visible = false;
        }

        public FTrackOrder(Account acc)
        {
            InitializeComponent();
            account = acc;
            containerMenu.Visible = false;
        }

        private void FTrackOrder_Load(object sender, EventArgs e)
        {
            List<Product> products = productDAO.LoadListWithBuyerID(account.Id);
            foreach (var pd in products)
            {
                UCProductBuy uc = new UCProductBuy(pd, account);
                //flpProduct.Controls.Add(uc);
                if (pd.OrderCondition == (int)ordercondition.WaitforConfirmation)
                {
                    tpWaitForConfirm.Controls.Add(uc);
                }
                else if (pd.OrderCondition == (int)ordercondition.Completed)
                {
                    tpCompleted.Controls.Add(uc);
                }
            }
            //cancelled list
            List<int> cancelledList = account.CancelledList;
            if(cancelledList != null)
            {
                foreach (var productID in cancelledList)
                {

                    Product cancelledproduct = productDAO.Retrieve(productID);
                    UCProductBuy uc = new UCProductBuy(cancelledproduct, account);
                    tpCancelled.Controls.Add(uc);
                }
            }
            //saved list
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

        private void pbLogo_Click(object sender, EventArgs e)
        {
            this.Hide();
            FBuy f = new FBuy(account);
            f.Closed += (s, args) => this.Close();
            f.Show();
        }
    }
}

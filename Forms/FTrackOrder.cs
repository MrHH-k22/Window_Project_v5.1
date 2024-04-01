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
        }

        public FTrackOrder(Account acc)
        {
            account = acc;
            InitializeComponent();
        }

        private void FTrackOrder_Load(object sender, EventArgs e)
        {
            List<Product> products = productDAO.LoadListWithBuyerID(account.Id);
            foreach (var pd in products)
            {
                UCProductBuy uc = new UCProductBuy(pd, account);
                if (pd.OrderCondition == (int)ordercondition.WaitforConfirmation)
                {
                    uc.btnFunction.Text = "Wait for confirmation";
                    uc.btnFunction.Enabled = false;
                }
                else if (pd.OrderCondition == (int)ordercondition.WaitforPayment)
                {
                    uc.btnFunction.Text = "Pay";
                    uc.btnFunction.Enabled = true;
                }
                else if (pd.OrderCondition == (int)ordercondition.Delivered)
                {
                    uc.btnFunction.Text = "Completed";
                    uc.btnFunction.Enabled = false;
                }
                flpProduct.Controls.Add(uc);
            }
        }
    }
}

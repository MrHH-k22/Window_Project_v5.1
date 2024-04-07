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
    }
}

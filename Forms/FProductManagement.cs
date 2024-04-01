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

    public partial class FProductManagement : Form
    {
        private ProductDAO productDAO = new ProductDAO();
        private Account account = new Account();
        public FProductManagement()
        {
            InitializeComponent();
        }

        public FProductManagement(Account acc)
        {
            InitializeComponent();
            account = acc;
        }

        private void FProductManagement_Load(object sender, EventArgs e)
        {
            List<Product> products = productDAO.LoadList();
            foreach (var pd in products)
            {
                if(pd.SellerID == account.Id)
                {
                    UCProductSell uc = new UCProductSell(pd, account);
                    uc.Dock = DockStyle.Top;
                    //uc.Width = this.Width - 230;
                    if (pd.OrderCondition == (int)ordercondition.Displaying)
                    {
                        tpDisplay.Controls.Add(uc);
                    }
                    if(pd.OrderCondition == (int)ordercondition.WaitforConfirmation)
                    {
                        tpWaitConfirm.Controls.Add(uc); 
                    }
                    if(pd.OrderCondition == (int)ordercondition.WaitforPayment)
                    {
                        tpWaitforPayment.Controls.Add(uc);
                    }
                    if(pd.OrderCondition == (int)ordercondition.Delivered)
                    {
                        tpDelivered.Controls.Add(uc);
                    }
                    if(pd.OrderCondition == (int)ordercondition.Cancelled)
                    {
                        tpCancelled.Controls.Add(uc);
                    }
                }

            }
        }
    }
}

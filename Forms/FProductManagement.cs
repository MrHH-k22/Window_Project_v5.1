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
                        uc.btnFunction.Text = "Hide product";
                        uc.btnFunction.Enabled = true;
                        tpDisplay.Controls.Add(uc);
                    }
                    else if(pd.OrderCondition == (int)ordercondition.WaitforConfirmation)
                    {
                        uc.btnFunction.Text = "Confirm";
                        tpWaitConfirm.Controls.Add(uc); 
                    }
                    else if(pd.OrderCondition == (int)ordercondition.WaitforPayment)
                    {
                        uc.btnFunction.Text = "Waiting for payment";
                        uc.btnFunction.Enabled = false;
                        tpWaitforPayment.Controls.Add(uc);
                    }
                    else if(pd.OrderCondition == (int)ordercondition.Delivered)
                    {
                        uc.btnFunction.Text = "Completed";
                        uc.btnFunction.Enabled = false;
                        tpCompleted.Controls.Add(uc);
                    }
                    else if(pd.OrderCondition == (int)ordercondition.Cancelled)
                    {
                        uc.btnFunction.Text = "Post again";
                        uc.btnFunction.Enabled = true;
                        tpCancelled.Controls.Add(uc);
                    }
                    else if(pd.OrderCondition == (int)ordercondition.hidden)
                    {
                        uc.btnFunction.Text = "Display product";
                        uc.btnFunction.Enabled = true;
                        tpHidden.Controls.Add(uc);
                    }
                }

            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            foreach (TabPage tabPage in tcManagement.TabPages)
            {
                tabPage.Controls.Clear();
            }
            FProductManagement_Load(sender, e);
        }
    }
}

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
    public partial class FSaveList : Form
    {
        private ProductDAO productDAO = new ProductDAO();
        private CartDAO cartDAO = new CartDAO();
        private Account account = new Account();
        public FSaveList()
        {
            InitializeComponent();
        }

        public FSaveList(Account acc)
        {
            InitializeComponent();
            account = acc;
        }

        private void FSaveList_Load(object sender, EventArgs e)
        {
            List<Product> products = cartDAO.loadListWithAccountID(account.Id);
            double total = 0;
            foreach (var pd in products)
            {
                UCProductBuy uc = new UCProductBuy(pd, account);
                flpSavedList.Controls.Add(uc);
            }

        }
    }
}

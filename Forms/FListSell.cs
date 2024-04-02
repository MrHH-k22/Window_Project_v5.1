using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
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
        }

        public FListSell(Account acc)
        {
            InitializeComponent();
            this.acc = acc;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FSellDetail fSellDetail = new FSellDetail(acc);
            fSellDetail.Show();
        }

        private void FListSell_Load(object sender, EventArgs e)
        {
            List<Product> products = productDAO.LoadListWithCondition("", acc.Id);
            foreach (var pd in products)
            {
                UCProductSell uc = new UCProductSell(pd, acc);
                uc.btnNextState.Visible = false;
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
                uc.btnNextState.Visible = false;
                flpProduct.Controls.Add(uc);
            }
        }
    }
}

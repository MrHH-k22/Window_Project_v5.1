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
    public partial class FBuy : Form
    {
        ProductDAO productDAO = new ProductDAO();

        public FBuy()
        {
            InitializeComponent();
        }

        private void ucProduct2_Load(object sender, EventArgs e)
        {

        }

        private void FBuy_Load(object sender, EventArgs e)
        {
            List<Product> products = productDAO.LoadList();
            foreach (var pd in products)
            {
                UCProduct uc = new UCProduct(pd);
                flpProduct.Controls.Add(uc);
            }
        }

    }
}

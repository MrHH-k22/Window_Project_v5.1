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
        private ProductDAO productDAO = new ProductDAO();
        private Account account = new Account();


        public FBuy()
        {
            InitializeComponent();
        }

        public FBuy(Account acc)
        {
            InitializeComponent();
            account = acc;
        }

        private void ucProduct2_Load(object sender, EventArgs e)
        {

        }

        private void FBuy_Load(object sender, EventArgs e)
        {
            List<Product> products = productDAO.LoadList();
            foreach (var pd in products)
            {
                UCProduct uc = new UCProduct(pd,account);
                flpProduct.Controls.Add(uc);
            }
        }

        private void txtProductName_TextChange(object sender, EventArgs e)
        {
            getFilter();

        }

        private void txtBrand_TextChange(object sender, EventArgs e)
        {
            getFilter();

        }

        private void txtMaxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự được nhập có phải là số không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Nếu không phải là số, không cho phép nhập
                e.Handled = true;
            }
        }

        private void txtMinPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Kiểm tra xem ký tự được nhập có phải là số không
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                // Nếu không phải là số, không cho phép nhập
                e.Handled = true;
            }
        }

        private void txtMaxPrice_TextChange(object sender, EventArgs e)
        {
            getFilter();
        }

        private void txtMinPrice_TextChange(object sender, EventArgs e)
        {
            getFilter();
        }

        private void getFilter()
        {
            List<Product> products = productDAO.LoadList();
            double maxPrice, minPrice;
            flpProduct.Controls.Clear();
            minPrice = (txtMinPrice.Text == "") ? 0 : double.Parse(txtMinPrice.Text);
            maxPrice = (txtMaxPrice.Text == "") ? double.MaxValue : double.Parse(txtMaxPrice.Text);


            if (txtMinPrice.Text == "" && txtMaxPrice.Text == "" && txtProductName.Text == "" && txtBrand.Text == "")
            {
                flpProduct.Controls.Clear();
                foreach (var pd in products)
                {
                    UCProduct uc = new UCProduct(pd,account);
                    flpProduct.Controls.Add(uc);
                }
            }

            flpProduct.Controls.Clear();
            foreach (var pd in products)
            {
                if (minPrice <= pd.SalePrice && pd.SalePrice <= maxPrice
                && pd.Brand.ToLower().Contains(txtBrand.Text.ToLower())
                && pd.Name.ToLower().Contains(txtProductName.Text.ToLower()))
                {
                    UCProduct uc = new UCProduct(pd, account);
                    flpProduct.Controls.Add(uc);
                }
            }
        }

        private void ddCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            if (ddCategories.SelectedItem != null)
            {
                selectedValue = ddCategories.SelectedItem.ToString();
            }
            getFilter();
            */
        }
    }
}

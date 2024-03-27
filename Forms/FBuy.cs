using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Window_Project_v5._1.Properties;

namespace Window_Project_v5._1.Forms
{
    public partial class FBuy : Form
    {
        private ProductDAO productDAO = new ProductDAO();
        private Account account = new Account();
        private bool save;


        public FBuy()
        {
            InitializeComponent();
            save = false;
        }

        public FBuy(Account acc)
        {
            InitializeComponent();
            account = acc;
            save = false;
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

        private void btnFilter_Click(object sender, EventArgs e)
        {
            List<Product> products = productDAO.LoadList();
            string productName = txtProductName.Text;
            string brand = txtBrand.Text;
            double maxPrice = double.TryParse(txtMaxPrice.Text, out double parsedMaxPrice) ? parsedMaxPrice : double.MaxValue;
            double minPrice = double.TryParse(txtMinPrice.Text, out double parsedMinPrice) ? parsedMinPrice : double.MinValue;
            string selectedCategory = ddCategories.SelectedItem?.ToString();

            // Filter products based on the specified conditions
            List<Product> filteredProducts = products.Where(pd =>
                (string.IsNullOrEmpty(productName) || pd.Name.ToLower().Contains(productName.ToLower())) &&
                (string.IsNullOrEmpty(brand) || pd.Brand.ToLower().Contains(brand.ToLower())) &&
                (pd.SalePrice >= minPrice && pd.SalePrice <= maxPrice) &&
                (string.IsNullOrEmpty(selectedCategory) || pd.Category == selectedCategory)
            ).ToList();

            // Clear existing products in the flow layout panel
            flpProduct.Controls.Clear();

            // Add filtered products to the flow layout panel
            foreach (var pd in filteredProducts)
            {
                UCProduct uc = new UCProduct(pd, account);
                flpProduct.Controls.Add(uc);
            }
        }
    }
}

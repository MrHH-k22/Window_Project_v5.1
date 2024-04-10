using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            containerMenu.Visible = false;
            save = false;
        }

        public FBuy(Account acc)
        {
            InitializeComponent();
            containerMenu.Visible = false;
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
                if(pd.BuyerID <=0 && pd.OrderCondition <= (int)ordercondition.Displaying)
                {
                    UCProduct uc = new UCProduct(pd, account);
                    flpProduct.Controls.Add(uc);
                }
            }
            convertByte(pbAvatar, account.Avatar);
        }

        private void convertByte(PictureBox pic, byte[] imageData)
        {

            if (imageData != null && imageData.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    // Attempt to create Image object
                    try
                    {
                        pic.Image = Image.FromStream(ms);
                    }
                    catch (ArgumentException ex)
                    {
                        // Handle ArgumentException
                        Console.WriteLine("Failed to create Image object: " + ex.Message);
                    }
                }
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
   
        private void btnLoad_Click(object sender, EventArgs e)
        {
            flpProduct.Controls.Clear();
            FBuy_Load(sender, e);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            List<Product> products = productDAO.LoadList();
            List<Product> productWithoutBuyerAndDisplaying = new List<Product>();
            //get product without buyid and having condition displaying
            foreach (var pd in products)
            {
                if ((pd.BuyerID == null || pd.BuyerID <= 0) && pd.OrderCondition == (int)ordercondition.Displaying)
                {
                    productWithoutBuyerAndDisplaying.Add(pd);
                }
            }
            string productName = txtProductName.Text;
            string brand = txtBrand.Text;
            double maxPrice = double.TryParse(txtMaxPrice.Text, out double parsedMaxPrice) ? parsedMaxPrice : double.MaxValue;
            double minPrice = double.TryParse(txtMinPrice.Text, out double parsedMinPrice) ? parsedMinPrice : double.MinValue;
            string selectedCategory = ddCategories.SelectedItem?.ToString();

            // Filter products based on the specified conditions
            List<Product> filteredProducts = productWithoutBuyerAndDisplaying.Where(pd =>
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

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if(containerMenu.Visible == false)
            {
                containerMenu.Visible = true;
            }
            else
            {
                containerMenu.Visible = false;
            }
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
    }
}

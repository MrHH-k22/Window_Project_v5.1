using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Window_Project_v5._1.Forms
{
    public partial class UCProductBuy : UserControl
    {
        private ImageDAO imageDAO = new ImageDAO();
        private Account account = new Account();
        private Product product;

        public UCProductBuy()
        {
            InitializeComponent();
        }

        public UCProductBuy(Product pd, Account acc)
        {
            InitializeComponent();
            this.product = pd;
            account = acc;
            lblPrice.Text = pd.SalePrice.ToString();
            lblProductCondition.Visible = false;
            lblProductName.Text = pd.Name;
            lblSellerName.Visible = false;

            byte[] imageData = imageDAO.GetImageProductData(pd.Id);

            if (imageData != null && imageData.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    // Attempt to create Image object
                    try
                    {
                        pbProduct.Image = Image.FromStream(ms);
                    }
                    catch (ArgumentException ex)
                    {
                        // Handle ArgumentException
                        Console.WriteLine("Failed to create Image object: " + ex.Message);
                    }
                }
            }
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            FBuyDetail trackDetail = new FBuyDetail(product, account);
            trackDetail.Show();
        }
    }
}

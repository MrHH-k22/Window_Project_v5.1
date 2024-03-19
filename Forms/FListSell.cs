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
        ImageDAO imageDAO = new ImageDAO();

        public FListSell()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FSellDetail fSellDetail = new FSellDetail();
            fSellDetail.Show();
        }

        private void FListSell_Load(object sender, EventArgs e)
        {
            List<Product> products = productDAO.LoadList();
            foreach (var pd in products)
            {
                UCProductTracking uc = new UCProductTracking();
                uc.lblPrice.Text = pd.SalePrice.ToString();
                uc.lblProductCondition.Visible = false;
                uc.lblProductName.Text = pd.Name;
                uc.lblSellerName.Visible = false;

                byte[] imageData = imageDAO.GetImageProductData(pd.Id);

                if (imageData != null && imageData.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        // Attempt to create Image object
                        try
                        {
                            uc.pbProduct.Image = Image.FromStream(ms);
                        }
                        catch (ArgumentException ex)
                        {
                            // Handle ArgumentException
                            Console.WriteLine("Failed to create Image object: " + ex.Message);
                        }
                    }
                }

                flpProduct.Controls.Add(uc);
            }
        }
    }
}

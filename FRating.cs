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
using Window_Project_v5._1.Forms;

namespace Window_Project_v5._1
{
    public partial class FRating : Form
    {
        private ImageDAO imageDAO = new ImageDAO();
        private Account account = new Account();
        private AccountDAO accountDAO = new AccountDAO();
        private Product product;
        private ProductDAO productDAO = new ProductDAO();
        public FRating()
        {
            InitializeComponent();
        }
        public FRating(Account acc, Product pd)
        {
            InitializeComponent();
            this.account = acc;
            this.product = pd;
            lblNameProduct.Text = product.Name;

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
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}

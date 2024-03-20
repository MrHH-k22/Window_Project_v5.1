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

namespace Window_Project_v5._1.Forms
{
    public partial class UCProductTracking : UserControl
    {
        private ImageDAO imageDAO = new ImageDAO();

        private Product product;

        public UCProductTracking()
        {
            InitializeComponent();
        }

        public UCProductTracking(Product pd)
        {
            InitializeComponent();
            this.product = pd;
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

        private void UCProductTracking_Load(object sender, EventArgs e)
        {
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            FTrackDetail trackDetail = new FTrackDetail(product);
            trackDetail.Show();
        }

        private void btnDetail_MouseEnter(object sender, EventArgs e)
        {
            btnDetail.BackColor = Color.FromArgb(239, 250, 253);
            btnDetail.ForeColor = Color.FromArgb(54, 50, 132);
            btnDetail.FlatAppearance.BorderSize = 1;
        }

        private void btnDetail_MouseLeave(object sender, EventArgs e)
        {
            btnDetail.BackColor = Color.FromArgb(54, 50, 132);
            btnDetail.ForeColor = Color.FromArgb(239, 250, 253);
            btnDetail.FlatAppearance.BorderSize = 0;
        }
    }
}

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
        private Product product;
        private ProductDAO productDAO = new ProductDAO();
        private Rating rt = new Rating();
        private RatingDAO ratingDAO = new RatingDAO();
        public FRating()
        {
            InitializeComponent();
        }
        public FRating(Product pd)
        {
            InitializeComponent();
            this.product = pd;
            lblNameProduct.Text = product.Name;

            byte[] imageData = imageDAO.GetImageProductData(pd.Id);
            if (imageData != null && imageData.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    try
                    {
                        pbProduct.Image = Image.FromStream(ms);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine("Failed to create Image object: " + ex.Message);
                    }
                }
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private float GetStarValue()
        {
            return rtStar.Value;
        }
        private void SetLabelStatus()
        {
            float star = GetStarValue();
            if(star >= 0 && star <= 1)
            {
                lblStatus.ForeColor = Color.WhiteSmoke;
                lblStatus.Text = "Bad";
            }
            else if(star > 1 && star <= 2)
            {
                lblStatus.ForeColor = Color.WhiteSmoke;
                lblStatus.Text = "Unsatisfied";
            }
            else if( star > 2 && star <= 3)
            {
                lblStatus.ForeColor = Color.WhiteSmoke;
                lblStatus.Text = "Normal";
            }
            else if (star > 3 && star <= 4)
            {
                lblStatus.ForeColor = Color.Yellow;
                lblStatus.Text = "Satisfied";
            }
            else
            {
                lblStatus.ForeColor = Color.Yellow;
                lblStatus.Text = "Great";
            }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            rt.Comment = txtComment.Text;
            rt.Star = GetStarValue();
            ratingDAO.Add(rt, product);
        }

        private void rtStar_ValueChanged(object sender, EventArgs e)
        {
            SetLabelStatus();
        }
    }
}

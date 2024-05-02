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
    public partial class FReview : Form
    {
        private ImageDAO imageDAO = new ImageDAO();
        private Account account = new Account();
        private AccountDAO accountDAO = new AccountDAO();
        private ProductDAO productDAO = new ProductDAO();
        private Product product;
        private Account Seller = new Account();
        private RatingDAO ratingDAO = new RatingDAO();
        private List<Rating> ratingList = new List<Rating>();
        public FReview()
        {
            InitializeComponent();
        }
        public FReview(Account acc, Product pd)
        {
            InitializeComponent();
            this.account = acc;
            this.product = pd;
            Seller = new Account(pd.SellerID);
            ratingList = ratingDAO.LoadList(Seller);
        }

        private void FReview_Load(object sender, EventArgs e)
        {
            foreach (Rating rating in ratingList)
            {
                UCReview uc = new UCReview(product, account, rating);
                flpRating.Controls.Add(uc);
            }
            lblNameSeller.Text = Seller.Name;
            convertByte(pbAvatarSeller, Seller.Avatar);
            lblStar.Text = Seller.AvgRating.ToString();
            rsStar.Value = Seller.AvgRating;
            lblArea.Text = "Area: " + Seller.Address;
            lblPhone.Text = "Contact Phone: " + Seller.Phone;
            DataTable dt = new DataTable();
            dt = ratingDAO.load(Seller);
            lblNumberRatings.Text = dt.Rows.Count.ToString() + " ratings";
            List<Product> listpd = new List<Product>();
            listpd = productDAO.LoadListWithCondition("", Seller.Id);
            lblNumberofproducts.Text = "Products: " + listpd.Count.ToString();
            int completed = 0;
            foreach (Product pd in listpd)
            {
                if (pd.OrderCondition == (int)ordercondition.Completed)
                {
                    completed++;
                }
            }
            lblSold.Text = "Sold: " + completed.ToString();
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
    }
}
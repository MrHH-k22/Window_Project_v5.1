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
                flowLayoutPanel1.Controls.Add(uc);
            }
        }
    }
}

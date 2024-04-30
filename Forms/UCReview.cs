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
using Guna.UI2.WinForms;
using Window_Project_v5._1.Forms;

namespace Window_Project_v5._1.Forms
{
    public partial class UCReview : UserControl
    {
        private ImageDAO imageDAO = new ImageDAO();
        private Account account = new Account();
        private AccountDAO accountDAO = new AccountDAO();
        private ProductDAO productDAO = new ProductDAO();
        private Product product;
        private Rating rating = new Rating();
        private RatingDAO ratingDAO = new RatingDAO();
        public UCReview()
        {
            InitializeComponent();
        }
        public UCReview(Product pd, Account acc, Rating rt)
        {
            InitializeComponent();
            this.product = pd;
            this.account = acc;
            this.rating = rt;
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

        private void gbContent_Enter(object sender, EventArgs e)
        {

        }

        private void UCReview_Load(object sender, EventArgs e)
        {
            Account Seller = new Account(rating.SellerID);
            lblNameSeller.Text = Seller.Name;
            convertByte(pbAvtSeller, Seller.Avatar);
            string labeldata = rating.Comment;
            string[] labels = labeldata.Split(';');

            foreach (string labelText in labels)
            {
               GenerateLabel(panelRating, labelText, labels.Length);
            }
            lblAvgStar.Text = Seller.AvgRating.ToString();
            rsAvgStar.Value = Seller.AvgRating;
            rsAvgStar.Enabled = false;
        }
        private void GenerateLabel(Panel panel, string labelText, int labelCount)
        {
            Label label = new Label();
            label.Text = labelText;
            label.AutoSize = false; // Tắt tính năng tự động thay đổi kích thước
            label.Padding = new Padding(5);
            label.BorderStyle = BorderStyle.FixedSingle;
            label.BackColor = Color.White;
            label.ForeColor = Color.Black;
            label.TextAlign = ContentAlignment.MiddleCenter;

            // Tính toán kích thước cho mỗi label
            int labelWidth = panel.ClientSize.Width / labelCount - 10;
            int labelHeight = panel.ClientSize.Height - 10;
            label.Size = new Size(labelWidth, labelHeight);
            label.Margin = new Padding(5);

            // Để bo tròn label, sử dụng sự kiện Paint
            label.Paint += (sender, e) =>
            {
                var rectangle = new Rectangle(0, 0, label.Width - 1, label.Height - 1);
                using (var pen = new Pen(Color.Black, 1))
                {
                    e.Graphics.DrawEllipse(pen, rectangle);
                }
            };

            panel.Controls.Add(label);
        }
    }
}

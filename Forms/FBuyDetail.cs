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
    public partial class FBuyDetail : Form
    {
        private ImageDAO imageDAO = new ImageDAO();
        private ProductDAO productDAO = new ProductDAO();


        public FBuyDetail()
        {
            InitializeComponent();
        }

        public FBuyDetail(Product pd)
        {
            InitializeComponent();
            lblProductName.Text = pd.Name;
            lblSellPrice.Text = pd.SalePrice.ToString() + " VND";
            lblBuyPrice.Text = pd.OriginalPrice.ToString() + " VND";
            lblCondition.Text = "Condition: " + pd.Condition.ToString() + "%";
            lblBrand.Text = "Brand: " + pd.Brand.ToString();
            lblCategory.Text = "Category: " + pd.Category.ToString();
            txtStatus.Text = pd.Status.ToString();
            txtDescription.Text = pd.Description.ToString();
            DataTable ImageTable = imageDAO.GetImageProduct(pd.Id);

            foreach (DataRow row in ImageTable.Rows)
            {
                int columnCount = row.ItemArray.Length;

                // Iterate over PictureBox controls
                for (int i = 0; i < 4; i++)
                {
                    PictureBox pictureBox = null;

                    // Assign pictureBox variable based on index
                    switch (i)
                    {
                        case 0:
                            pictureBox = pbImage1;
                            break;
                        case 1:
                            pictureBox = pbImage2;
                            break;
                        case 2:
                            pictureBox = pbImage3;
                            break;
                        case 3:
                            pictureBox = pbImage4;
                            break;
                    }

                    // If index exceeds column count, hide PictureBox
                    if (i >= columnCount)
                    {
                        pictureBox.Visible = false;
                        continue;
                    }

                    // Load image into PictureBox
                    byte[] imageData = (byte[])row[i];
                    MemoryStream ms = new MemoryStream(imageData);
                    pictureBox.Image = Image.FromStream(ms);
                    pictureBox.Visible = true;
                }
            }


        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            //product buyerid = acount id  
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<Product> products = productDAO.LoadList();
            foreach (var pd in products)
            {
                UCProduct uc = new UCProduct(pd);
                flpProduct.Controls.Add(uc);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bunifu.UI.WinForms;
using System.Windows.Forms;

namespace Window_Project_v5._1.Forms
{
    public partial class FTrackDetail : Form
    {
        private ImageDAO imageDAO = new ImageDAO();
        private Product pd;

        public FTrackDetail()
        {
            InitializeComponent();
        }

        public FTrackDetail(Product pd)
        {
            InitializeComponent();
            this.pd = pd;

            lblProductName.Text = pd.Name;
            lblPrice.Text = pd.SalePrice.ToString() + " VND";
            lblBrand.Text = "Brand: " + pd.Brand.ToString();
            lblBuyPrice.Text = pd.OriginalPrice.ToString() + " VND";
            lblCondition.Text = "Condition: " + pd.Condition.ToString() + "%";
            txtStatus.Text = pd.Status.ToString();
            txtDescription.Text = pd.Description.ToString();
            Account seller = new Account(pd.SellerID);
            lblShop.Text = seller.Name;
            lblPhone.Text = "Contact Phone: " + seller.Phone;

            txtStatus.ReadOnly = true;
            txtDescription.ReadOnly = true;

            DataTable ImageTable = imageDAO.GetImageProduct(pd.Id);

            int pictureBoxIndex = 0;

            foreach (DataRow row in ImageTable.Rows)
            {
                if (pictureBoxIndex >= 4) // If we have more images than PictureBoxes
                    break;

                byte[] imageData = (byte[])row["Image"]; // Access the "Image" column

                // Load image into PictureBox
                MemoryStream ms = new MemoryStream(imageData);

                // Assign pictureBox variable based on index
                BunifuImageButton pictureBox = null;
                switch (pictureBoxIndex)
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

                // Assign image to PictureBox and make it visible
                pictureBox.Image = Image.FromStream(ms);
                pictureBox.Visible = true;

                pictureBoxIndex++;
            }

            // Hide any remaining PictureBoxes
            for (int i = pictureBoxIndex; i < 4; i++)
            {
                switch (i)
                {
                    case 0:
                        pbImage1.Visible = false;
                        break;
                    case 1:
                        pbImage2.Visible = false;
                        break;
                    case 2:
                        pbImage3.Visible = false;
                        break;
                    case 3:
                        pbImage4.Visible = false;
                        break;
                }
            }
        }






        private void panelBody_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbImage2_Click(object sender, EventArgs e)
        {
            BunifuImageButton temp = new BunifuImageButton();
            temp.Image = pbImage1.Image;
            pbImage1.Image = pbImage2.Image;
            pbImage2.Image = temp.Image;
        }

        private void pbImage3_Click(object sender, EventArgs e)
        {
            BunifuImageButton temp = new BunifuImageButton();
            temp.Image = pbImage1.Image;
            pbImage1.Image = pbImage3.Image;
            pbImage3.Image = temp.Image;
        }

        private void pbImage4_Click(object sender, EventArgs e)
        {
            BunifuImageButton temp = new BunifuImageButton();
            temp.Image = pbImage1.Image;
            pbImage1.Image = pbImage4.Image;
            pbImage4.Image = temp.Image;
        }

        private void pbImage1_Click(object sender, EventArgs e)
        {

        }
            
        private void btnEdit_Click(object sender, EventArgs e)
        {
            FSellDetail fSellDetail = new FSellDetail(pd);
            fSellDetail.Show();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

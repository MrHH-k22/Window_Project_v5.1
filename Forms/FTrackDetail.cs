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
    public partial class FTrackDetail : Form
    {
        private ImageDAO imageDAO = new ImageDAO();
        private AccountDAO accountDAO = new AccountDAO();  

        public FTrackDetail()
        {
            InitializeComponent();
        }

        public FTrackDetail(Product pd)
        {
            InitializeComponent();
            
            btnSave.Visible = false;

            lblProductName.Text = pd.Name;
            lblPrice.Text = pd.SalePrice.ToString() + " VND";
            lblBrand.Text = "Brand: " + pd.Brand.ToString();
            lblBuyPrice.Text = pd.OriginalPrice.ToString() + " VND";
            lblCondition.Text = "Condition: " + pd.Condition.ToString() + "%";
            txtStatus.Text = pd.Status.ToString();
            txtDescription.Text = pd.Description.ToString();
            lblShop.Text = (new Account(pd.SellerID)).Name;


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
                PictureBox pictureBox = null;

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbImage2_Click(object sender, EventArgs e)
        {
            PictureBox temp = pbImage1;
            pbImage1 = pbImage2;
            pbImage2 = temp;
        }

        private void pbImage3_Click(object sender, EventArgs e)
        {
            PictureBox temp = pbImage1;
            pbImage1 = pbImage3;
            pbImage3 = temp;
        }

        private void pbImage4_Click(object sender, EventArgs e)
        {
            PictureBox temp = pbImage1;
            pbImage1 = pbImage4;
            pbImage4 = temp;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnSave.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Visible = false;
        }
    }
}

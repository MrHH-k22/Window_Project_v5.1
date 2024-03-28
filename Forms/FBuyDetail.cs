﻿using System;
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
        private FavoriteDAO favoriteDAO = new FavoriteDAO();
        private Account account = new Account();
        private Product product = new Product();


        public FBuyDetail()
        {
            InitializeComponent();
        }

        public FBuyDetail(Product pd,Account acc)
        {
            InitializeComponent();
            account = acc;
 
            product = pd;
            pd.ViewCount++;
            productDAO.Update(pd);
            lblProductName.Text = pd.Name;
            lblSellPrice.Text = pd.SalePrice.ToString() + " VND";
            lblBuyPrice.Text = pd.OriginalPrice.ToString() + " VND";
            lblCondition.Text = "Condition: " + pd.Condition.ToString() + "%";
            lblBrand.Text = "Brand: " + pd.Brand.ToString();
            lblCategory.Text = "Category: " + pd.Category.ToString();
            txtStatus.Text = pd.Status.ToString();
            txtDescription.Text = pd.Description.ToString();
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
            /*
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
            */
            //check button save
            if (favoriteDAO.checkProductinFavorite(account.Id, product.Id))
            {
                btnSave.Text = "Saved";
                btnSave.BackColor = Color.WhiteSmoke;
                btnSave.ForeColor = Color.Red;
            }
            else
            {
                btnSave.Text = "Save";
                btnSave.BackColor = Color.Red;
                btnSave.ForeColor = Color.WhiteSmoke;
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
            product.BuyerID = account.Id;
            productDAO.Update(product);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (favoriteDAO.checkProductinFavorite(account.Id, product.Id))
            {
                favoriteDAO.delete(account.Id, product.Id);
                btnSave.Text = "Save";

                btnSave.BackColor = Color.Red;
                btnSave.ForeColor = Color.WhiteSmoke;
            }
            else
            {
                favoriteDAO.add(account.Id, product.Id);
                btnSave.Text = "Saved";

                btnSave.BackColor = Color.WhiteSmoke;
                btnSave.ForeColor = Color.Red;
            }
        }

    }
}

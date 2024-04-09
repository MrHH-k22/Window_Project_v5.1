﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Window_Project_v5._1.Forms
{
    public partial class UCProduct : UserControl
    {
        public EventHandler onSelect = null;
        private ImageDAO imageDAO = new ImageDAO();
        Account account = new Account();

        private Product product;
        public UCProduct()
        {
            InitializeComponent();
            SetEventForAllControls(this);
        }

        public UCProduct(Product pd, Account acc)
        {
            InitializeComponent();
            SetEventForAllControls(this);
            account = acc;
            this.product = pd;
            lblBuyPrice.Text = pd.OriginalPrice.ToString("N0") + " VND";
            lblSellPrice.Text = pd.SalePrice.ToString("N0") + " VND";
            lblProductName.Text = pd.Name.ToString();
            lblArea.Text = pd.Area.ToString();

            byte[] imageData = imageDAO.GetImageProductData(pd.Id);

            if (imageData != null && imageData.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    // Attempt to create Image object
                    try
                    {
                        pbProductImage.Image = Image.FromStream(ms);
                    }
                    catch (ArgumentException ex)
                    {
                        // Handle ArgumentException
                        Console.WriteLine("Failed to create Image object: " + ex.Message);
                    }
                }
            }

        }





        private void lblItemPrice_Click(object sender, EventArgs e)
        {

        }

        private void UCProduct_MouseEnter(object sender, EventArgs e)
        {
            panelBody.BorderColor = Color.Black;
        }

        private void UCProduct_MouseLeave(object sender, EventArgs e)
        {
            panelBody.BorderColor = Color.FromArgb(250, 250, 250);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            onSelect?.Invoke(this, e);
        }


        private void ratingProduct_ValueChanged(object sender, Bunifu.UI.WinForms.BunifuRating.ValueChangedEventArgs e)
        {
        }

        private void lblProductName_Click(object sender, EventArgs e)
        {

        }

        private void UCProduct_DoubleClick(object sender, EventArgs e)
        {
            
            FBuyDetail fBuyDetail = new FBuyDetail(product,account);
            fBuyDetail.Show();
        }

        private void SetEventForAllControls(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                control.Click += UCProduct_DoubleClick;
                control.MouseEnter += UCProduct_MouseEnter;
                control.MouseLeave += UCProduct_MouseLeave;
                if (control.HasChildren)
                {
                    SetEventForAllControls(control);
                }
            }
        }


        private void UCProduct_Click(object sender, EventArgs e)
        {
          
        }

        private void UCProduct_MouseHover(object sender, EventArgs e)
        {
            
        }
    }
}

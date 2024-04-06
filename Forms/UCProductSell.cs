﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Window_Project_v5._1.Forms
{
    public partial class UCProductSell : UserControl
    {
        private ImageDAO imageDAO = new ImageDAO();
        private Account account = new Account();
        private AccountDAO accountDAO = new AccountDAO();
        private ProductDAO productDAO = new ProductDAO();
        private Product product;

        public UCProductSell()
        {
            InitializeComponent();
        }

        public UCProductSell(Product pd, Account acc)
        {
            InitializeComponent();
            this.product = pd;
            account = acc;
            lblPrice.Text = pd.SalePrice.ToString();
            lblProductCondition.Text = pd.GetBillStatus();
            lblProductCondition.Visible = false;
            lblProductName.Text = pd.Name;


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



        private void pbProduct_Click(object sender, EventArgs e)
        {

        }

        private void lblSellerName_Click(object sender, EventArgs e)
        {

        }

        private void lblProductName_Click(object sender, EventArgs e)
        {

        }

        private void lblProductCondition_Click(object sender, EventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void btnFunction_DoubleClick(object sender, EventArgs e)
        {

        }


        private void UCProductSell_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Top;
            if(!(product.BuyerID <=0 || product.BuyerID == null))
            {
                Account Buyer = accountDAO.Retrieve(product.BuyerID);
                lblBuyerName.Text = "Buyer name: " + Buyer.Name;
            }
            else
            {
                lblBuyerName.Text = "No one buy yet";
            }
            if (product.OrderCondition == (int)ordercondition.Displaying)
            {
                btnFunction.Text = "Hide product";
                btnFunction.Enabled = true;
            }
            else if (product.OrderCondition == (int)ordercondition.WaitforConfirmation)
            {
                btnFunction.Text = "Next state";
                btnFunction.Enabled = true;
            }
            else if (product.OrderCondition == (int)ordercondition.Delivering)
            {
                btnFunction.Text = "Next state";
                btnFunction.Enabled = true;
            }
            else if (product.OrderCondition == (int)ordercondition.Completed)
            {
                btnFunction.Text = "Completed";
                btnFunction.Enabled = false;
            }
            else if (product.OrderCondition == (int)ordercondition.Cancelled)
            {
                btnFunction.Text = "Post again";
                btnFunction.Enabled = true;
            }
            else if (product.OrderCondition == (int)ordercondition.hidden)
            {
                btnFunction.Text = "Display product";
                btnFunction.Enabled = true;
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("The product will be deleted in the system. Do you want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                productDAO.Delete(product);
                imageDAO.Delete(product.Id);
                MessageBox.Show("The product has been successfully deleted from the system.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            FTrackDetail trackDetail = new FTrackDetail(product);
            trackDetail.Show();
        }

        private void btnFunction_Click(object sender, EventArgs e)
        {
            if (product.OrderCondition == (int)ordercondition.Displaying)
            {
                product.OrderCondition = (int)ordercondition.hidden;
                productDAO.Update(product);
            }
            else if (product.OrderCondition == (int)ordercondition.WaitforConfirmation)
            {
                product.OrderCondition = (int)ordercondition.Delivering;
                productDAO.Update(product);
                Account buyer = accountDAO.Retrieve(product.BuyerID);
                buyer.Money -= product.SalePrice;
                accountDAO.update(buyer);
                account.Money += product.SalePrice;
                accountDAO.update(account);
            }
            else if (product.OrderCondition == (int)ordercondition.Delivering)
            {
                product.OrderCondition = (int)ordercondition.Completed;
                productDAO.Update(product);
            }
            else if (product.OrderCondition == (int)ordercondition.Cancelled)
            {
                product.OrderCondition = (int)ordercondition.Displaying;
                productDAO.Update(product);
            }
            else if (product.OrderCondition == (int)ordercondition.hidden)
            {
                product.OrderCondition = (int)ordercondition.Displaying;
                productDAO.Update(product);
            }
        }
    }
}
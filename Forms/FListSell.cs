﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Window_Project_v5._1.Forms
{
    public partial class FListSell : Form
    {
        ProductDAO productDAO = new ProductDAO();

        public FListSell()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FSellDetail fSellDetail = new FSellDetail();
            fSellDetail.Show();
        }

        private void FListSell_Load(object sender, EventArgs e)
        {
            List<Product> products = productDAO.LoadList();
            foreach (var pd in products)
            {
                UCProductTracking uc = new UCProductTracking(pd);
                flpProduct.Controls.Add(uc);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            flpProduct.Controls.Clear();
            List<Product> products = productDAO.LoadListWithCondition(txtSearch.Text);
            foreach (var pd in products)
            {
                UCProductTracking uc = new UCProductTracking(pd);
                flpProduct.Controls.Add(uc);
            }
        }
    }
}

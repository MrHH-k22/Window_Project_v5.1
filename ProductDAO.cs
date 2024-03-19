﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Window_Project_v5._1
{
    internal class ProductDAO
    {
        DBConnection dbc = new DBConnection();
        public void Add(Product product)
        {
            string sqlStr = string.Format("INSERT INTO Product (Condition, Status, OriginalPrice, SalePrice, Name, Description) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", product.Condition, product.Status, product.OriginalPrice, product.SalePrice, product.Name, product.Description);
            dbc.Excute(sqlStr);
        }
        
        public Product GetLastProduct()
        {
            Product pd = new Product();
            DataTable dt = dbc.Load("SELECT TOP 1 * FROM Product ORDER BY id DESC;");
            // Check if there are rows in the DataTable
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0]; // Get the first row

                // Assign values from DataRow to Product object
                pd.Id = Convert.ToInt32(row["id"]);
            }
            return pd;
        }

        public List<Product> LoadList()
        {
            List<Product> list = new List<Product>();
            DataTable dt = dbc.Load("SELECT * FROM Product;");
            foreach (DataRow dr in dt.Rows) {
                Product pd = new Product();
                pd.Id = Convert.ToInt32(dr["id"]);
                pd.Name = dr["name"].ToString();
                pd.OriginalPrice = Convert.ToDouble(dr["originalPrice"]);
                pd.SalePrice = Convert.ToDouble(dr["salePrice"]);
                pd.Condition = dr["condition"].ToString();
                pd.Status = dr["status"].ToString();
                pd.Description = dr["description"].ToString();
                //pd.SellerID = Convert.ToInt32(dr["sellerID"]);

                list.Add(pd);
            }
            return list;
        }
    }
}

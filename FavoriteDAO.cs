﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Window_Project_v5._1.Forms;

namespace Window_Project_v5._1
{
    public class FavoriteDAO
    {
        DBConnection dbc = new DBConnection();

        public void add(int buyerid,int productid)
        {
            string sqlStr = string.Format("INSERT INTO Favorite (BuyerID,ProductID) VALUES ('{0}', '{1}')",buyerid,productid);
            dbc.Execute(sqlStr);
        }

        public bool checkProductinFavorite(int buyerid,int productid)
        {
            string sqlStr = string.Format("SELECT * FROM Favorite WHERE BuyerID = '{0}' AND ProductID = '{1}'", buyerid, productid);
            DataTable dt = dbc.Load(sqlStr);
            return dt.Rows.Count > 0;
        }

        public void delete(int buyerId, int productId)
        {
            string sqlStr = string.Format("DELETE FROM Favorite WHERE BuyerID = '{0}' AND ProductID = '{1}'", buyerId, productId);
            dbc.Execute(sqlStr);
        }

        public List<Product> loadListWithAccountID(int accountID)
        {
            
            List<Product> list = new List<Product>();
            DataTable dt = new DataTable();
            dt = dbc.Load(string.Format("SELECT * FROM Favorite WHERE BuyerID = '{0}'", accountID));
            foreach (DataRow dr in dt.Rows)
            {
                int id = Convert.ToInt32(dr["productID"]);
                Product pd = new Product(id);
                list.Add(pd);
            }
            return list;
            
        }

    }
}

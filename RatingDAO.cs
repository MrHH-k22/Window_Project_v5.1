using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Window_Project_v5._1
{
    internal class RatingDAO
    {
        private DBConnection dbconnection = new DBConnection();
        public void Add(Rating rt, Product pd)
        {
            string sqlStr = string.Format("INSERT INTO Rating (Comment, Star, SellerID, ProductID, BuyerID) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", rt.Comment, rt.Star, pd.SellerID, pd.Id, pd.BuyerID);
            dbconnection.Execute(sqlStr);
        }
    }
}

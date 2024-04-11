using System;
using System.Collections.Generic;
using System.Data;
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

        public DataTable load(Account acc)
        {
            string sqlStr = string.Format("Select * from Rating where SellerID = '{0}'", acc.Id);
            DataTable table = dbconnection.Load(sqlStr);
            return table;
        }
        public List<Rating> LoadList(Account acc)
        {
            List<Rating> list = new List<Rating>();
            DataTable dt = load(acc);
            foreach(DataRow dr in dt.Rows)
            {
                Rating rt = GetRatingFromDataRow(dr);
                if(rt != null)
                {
                    list.Add(rt);
                }
            }
            return list;
        }
        public Rating GetRatingFromDataRow(DataRow dr)
        {
            Rating rt = new Rating();
            rt.Comment = dr["Comment"].ToString();
            rt.Star = Convert.ToSingle(dr["Star"]);
            return rt;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Window_Project_v5._1
{
    internal class RecommendDAO
    {
        DBConnection dbc = new DBConnection();

        public void update(string type, int buyerID)
        {
            string sqlStr;
            // Check if type already exists
            DataTable dt = dbc.Load(string.Format("SELECT * FROM Recommend WHERE BuyerID = '{0}' AND Type = '{1}'", buyerID, type));

            if (dt.Rows.Count > 0)
            {
                // If the type already exists, update the ViewCount
                //int viewCount = Convert.ToInt32(dt.Rows[0]["ViewCount"]) + 1;
                sqlStr = string.Format("UPDATE Recommend SET ViewCount = ViewCount + 1 WHERE BuyerID = '{0}' AND Type = '{1}'", buyerID, type);
            }
            else
            {
                // If the type doesn't exist, insert with ViewCount = 0
                sqlStr = string.Format("INSERT INTO Recommend (BuyerID, Type, ViewCount) VALUES ('{0}', '{1}', 0)", buyerID, type);
            }

            dbc.Execute(sqlStr);
        }

        public List<string> GetTopThreeRecommendedTypesByBuyerID(int buyerID)
        {
            List<string> topThreeTypes = new List<string>();
            string sqlStr = string.Format("SELECT TOP 3 Type, ViewCount " +
                                               "FROM Recommend WHERE BuyerID = '{0}' " +
                                               "ORDER BY ViewCount DESC;", buyerID);
            DataTable dt = dbc.Load(sqlStr);
            foreach (DataRow row in dt.Rows)
            {
                string type = row["Type"].ToString();
                topThreeTypes.Add(type);
            }
            return topThreeTypes;
        }




    }
}

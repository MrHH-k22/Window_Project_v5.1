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

        public void add(string type, int viewCount, int buyerID)
        {
            string sqlStr;
            //check if type already exists
            DataTable dt = dbc.Load(string.Format("SELECT * FROM Recommend WHERE BuyerID = '{0}' and Type = '{1}'", buyerID,type));
            //...
            if(dt.Rows.Count>0)
            {
                sqlStr = string.Format("UPDATE Recommend SET ViewCount '{0}' WHERE BuyerID = '{1}' AND Type = '{2}'",viewCount++,buyerID,type);
            }
            else
            {
                sqlStr = string.Format("INSERT INTO Recommend (BuyerID, Type, ViewCount) VALUES ('{0}', '{1}', {2})",buyerID,type,viewCount);
            }
            dbc.Execute(sqlStr);
        }
    }
}

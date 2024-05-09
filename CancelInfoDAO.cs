using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Window_Project_v5._1
{
    internal class CancelInfoDAO
    {
        DBConnection dbc = new DBConnection();
        
        public void add(CancelInfo cancelInfo)
        {
            string sqlStr = string.Format("INSERT INTO Cancel_Info (ProductID, CancelledTime, Reason, ExtraInfo, BuyerID) VALUES ({0}, '{1}', '{2}', '{3}', '{4}')",cancelInfo.ProductID,DateTime.Now , cancelInfo.Reason, cancelInfo.ExtraInfo, cancelInfo.BuyerID);
            dbc.Execute(sqlStr);
        }
        /*
        public List<CancelInfo> loadList(int SellerID)
        {
            
            List<CancelInfo> list = new List<CancelInfo>();
            DataTable dt = dbc.Load("SELECT * FROM CancelInfo Where SellerID = ;");
            foreach (DataRow dr in dt.Rows)
            {
                Shipping shipping = GetShippingFromDataRow(dr);
                list.Add(shipping);
            }
            return list;
            
        }
        */

    }
}

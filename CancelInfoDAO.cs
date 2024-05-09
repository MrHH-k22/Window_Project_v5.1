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

        public void delete(int id)
        {
            string sqlStr = string.Format("DELETE FROM Cancel_Info WHERE ID = {0}", id);
            dbc.Execute(sqlStr);
        }

        public List<CancelInfo> loadList(int SellerID)
        {   
            List<CancelInfo> list = new List<CancelInfo>();
            DataTable dt = dbc.Load(string.Format("SELECT Cancel_Info.* FROM Cancel_Info JOIN Product ON Cancel_Info.ProductID = Product.ID WHERE Product.SellerID = {0};", SellerID));
            foreach (DataRow dr in dt.Rows)
            {
                CancelInfo shipping = new CancelInfo();
                shipping.GetCancelInfoFromDataRow(dr);
                list.Add(shipping);
            }
            return list;
        }
    }
}

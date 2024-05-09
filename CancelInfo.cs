using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Window_Project_v5._1
{
    public class CancelInfo
    {
        private int id;
        private int productID;
        private int buyerID;
        private DateTime cancelledTime;
        private string reason;
        private string extraInfo;

        public CancelInfo() { }

        public CancelInfo(int productID, int buyerID, string reason, string extraInfo)
        {
            this.productID = productID;
            this.buyerID = buyerID;
            this.reason = reason;
            this.extraInfo = extraInfo;
        }

        public void GetCancelInfoFromDataRow(DataRow dr)
        {
            id = Convert.ToInt32(dr["ID"]);
            productID = Convert.ToInt32(dr["ProductID"]);
            buyerID = Convert.ToInt32(dr["BuyerID"]);
            cancelledTime = Convert.ToDateTime(dr["CancelledTime"]);
            reason = dr["Reason"].ToString();
            extraInfo = dr["ExtraInfo"].ToString();
        }

        public int Id { get => id; set => id = value; }
        public int ProductID { get => productID; set => productID = value; }
        public int BuyerID { get => buyerID; set => buyerID = value; }
        public DateTime CancelledTime1 { get => cancelledTime; set => cancelledTime = value; }
        public string Reason { get => reason; set => reason = value; }
        public string ExtraInfo { get => extraInfo; set => extraInfo = value; }
    }
}

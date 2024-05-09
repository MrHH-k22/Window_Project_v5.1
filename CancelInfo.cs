using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Window_Project_v5._1
{
    internal class CancelInfo
    {
        private int id;
        private int productID;
        private int buyerID;
        private DateTime CancelledTime;
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

        public int Id { get => id; set => id = value; }
        public int ProductID { get => productID; set => productID = value; }
        public int BuyerID { get => buyerID; set => buyerID = value; }
        public DateTime CancelledTime1 { get => CancelledTime; set => CancelledTime = value; }
        public string Reason { get => reason; set => reason = value; }
        public string ExtraInfo { get => extraInfo; set => extraInfo = value; }
    }
}

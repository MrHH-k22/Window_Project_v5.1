using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Window_Project_v5._1
{
    internal class Recommend
    {
        private string type;
        private int count;
        private string buyerID;

        public Recommend(string type, int count, string buyerID)
        {
            this.type = type;
            this.count = count;
            this.buyerID = buyerID;
        }

        public string Type { get => type; set => type = value; }
        public int Count { get => count; set => count = value; }
        public string BuyerID { get => buyerID; set => buyerID = value; }
    }
}

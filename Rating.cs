using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Window_Project_v5._1
{
    public class Rating
    {
        private string comment;
        private float star;
        private int sellerID;
        private int buyerID;
        private int productID;
        public Rating() { }
        public Rating(string comment, float star, int sellerID, int buyerID, int productID)
        {
            this.comment = comment;
            this.star = star;
            this.sellerID = sellerID;
            this.BuyerID = buyerID;
            this.ProductID = productID;
        }
        public string Comment { get =>  comment; set => comment = value; }
        public float Star { get => star; set => star = value; }
        public int BuyerID { get => buyerID; set => buyerID = value; }
        public int ProductID { get => productID; set => productID = value; }
        public int SellerID { get => sellerID; set => sellerID = value; }
    }
}

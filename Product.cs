using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Threading.Tasks;
using System.Data;

namespace Window_Project_v5._1
{
    public class Product
    {
        private int id;
        private string name;
        private double originalPrice;
        private double salePrice;
        private string condition;
        private string status;
        private string description;
        private int sellerID;
        private int buyerID;

        public Product()
        {
        }

        public Product(DataRow dr)
        {
            id = Convert.ToInt32(dr["id"]);
            name = dr["name"].ToString();
            originalPrice = Convert.ToDouble(dr["originalPrice"]);
            salePrice = Convert.ToDouble(dr["salePrice"]);
            condition = dr["condition"].ToString();
            status = dr["status"].ToString();
            description = dr["description"].ToString();
            //sellerID = Convert.ToInt32(dr["sellerid"]);
            //buyerID = Convert.ToInt32(dr["buyerid"]);
        }

        public Product(int id, string name, double originalPrice, double salePrice, string condition, string status)
        {
            this.id = id;
            this.name = name;
            this.originalPrice = originalPrice;
            this.salePrice = salePrice;
            this.condition = condition;
            this.status = status;
        }

        public Product(string condition, string status, double originalPrice, double salePrice, string name, string description)
        {
            this.condition = condition;
            this.status = status;
            this.originalPrice = originalPrice;
            this.salePrice = salePrice;
            this.name = name;
            this.description = description;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double OriginalPrice { get => originalPrice; set => originalPrice = value; }
        public double SalePrice { get => salePrice; set => salePrice = value; }
        public string Condition { get => condition; set => condition = value; }
        public string Status { get => status; set => status = value; }
        public string Description { get => description; set => description = value; }
        public int SellerID { get => sellerID; set => sellerID = value; }
        public int BuyerID { get => buyerID; set => buyerID = value; }
    }




}

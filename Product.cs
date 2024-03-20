using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Threading.Tasks;

namespace Window_Project_v5._1
{
    public class Product
    {
        private int id;
        private string name;
        private string brand;
        private double originalPrice;
        private double salePrice;
        private string condition;
        private string status;
        private string description;
        private int sellerID;
        private int buyerID;
        private List<byte[]> images = new List<byte[]>();
        private string category;

        public Product()
        {
        }

        public Product(int id, string name, double originalPrice, double salePrice, string condition, string status, List<byte[]> images, string brand, string description, int sellerID, int buyerID, string category)
        {
            this.id = id;
            this.name = name;
            this.originalPrice = originalPrice;
            this.salePrice = salePrice;
            this.condition = condition;
            this.status = status;
            this.images = images;
            this.brand = brand;
            this.description = description;
            this.sellerID = sellerID;
            this.buyerID = buyerID;
            this.category = category;
        }

        public Product(string condition, string status, double originalPrice, double salePrice, string name, string description,string brand, string category)
        {
            this.condition = condition;
            this.status = status;
            this.originalPrice = originalPrice;
            this.salePrice = salePrice;
            this.name = name;
            this.description = description;
            this.brand = brand;
            this.category = category;

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
        public string Brand { get => brand; set => brand = value; }
        public string Category { get => category; set => category = value; }
    }




}

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
        private ProductDAO productDAO = new ProductDAO();
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
        private int billStatus;
        private int viewCount;
        private string category;

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
            brand = dr["Brand"].ToString();
            Category = dr["category"].ToString();
            sellerID = Convert.ToInt32(dr["sellerid"]);
            viewCount = Convert.ToInt32(dr["viewcount"]);
            billStatus = Convert.ToInt32(dr["billstatus"]);
            buyerID = Convert.ToInt32(dr["buyerid"]);
        }

        public Product(int id)
        {
            Product product = productDAO.Retrieve(id);
            this.id = product.id;
            this.name = product.name;
            this.brand = product.brand;
            this.originalPrice = product.originalPrice;
            this.salePrice = product.salePrice;
            this.condition = product.condition;
            this.status = product.status;
            this.description = product.description;
            this.SellerID = product.sellerID;
            this.BuyerID = product.buyerID;
            this.category = product.category;
        }

        public Product(int id, string name, double originalPrice, double salePrice, string condition, string status, string brand, string category)
        {
            this.id = id;
            this.name = name;
            this.originalPrice = originalPrice;
            this.salePrice = salePrice;
            this.condition = condition;
            this.status = status;
            this.brand = brand;
            this.category = category;

        }
        public Product(int id, string name, double originalPrice, double salePrice, string condition, string status, string brand, string description, int sellerID, int buyerID, string category)
        {
            this.id = id;
            this.name = name;
            this.originalPrice = originalPrice;
            this.salePrice = salePrice;
            this.condition = condition;
            this.status = status;
            this.brand = brand;
            this.description = description;
            this.sellerID = sellerID;
            this.buyerID = buyerID;
            this.category = category;
        }

        public Product(string condition, string status, double originalPrice, double salePrice, string name, string description,string brand, string category, int sellerID)
        {
            this.condition = condition;
            this.status = status;
            this.originalPrice = originalPrice;
            this.salePrice = salePrice;
            this.name = name;
            this.description = description;
            this.brand = brand;
            this.category = category;
            this.sellerID = sellerID;
            billStatus = 0;
            viewCount = 0;
        }

        //add buyerid
        public Product(string condition, string status, double originalPrice, double salePrice, string name, string description, string brand, string category, string buyerID)
        {
            this.condition = condition;
            this.status = status;
            this.originalPrice = originalPrice;
            this.salePrice = salePrice;
            this.name = name;
            this.description = description;
            this.brand = brand;
            this.category = category;
            this.BuyerID = BuyerID;
            billStatus = 0;
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
        public int BillStatus { get => billStatus; set => billStatus = value; }
        public int ViewCount { get => viewCount; set => viewCount = value; }

        public string GetBillStatus()
        {
            switch (billStatus)
            {
                case 0:
                    return "";
                case 1:
                    return "Wait for confirmation";
                case 2:
                    return "Confirmed";
                case 3:
                    return "Pack";
                case 4:
                    return "Transport";
                case 5:
                    return "Completed";
                default:
                    return "";
            }
        }
    }




}

using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Threading.Tasks;
using System.Data;
using System.Runtime.CompilerServices;
using System.Reflection;

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
        private int orderCondition;
        private string contactPhone;
        private string deliveryAddress;
        private string origin;
        private string type;
        private string material;
        private string supportPolicy;
        private string area;
        private string size;
        private DateTime postedTime;
        private DateTime completeTime;
        private string color;
        private string functionality;
        private DateTime BuyDate;
        private int cancelLimit;
        private bool cancelRefund;



        public Product()
        {
        }

        public Product(DataRow dr)
        {
            Product product = productDAO.GetProductFromDataRow(dr);
            if (product != null)
            {
                PropertyInfo[] properties = typeof(Product).GetProperties();
                foreach (PropertyInfo property in properties)
                {
                    PropertyInfo thisProperty = typeof(Product).GetProperty(property.Name);
                    object value = property.GetValue(product);
                    thisProperty.SetValue(this, value);
                }
            }
        }

        public Product(int id)
        {
            Product product = productDAO.Retrieve(id);
            if (product != null)
            {
                PropertyInfo[] properties = typeof(Product).GetProperties();
                foreach (PropertyInfo property in properties)
                {
                    PropertyInfo thisProperty = typeof(Product).GetProperty(property.Name);
                    object value = property.GetValue(product);
                    thisProperty.SetValue(this, value);
                }
            }
        }

        //Post Product
        public Product(string category, string name, string type, double originalPrice, double salePrice, string area, string condition, string status, string supportPolicy, string brand, string origin, string material, string size, string functionality, string description, string hours, bool cancel, int sellerID)
        {
            this.category = category;
            this.name = name;
            this.type = type;
            this.originalPrice = originalPrice;
            this.salePrice = salePrice;
            this.area = area;
            this.condition = condition;
            this.status = status;
            this.supportPolicy = supportPolicy;
            this.brand = brand;
            this.origin = origin;
            this.material = material;
            this.size = size;
            this.functionality = functionality;
            this.description = description;
            this.sellerID = sellerID;
            orderCondition = 0;
            billStatus = 0;
            buyerID = 0;
            viewCount = 0;
            contactPhone = "";
            deliveryAddress = "";
            completeTime = DateTime.MinValue;
            cancelLimit = int.Parse(hours);
            cancelRefund = cancel;
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
            OrderCondition = (int)ordercondition.Displaying;
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
        public int OrderCondition { get => orderCondition; set => orderCondition = value; }
        public string ContactPhone { get => contactPhone; set => contactPhone = value; }
        public string DeliveryAddress { get => deliveryAddress; set => deliveryAddress = value; }
        public string Origin { get => origin; set => origin = value; }
        public string Type { get => type; set => type = value; }
        public string Material { get => material; set => material = value; }
        public string SupportPolicy { get => supportPolicy; set => supportPolicy = value; }
        public string Area { get => area; set => area = value; }
        public string Size { get => size; set => size = value; }
        public DateTime PostedTime { get => postedTime; set => postedTime = value; }
        public DateTime CompleteTime { get => completeTime; set => completeTime = value; }
        public string Color { get => color; set => color = value; }
        public string Functionality { get => functionality; set => functionality = value; }
        public int CancelLimit { get => cancelLimit; set => cancelLimit = value; }
        public bool CancelRefund { get => cancelRefund; set => cancelRefund = value; }

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

        public DateTime CancelDate()
        {
            return BuyDate.AddHours(cancelLimit);
        }
    }
}

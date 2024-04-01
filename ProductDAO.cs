using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace Window_Project_v5._1
{
    internal class ProductDAO
    {
        DBConnection dbc = new DBConnection();
        public void Add(Product product)
        {
            string sqlStr = string.Format("INSERT INTO Product (Condition, Status, OriginalPrice, SalePrice, Name, Description, Brand, Category, SellerID, BillStatus, ViewCount, OrderCondition) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}')", product.Condition, product.Status, product.OriginalPrice, product.SalePrice, product.Name, product.Description,product.Brand, product.Category, product.SellerID, product.BillStatus, product.ViewCount, product.OrderCondition);
            dbc.Excute(sqlStr);
        }

        public void Update(Product product)
        {
            string sqlStr = string.Format("UPDATE Product SET Condition = '{0}', Status = '{1}', OriginalPrice = '{2}', SalePrice = '{3}', Name = '{4}', Description = '{5}', Brand = '{6}', Category = '{7}',BuyerID = '{8}', BillStatus = '{9}', ViewCount = '{10}',OrderCondition = '{11}' WHERE id = '{12}'", product.Condition, product.Status, product.OriginalPrice, product.SalePrice, product.Name, product.Description, product.Brand, product.Category,product.BuyerID, product.BillStatus, product.ViewCount,product.OrderCondition, product.Id);
            dbc.Excute(sqlStr);
        }

        public void DeleteBuyerID(Product product)
        {
            string sqlStr = string.Format("Update Product Set BuyerID = 0 where id = '{0}'", product.Id);
            //string sqlStr = string.Format("UPDATE Product SET Condition = '{0}', Status = '{1}', OriginalPrice = '{2}', SalePrice = '{3}', Name = '{4}', Description = '{5}', Brand = '{6}', Category = '{7}', BuyerID = NULL, BillStatus = '{8}', ViewCount = '{9}' WHERE id = '{10}'", product.Condition, product.Status, product.OriginalPrice, product.SalePrice, product.Name, product.Description, product.Brand, product.Category, product.BillStatus, product.ViewCount, product.Id);
            dbc.Excute(sqlStr);
        }

        public Product GetLastProduct()
        {
            Product pd = new Product();
            DataTable dt = dbc.Load("SELECT TOP 1 * FROM Product ORDER BY id DESC;");
            // Check if there are rows in the DataTable
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0]; // Get the first row

                // Assign values from DataRow to Product object
                pd.Id = Convert.ToInt32(row["id"]);
            }
            return pd;
        }

        

        public List<Product> LoadList()
        {
            List<Product> list = new List<Product>();
            DataTable dt = dbc.Load("SELECT * FROM Product ORDER BY ViewCount DESC;");
            foreach (DataRow dr in dt.Rows) {
                Product pd = new Product(dr);
                list.Add(pd);
            }
            return list;
        }

        public List<Product> LoadListWithCondition(string name, int id)
        {
            List<Product> list = new List<Product>();
            DataTable dt = new DataTable();
            if (name.Length == 0)
            {
                dt = dbc.Load(string.Format("SELECT * FROM Product WHERE SellerID = '{0}'", id));
            } else
            {
                dt = dbc.Load(string.Format("SELECT * FROM Product WHERE Name LIKE '%{0}%' AND SellerID = '{1}'", name, id));
            }
            foreach (DataRow dr in dt.Rows)
            {
                Product pd = new Product(dr);
                list.Add(pd);
            }
            return list;
        }

        public Product Retrieve(int id)
        {
            string SQL = string.Format("select * from product where ID = '{0}'", id);
            DataTable dt = dbc.Load(SQL);
            return GetProductFromDataTable(dt);
        }

        public Product GetProductFromDataTable(DataTable dt)
        {
            if (dt.Rows.Count > 0)
            {
                Product product = new Product();
                DataRow row = dt.Rows[0];
                product.Id = Convert.ToInt32(row["id"]);
                product.Name = Convert.ToString(row["name"]);
                product.Brand = Convert.ToString(row["Brand"]);
                product.OriginalPrice = Convert.ToDouble(row["OriginalPrice"]);
                product.SalePrice = Convert.ToDouble(row["SalePrice"]);
                product.Condition = Convert.ToString(row["Condition"]);
                product.Status = Convert.ToString(row["Status"]);
                product.Description = Convert.ToString(row["Description"]);
                product.SellerID = Convert.ToInt32(row["SellerID"]);
                product.BuyerID = Convert.ToInt32(row["BuyerID"]);
                product.Category = Convert.ToString(row["Category"]);

                return product;
            }
            else
            {
                return null;
            }
        }

        public List<Product> LoadListWithBuyerID(int id)
        {
            List<Product> list = new List<Product>();
            DataTable dt = new DataTable();
            dt = dbc.Load(string.Format("SELECT * FROM Product WHERE BuyerID = '{0}'", id));
            foreach (DataRow dr in dt.Rows)
            {
                Product pd = new Product(dr);
                list.Add(pd);
            }
            return list;
        }

        public List<Product> LoadListWithoutBuyerID()
        {
            List<Product> list = new List<Product>();
            DataTable dt = new DataTable();
            dt = dbc.Load(string.Format("SELECT * FROM Product WHERE BuyerID IS NULL or BuyerID <= 0"));
            foreach (DataRow dr in dt.Rows)
            {
                Product pd = new Product(dr);
                list.Add(pd);
            }
            return list;
        }
    }
}

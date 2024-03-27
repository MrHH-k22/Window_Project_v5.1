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

namespace Window_Project_v5._1
{
    internal class ProductDAO
    {
        DBConnection dbc = new DBConnection();
        public void Add(Product product)
        {
            string sqlStr = string.Format("INSERT INTO Product (Condition, Status, OriginalPrice, SalePrice, Name, Description, Brand, Categories) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", product.Condition, product.Status, product.OriginalPrice, product.SalePrice, product.Name, product.Description,product.Brand, product.Category);
            dbc.Excute(sqlStr);
        }

        public void Update(Product product)
        {
            string sqlStr = string.Format("UPDATE Product SET Condition = '{0}', Status = '{1}', OriginalPrice = '{2}', SalePrice = '{3}', Name = '{4}', Description = '{5}', Brand = '{6}', Category = '{7}',BuyerID = '{8}' WHERE id = '{9}'", product.Condition, product.Status, product.OriginalPrice, product.SalePrice, product.Name, product.Description, product.Brand, product.Category,product.BuyerID, product.Id);
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
            DataTable dt = dbc.Load("SELECT * FROM Product;");
            foreach (DataRow dr in dt.Rows) {
                Product pd = new Product(dr);
                list.Add(pd);
            }
            return list;
        }

        public List<Product> LoadListWithCondition(string name)
        {
            List<Product> list = new List<Product>();
            DataTable dt = new DataTable();
            if (name.Length == 0)
            {
                dt = dbc.Load("SELECT * FROM Product;");
            }
            else
            {
                dt = dbc.Load(string.Format("SELECT * FROM Product WHERE Name LIKE '%{0}%'", name));
            }
            foreach (DataRow dr in dt.Rows)
            {
                Product pd = new Product(dr);
                list.Add(pd);
            }
            return list;
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
    }
}

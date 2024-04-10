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
using Guna.UI2.WinForms.Suite;
using static Guna.UI2.Native.WinApi;
using System.Data.SqlTypes;

namespace Window_Project_v5._1
{
    internal class ProductDAO
    {
        DBConnection dbc = new DBConnection();
        // Add product into database
        public void Add(Product pd)
        {
            string sqlStr = "INSERT INTO Product (Name, Brand, OriginalPrice, SalePrice, Condition, Status, Description, SellerID, BuyerID, Category, BillStatus, ViewCount, OrderCondition, ContactPhone, DeliveryAddress, Origin, Type, Material, SupportPolicy, Area, Size, PostedTime, Functionality, CompleteTime) " +
                            "VALUES (@Name, @Brand, @OriginalPrice, @SalePrice, @Condition, @Status, @Description, @SellerID, @BuyerID, @Category, @BillStatus, @ViewCount, @OrderCondition, @ContactPhone, @DeliveryAddress, @Origin, @Type, @Material, @SupportPolicy, @Area, @Size, @PostedTime, @Functionality, @CompleteTime)";

            // Adjust PostedTime if it's outside the valid range
            DateTime postedTime = pd.PostedTime < SqlDateTime.MinValue.Value ? SqlDateTime.MinValue.Value : (pd.PostedTime > SqlDateTime.MaxValue.Value ? SqlDateTime.MaxValue.Value : pd.PostedTime);

            // Adjust CompleteTime if it's outside the valid range
            DateTime completeTime = pd.CompleteTime < SqlDateTime.MinValue.Value ? SqlDateTime.MinValue.Value : (pd.CompleteTime > SqlDateTime.MaxValue.Value ? SqlDateTime.MaxValue.Value : pd.CompleteTime);

            SqlParameter[] parameters =
            {
                new SqlParameter("@Name", pd.Name),
                new SqlParameter("@Brand", pd.Brand),
                new SqlParameter("@OriginalPrice", pd.OriginalPrice),
                new SqlParameter("@SalePrice", pd.SalePrice),
                new SqlParameter("@Condition", pd.Condition),
                new SqlParameter("@Status", pd.Status),
                new SqlParameter("@Description", pd.Description),
                new SqlParameter("@SellerID", pd.SellerID),
                new SqlParameter("@BuyerID", pd.BuyerID),
                new SqlParameter("@Category", pd.Category),
                new SqlParameter("@BillStatus", pd.BillStatus),
                new SqlParameter("@ViewCount", pd.ViewCount),
                new SqlParameter("@OrderCondition", pd.OrderCondition),
                new SqlParameter("@ContactPhone", pd.ContactPhone),
                new SqlParameter("@DeliveryAddress", pd.DeliveryAddress),
                new SqlParameter("@Origin", pd.Origin),
                new SqlParameter("@Type", pd.Type),
                new SqlParameter("@Material", pd.Material),
                new SqlParameter("@SupportPolicy", pd.SupportPolicy),
                new SqlParameter("@Area", pd.Area),
                new SqlParameter("@Size", pd.Size),
                new SqlParameter("@PostedTime", postedTime),
                new SqlParameter("@Functionality", pd.Functionality),
                new SqlParameter("@CompleteTime", completeTime)
            };

            dbc.Execute(sqlStr, parameters);
        }



        // Seller edit product's information
        public void Update(Product pd, bool check)
        {
            string sqlStr = string.Format("UPDATE Product SET Name = '{0}', Brand = '{1}' , OriginalPrice = '{2}', SalePrice = '{3}', Condition = '{4}', Status = '{5}', Description = '{6}', Category = '{7}', Origin = '{8}', Type = '{9}', Material = '{10}', SupportPolicy = '{11}', Area = '{12}', Size = '{13}', Functionality = '{14}' WHERE ID = '{15}'",
                                       pd.Name, pd.Brand, pd.OriginalPrice, pd.SalePrice, pd.Condition, pd.Status, pd.Description, pd.Category, pd.Origin, pd.Type, pd.Material, pd.SupportPolicy, pd.Area, pd.Size, pd.Functionality, pd.Id);
            dbc.Execute(sqlStr);
        }

        // Buyer purchase the product
        public void Update(Product product)
        {
            string sqlStr = string.Format("UPDATE Product SET BuyerID = '{0}', OrderCondition = '{1}', ContactPhone = '{2}', DeliveryAddress = '{3}'  WHERE ID = '{4}'",
                                             product.BuyerID, product.OrderCondition, product.ContactPhone, product.DeliveryAddress, product.Id);
            dbc.Execute(sqlStr);
        }

        public void Delete(Product product)
        {
            string sqlStr = string.Format("DELETE FROM Product WHERE id = '{0}'", product.Id);
            dbc.Execute(sqlStr);
        }

        public void DeleteBuyerID(Product product)
        {
            string sqlStr = string.Format("Update Product Set BuyerID = 0 where id = '{0}'", product.Id);
            //string sqlStr = string.Format("UPDATE Product SET Condition = '{0}', Status = '{1}', OriginalPrice = '{2}', SalePrice = '{3}', Name = '{4}', Description = '{5}', Brand = '{6}', Category = '{7}', BuyerID = NULL, BillStatus = '{8}', ViewCount = '{9}' WHERE id = '{10}'", product.Condition, product.Status, product.OriginalPrice, product.SalePrice, product.Name, product.Description, product.Brand, product.Category, product.BillStatus, product.ViewCount, product.Id);
            dbc.Execute(sqlStr);
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

        public List<int> LoadCustomers(int sellerid)
        {
            List<int> list = new List<int>();
            DataTable dt = new DataTable();
            dt = dbc.Load(string.Format("SELECT DISTINCT BuyerID FROM Product WHERE BuyerID IS NOT NULL AND SellerID = '{0}'", sellerid));
            foreach (DataRow dr in dt.Rows)
            {
                list.Add((int)dr["BuyerID"]);
            }
            return list;
        }

        public Product Retrieve(int id)
        {
            string SQL = string.Format("SELECT * FROM product WHERE ID = '{0}'", id);
            DataTable dt = dbc.Load(SQL);
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                return GetProductFromDataRow(dr);
            }
            else
            {
                return null;
            }
        }

        public List<Product> GetProductsFromDataTable(DataTable dt)
        {
            List<Product> products = new List<Product>();

            foreach (DataRow dr in dt.Rows)
            {
                Product product = GetProductFromDataRow(dr);
                if (product != null)
                {
                    products.Add(product);
                }
            }
            return products;
        }

        public Product GetProductFromDataRow(DataRow dr)
        {
            Product product = new Product();
            product.Id = (dr["ID"] == DBNull.Value) ? -1 : Convert.ToInt32(dr["ID"]);
            product.Name = dr["Name"].ToString();
            product.Brand = dr["Brand"].ToString();
            product.OriginalPrice = Convert.ToDouble(dr["OriginalPrice"]);
            product.SalePrice = Convert.ToDouble(dr["SalePrice"]);
            product.Condition = dr["Condition"].ToString();
            product.Status = dr["Status"].ToString();
            product.Description = dr["Description"].ToString();
            product.SellerID = Convert.ToInt32(dr["SellerID"]);
            product.BuyerID = (dr["BuyerID"] == DBNull.Value) ? -1 : Convert.ToInt32(dr["BuyerID"]);
            product.BillStatus = (dr["BillStatus"] == DBNull.Value) ? -1 : Convert.ToInt32(dr["BillStatus"]);
            product.ViewCount = (dr["ViewCount"] == DBNull.Value) ? 0 : Convert.ToInt32(dr["ViewCount"]);
            product.Category = dr["Category"].ToString();
            product.OrderCondition = (dr["OrderCondition"] == DBNull.Value) ? -1 : Convert.ToInt32(dr["OrderCondition"]);
            product.ContactPhone = dr["ContactPhone"].ToString();
            product.DeliveryAddress = dr["DeliveryAddress"].ToString();
            product.Origin = dr["Origin"].ToString();
            product.Type = dr["Type"].ToString();
            product.Material = dr["Material"].ToString();
            product.SupportPolicy = dr["SupportPolicy"].ToString();
            product.Area = dr["Area"].ToString();
            product.Size = dr["Size"].ToString();
            product.PostedTime = (dr["PostedTime"] == DBNull.Value) ? DateTime.MinValue : Convert.ToDateTime(dr["PostedTime"]);
            product.CompleteTime = (dr["CompleteTime"] == DBNull.Value) ? DateTime.MinValue : Convert.ToDateTime(dr["CompleteTime"]);
            product.Functionality = dr["Functionality"].ToString();
            return product;
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

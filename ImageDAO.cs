using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Window_Project_v5._1
{
    internal class ImageDAO
    {
        DBConnection dbc = new DBConnection();
        public void Add(int productID, string imgLocation)
        {
            byte[] images = File.ReadAllBytes(imgLocation);
            string sqlStr = "INSERT INTO ProductImages (ProductID, Image) VALUES (@ProductID, @Images)";

            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@ProductID", SqlDbType.Int);
            parameters[0].Value = productID;
            parameters[1] = new SqlParameter("@Images", SqlDbType.VarBinary);
            parameters[1].Value = images;

            dbc.Execute(sqlStr, parameters);
        }
        public void Delete(int productID)
        {
            string sqlStr = string.Format("DELETE FROM ProductImages WHERE productid = '{0}'", productID);
            dbc.Excute(sqlStr);
        }

        public byte[] GetImageProductData(int productID)
        {
            string sqlStr = string.Format("SELECT TOP 1 Image FROM ProductImages WHERE ProductID = '{0}'", productID);
            object result = dbc.ExecuteScalar(sqlStr);

            if (result != null && result != DBNull.Value)
            {
                return (byte[])result;
            }

            return null;
        }

        public DataTable GetImageProduct(int productID)
        {
            string sqlStr = string.Format("SELECT Image FROM ProductImages WHERE ProductID = '{0}'", productID);
            return dbc.Load(sqlStr);
        }
    }
}

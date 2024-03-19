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
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public void Add(int productID, string imgLocation)
        {
            byte[] images = File.ReadAllBytes(imgLocation);

            string sqlStr = string.Format("INSERT INTO ProductImages (ProductID, Image) VALUES ('{0}', @Images)", productID);
            SqlCommand command = new SqlCommand(sqlStr, conn);
            // Add parameter for image data
            command.Parameters.AddWithValue("@Images", images);
            try
            {
                conn.Open();
                int rowsAffected = command.ExecuteNonQuery();
                MessageBox.Show("Image saved to database successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving image to database: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
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
    }
}

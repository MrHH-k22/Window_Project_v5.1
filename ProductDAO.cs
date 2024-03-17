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

namespace Window_Project_v5._1
{
    internal class ProductDAO
    {
        DBConnection dbc = new DBConnection();
        public void Add(Product product)
        {
            string sqlStr = string.Format("INSERT INTO Product (Condition, Status, OriginalPrice, SalePrice, Name, Description) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", product.Condition, product.Status, product.OriginalPrice, product.SalePrice, product.Name, product.Description);
            dbc.Excute(sqlStr);
        }
    }
}

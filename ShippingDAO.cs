using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Window_Project_v5._1.Forms;

namespace Window_Project_v5._1
{
    internal class ShippingDAO
    {
        DBConnection dbc = new DBConnection();

        public void add(Shipping shipping)
        {
            string sqlStr = string.Format("INSERT INTO ShippingInfo (AccountID, RecipientName, Address, PhoneNumber) VALUES ({0}, '{1}', '{2}', '{3}')", shipping.AccountId, shipping.RecipientName, shipping.Address, shipping.PhoneNo);
            dbc.Execute(sqlStr);
        }

        public List<Shipping> LoadList()
        {
            List<Shipping> list = new List<Shipping>();
            DataTable dt = dbc.Load("SELECT * FROM ShippingInfo;");
            foreach (DataRow dr in dt.Rows)
            {
                Shipping shipping = GetShippingFromDataRow(dr);
                list.Add(shipping);
            }
            return list;
        }

        public Shipping GetShipping(int id)
        {
            DataTable dt = dbc.Load(string.Format("SELECT * FROM ShippingInfo WHERE ID = '{0}';", id));
            foreach (DataRow dr in dt.Rows)
            {
                Shipping shipping = GetShippingFromDataRow(dr);
                return shipping;
            }
            return null;
        }



        public Shipping GetShippingFromDataRow(DataRow dr)
        {
            Shipping shipping = new Shipping();
            shipping.AccountId = (dr["AccountID"] == DBNull.Value) ? -1 : Convert.ToInt32(dr["AccountID"]);
            shipping.RecipientName = dr["RecipientName"].ToString();
            shipping.Address = dr["Address"].ToString();
            shipping.PhoneNo = dr["PhoneNumber"].ToString();
            shipping.Id = Convert.ToInt32(dr["ID"]);
            return shipping;
        }

    }
}

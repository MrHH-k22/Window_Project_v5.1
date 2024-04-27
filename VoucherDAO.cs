using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Window_Project_v5._1
{
    public class VoucherDAO
    {
        DBConnection dbc = new DBConnection();

        public void add(Voucher voucher)
        {
            string sqlStr = string.Format("INSERT INTO Voucher (SellerID, Name, Value, BeginDay, EndDay) VALUES ({0}, '{1}', '{2}', '{3}', '{4}')", voucher.SellerId,voucher.Name,voucher.Value,voucher.Beginday,voucher.Endday);
            dbc.Execute(sqlStr);
        }

        public List<Voucher> LoadList()
        {
            List<Voucher> list = new List<Voucher>();
            DataTable dt = dbc.Load("SELECT * FROM Voucher;");
            foreach (DataRow dr in dt.Rows)
            {
                Voucher pd = GetFromDataRow(dr);
                list.Add(pd);
            }
            return list;
        }

        public Voucher GetFromDataRow(DataRow dr)
        {
            Voucher voucher = new Voucher();
            voucher.SellerId = (dr["SellerID"] == DBNull.Value) ? -1 : Convert.ToInt32(dr["SellerID"]);
            voucher.Name = dr["Name"].ToString();
            voucher.Value = Convert.ToDouble(dr["Value"]);
            voucher.Beginday = Convert.ToDateTime(dr["BeginDay"]);
            voucher.Endday = Convert.ToDateTime(dr["EndDay"]);
            voucher.VoucherId = (dr["VoucherID"] == DBNull.Value) ? -1 : Convert.ToInt32(dr["VoucherID"]);
            return voucher;
        }

        public void collectVoucher(int VoucherId,int BuyerID)
        {
            // Kiểm tra xem cặp (VoucherID, BuyerID) đã tồn tại trong bảng Voucher_Account hay chưa
            string checkSqlStr = string.Format("SELECT COUNT(*) FROM Voucher_Account WHERE VoucherID = {0} AND BuyerID = {1}", VoucherId, BuyerID);
            int existingCount = (int)dbc.ExecuteScalar(checkSqlStr);

            // Nếu cặp đã tồn tại, không thực hiện thêm mới
            if (existingCount > 0)
            {
                MessageBox.Show("This voucher has already been collected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Dừng hàm
            }

            // Nếu cặp chưa tồn tại, thực hiện thêm mới
            string sqlStr = string.Format("INSERT INTO Voucher_Account (VoucherID, BuyerID) VALUES ('{0}', '{1}')", VoucherId, BuyerID);
            dbc.Execute(sqlStr);

            MessageBox.Show("Voucher successfully collected.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public Voucher GetVoucher(int id)
        {
            DataTable dt = dbc.Load(string.Format("SELECT * FROM Voucher WHERE VoucherID = '{0}';", id));
            foreach (DataRow dr in dt.Rows)
            {
                Voucher voucher = GetFromDataRow(dr);
                return voucher;
            }
            return null;
        }



        public List<int> GetVoucherIDsByBuyerID(int buyerID)
        {
            List<int> list = new List<int>();
            DataTable dt = dbc.Load(string.Format("SELECT VoucherID FROM Voucher_Account WHERE BuyerID = {0}", buyerID));
            foreach (DataRow dr in dt.Rows)
            {
                list.Add((int)dr["VoucherID"]);
            }
            return list;
        }

    }
}

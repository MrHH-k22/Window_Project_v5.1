using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace Window_Project_v5._1
{
    internal class AccountDAO
    {
        private SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        private DBConnection dbconnection = new DBConnection();
       
        public void update(Account account)
        {
            string sqlStr = string.Format("UPDATE Account SET email = '{0}', password = '{1}', name = '{2}', Phone = '{3}', Birthday = '{4}', address = '{5}', money = '{6}' WHERE id = {7}", 
                account.Email, account.Password,account.Name, account.Phone, account.Birthday,account.Address, account.Money, account.Id);
            AddImage(account, account.Avatar);
            dbconnection.Excute(sqlStr);
        }

        public void AddImage(Account account,byte[] imgData)
        {
            if (imgData != null)
            {
                string sqlStr = "UPDATE Account SET Avatar = @Avatar WHERE ID = @AccountID";

                SqlParameter[] parameters = new SqlParameter[2];
                parameters[0] = new SqlParameter("@Avatar", SqlDbType.VarBinary);
                parameters[0].Value = imgData;
                parameters[1] = new SqlParameter("@AccountID", SqlDbType.Int);
                parameters[1].Value = account.Id;

                dbconnection.Execute(sqlStr, parameters);
            }
        }
        

        public void CreateNewAccount(Account account)
        {
            string SQL = string.Format("INSERT INTO Account (Email, Password, Name, Money) VALUES ('{0}', '{1}', '{2}', '{3}')", account.Email, account.Password, account.Name, account.Money);
            dbconnection.Excute(SQL);
        }
        public Account CheckAccount(Account account)
        {
            string SQL = string.Format("select * from Account where Email = '{0}' and Password = '{1}'", account.Email, account.Password);
            DataTable dt = dbconnection.Load(SQL);
            return GetAccountFromDataTable(dt);
        }

        public Account Retrieve(int id)
        {
            string SQL = string.Format("select * from Account where ID = '{0}'", id);
            DataTable dt = dbconnection.Load(SQL);
            return GetAccountFromDataTable(dt);
        }

        public Account GetAccountFromDataTable(DataTable dt)
        {
            if (dt.Rows.Count > 0)
            {
                Account account = new Account();
                DataRow row = dt.Rows[0];
                account.Id = Convert.ToInt32(row["id"]);
                account.Name = Convert.ToString(row["name"]);
                account.Address = Convert.ToString(row["address"]);
                account.Email = Convert.ToString(row["email"]);
                account.Phone = Convert.ToString(row["phone"]);
                account.Password = Convert.ToString(row["password"]);
                account.Money = Convert.ToDouble(row["money"]);
                object birthdayValue = row["birthday"];
                DateTime birthday;
                if (birthdayValue != DBNull.Value && DateTime.TryParse(birthdayValue.ToString(), out birthday))
                {
                    account.Birthday = birthday;
                }
                // Assuming the Avatar column is stored as byte[] in the database
                if (row["Avatar"] != DBNull.Value)
                {
                    account.Avatar = (byte[])row["Avatar"];
                }
                else
                {
                    account.Avatar = null; // Or any other default value you want to assign
                }
                return account;
            }
            else
            {
                return null;
            }
        }
    }

}

using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Window_Project_v5._1
{
    internal class AccountDAO
    {
        private SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        private DBConnection dbconnection = new DBConnection();
        private RatingDAO ratingDAO = new RatingDAO();
       
        public void update(Account account)
        {
            string sqlStr = string.Format("UPDATE Account SET email = '{0}', password = '{1}', name = '{2}', Phone = '{3}', Birthday = '{4}', address = '{5}', money = '{6}' WHERE id = {7}", 
                account.Email, account.Password,account.Name, account.Phone, account.Birthday,account.Address, account.Money, account.Id);
            AddImage(account, account.Avatar);
            dbconnection.Execute(sqlStr);
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
        

        public bool CreateNewAccount(Account account)
        {
            if (CheckEmailExisted(account.Email) == true)
            {
                MessageBox.Show("Email has been existed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                string sql = string.Format("INSERT INTO Account (Email, Password, Name) VALUES ('{0}', '{1}', '{2}')", account.Email, account.Password, account.Name);
                dbconnection.Execute(sql);
                return true;
            }

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
                account.Money = row["money"] != DBNull.Value ? Convert.ToDouble(row["money"]) : 0;
                
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
        public void  ResetPassword(string emailsubmitted, string pwsubmitted)
        {
            if (CheckEmailExisted(emailsubmitted) == true)
            {
                string sql = string.Format("UPDATE Account SET Password = '{0}' WHERE Email = '{1}'", pwsubmitted, emailsubmitted);
                dbconnection.Execute(sql);
            }
            else
            {
                MessageBox.Show("Email has not been found in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public bool CheckEmailExisted(string email)
        {
            string SQL = string.Format("SELECT * FROM Account WHERE Email = '{0}'", email);
            DataTable dt = dbconnection.Load(SQL);

            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}

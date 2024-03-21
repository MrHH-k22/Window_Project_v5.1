using System;
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
    internal class AccountDAO
    {
        private SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        private DBConnection dbconnection = new DBConnection();
       
        public void update(Account account)
        {
            string sqlStr = string.Format("UPDATE Account SET email = '{0}', password = '{1}', name = '{2}', Phone = '{3}', Birthday = '{4}', address = '{5}' WHERE id = {6}", 
                account.Email, account.Password,account.Name, account.Phone, account.Birthday,account.Address, account.Id);
            AddImage(account, account.Avatar);
            dbconnection.Excute(sqlStr);
        }

        
        public void AddImage(Account account,byte[] imgLocation)
        {
            //byte[] images = File.ReadAllBytes(imgLocation);
            string sqlStr = "UPDATE Account SET Image = @Image WHERE ID = @AccountID";

            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@AccountID", SqlDbType.Int);
            parameters[0].Value = account.Id;
            parameters[1] = new SqlParameter("@Images", SqlDbType.VarBinary);
            parameters[1].Value = imgLocation;

            dbconnection.Execute(sqlStr, parameters);
        }
        

        public void CreateNewAccount(Account account)
        {
            string SQL = string.Format("INSERT INTO Account (Email, Password, Name) VALUES ('{0}', '{1}', '{2}')", account.Email, account.Password, account.Name);
            dbconnection.Excute(SQL);
        }
        public Account CheckAccount(Account account)
        {
            string SQL = string.Format("select * from Account where Email = '{0}' and Password = '{1}'", account.Email, account.Password);
            DataTable dt = dbconnection.Load(SQL);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                account.Id = Convert.ToInt32(row["id"]);
                account.Name = Convert.ToString(row["name"]);
                account.Address = Convert.ToString(row["address"]);
                account.Phone = Convert.ToString(row["phone"]);
                //account.Birthday = Convert.ToDateTime(row["birthday"]);
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

        public Account Retrieve(int id)
        {
            string SQL = string.Format("select * from Account where ID = '{0}'", id);
            DataTable dt = dbconnection.Load(SQL);
            if (dt.Rows.Count > 0)
            {
                Account account = new Account();
                DataRow row = dt.Rows[0];
                account.Id = Convert.ToInt32(row["id"]);
                account.Name = Convert.ToString(row["name"]);
                account.Address = Convert.ToString(row["address"]);
                account.Phone = Convert.ToString(row["phone"]);
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

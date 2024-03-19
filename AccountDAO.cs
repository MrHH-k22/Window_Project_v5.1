using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Window_Project_v5._1
{
    internal class AccountDAO
    {
        protected SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
       
        public void update(Account account)
        {
            string sqlStr = "UPDATE Account SET Email = @Email, Password = @Password, Name = @Name, Phone = @Phone, Birthday = @Birthday, Address = @Address, Avatar = @Avatar WHERE ID = @ID";
            //string sqlStr = "INSERT INTO Account (Email, Password, Name, Phone, Birthday, Address, Avatar) VALUES (@Email, @Password, @Name, @Phone, @Birthday, @Address, @Avatar)";


            using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand(sqlStr, conn))
                {
                    command.Parameters.AddWithValue("@Email", account.Email);
                    command.Parameters.AddWithValue("@Password", account.Password);
                    command.Parameters.AddWithValue("@Name", account.Name);
                    command.Parameters.AddWithValue("@Phone", account.Phone);
                    command.Parameters.AddWithValue("@Birthday", account.Birthday);
                    command.Parameters.AddWithValue("@Address", account.Address);
                    command.Parameters.AddWithValue("@Avatar", account.Avatar);
                    command.Parameters.AddWithValue("@ID", account.Id);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Window_Project_v5._1
{
    internal class DBConnection
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public void Excute(string sqlStr)
        {
            try
            {
                // Ket noi
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Successful");
                else
                    MessageBox.Show("Unsuccessful");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unsuccessful" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable Load(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
            return new DataTable();
        }
        public object ExecuteScalar(string query)
        {
            using (var connection = conn)
            {
                connection.Open();
                using (var command = new SqlCommand(query, connection))
                {
                    return command.ExecuteScalar();
                }
            }
        }
    }
}

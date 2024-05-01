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

        public void Execute(string sqlStr, SqlParameter[] parameters)
        {
            using (SqlCommand command = new SqlCommand(sqlStr, conn))
            {
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                try
                {
                    conn.Open();
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    // Handle exception as required
                    Console.WriteLine("Error executing query: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public void Execute(string sqlStr)
        {
            try
            {
                // Ket noi
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Successful");
                }
                else
                {
                    MessageBox.Show("Unsuccessful");

                }
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
        public object ExecuteScalar(string sqlStr)
        {
            object result = null;
            conn.Open();
            using (SqlCommand command = new SqlCommand(sqlStr, conn))
            {
                result = command.ExecuteScalar();
            }
            conn.Close();
            return result;
        }

        public SqlDataReader ExecuteReader(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                return cmd.ExecuteReader();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}

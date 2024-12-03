using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class DataProvider
    {
        private SqlConnection sqlConnection;

        private static DataProvider instance;

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return instance; }
            set => instance = value;
        }


        public DataProvider()
        {
            sqlConnection = new SqlConnection("Data Source=DESKTOP-HM13SQP\\SQLEXPRESS;Initial Catalog=QLNhaHang;Integrated Security=True;Encrypt=False");
        }

        public DataTable ExecuteQuery(string query, SqlParameter[] sqlParameters = null)
        {
            DataTable dt = new DataTable();
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                if (sqlParameters != null)
                {
                    sqlCommand.Parameters.AddRange(sqlParameters);
                }
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
            return dt;

        }

        public int ExecuteNonQuery(string query, SqlParameter[] sqlParameters = null)
        {
            int row = -1;
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                if (sqlParameters != null)
                {
                    sqlCommand.Parameters.AddRange(sqlParameters);
                }
                row = sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                sqlConnection.Close();
            }
            return row;

        }

        public object ExecuteScalar(string query, SqlParameter[] sqlParameters = null)
        {
            DataTable dt = new DataTable();
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                if (sqlParameters != null)
                {
                    sqlCommand.Parameters.AddRange(sqlParameters);
                }
                return sqlCommand.ExecuteScalar();

            }
            catch (Exception ex)
            {

            }
            finally
            {
                sqlConnection.Close();
            }
            return null;

        }

    }
}

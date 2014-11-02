using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Nucleo
{
    public class BaseDal : IDisposable
    {
        private SqlConnection connection;
        private SqlCommand sql;

        public SqlCommand Sql
        {
            get { return sql; }
            set { sql = value; }
        }

        public SqlConnection Connection
        {
            get { return connection; }
            set { connection = value; }
        }

        public BaseDal(ConexoesBanco banco)
        {
            Connection = new SqlConnection();
            if (banco == ConexoesBanco.PlusCondominios)
                Connection.ConnectionString = ConfigurationManager.AppSettings["PLUSCONDOMINIOS"].ToString();
        }

        public void openConnection()
        {
            try
            {
                if (this.Connection.State != ConnectionState.Open)
                    this.Connection.Open();
            }
            catch (Exception)
            {
                throw new Exception("Ocorreu um erro com o banco de dados, tente novamente em instantes.");
            }
        }

        public DataTable GetDataTable()
        {
            DataTable dt = new DataTable();

            try
            {
                openConnection();
                Sql.Connection = Connection;
                dt.Load(Sql.ExecuteReader());
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message, exc);
            }
            finally
            {
                Connection.Close();
            }

            return dt;
        }

        public SqlDataReader GetDataReader()
        {
            try
            {
                openConnection();
                Sql.Connection = Connection;
                return Sql.ExecuteReader();
            }
            catch (Exception exc)
            {
                Connection.Close();
                throw new Exception(exc.Message, exc);
            }
            finally
            {

            }
        }

        public int ExecuteScalar()
        {
            try
            {
                openConnection();
                Sql.Connection = Connection;
                return Convert.ToInt32(Sql.ExecuteScalar());
            }
            catch (Exception exc)
            {
                Connection.Close();
                throw new Exception(exc.Message, exc);
            }
        }

        public int ExecuteQuery()
        {
            int rowsaffected = 0;

            try
            {

                openConnection();
                Sql.Connection = Connection;
                rowsaffected = Sql.ExecuteNonQuery();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message, exc);
            }

            return rowsaffected;
        }

        public DataSet GetDataSet()
        {
            DataSet ds = new DataSet();

            try
            {
                openConnection();
                Sql.Connection = Connection;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = Sql;
                da.Fill(ds);
            }
            catch (Exception exc)
            {
                throw new Exception(exc.Message, exc);
            }
            finally
            {
                Connection.Close();
            }

            return ds;
        }

        public void Dispose()
        {
            if (Connection != null && Connection.State != ConnectionState.Closed)
                Connection.Close();
        }
    }
}

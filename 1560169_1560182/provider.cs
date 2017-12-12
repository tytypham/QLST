using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace _1560169_1560182
{
    class provider
    {
        string connectionString = @"Data Source=.;Initial Catalog=QuanLySieuThi;Integrated Security=True";
        SqlConnection connection = null;

        public void Connect()
        {
            try
            {
                if (connection == null)
                    connection = new SqlConnection(connectionString);
                if (connection.State != System.Data.ConnectionState.Closed)
                    connection.Close();
                connection.Open();
            }
            catch (SqlException e)
            {
                throw e;
            }
        }

        public void Disconnect()
        {
            try
            {
                if (connection != null && connection.State != System.Data.ConnectionState.Closed)
                    connection.Close();
            }
            catch (SqlException e)
            {
                throw e;
            }
        }

        public int ExcuteNonQuery(string sql, CommandType Type, params SqlParameter[] p)
        {
            try
            {
                this.Connect();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = sql;
                command.CommandType = Type;
                if (p != null && p.Length > 0)
                {
                    command.Parameters.AddRange(p);

                }
                int nRow = command.ExecuteNonQuery();
                return nRow;
                this.Disconnect();
            }
            catch (SqlException e)
            {
                throw e;

            }

        }
        public IDataReader ExcuteQuerry(string sql, params SqlParameter[] p)
        {
            try
            {
                this.Connect();
                SqlCommand cmd = new SqlCommand(sql, this.connection);
                cmd.CommandType = CommandType.Text;
                if (p != null && p.Length > 0)
                    cmd.Parameters.AddRange(p);
                SqlDataReader rd = cmd.ExecuteReader();
                return rd;
            }
            catch (SqlException e)
            {
                this.Disconnect();
                throw e;
            }
        }
    }
    
}

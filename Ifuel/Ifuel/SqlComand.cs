using System;
using System.Data;
using System.Data.SqlClient;

namespace Ifuel
{
    internal class SqlComand
    {
        public SqlComand(string sql, SqlConnection conect)
        {
        }

        public CommandType CommandType { get; internal set; }

        internal SqlDataReader ExecuteReader()
        {
            throw new NotImplementedException();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace crud
{
    class ConnectionDataBase
    {
        private string strConnetion = @"Data Source=PC-ARAUJO\SQLEXPRESS;Initial Catalog=crud;User ID=sa;Password=@1nt3r2013";

        private SqlConnection GetConexao(string stringBD)
        {
            SqlConnection con = new SqlConnection(stringBD);
            return con;
        }

        public SqlConnection _GetConexao()
        {
            return GetConexao(strConnetion);
        }
    }
}

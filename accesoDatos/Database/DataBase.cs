using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace accesoDatos.Database
{
    public class DataBase
    {
        private SqlConnection c = new SqlConnection("Data Source=DESKTOP-4Q0A0TB\\SQLEXPRESS;Initial Catalog=BDSISTR;Integrated Security=True");

        public SqlConnection OpenConnection()
        {
            if (c.State == ConnectionState.Closed) c.Open();
            return c;
        }

        public SqlConnection CloseConnection()
        {
            if (c.State == ConnectionState.Open) c.Close();
            return c;
        }
    }
}

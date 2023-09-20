using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using accesoDatos.Database;

namespace accesoDatos.entidades
{
    public class estudiante
    {
        //variables
        DataBase c = new DataBase();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        DataTable td = new DataTable();
    }
}

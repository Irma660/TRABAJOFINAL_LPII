using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using accesoDatos.entidades;

namespace logicaNegocio.CRUD
{
    public class Cestudiante
    {
        estudiante persona = new estudiante();
        public DataTable Mostrar()
        {
            DataTable td = new DataTable();
            td = persona.Mostrar();
            return td;

        }
    }
}

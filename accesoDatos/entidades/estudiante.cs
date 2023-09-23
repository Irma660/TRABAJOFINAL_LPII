using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using atributos.atributos;
using accesoDatos.Database;
using static System.Collections.Specialized.BitVector32;
using System.Net;

namespace accesoDatos.entidades
{
    public class estudiante
    {
        //variables
        DataBase c = new DataBase();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        DataTable td = new DataTable();

        public DataTable Mostrar()
        {
            try {
                cmd.Connection = c.OpenConnection();
                cmd.CommandText = "MOSTRAR";
                cmd.CommandType = CommandType.StoredProcedure;
                dr = cmd.ExecuteReader();
                td.Load(dr);
            }
           catch(Exception ex){
                String msj = ex.ToString();
            }
            finally
            {
                cmd.Connection = c.CloseConnection();
            }
            return td;
        }
        public void INSERTAR(atributosEstudiantes obj)
        {
           

            try
            {
                cmd.Connection = c.OpenConnection();
                cmd.CommandText = "INSERTAR";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID", obj.Id);
                cmd.Parameters.AddWithValue("@PRIMER_NOMBRE", obj.Primer_nombre);
                cmd.Parameters.AddWithValue("@SEGUNDO_NOMBRE", obj.Segundo_nombre);
                cmd.Parameters.AddWithValue("@PRIMER_APELLIDO", obj.Primer_apellido);
                cmd.Parameters.AddWithValue("@SEGUNDO_APELLIDO", obj.Segundo_apellido);
                cmd.Parameters.AddWithValue("@NIVEL", obj.Nivel);
                cmd.Parameters.AddWithValue("@GRADO", obj.Grado);
                cmd.Parameters.AddWithValue("@SECCIÓN", obj.Seccion);
                cmd.Parameters.AddWithValue("@SEXO", obj.Sexo);
                cmd.Parameters.AddWithValue("@DNI", obj.Dni);
                cmd.Parameters.AddWithValue("@TELÉFONO", obj.Telefono);
                cmd.Parameters.AddWithValue("@DIRECCIÓN", obj.Direccion);
                cmd.Parameters.AddWithValue("@NACIMIENTO", obj.Fecha_nac);
                cmd.Parameters.AddWithValue("@OBSERVACIONES", obj.Observaciones);
                cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();

          
            }
            catch (Exception ex)
            {
                string msj = ex.ToString();
            }
            finally
            {
                cmd.Connection = c.CloseConnection();
            }
        }
    }
}

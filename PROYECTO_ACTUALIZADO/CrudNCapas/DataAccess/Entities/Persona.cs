using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccess.Connection;
using Common.Attributes;

namespace DataAccess.Entities
{
    public class Persona
    {
        //Variables
        Connection_Database c = new Connection_Database();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        DataTable td = new DataTable();

        public DataTable Mostrar()
        {
            try
            {
                cmd.Connection = c.OpenConnection();
                cmd.CommandText = "MOSTRAR";
                cmd.CommandType = CommandType.StoredProcedure;
                dr = cmd.ExecuteReader();
                td.Load(dr);
            }
            catch(Exception ex)
            {
                string msj = ex.ToString();
            }
            finally
            {
                cmd.Connection = c.CloseConnection();
            }
            return td;
        }

        public DataTable Buscar(string Palabras)
        {
            try
            {
                cmd.Connection = c.OpenConnection();
                cmd.CommandText = "SP_Buscar";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Palabras", Palabras);
                dr = cmd.ExecuteReader();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                td.Load(dr);
            }
            catch (Exception ex)
            {
                string msj = ex.ToString();
            }
            finally
            {
                cmd.Connection = c.CloseConnection();
            }
            return td;
        }

        public void Insertar(AttributesPeople obj)
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
            catch(Exception ex)
            {
                string msj = ex.ToString();
            }
            finally
            {
                cmd.Connection = c.CloseConnection();
            }
        }

        public void Modificar(AttributesPeople obj)
        {
            try
            {
                cmd.Connection = c.OpenConnection();
                cmd.CommandText = "SP_Modificar";
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

        public void Eliminar(AttributesPeople obj)
        {
            try
            {
                cmd.Connection = c.OpenConnection();
                cmd.CommandText = "SP_Eliminar";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", obj.Id);
                cmd.ExecuteReader();
                cmd.Parameters.Clear();
            }
            catch(Exception ex)
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

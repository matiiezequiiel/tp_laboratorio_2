using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Clases_Abstractas;
using Clases_Instanciables;

namespace SQL
{
    public static class EmpleadoDB
    {
        const string STRINGCONNEC = @"Server=agasoluciones.dynamic-dns.net\mssqlserver2;Database=Mensajes;User Id=Alumno;Password=FraUtn;"; //cambiar

        static SqlConnection sqlConn;
        static SqlCommand command;

        /// <summary>
        /// Contructor estatico, abre la conexion.
        /// </summary>
        static EmpleadoDB()
        {
            sqlConn = new SqlConnection();
            sqlConn.ConnectionString = STRINGCONNEC;
            command = new SqlCommand();
            command.Connection = sqlConn;
        }


        /// <summary>
        /// Trae todos los empleados de la base de datos.
        /// </summary>
        /// <returns>Lista de clientes.</returns>
        public static List<Empleado> TraerPersonas()
        {
            List<Empleado> empleados = new List<Empleado>();
            string consulta = " Select * from empleados ";

            try
            {
                command.CommandText = consulta;
                sqlConn.Open();
                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    empleados.Add(new Empleado(dr["Nombre"].ToString(), dr["Apellido"].ToString(), dr["DNI"].ToString(),Persona.StringTOSexo(dr["Sexo"].ToString()),Persona.StringTONac(dr["Nacionalidad"].ToString()), int.Parse(dr["Legajo"].ToString()), double.Parse(dr["Sueldo"].ToString()), Empleado.StringTODate(dr["Fecha Ingreso"].ToString())));
                   
                }

                return empleados;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                sqlConn.Close();
            }


        }


        /// <summary>
        /// Inserta un empleado en la base de datos.
        /// </summary>
        /// <returns>Lista de clientes.</returns>
        public static bool InstertarEmpleado(Empleado empleado)
        {
            string consulta = " INSERT INTO empleados ([Nombre],[Apellido],[DNI],[Sexo],[Nacionalidad],[Legajo],[Sueldo],[Fecha Ingreso]) VALUES (@nombre ,@apellido,@dni,@sexo,@nacionalidad,@legajo,@sueldo,@fecha)";

            try
            {
                command.CommandText = consulta;
                command.Parameters.Clear();
                command.Parameters.Add(new SqlParameter("@nombre", empleado.Nombre));
                command.Parameters.Add(new SqlParameter("@apellido", empleado.Apellido));
                command.Parameters.Add(new SqlParameter("@dni", empleado.DNI));
                command.Parameters.Add(new SqlParameter("@sexo", empleado.Sexo));
                command.Parameters.Add(new SqlParameter("@nacionalidad", empleado.Nacionalidad));
                command.Parameters.Add(new SqlParameter("@legajo", empleado.Legajo));
                command.Parameters.Add(new SqlParameter("@sueldo", empleado.Sueldo));
                command.Parameters.Add(new SqlParameter("@fecha", empleado.FechaIngreso.ToString("yy:MM:dd")));
               

                sqlConn.Open();
                int retorno = command.ExecuteNonQuery();

                return retorno != -1;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sqlConn.Close();
            }
        }

    }
}

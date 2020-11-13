using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Clases_Abstractas;
using Clases_Instanciables;
using System.Security.Cryptography;


namespace SQL
{
    public static class EmpleadoDB
    {
       


       // const string STRINGCONNEC = @"Server=DESKTOP-9CR275H\SQLEXPRESS;Database=TP4;"; //cambiar
        const string STRINGCONNEC = @"Data Source=DESKTOP-9CR275H\SQLEXPRESS;Initial Catalog =TP4;Integrated Security = True"; //cambiar

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
            string consulta = " Select * from dbo.empleados ";

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
        /// Consulta y valida contraseña del empleado.
        /// </summary>
        /// <returns>Lista de clientes.</returns>
        public static bool ValidarContraseña(string pass,string legajo)
        {
            bool retorno = false;
            string consulta = " Select pass from dbo.empleados where legajo = @legajo ";
            command.Parameters.Clear();
            command.Parameters.Add(new SqlParameter("@legajo", legajo));

            try
            {
                command.CommandText = consulta;
                sqlConn.Open();
                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                   if(dr["Pass"].ToString() == Encriptar(pass))
                    {
                        retorno = true;
                    }
                   
                }

                return retorno;

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

        static string Encriptar(string pass)
        {
            MD5 md5 = MD5CryptoServiceProvider.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = md5.ComputeHash(encoding.GetBytes(pass));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();

        }

    }
}

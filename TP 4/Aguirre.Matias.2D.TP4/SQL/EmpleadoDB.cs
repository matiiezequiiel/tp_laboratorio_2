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
    public class EmpleadoDB
    {
        const string STRINGCONNEC = @"Data Source=DESKTOP-9CR275H\SQLEXPRESS;Initial Catalog =TP4;Integrated Security = True"; 

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
        public static List<Empleado> TraerEmpleados()
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
                    empleados.Add(new Empleado(dr["Nombre"].ToString(), dr["Apellido"].ToString(), dr["DNI"].ToString(), Persona.StringTOSexo(dr["Sexo"].ToString()), Persona.StringTONac(dr["Nacionalidad"].ToString()), int.Parse(dr["Legajo"].ToString()), double.Parse(dr["Sueldo"].ToString()), Empleado.StringTODate(dr["Fecha Ingreso"].ToString())));

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
        public static bool ValidarContraseña(string pass, string legajo)
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
                    if (dr["Pass"].ToString() == Encriptar(pass))
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

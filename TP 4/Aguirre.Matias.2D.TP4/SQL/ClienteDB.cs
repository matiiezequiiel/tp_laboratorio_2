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
    public static class ClienteDB
    {
        const string STRINGCONNEC = @"Data Source=DESKTOP-9CR275H\SQLEXPRESS;Initial Catalog =TP4;Integrated Security = True"; 
        static SqlConnection sqlConn;
        static SqlCommand command;

        /// <summary>
        /// Contructor estatico, abre la conexion.
        /// </summary>
        static ClienteDB()
        {
            sqlConn = new SqlConnection();
            sqlConn.ConnectionString = STRINGCONNEC;
            command = new SqlCommand();
            command.Connection = sqlConn;
        }


        /// <summary>
        /// Trae todos los clientes de la base de datos.
        /// </summary>
        /// <returns>Lista de clientes.</returns>
        public static List<Cliente> TraerClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            string consulta = " Select * from dbo.clientes ";

            try
            {
                command.CommandText = consulta;
                sqlConn.Open();
                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {

                    clientes.Add(new Cliente(dr["Nombre"].ToString(), dr["Apellido"].ToString(), dr["DNI"].ToString(), Persona.StringTOSexo(dr["Sexo"].ToString()), Persona.StringTONac(dr["Nacionalidad"].ToString()), int.Parse(dr["Numero cliente"].ToString())));


                }

                return clientes;

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
        /// Inserta un cliente en la base de datos.
        /// </summary>
        /// <returns>Lista de clientes.</returns>
        public static bool InstertarEmpleado(Cliente cliente)
        {
            string consulta = " INSERT INTO empleados ([Nombre],[Apellido],[DNI],[Sexo],[Nacionalidad],[Numero cliente) VALUES (@nombre ,@apellido,@dni,@sexo,@nacionalidad,@nrocliente)";

            try
            {
                command.CommandText = consulta;
                command.Parameters.Clear();
                command.Parameters.Add(new SqlParameter("@nombre", cliente.Nombre));
                command.Parameters.Add(new SqlParameter("@apellido", cliente.Apellido));
                command.Parameters.Add(new SqlParameter("@dni", cliente.DNI));
                command.Parameters.Add(new SqlParameter("@sexo", cliente.Sexo));
                command.Parameters.Add(new SqlParameter("@nacionalidad", cliente.Nacionalidad));
                command.Parameters.Add(new SqlParameter("@nrocliente", cliente.NroCliente));


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


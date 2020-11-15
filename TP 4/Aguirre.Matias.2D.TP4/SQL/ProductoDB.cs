﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Clases_Abstractas;
using Clases_Instanciables;

namespace SQL
{
    public class ProductoDB
    {
        const string STRINGCONNEC = @"Data Source=DESKTOP-9CR275H\SQLEXPRESS;Initial Catalog =TP4;Integrated Security = True";
        static SqlConnection sqlConn;
        static SqlCommand command;

        /// <summary>
        /// Contructor estatico, abre la conexion.
        /// </summary>
        static ProductoDB()
        {
            sqlConn = new SqlConnection();
            sqlConn.ConnectionString = STRINGCONNEC;
            command = new SqlCommand();
            command.Connection = sqlConn;
        }


 
        /// <summary>
        /// Trae todos los productos de infomatica de la base de datos.
        /// </summary>
        /// <returns>Lista de clientes.</returns>
        public static List<Informatica> TraerProductosInformatica()
        {
            List<Informatica> productos = new List<Informatica>();
            string consulta = " Select * from dbo.productos_informatica ";

            try
            {
                command.CommandText = consulta;
                sqlConn.Open();
                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    string prueba = dr["Conexion 5G"].ToString();
                    if (string.IsNullOrEmpty(dr["Conexion 5G"].ToString()))
                    {
                        productos.Add(new Computadora(dr["Modelo"].ToString(), dr["Codigo Producto"].ToString(), double.Parse(dr["Precio"].ToString()), int.Parse(dr["Stock"].ToString()), int.Parse(dr["Memoria RAM"].ToString()), int.Parse(dr["Almacenamiento"].ToString()), Convert.ToBoolean(int.Parse(dr["Perifericos"].ToString())), Convert.ToBoolean(int.Parse(dr["Gamer"].ToString()))));
                    } 
                    else
                    {
                        productos.Add(new Celular(dr["Modelo"].ToString(), dr["Codigo Producto"].ToString(), double.Parse(dr["Precio"].ToString()), int.Parse(dr["Stock"].ToString()), int.Parse(dr["Memoria RAM"].ToString()), int.Parse(dr["Almacenamiento"].ToString()), Convert.ToBoolean(int.Parse(dr["Conexion 5G"].ToString())), float.Parse(dr["Tamaño Pantalla"].ToString())));

                    }

                   


                }

                return productos;

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
        /// Trae todos los electrodomesticos de la base de datos.
        /// </summary>
        /// <returns>Lista de clientes.</returns>
        public static List<Electrodomesticos> TraerProductosElectrodomesticos()
        {
            List<Electrodomesticos> productos = new List<Electrodomesticos>();
            string consulta = " Select * from dbo.productos_electrodomesticos ";

            try
            {
                command.CommandText = consulta;
                sqlConn.Open();
                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    productos.Add(new Electrodomesticos(dr["Nombre"].ToString(), dr["Codigo"].ToString(), double.Parse(dr["Precio"].ToString()), int.Parse(dr["Stock"].ToString()), int.Parse(dr["Potencia"].ToString()), Convert.ToBoolean(int.Parse(dr["Control"].ToString())), Electrodomesticos.StringTOCategoria(dr["Categoria"].ToString()) ));
                   
                }

                return productos;

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
        public static bool InstertarProducto(Informatica producto)
        {
            string consulta = " INSERT INTO dbo.productos_informatica ([Modelo],[Precio],[Stock],[Memoria RAM],[Almacenamiento],[Perifericos],[Gamer],[Conexion 5G],[Tamaño Pantalla]) VALUES (@modelo ,@precio,@stock,@memoria,@almacenamiento,@perifericos,@gamer,@conexion,@pantalla)";

            
            try      
            {
                command.CommandText = consulta; 
                command.Parameters.Clear();
                command.Parameters.Add(new SqlParameter("@modelo", producto.Nombre));
                command.Parameters.Add(new SqlParameter("@precio", producto.Precio.ToString()));
                command.Parameters.Add(new SqlParameter("@stock", producto.Stock.ToString()));
                command.Parameters.Add(new SqlParameter("@memoria", producto.MemoriaRam.ToString()));
                command.Parameters.Add(new SqlParameter("@almacenamiento", producto.Almacenamiento.ToString()));

                if(producto.GetType() == typeof(Celular))
                {
                    Celular aux = (Celular)producto;
                    command.Parameters.Add(new SqlParameter("@perifericos", null));
                    command.Parameters.Add(new SqlParameter("@gamer", null));
                    command.Parameters.Add(new SqlParameter("@conexion",  (Convert.ToInt32(aux.Conexion)).ToString() ));
                    command.Parameters.Add(new SqlParameter("@pantalla", aux.TamañoPantalla.ToString()));

                }
                else
                {
                    Computadora aux = (Computadora)producto;

                    command.Parameters.Add(new SqlParameter("@perifericos", (Convert.ToInt32(aux.PerifericosBool)).ToString() ));
                    command.Parameters.Add(new SqlParameter("@gamer", (Convert.ToInt32(aux.GamerBool)).ToString()));
                    command.Parameters.Add(new SqlParameter("@conexion", null));
                    command.Parameters.Add(new SqlParameter("@pantalla", null));
                }
              


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
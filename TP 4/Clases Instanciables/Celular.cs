﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases_Abstractas;

namespace Clases_Instanciables
{
    public sealed class Celular : Informatica
    {
        #region Atributos
        bool conexion5G;
        float tamanioPantalla;
        #endregion

        #region Propiedades

        /// <summary>
        /// True si tiene conexion 5G incluida, False si no.
        /// </summary>
        public bool Conexion5G
        {
            get { return this.conexion5G; }
            //set { myVar = value; }
        }

        /// <summary>
        /// Tamaño de la pantalla del celular. 
        /// </summary>
        public float TamañoPantalla
        {
            get { return this.tamanioPantalla; }
            //set { myVar = value; }
        }


        #endregion

        #region Constructores


        /// <summary>
        /// Constructor de instancia.
        /// </summary>
        /// <param name="nombre">Nombre de el celular.</param>
        /// <param name="codigo">Codigo de el celular.</param>
        /// <param name="precio">Precio de el celular.</param>
        /// <param name="stock">Stock de el celular.</param>
        /// <param name="memoriaRam">Memoria Ram de el celular.</param>
        /// <param name="almacenamiento">Almacenamiento de el celular.</param>
        /// <param name="conexion5G">True si incluye conexion 5G, false si no.</param>
        /// <param name="tamanioPantalla">Tamaño de pantalla de el celular.</param>
        public Celular(string nombre, string codigo, double precio, int stock, int memoriaRam, int almacenamiento, bool conexion5G, float tamanioPantalla) : base(nombre, codigo, precio, stock, memoriaRam, almacenamiento)
        {
            this.conexion5G = conexion5G;
            this.tamanioPantalla = tamanioPantalla;
        }

        /// <summary>
        /// Constructor de instancia.
        /// </summary>
        /// <param name="nombre">Nombre de el celular.</param>
        /// <param name="precio">Precio de el celular.</param>
        /// <param name="stock">Stock de el celular.</param>
        /// <param name="memoriaRam">Memoria Ram de el celular.</param>
        /// <param name="almacenamiento">Almacenamiento de el celular.</param>
        /// <param name="conexion5G">True si incluye conexion 5G, false si no.</param>
        /// <param name="tamanioPantalla">Tamaño de pantalla de el celular.</param>
        public Celular(string nombre, double precio, int stock, int memoriaRam, int almacenamiento, bool conexion5G, float tamanioPantalla) : base(nombre, precio, stock, memoriaRam, almacenamiento)
        {          
            this.conexion5G = conexion5G;
            this.tamanioPantalla = tamanioPantalla;
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Muestra los atributos de el celular.
        /// </summary>
        /// <returns>Atributos del celular.</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat(base.ToString());
            sb.AppendLine(this.conexion5G.ToString());
            sb.AppendLine(this.tamanioPantalla.ToString());


            return sb.ToString();
        }

        #endregion

    }
}

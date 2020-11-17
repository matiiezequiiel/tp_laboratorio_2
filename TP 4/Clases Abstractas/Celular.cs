using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases_Abstractas;

namespace Clases_Instanciables
{
    [Serializable]
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
        public string Conexion5G
        {
            get {if (this.conexion5G)
                    return "SI";
                else
                    return "NO";
                }
            //set { myVar = value; }
        } 
        public bool Conexion
        {
            get {return this.conexion5G;}
            set { this.conexion5G = value; }
        }

        /// <summary>
        /// Tamaño de la pantalla del celular. 
        /// </summary>
        public float TamañoPantalla
        {
            get { return this.tamanioPantalla; }
            set { this.tamanioPantalla = value; }
        }


        #endregion

        #region Constructores

        public Celular()
        {

        }
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

            sb.AppendLine(base.ToString());
            sb.AppendFormat("Conexion 5G: {0} ",this.Conexion5G.ToString());
            sb.AppendFormat("Pantalla: {0} pulgadas. ",this.tamanioPantalla.ToString());



            return sb.ToString();
        }

        #endregion

    }
}

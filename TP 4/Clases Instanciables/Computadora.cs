using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases_Abstractas;

namespace Clases_Instanciables
{
    public sealed class Computadora : Informatica
    {

        #region Atributos
        string procesador;
        bool perifericos;
        bool gamer;
        #endregion

        #region Propiedades

        /// <summary>
        /// Propiedad procesador computadora.
        /// </summary>
        public string Procesador
        {
            get { return this.procesador; }
            //set { myVar = value; }
        }
        
        /// <summary>
        /// True si tiene perifericos incluidos, False si no.
        /// </summary>
        public bool Perifericos
        {
            get { return this.perifericos; }
            //set { myVar = value; }
        }

        /// <summary>
        /// True si la pc es apta para gaming, False si no.
        /// </summary>
        public bool Gamer
        {
            get { return this.gamer; }
            //set { myVar = value; }
        }


        #endregion

        #region Constructores


        /// <summary>
        /// Constructor de instancia.
        /// </summary>
        /// <param name="nombre">Nombre de la computadora.</param>
        /// <param name="codigo">Codigo de la computadora.</param>
        /// <param name="precio">Precio de la computadora.</param>
        /// <param name="stock">Stock de la computadora.</param>
        /// <param name="memoriaRam">Memoria Ram de la computadora.</param>
        /// <param name="almacenamiento">Almacenamiento de la computadora.</param>
        /// <param name="perifericos">True si incluye perifericos, false si no.</param>
        /// <param name="gamer">True si es apta para gaming, false si no.</param>
        public Computadora(string nombre, string codigo, double precio, int stock, int memoriaRam, int almacenamiento,bool perifericos,bool gamer) : base (nombre,codigo,precio,stock,memoriaRam,almacenamiento)
        {
            this.perifericos = perifericos;
            this.gamer = gamer;
        }

        /// <summary>
        /// Constructor de instancia sin codigo de producto para ser generado automaticamente.
        /// </summary>
        /// <param name="nombre">Nombre de la computadora.</param>
        /// <param name="precio">Precio de la computadora.</param>
        /// <param name="stock">Stock de la computadora.</param>
        /// <param name="memoriaRam">Memoria Ram de la computadora.</param>
        /// <param name="almacenamiento">Almacenamiento de la computadora.</param>
        /// <param name="perifericos">True si incluye perifericos, false si no.</param>
        /// <param name="gamer">True si es apta para gaming, false si no.</param>
        public Computadora(string nombre, double precio, int stock, int memoriaRam, int almacenamiento,bool perifericos,bool gamer) : base (nombre,precio,stock,memoriaRam,almacenamiento)
        {
            this.perifericos = perifericos;
            this.gamer = gamer;
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Muestra los atributos de la computadora.
        /// </summary>
        /// <returns>Atributos de la computadora.</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat(base.ToString());
            sb.AppendLine(this.perifericos.ToString());
            sb.AppendLine(this.gamer.ToString());

            return sb.ToString();
        }

        #endregion
    }
}

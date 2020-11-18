using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases_Abstractas;

namespace Clases_Instanciables
{
    [Serializable]
    public sealed class Computadora : Informatica
    {

        #region Atributos
        bool perifericos;
        bool gamer;
        #endregion

        #region Propiedades

          
        /// <summary>
        /// True si tiene perifericos incluidos, False si no.
        /// </summary>
        public string Perifericos
        {
            get
            {
                if (this.perifericos)
                    return "SI";
                else
                    return "NO";
            }
          
        }

         /// <summary>
        /// True si tiene perifericos incluidos, False si no.
        /// </summary>
        public bool PerifericosBool
        {
            get
            {
                return this.perifericos;
            }
            set { this.perifericos = value; }
        }

        /// <summary>
        /// True si la pc es apta para gaming, False si no.
        /// </summary>
        public string Gamer
        {
            get
            {
                if (this.gamer)
                    return "SI";
                else
                    return "NO";
            }
        } 
        /// <summary>
        /// True si la pc es apta para gaming, False si no.
        /// </summary>
        public bool GamerBool
        {
            get { return this.gamer; }
            set { this.gamer = value; }
        }


        #endregion

        #region Constructores

        /// <summary>
        /// Constructor sin parametros para la serializacion.
        /// </summary>
        public Computadora()
        {
               
        }

        /// <summary>
        ///  Constructor de instancia para producto desde BD con el codigo de producto.
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
        ///  Constructor de instancia para subida producto a BD sin el codigo de producto.
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

            sb.AppendLine(base.ToString());
            sb.AppendFormat("Perifericos incluidos: {0}\n",this.Perifericos.ToString());
            sb.AppendFormat("Perifericos incluidos: {0}\n",this.Gamer.ToString());

            return sb.ToString();
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Clases_Abstractas
{
    [Serializable]
    [XmlInclude(typeof(Clases_Instanciables.Celular))]
    [XmlInclude(typeof(Clases_Instanciables.Computadora))]
    public abstract class Informatica : Producto
    {

        #region Atributos
        protected int memoriaRam;
        protected int almacenamiento;
        #endregion

        #region Propiedades
        /// <summary>
        /// Atributo memoria ram publico para la serializacion.
        /// </summary>
        public int MemoriaRam
        {
            get { return this.memoriaRam; }
            set { this.memoriaRam = value; }
        }
        /// <summary>
        /// Atributo memoria  publico para la serializacion.
        /// </summary>
        public int Almacenamiento
        {
            get { return this.almacenamiento; }
            set { this.almacenamiento = value; }
        }

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor sin parametro para serializacion.
        /// </summary>
        public Informatica()
        {

        }

        /// <summary>
        ///  Constructor de instancia para producto desde BD con el codigo de producto.
        /// </summary>
        /// <param name="nombre">Nombre del producto.</param>
        /// <param name="codigo">Codigo del producto.</param>
        /// <param name="precio">Precio del producto.</param>
        /// <param name="stock">Stock del producto.</param>
        /// <param name="memoriaRam">RAM del producto.</param>
        /// <param name="almacenamiento">Almacenamiento del producto.</param>
        public Informatica(string nombre, string codigo, double precio, int stock, int memoriaRam, int almacenamiento) : base(nombre,codigo,precio,stock)
        {
            this.memoriaRam = memoriaRam;
            this.almacenamiento = almacenamiento;
        }

        /// <summary>
        /// Constructor de instancia para subida producto a BD sin el codigo de producto.
        /// </summary>
        /// <param name="nombre">Nombre del producto.</param>
        /// <param name="codigo">Codigo del producto.</param>
        /// <param name="precio">Precio del producto.</param>
        /// <param name="stock">Stock del producto.</param>
        /// <param name="memoriaRam">RAM del producto.</param>
        /// <param name="almacenamiento">Almacenamiento del producto.</param>
        public Informatica(string nombre,double precio, int stock, int memoriaRam, int almacenamiento) : base(nombre,precio,stock)
        {
            this.memoriaRam = memoriaRam;
            this.almacenamiento = almacenamiento;
        } 
        
        #endregion

        #region Metodos
        /// <summary>
        /// Muestra los atributos del producto.
        /// </summary>
        /// <returns>Cadena con los atributos.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendFormat("Memoria RAM: {0} GB\n",this.memoriaRam.ToString());
            sb.AppendFormat("Almacenamiento: {0} GB\n", this.almacenamiento.ToString());

            return sb.ToString();
        }
        #endregion
    }
}

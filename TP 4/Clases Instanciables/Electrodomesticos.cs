using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases_Abstractas;

namespace Clases_Instanciables
{
    public sealed class Electrodomesticos : Producto
    {
        #region Atributos
        public enum ECategoria { Cocina, Ventilacion, Refrigeracion}
        int potencia;
        bool tieneControlRemoto;
        ECategoria categoria;
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad potencia del electrodomestico.
        /// </summary>
        public int Potencia
        {
            get { return this.potencia; }
          //  set { myVar = value; }
        }

        /// <summary>
        /// Propiedad control remoto incluido del electrodomestico.
        /// </summary>
        public bool ControlRemotoIncluido
        {
            get { return this.tieneControlRemoto; }
            //set { myVar = value; }
        }

        /// <summary>
        /// Propiedad categoria del electrodomestico.
        /// </summary>
        public ECategoria Categoria
        {
            get { return this.categoria; }
         //   set { myVar = value; }
        }

        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        private Electrodomesticos()
        {
          
        }
        /// <summary>
        /// Constructor de instancia sin codigo de producto para que se genere automaticamente.
        /// </summary>
        /// <param name="nombre">Nombre del electrodomestico.</param>
        /// <param name="precio">Precio del electrodomestico.</param>
        /// <param name="stock">Stock del electrodomestico.</param>
        /// <param name="potencia">Potencia del electrodomestico.</param>
        /// <param name="control">True si incluye control remoto,False si no.</param>
        /// <param name="categoria">Categoria del electrodomestico.</param>
        public Electrodomesticos(string nombre,double precio,int stock,int potencia,bool control,ECategoria categoria)
            : base (nombre,precio,stock)
        {
            this.potencia = potencia;
            this.tieneControlRemoto = control;
            this.categoria = categoria;
        }

        /// <summary>
        /// Constructor de instancia sin codigo de producto para que se genere automaticamente.
        /// </summary>
        /// <param name="nombre">Nombre del electrodomestico.</param>
        /// <param name="codigo">Codigo del electrodomestico.</param>
        /// <param name="precio">Precio del electrodomestico.</param>
        /// <param name="stock">Stock del electrodomestico.</param>
        /// <param name="potencia">Potencia del electrodomestico.</param>
        /// <param name="control">True si incluye control remoto,False si no.</param>
        /// <param name="categoria">Categoria del electrodomestico.</param>
        public Electrodomesticos(string nombre,string codigo,double precio,int stock,int potencia,bool control,ECategoria categoria) : base (nombre,codigo,precio,stock)
        {
            this.potencia = potencia;
            this.tieneControlRemoto = control;
            this.categoria = categoria;
        }


        #endregion

        #region Metodos

        /// <summary>
        /// Muestra los atributos de el electrodomestico.
        /// </summary>
        /// <returns>Atributos del electrodomestico.</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(base.ToString());
            sb.AppendLine(this.potencia.ToString());
            sb.AppendLine(this.tieneControlRemoto.ToString());
            sb.AppendLine(this.categoria.ToString());

            return sb.ToString();
        }

        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases_Abstractas;

namespace Clases_Instanciables
{
    [Serializable]
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
            set {  this.potencia = value; }
        }

        /// <summary>
        /// Propiedad control remoto incluido del electrodomestico.
        /// </summary>
        public string ControlRemotoIncluido
        {
            get
            {
                if (this.tieneControlRemoto)
                    return "SI";
                else
                    return "NO";
            }
        } 
        
        /// <summary>
        /// Propiedad control remoto incluido del electrodomestico.
        /// </summary>
        public bool ControlRemoto
        {
            get {return this.tieneControlRemoto; }
            set { this.tieneControlRemoto = value; }
        }

        /// <summary>
        /// Propiedad categoria del electrodomestico.
        /// </summary>
        public ECategoria Categoria
        {
            get { return this.categoria; }
            set { this.categoria = value; }
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

        public override string ToString()
        {
            return Mostrar();
        }

        /// <summary>
        /// Muestra los atributos de el electrodomestico.
        /// </summary>
        /// <returns>Atributos del electrodomestico.</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendFormat("Potencia: {0} W\n" ,this.potencia.ToString());
            sb.AppendFormat("Control remoto: {0} \n", this.ControlRemotoIncluido);
            sb.AppendFormat("Categoria: {0} \n", this.categoria.ToString());

            return sb.ToString();
        }

        public static ECategoria StringTOCategoria(string cadena)
        {
            ECategoria categoria = ECategoria.Cocina;

            switch (cadena)
            {
                case "Cocina":
                    categoria = ECategoria.Cocina;
                    break;
                case "Ventilacion":
                    categoria = ECategoria.Ventilacion;
                    break;
                case "Refrigeracion":
                    categoria = ECategoria.Refrigeracion;
                    break;

            }

            return categoria;
        }
        #endregion

    }
}

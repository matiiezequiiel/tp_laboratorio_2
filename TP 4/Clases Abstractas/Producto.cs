using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Clases_Abstractas
{
    public abstract class Producto
    {
        #region Atributos
        protected string nombre;
        protected string codigo;
        protected double precio;
        protected int stock;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public Producto()
        {
          //  this.codigo = GenerarCodigo();
        }

        
        /// <summary>
        /// Constructor de instancia.
        /// </summary>
        /// <param name="nombre">Nombre del producto.</param>
        /// <param name="precio">Precio del producto.</param>
        /// <param name="stock">Stock del producto.</param>
        public Producto(string nombre, double precio,int stock) :this()
        {
            this.Nombre = nombre;
            this.Precio = precio;
            this.Stock = stock;
        }
        
        /// <summary>
        /// Constructor de instancia.
        /// </summary>
        /// <param name="nombre">Nombre del producto.</param>
        /// <param name="codigo">Codigo del producto.</param>
        /// <param name="precio">Precio del producto.</param>
        /// <param name="stock">Stock del producto.</param>
        public Producto(string nombre,string codigo, double precio,int stock) :this(nombre,precio,stock)
        {
            this.codigo = codigo;
        }

        #endregion

        #region Propiedades

        /// <summary>
        /// Propiedad valida nombre de el producto.
        /// </summary>
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = ValidarNombreProducto(value); }
        }

        /// <summary>
        /// Propiedad codigo de el producto.
        /// </summary>
        public string Codigo
        {
            get { return this.codigo; }
        }

        /// <summary>
        /// Propiedad precio de el producto.
        /// </summary>
        public double Precio
        {
            get { return this.precio; }
            set { this.precio = ValidarNumeroPrecio(value); }
        }

        /// <summary>
        /// Propiedad stock de el producto.
        /// </summary>
        public int Stock
        {
            get { return this.stock; }
            set { this.stock = ValidarNumeroStock(value); }
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Valida que el nombre no tenga espacios, numeros o simbolos.
        /// </summary>
        /// <param name="dato"></param>
        /// <returns>Nombre, NULL si es invalido.</returns>
        private string ValidarNombreProducto(string dato)
        {
            string retorno = null;

            for (int i = 0; i < dato.Length; i++)
            {
                if (char.IsWhiteSpace(dato[i]) || char.IsNumber(dato[i]) || char.IsSymbol(dato[i]))
                {
                    break;
                }
                else
                {
                    retorno = dato;
                }
            }

            return retorno;
        }


        /// <summary>
        /// Valida que el numero de el precio sea mayor a 0.
        /// </summary>
        /// <param name="dato">Precio</param>
        /// <returns>Numero de precio si esta ok sino 0</returns>
        private double ValidarNumeroPrecio(double dato)
        {
            double numero = 0;

            if (dato > 0)
                numero=dato;

            return numero;

        }
        
        /// <summary>
        /// Valida que el numero de el stock sea mayor a 0.
        /// </summary>
        /// <param name="dato">Precio</param>
        /// <returns>Numero de precio si esta ok sino 0</returns>
        private int ValidarNumeroStock(int dato)
        {
            double numero = dato;
            return (int)ValidarNumeroPrecio(numero);      
        }

        /// <summary>
        /// Genera un codigo aleatorio de 8 caracteres.
        /// </summary>
        /// <returns>Codigo aleatorio generado.</returns>
        private string GenerarCodigo()
        {
          
            string codigoGenerado = string.Empty;
            Random random=new Random();
            

            while(codigoGenerado.Length<=8)
            {
                codigoGenerado += (char)random.Next(65, 90);
                Thread.Sleep(1);                
            }

            return codigoGenerado;

        }


        public abstract string Mostrar();

        /// <summary>
        /// Muestra atributos de el producto.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Producto: {0} \n",this.Nombre);
            sb.AppendFormat("Codigo: {0} \n",this.Codigo);
            sb.AppendFormat("Precio: ${0} \n",this.Precio.ToString());
            sb.AppendFormat("Stock: {0} un.",this.Stock.ToString());
           
            return sb.ToString();
        }
        #endregion

        #region Sobrecargas
        public static bool operator ==(Producto a, Producto b)
        {
            bool sonIguales = false;

            if (a.GetType() == b.GetType())
            {
                if(a.Codigo==b.Codigo)
                {
                    sonIguales = true;
                }
            }

            return sonIguales;
        } 
        public static bool operator !=(Producto a, Producto b)
        {
            return !(a == b);
        }

        #endregion
    }
}

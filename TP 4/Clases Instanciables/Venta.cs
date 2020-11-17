using Clases_Abstractas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;

namespace Clases_Instanciables
{
    [Serializable]
   
    public sealed class Venta 
    {
       

        #region Atributos
        Cliente comprador;
        Empleado vendedor;
        List<Producto> carrito;
        int ticket;
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad de carrito de compras.
        /// </summary>
        public List<Producto> Carrito
        {
            get { return this.carrito; }
            set { this.carrito = value; }
        }

        /// <summary>
        /// Propiedad de ticket de compra.
        /// </summary>
        public int Ticket
        {
            get { return this.ticket; }
            set { this.ticket = value; }
        }

        /// <summary>
        /// Propiedad de comprador.
        /// </summary>
        public Cliente Comprador
        {
            get { return this.comprador; }
            set { this.comprador = value; }
        }

        /// <summary>
        /// Propiedad de vendedor.
        /// </summary>
        public Empleado Vendedor
        {
            get { return this.vendedor; }
            set { this.vendedor = value; }
        }

        #endregion

        #region Constructores

        public Venta()
        {
            this.carrito = new List<Producto>();
        }

        public Venta(List<Producto> carritoDeCompras, int nroTicket,Cliente comprador,Empleado vendedor)
        {
            this.carrito = carritoDeCompras;
            this.ticket = nroTicket;
            this.comprador = comprador;
            this.vendedor = vendedor;
        }
        #endregion

        #region Metodos

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Ticket numero: {0}\n",this.Ticket.ToString());
            sb.AppendFormat("Cliente: {0}\n",this.Comprador.Nombre);
            sb.AppendFormat("Vendedor: {0}\n",this.Vendedor.Nombre);
            //sb.AppendLine("Productos vendidos: ");
            foreach (Producto item in this.Carrito)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }

        /// <summary>
        /// Metodo de clase que guarda la informacion de la clase Venta en un archivo .xml, retorna true si fue correcta
        /// </summary>
        /// <param name="uni"> Venta. </param>
        /// <returns>True si se guardo correctamente, false si no.</returns>
        public static bool Guardar(string archivo, Venta datos)
        {
            string ruta = AppDomain.CurrentDomain.BaseDirectory;
            bool retorno = false;

            XML<Venta> universidad = new XML<Venta>();

            retorno = universidad.Guardar(ruta + "LISTAVENTAS.xml", datos);

            return retorno;
        }

        /// <summary>
        /// Metodo de clase para leer un archivo .xml y retorna su informacion
        /// </summary>
        /// <returns>True si se leyo correctamente, false si no.</returns>
        public static Venta Leer(string archivo)
        {
            string ruta = AppDomain.CurrentDomain.BaseDirectory;

            XML<Venta> venta = new XML<Venta>();

            if (!venta.Leer(ruta + archivo, out Venta retornoVenta))
            {
                retornoVenta = null;

            }

            return retornoVenta;
        }


        #endregion

        #region Sobrecargas

        public static bool operator == (Venta a, Venta b)
        {
            if(a.Ticket == b.Ticket)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
         public static bool operator != (Venta a, Venta b)
        {
            return !(a == b);      
        }

        public static Venta operator +(Venta v, Cliente c)
        {
            v.comprador = c;
            return v;
        }

        public static Venta operator +(Venta v, Empleado p)
        {
            v.vendedor = p;
            return v;
        }


        public static Venta operator + (Venta v,Producto p)
        {
            v.carrito.Add(p);
            return v;
        }

        #endregion
    }
}

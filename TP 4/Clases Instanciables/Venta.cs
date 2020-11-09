using Clases_Abstractas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
           // set { myVar = value; }
        }

        /// <summary>
        /// Propiedad de ticket de compra.
        /// </summary>
        public int Ticket
        {
            get { return this.ticket; }
           // set { myVar = value; }
        }

        /// <summary>
        /// Propiedad de comprador.
        /// </summary>
        public Cliente Comprador
        {
            get { return this.comprador; }
            // set { myVar = value; }
        }

        /// <summary>
        /// Propiedad de vendedor.
        /// </summary>
        public Empleado Vendedor
        {
            get { return this.vendedor; }
            // set { myVar = value; }
        }

        #endregion

        #region Constructores

        private Venta()
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
            sb.AppendLine("Productos: ");
            foreach (Producto item in this.Carrito)
            {
                sb.AppendLine(item.Mostrar());
            }

            return sb.ToString();
        }
        //GUARDAR

        #endregion

        #region Sobrecargas

        public static bool operator == (Venta a, Venta b)
        {
            if(a.Ticket == b.Ticket && a.carrito.Equals(b.carrito))
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

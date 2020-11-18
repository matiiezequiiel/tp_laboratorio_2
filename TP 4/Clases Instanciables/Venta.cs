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

        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public Venta()
        {
            this.carrito = new List<Producto>();
        }

        /// <summary>
        /// Constructor de instancia.
        /// </summary>
        /// <param name="carritoDeCompras">Lista de productos vendidos.</param>
        /// <param name="nroTicket">Numero de ticket.</param>
        /// <param name="comprador">Cliente que realizo la compra.</param>
        /// <param name="vendedor">Vendedor que reakuzi la venta,</param>
        public Venta(List<Producto> carritoDeCompras, int nroTicket,Cliente comprador,Empleado vendedor)
        {
            this.carrito = carritoDeCompras;
            this.ticket = nroTicket;
            this.comprador = comprador;
            this.vendedor = vendedor;
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Muestra los datos de la venta.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Ticket numero: {0}\n",this.Ticket.ToString());
            sb.AppendFormat("Cliente: {0}\n",this.Comprador.Nombre);
            sb.AppendFormat("Vendedor: {0}\n",this.Vendedor.Nombre);
            foreach (Producto item in this.Carrito)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }

  


        #endregion

        #region Sobrecargas

        /// <summary>
        /// Una venta es igual a otra si tienen el mismo numero de ticket.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>True si existe la venta, false si no.</returns>
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


        #endregion
    }
}

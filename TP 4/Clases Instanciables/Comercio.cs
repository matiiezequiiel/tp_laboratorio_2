using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Clases_Abstractas;
using Excepciones;
using Archivos;



namespace Clases_Instanciables
{
    [Serializable]
    public sealed class Comercio
    {
        #region Atributos
        List<Producto> inventario;
        List<Cliente> clientes;
        List<Empleado> empleados;
        List<Venta> ventas;
        #endregion

        #region Propiedades
        public List<Producto> Inventario
        {
            get { return this.inventario; }
            set {
                this.inventario.Clear();
                this.inventario = value; }
        }
        public List<Cliente> Clientes
        {
            get { return this.clientes; }
            set { this.clientes = value; }
        }
        public List<Empleado> Empleados
        {
            get { return this.empleados; }
            set { this.empleados = value; }
        }
        public List<Venta> Ventas
        {
            get { return this.ventas; }
            set { this.ventas = value; }
        }

        #endregion

        #region Constructores

        public Comercio()
        {
            inventario = new List<Producto>();
            clientes = new List<Cliente>();
            empleados = new List<Empleado>();
            ventas = new List<Venta>();
        }


        public Comercio(List<Producto> inventario, List<Empleado> empleados, List<Cliente> clientes, List<Venta> ventas) : this()
        {
            this.inventario = inventario;
            this.empleados = empleados;
            this.clientes = clientes;
            this.ventas = ventas;
        }

        #endregion

        #region Metodos

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("LISTA DE PRODUCTOS:\n");
            foreach (Producto item in this.inventario)
            {
                sb.AppendLine(item.ToString());
            }

            sb.AppendLine("LISTA DE CLIENTES:\n");
            foreach (Cliente item in this.clientes)
            {
                sb.AppendLine(item.Mostrar());
                sb.AppendLine();
            }

            sb.AppendLine("LISTA DE EMPLEADOS:\n");
            foreach (Empleado item in this.empleados)
            {
                sb.AppendLine(item.Mostrar());
                sb.AppendLine();
            }

            sb.AppendLine("VENTAS REALIZADAS:\n");
            foreach (Venta item in this.ventas)
            {
                sb.AppendLine(item.ToString());
            }
           
            return sb.ToString();
        }

        public Venta NuevaVenta(Comercio c,Venta nuevaVenta)
        {

            c += nuevaVenta;

            GenerarTicket(nuevaVenta);

            return nuevaVenta;

        }


        private void GenerarTicket(Venta nuevaVenta)
        {
            StringBuilder sb = new StringBuilder();
            string ruta = AppDomain.CurrentDomain.BaseDirectory;
            string nombreTicket = nuevaVenta.Ticket.ToString()+".txt";
            double total = 0;

            Texto auxTexto = new Texto();

            sb.AppendFormat("Usted fue atendido por: {0} {1} \n",nuevaVenta.Vendedor.Nombre,nuevaVenta.Vendedor.Apellido);
            sb.AppendFormat("Fecha: {0}\n", DateTime.Now);
            sb.AppendFormat("Cliente: {0} {1} \n",nuevaVenta.Comprador.Nombre,nuevaVenta.Comprador.Apellido);

            sb.AppendLine("");
            sb.AppendLine("");
            sb.AppendLine("Lista de productos: ");
            sb.AppendLine("-----------------------------------");

            foreach (Producto item in nuevaVenta.Carrito)
            {
                sb.AppendFormat("{0,-28}   ${1,-20}\n", item.Nombre, item.Precio);
                total = total + item.Precio;
            }
            sb.AppendLine("-----------------------------------");
            sb.AppendFormat("Total:         {0,20} \n", total.ToString());
            sb.AppendLine("-----------------------------------");
            sb.AppendLine("-----------------------------------");
            sb.AppendFormat("Nro de ticket: {0,20} \n", nuevaVenta.Ticket.ToString());
            sb.AppendLine("-----------------------------------");

            auxTexto.Guardar(ruta + nombreTicket, sb.ToString());


        }
        
        public static void Guardar(Comercio datosComercio)
        {
            string ruta = AppDomain.CurrentDomain.BaseDirectory;
           

            XML<List<Venta>> ventasComercio = new XML<List<Venta>>();

                ventasComercio.Guardar(ruta + "XMLVENTAS.xml", datosComercio.ventas);
   
        }

        #endregion

        #region Sobrecargas

        public static Comercio operator +(Comercio c,Empleado e)
        {
            bool existe = false;

            foreach (Empleado item in c.Empleados)
            {
                if(item.Legajo == e.Legajo)
                {
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                c.empleados.Add(e);
            }

            return c;
        }
        
        public static Comercio operator +(Comercio c,Cliente a)
        {
            bool existe = false;

            foreach (Cliente item in c.Clientes)
            {
                if(item.DNI == a.DNI)
                {
                    existe = true;
                    break;
                }
            }

            if (!existe)
            {
                c.clientes.Add(a);
            }

            return c;
        }
        
        public static Comercio operator +(Comercio c,Producto p)
        {
            bool existe = false;

            foreach (Producto item in c.inventario)
            {
                if(p==item)
                {
                    existe = true;
                    break;
                }

            }

            if (!existe)
            {
                c.inventario.Add(p);
            }

            return c;
        }

        public static Comercio operator + (Comercio c, Venta a)
        {
            bool existe = false;

            foreach (Venta item in c.ventas)
            {
                if(item.Ticket==a.Ticket)
                {
                    existe = true;
                    break;
                }
               
            }
            if (existe)
            {               
                throw new VentaDuplicadaException();
            }
            else
            {

                List<Producto> l = new List<Producto>();
                l.AddRange(a.Carrito);
                int ticket=c.ventas.Count + 1;
                Cliente cl = new Cliente();
                cl=a.Comprador;
                Empleado v = new Empleado();
                v = a.Vendedor;
                c.ventas.Add(new Venta(l,ticket,cl,v));

            }
           
            return c;
        }

        #endregion
    }
}

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
using System.IO;

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

        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public Comercio()
        {
            inventario = new List<Producto>();
            clientes = new List<Cliente>();
            empleados = new List<Empleado>();
            ventas = new List<Venta>();
        }


        /// <summary>
        /// Constructor de instancia
        /// </summary>
        /// <param name="inventario">Inventario del comercio.</param>
        /// <param name="empleados">Empleados del comercio.</param>
        /// <param name="clientes">Clientes del comercio.</param>
        /// <param name="ventas">Ventas del comercio.</param>
        public Comercio(List<Producto> inventario, List<Empleado> empleados, List<Cliente> clientes, List<Venta> ventas) : this()
        {
            this.inventario = inventario;
            this.empleados = empleados;
            this.clientes = clientes;
            this.ventas = ventas;
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Muestra los datos del comercio.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Carga una nueva venta.
        /// </summary>
        /// <param name="c">Comercio.</param>
        /// <param name="nuevaVenta">Nueva venta.</param>
        /// <returns>Venta</returns>
        public Venta NuevaVenta(Comercio c,Venta nuevaVenta)
        {

            c += nuevaVenta;

            GenerarTicket(nuevaVenta);

            return nuevaVenta;

        }


        /// <summary>
        /// Genera un archivo TXT por cada venta.
        /// </summary>
        /// <param name="nuevaVenta"></param>
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
        
        /// <summary>
        /// Guarda las ventas del comercio
        /// </summary>
        /// <param name="datosComercio">Comercio.</param>
        public static void Guardar(Venta ventaRealizada)
        {
            string ruta = AppDomain.CurrentDomain.BaseDirectory;
            string nombre = ventaRealizada.Ticket.ToString() + ".xml";
           

            XML<Venta> ventasComercio = new XML<Venta>();

                ventasComercio.Guardar(ruta + nombre, ventaRealizada);
   
        }

        /// <summary>
        /// Metodo de clase para leer un archivo .xml y retorna su informacion
        /// </summary>
        /// <returns>True si se leyo correctamente, false si no.</returns>
        public static List<Venta> Leer()
        {
          
            DirectoryInfo di = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
            FileInfo[] archivos = di.GetFiles("*.xml");
            Venta retornoVenta=new Venta();
            List<Venta> listaCargada = new List<Venta>();

            XML<Venta> venta = new XML<Venta>();



            for (int i = 0; i < archivos.Length; i++)
            {
                if (!venta.Leer(AppDomain.CurrentDomain.BaseDirectory+archivos[i].ToString(), out retornoVenta))
                {
                    retornoVenta = null;
                }
                else
                {
                    listaCargada.Add(retornoVenta);
                }
            }       
           
            return listaCargada;
            
        }


        #endregion

        #region Sobrecargas

        /// <summary>
        /// Agregar empleados para la prueba de TEST, esta funcionalidad no esta en el formulario.
        /// </summary>
        /// <param name="c">Comercio.</param>
        /// <param name="e">Empleado.</param>
        /// <returns>Comercio.</returns>
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
        
        /// <summary>
        /// Agrega un cliente al comercio para la prueba TEST, en el formulario se inserta directamente en la base de datos.
        /// </summary>
        /// <param name="c">Comercio.</param>
        /// <param name="a">Cliente</param>
        /// <returns>Comercio</returns>
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

        /// <summary>
        /// Agrega un producto al comercio para la prueba TEST, en el formulario se inserta directamente en la base de datos.
        /// </summary>
        /// <param name="c">Comercio.</param>
        /// <param name="a">Producto</param>
        /// <returns>Comercio</returns>
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

        /// <summary>
        /// Agrega una venta al comercio para la prueba TEST, en el formulario guarda en un XML.
        /// </summary>
        /// <param name="c">Comercio.</param>
        /// <param name="a">Venta</param>
        /// <returns>Comercio</returns>
        public static Comercio operator + (Comercio c, Venta a)
        {
            bool existe = false;

            foreach (Venta item in c.ventas)
            {
                if(item==a)
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
                int ticket=c.ventas.Count;
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

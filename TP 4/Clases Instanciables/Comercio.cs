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

namespace Clases_Instanciables
{
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
          //  set { myVar = value; }
        }
        public List<Cliente> Clientes
        {
            get { return this.clientes; }
          //  set { myVar = value; }
        }
        public List<Empleado> Empleados
        {
            get { return this.empleados; }
          //  set { myVar = value; }
        }
        public List<Venta> Ventas
        {
            get { return this.ventas; }
          //  set { myVar = value; }
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
        //GUARDAR

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
                if(item.NroCliente == a.NroCliente)
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
                c.ventas.Add(a);
            }
           
            return c;
        }

        #endregion
    }
}

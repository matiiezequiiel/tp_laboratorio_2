using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases_Instanciables;
using Clases_Abstractas;
using SQL;

namespace InicioSesion
{
    public partial class MenuPrincipal : Form
    {


        #region Atributos
        private List<Cliente> listaAuxCliente;
        private List<Producto> listaAuxProductos;

        #endregion

        #region Carga de datos

        public MenuPrincipal()
        {
            InitializeComponent();
            listaAuxCliente = new List<Cliente>();
            listaAuxProductos = new List<Producto>();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
           
            CargarMenuCompras(false);
            CargarListaCliente();
            CargarListaProducto();
       
        }
        private void nuevaCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargarMenuCompras(true);
        }

        private void CargarMenuCompras(bool estado)
        {
            if (estado)
            {
                lblEmpleadoLogeado.Visible = true;
                txtEmpleadoLogeado.Visible = true;
                lblCarrito.Visible = true;
                lblDescuento.Visible = true;
                lblListaClientes.Visible = true;
                lblListaProductos.Visible = true;
                lblNuevoCliente.Visible = true;
                lblTotal.Visible = true;
                lblTotalCompra.Visible = true;
                lblTotalDescuento.Visible = true;
                btnConfirmarCompra.Visible = true;
                btnVaciarCarrito.Visible = true;
                btnDetalleEmpleado.Visible = true;
                lsvCarrito.Visible = true;
                lsvClientes.Visible = true;
                lsvProductos.Visible = true;

            }
            else
            {
                lblEmpleadoLogeado.Visible = false;
                txtEmpleadoLogeado.Visible = false;
                lblCarrito.Visible = false;
                lblDescuento.Visible = false;
                lblListaClientes.Visible = false;
                lblListaProductos.Visible = false;
                lblNuevoCliente.Visible = false;
                lblTotal.Visible = false;
                lblTotalCompra.Visible = false;
                lblTotalDescuento.Visible = false;
                btnConfirmarCompra.Visible = false;
                btnVaciarCarrito.Visible = false;
                btnDetalleEmpleado.Visible = false;
                lsvCarrito.Visible = false;
                lsvClientes.Visible = false;
                lsvProductos.Visible = false;
            }

        }

        public void CargarListaCliente()
        {
            lsvClientes.Items.Clear();
    
            foreach (Cliente item in ClienteDB.TraerClientes())
            {
                ListViewItem aux = new ListViewItem(item.Nombre);
                aux.SubItems.Add(item.Apellido);
                lsvClientes.Items.Add(aux);
            }

        }
        
        public void CargarListaProducto()
        {

            lsvProductos.Items.Clear();
            List<Informatica> listaInformatica = ProductoDB.TraerProductosInformatica();
            List<Electrodomesticos> listaElectrodomesticos = ProductoDB.TraerProductosElectrodomesticos();
           
         

            foreach (Informatica item in listaInformatica)
            {
                ListViewItem aux = new ListViewItem(item.Nombre);
                aux.SubItems.Add(item.Stock.ToString());
                aux.SubItems.Add(item.Precio.ToString());
                lsvProductos.Items.Add(aux);

            } 

            foreach (Electrodomesticos item in listaElectrodomesticos)
            {
                ListViewItem aux = new ListViewItem(item.Nombre);
                aux.SubItems.Add(item.Stock.ToString());
                aux.SubItems.Add(item.Precio.ToString());
                lsvProductos.Items.Add(aux);

            }
        }
        /*
        #endregion

        #region Refrescar listas

        private void RefrescarListaProducto()
        {
            lsvProductos.Items.Clear();

            foreach (Producto item in listaAuxProdEnCompra)
            {
                ListViewItem aux = new ListViewItem(item.nombreProducto);
                aux.SubItems.Add(item.stockProducto.ToString());
                aux.SubItems.Add(item.precioProducto.ToString());
                lsvProductos.Items.Add(aux);

            }

        }
        private void RefrescarCarrito()
        {
            lsvProductos.Items.Clear();


            foreach (Producto item in listaAuxProd)
            {
                ListViewItem aux = new ListViewItem(item.nombreProducto);
                aux.SubItems.Add(item.stockProducto.ToString());
                aux.SubItems.Add(item.precioProducto.ToString());
                lsvProductos.Items.Add(aux);

            }

            listaAuxProdEnCompra.Clear();

            foreach (Producto item in listaAuxProd)
            {
                string nombre = item.nombreProducto;
                int stock = item.stockProducto;
                //   string categoria = item.CategoriaProducto;
                int codigo = item.codigoProducto;
                double precio = item.precioProducto;

                listaAuxProdEnCompra.Add(new Producto(nombre, item.tipoProducto, precio, stock, codigo));
            }

        }

        private void ActualizarStockListaAux(string productoActualizar)
        {

            foreach (Producto item in listaAuxProdEnCompra)
            {
                if (item.nombreProducto == productoActualizar)
                {
                    item.stockProducto = item.stockProducto - 1;
                    carroDeCompras.Add(item);
                    SacarTotales();
                    RefrescarListaProducto();
                    break;

                }
            }
        }



        #endregion

        #region Nuevos Forms

        private void lblNuevoCliente_Click(object sender, EventArgs e)
        {
            NuevoCliente formAgregarCliente = new NuevoCliente(this);
            this.Hide();
            formAgregarCliente.Show();
        }

        private void comprasPorEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComprasPorEmpleado formCompraPorEmpleado = new ComprasPorEmpleado();
            this.Hide();
            formCompraPorEmpleado.Show();
        }

        private void stockDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaStock formStock = new ListaStock();
            this.Hide();
            formStock.Show();
        }

        private void altaProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarProducto formAgregarProducto = new AgregarProducto(this);
            this.Hide();
            formAgregarProducto.Show();
        }

        private void productoConMenosDe10UnidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StockMenosProductos formStock10Un = new StockMenosProductos();
            this.Hide();
            formStock10Un.Show();
        }

        #endregion

        #region Drag and Drop
        private void lsvClientes_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int indiceCheck;

            indiceCheck = e.Index;

            foreach (ListViewItem auxLista in lsvClientes.Items)
            {
                if (indiceCheck != auxLista.Index)
                {
                    auxLista.Checked = false;
                }

            }

        }

        private void lsvProductos_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                int linea = lsvProductos.HitTest(e.X, e.Y).Item.Index;
                lsvProductos.DoDragDrop(linea, DragDropEffects.Copy);
            }
            catch (Exception)
            {
                //No tiene sentido informar al usuario que clickeo fuera de el area.
            }

        }

        private void lsvCarrito_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void lsvCarrito_DragDrop(object sender, DragEventArgs e)
        {
            bool seleccionoCliente = false;

            foreach (ListViewItem auxLista in lsvClientes.Items)
            {
                if (auxLista.Checked == true)
                {
                    lsvClientes.CheckBoxes = false;
                    seleccionoCliente = true;
                    break;
                }

            }

            if (seleccionoCliente)
            {
                int lineaArrastrada = Convert.ToInt32(e.Data.GetData(Type.GetType("System.Int32")));


                foreach (ListViewItem aux in lsvProductos.Items)
                {
                    if (lineaArrastrada == aux.Index)
                    {
                        if (aux.SubItems[1].Text != "0")
                        {
                            ListViewItem nuevoProducto = new ListViewItem(aux.Text);
                            lsvCarrito.Items.Add(nuevoProducto);
                            ActualizarStockListaAux(aux.Text);
                            break;

                        }
                        else
                        {
                            MessageBox.Show("No hay stock del producto seleccionado");
                            if (lsvCarrito.Items.Count == 0)
                            {
                                lsvClientes.CheckBoxes = true;
                            }

                        }

                    }
                }

            }


        }






        #endregion

        #region botones

        private void btnVaciarCarrito_Click(object sender, EventArgs e)
        {
            if (carroDeCompras.Count > 0)
            {
                lsvCarrito.Items.Clear();
                carroDeCompras.Clear();
                lsvClientes.CheckBoxes = true;
                this.lblTotalCompra.Text = "";
                this.lblTotalDescuento.Text = "";
                RefrescarCarrito();

            }
            else
            {
                MessageBox.Show("El carrito esta vacio.");
            }


        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@".\data\AperturaPuerta.wav");
            player.Play();
        }

        private void btnConfirmarCompra_Click(object sender, EventArgs e)
        {
            int nroTicket;

            if (carroDeCompras.Count > 0)
            {
                nroTicket = Comercio.CargarVenta(carroDeCompras, this.txtEmpleadoLogeado.Text);
                GenerarTicket(carroDeCompras, nroTicket);
                Comercio.ActualizarListaStock(listaAuxProdEnCompra);
                listaAuxProdEnCompra.Clear();
                lsvCarrito.Items.Clear();
                lblTotalCompra.Text = "";
                lblTotalDescuento.Text = "";
                lsvClientes.CheckBoxes = true;
                carroDeCompras.Clear();
                CargarListaProducto();

                MessageBox.Show("GRACIAS VUELVA PRONTOS!!!");
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@".\data\GraciasVuelvaPronto.wav");
                player.Play();

            }
            else
            {
                MessageBox.Show("El carrito esta vacio.");
            }
        }

        private void btnDetalleEmpleado_Click(object sender, EventArgs e)
        {
            //List<Empleado> listaEmpleados = new List<Empleado>();

            //listaEmpleados=Comercio
            string[] valores;
            valores = txtEmpleadoLogeado.Text.Split(' ');


            foreach (Empleado item in Comercio.RetornarListaEmpleados())
            {
                if (valores[0] == item.NombrePersona && valores[1] == item.ApellidoPersona)
                {
                    MessageBox.Show(item.DatosPersona());
                }
            }
        }

        private void lsvClientes_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                menuCliente.Show(lsvClientes, e.X, e.Y);
                try
                {
                    lineaSeleccionada = lsvClientes.HitTest(e.X, e.Y).Item.Index;
                }
                catch (Exception)
                {
                    //No tiene sentido informar al usuario que clickeo fuera de el area.
                }

            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string nombre = "";
            string apellido = "";


            foreach (ListViewItem item in lsvClientes.Items)
            {
                if (item.Index == lineaSeleccionada)
                {
                    nombre = item.SubItems[0].Text;
                    apellido = item.SubItems[1].Text;
                    break;
                }
            }

            foreach (Cliente item in listaAuxCliente)
            {
                if (item.NombrePersona == nombre && item.ApellidoPersona == apellido)
                {
                    MessageBox.Show(item.DatosPersona());
                    break;
                }
            }

        }



        #endregion

        #region Total y tickets de compras

        private void SacarTotales()
        {
            double total = 0;
            double totalDesc = 0;
            double descuentoProducto = 0;



            foreach (ListViewItem auxLista in lsvClientes.Items)
            {
                if (auxLista.Checked == true)
                {
                    string nombre = auxLista.SubItems[0].Text;
                    string apellido = auxLista.SubItems[1].Text;

                    if (apellido == "Simpson")
                    {
                        foreach (Producto prod in carroDeCompras)
                        {
                            total = total + prod.precioProducto;
                            descuentoProducto = prod.precioProducto * 15 / 100;
                            totalDesc = totalDesc + descuentoProducto;

                        }
                        this.lblTotalCompra.Text = "$" + total.ToString();
                        this.lblTotalDescuento.Text = "$" + totalDesc.ToString();
                    }
                    else
                    {
                        foreach (Producto prod in carroDeCompras)
                        {
                            total = total + prod.precioProducto;

                        }
                        this.lblTotalCompra.Text = "$" + total.ToString();
                    }



                }

            }


        }


        private void GenerarTicket(List<Producto> carritoDeCompras, int nroTicket)
        {
            string nombreTicket = nroTicket.ToString();
            Stream fs = new FileStream(".\\data\\Ticket " + nroTicket + ".txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);


            sw.WriteLine("Usted fue atendido por: " + this.txtEmpleadoLogeado.Text);
            sw.WriteLine("Fecha: " + DateTime.Now);

            foreach (ListViewItem item in lsvClientes.Items)
            {
                if (item.Checked == true)
                {
                    sw.WriteLine("Cliente: " + item.Text + " " + item.SubItems[1].Text);

                }

            }

            sw.WriteLine("");
            sw.WriteLine("");
            sw.WriteLine("Lista de productos: ");
            sw.WriteLine("-----------------------------------");

            foreach (Producto item in carritoDeCompras)
            {
                sw.WriteLine("{0,-28}   ${1,-20}", item.nombreProducto, item.precioProducto);
            }
            sw.WriteLine("-----------------------------------");
            sw.WriteLine("Total:         {0,20} ", this.lblTotalCompra.Text);
            sw.WriteLine("-----------------------------------");
            //  sw.WriteLine("");
            sw.WriteLine("-----------------------------------");
            sw.WriteLine("Descuento:     {0,20}", this.lblTotalDescuento.Text);
            sw.WriteLine("-----------------------------------");
            //  sw.WriteLine("");
            sw.WriteLine("-----------------------------------");
            sw.WriteLine("Nro de ticket: {0,20}", nroTicket);
            sw.WriteLine("-----------------------------------");

            sw.Close();

        
        }


        
        
        */
        #endregion

      
    }
}

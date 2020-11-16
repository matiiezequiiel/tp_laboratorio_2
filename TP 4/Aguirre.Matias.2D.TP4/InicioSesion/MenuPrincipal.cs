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
    public delegate void miDelegado(List<Producto> productosVendidos,string vendedor,string comprador);
   
    public partial class MenuPrincipal : Form
    {

        #region Atributos
        Comercio miComercio = new Comercio(ProductoDB.TraerProductos(), EmpleadoDB.TraerEmpleados(), ClienteDB.TraerClientes(),new List<Venta>());
        List<Producto> listaAuxiliar;
        Venta ventaParcial=new Venta();
        public event miDelegado NuevaVenta;



        #endregion

        #region Carga de datos

        public MenuPrincipal()
        {
            InitializeComponent();
              
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
   
            CargarListaCliente();
            CargarListaProducto();
            NuevaVenta += miComercio.NuevaVenta;
       
        }
        private void nuevaCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //HILOS PARA VARIAS COMPRAS.
        }

      
        public void CargarListaCliente()
        {
            lsvClientes.Items.Clear();
    
            foreach (Cliente item in miComercio.Clientes)
            {
                ListViewItem aux = new ListViewItem(item.Nombre);
                aux.SubItems.Add(item.Apellido);
                lsvClientes.Items.Add(aux);
            }

        }
        
        public void CargarListaProducto()
        {

            lsvProductos.Items.Clear();

            listaAuxiliar = ProductoDB.TraerProductos();
          
            foreach (Producto item in listaAuxiliar)
            {
                ListViewItem aux = new ListViewItem(item.Nombre);
                aux.SubItems.Add(item.Stock.ToString());
                aux.SubItems.Add(item.Precio.ToString());
                lsvProductos.Items.Add(aux);

            }
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
                        if (aux.SubItems[1].Text != "0") //Si tiene stock
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

        #region Actualizar listas
        private void ActualizarStockListaAux(string productoActualizar)
        {

            foreach (Producto item in listaAuxiliar)
            {
                if (item.Nombre == productoActualizar)
                {
                    item.Stock = item.Stock - 1;
                    ventaParcial.Carrito.Add(item);
                    SacarTotales();
                    RefrescarListaProducto();
                    break;

                }
            }
        }

        private void SacarTotales()
        {
            double total = 0;
        
            foreach (ListViewItem auxLista in lsvClientes.Items)
            {
                if (auxLista.Checked == true)
                {
                   
                    foreach (Producto prod in ventaParcial.Carrito)
                    {
                        total = total + prod.Precio;
          
                    }
                    this.lblTotalCompra.Text = "$" + total.ToString();
    
                }

            }


        }

        private void RefrescarListaProducto()
        {
            lsvProductos.Items.Clear();

            foreach (Producto item in listaAuxiliar)
            {
                ListViewItem aux = new ListViewItem(item.Nombre);
                aux.SubItems.Add(item.Stock.ToString());
                aux.SubItems.Add(item.Precio.ToString());
                lsvProductos.Items.Add(aux);

            }

        }

       
        #endregion

        #region Botones
        private void btnVaciarCarrito_Click(object sender, EventArgs e)
        {
            if (ventaParcial.Carrito.Count > 0)
            {
                lsvCarrito.Items.Clear();
                ventaParcial.Carrito.Clear();
                lsvClientes.CheckBoxes = true;
                this.lblTotalCompra.Text = "";
                this.lblTotalDescuento.Text = "";
                CargarListaProducto();

            }
            else
            {
                MessageBox.Show("El carrito esta vacio.");
            }


        }

        private void btnConfirmarCompra_Click(object sender, EventArgs e)
        {

            if (ventaParcial.Carrito.Count > 0)
            {
                NuevaVenta.Invoke(ventaParcial.Carrito,this.txtEmpleadoLogeado.Text,lsvClientes.SelectedItems.ToString());
               /*
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

                MessageBox.Show("Su venta fue registrada correctamente.");
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@".\data\GraciasVuelvaPronto.wav");
                player.Play();
               */
            }
            else
            {
                MessageBox.Show("El carrito esta vacio.");
            }
        }

        #endregion


    }
}

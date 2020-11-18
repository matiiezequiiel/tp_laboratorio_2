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
    public delegate Venta miDelegado(Comercio c,Venta nuevaVenta);

   
    public partial class MenuPrincipal : Form
    {

        #region Atributos
        public Comercio miComercio = new Comercio(ProductoDB.TraerProductos(), EmpleadoDB.TraerEmpleados(), ClienteDB.TraerClientes(),new List<Venta>());
        List<Producto> listaAuxiliar;
        Venta ventaParcial=new Venta();
        public event miDelegado NuevaVenta;
        
        int lineaSeleccionada;
        #endregion

        #region Carga de datos

        public MenuPrincipal()
        {
            InitializeComponent();         
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            CargarVendedor();
            CargarListaCliente();
            CargarListaProducto();
            NuevaVenta += miComercio.NuevaVenta;
      //      CambioEnLista += CargarListaCliente;
      //      CambioEnLista += CargarListaProducto;
       
        }
        private void nuevaCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //HILOS PARA VARIAS COMPRAS.
        }

        public void CargarVendedor()
        {
            foreach (Empleado item in miComercio.Empleados)
            {
                if(txtLegajo.Text==item.Legajo.ToString())
                {
                    ventaParcial.Vendedor = item;
                    break;

                }
            }
        }

        public void CargarListaCliente()
        {
            
            lsvClientes.Items.Clear();

            miComercio.Clientes = ClienteDB.TraerClientes();

            foreach (Cliente item in miComercio.Clientes)
            {
                ListViewItem aux = new ListViewItem(item.Nombre);
                aux.SubItems.Add(item.Apellido);
                aux.SubItems.Add(item.NroCliente.ToString());
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

                    foreach (Cliente item in miComercio.Clientes)
                    {
                        if(item.NroCliente.ToString() == auxLista.SubItems[2].Text)
                        {
                            ventaParcial.Comprador = item;
                            break;
                        }
                    }

                   //BUSCAR CLIENTE
                    
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

        public void LimpiarPantalla()
        {
            lsvCarrito.Items.Clear();
            lblTotalCompra.Text = "";
            lsvClientes.CheckBoxes = true;
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
               

                Venta ventaConfirmada=NuevaVenta.Invoke(miComercio,ventaParcial);
                //ventaConfirmada.Guardar()

                ProductoDB.ActualizarStockProducto(ventaConfirmada.Carrito);

                miComercio.Inventario = ProductoDB.TraerProductos();
                listaAuxiliar.Clear();
                ventaParcial.Carrito.Clear();

                CargarListaProducto();

                LimpiarPantalla();
                MessageBox.Show("Su venta fue registrada correctamente.");
               
            }
            else
            {
                MessageBox.Show("El carrito esta vacio.");
            }
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }
        #endregion

        #region Botones mas informacion

        private void btnDetalleEmpleado_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ventaParcial.Vendedor.Mostrar());      
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
            string nroCliente=string.Empty;


            foreach (ListViewItem item in lsvClientes.Items)
            {
                if (item.Index == lineaSeleccionada)
                {
                    nroCliente = item.SubItems[2].Text;
                  
                    break;
                }
            }

            foreach (Cliente item in miComercio.Clientes)
            {
                if (item.NroCliente.ToString() == nroCliente)
                {
                    MessageBox.Show(item.Mostrar());
                    break;
                }
            }

        }


        #endregion


        #region Botones nuevos FORMS

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            NuevoCliente formAgregarCliente = new NuevoCliente(this);
            this.Hide();
            formAgregarCliente.Show();
        }

        private void btnAgregarProdu_Click(object sender, EventArgs e)
        {
            AgregarProducto formAgregarProducto = new AgregarProducto(this);
            this.Hide();
            formAgregarProducto.Show();
        }

        #endregion
        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Comercio.Guardar(miComercio);
          
        }

      
    }
}

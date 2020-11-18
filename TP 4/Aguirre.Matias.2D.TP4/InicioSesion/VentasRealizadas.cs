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

namespace InicioSesion
{
    public partial class VentasRealizadas : Form
    {
        MenuPrincipal datos;

        public VentasRealizadas(MenuPrincipal auxMenu)
        {
            InitializeComponent();
            datos = auxMenu;
        }

        private void VentasRealizadas_Load(object sender, EventArgs e)
        {
            CargarTickets();
        }

        private void CargarTickets()
        {

            lsvVentas.Items.Clear();


            foreach (Venta item in datos.miComercio.Ventas)
            {
                ListViewItem aux = new ListViewItem(item.Comprador.Nombre + " " + item.Comprador.Apellido);
                aux.SubItems.Add(item.Vendedor.Nombre + " " + item.Vendedor.Apellido);
                aux.SubItems.Add(item.Ticket.ToString());
                lsvVentas.Items.Add(aux);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            this.Close();
            datos.Show();

        }

        private void lsvVentas_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            string nroTicket="";

            CheckBoxIndicesEmpleados(e.Index);


            if (e.Index < lsvVentas.Items.Count)
            {
                foreach (ListViewItem auxLista in lsvVentas.Items)
                {
                    if (e.Index == auxLista.Index)
                    {
                        nroTicket = auxLista.SubItems[2].Text;
                        break;

                    }
                }

            }


            foreach (Venta item in datos.miComercio.Ventas)
            {
               if(item.Ticket.ToString() == nroTicket)
                {
                    foreach (Producto item2 in item.Carrito)
                    {
                        lsvProductos.Items.Clear(); 
                        ListViewItem aux = new ListViewItem(item2.Nombre.ToString());
                        aux.SubItems.Add(item2.Precio.ToString());
                        aux.SubItems.Add(item2.Codigo.ToString());
                        lsvProductos.Items.Add(aux);

                    }
                    
                }
            }




        }
        private void CheckBoxIndicesEmpleados(int indice)
        {

            foreach (ListViewItem auxLista in lsvVentas.Items)
            {
                if (indice != auxLista.Index)
                {
                    auxLista.Checked = false;
                }

            }
        }
    }
   }

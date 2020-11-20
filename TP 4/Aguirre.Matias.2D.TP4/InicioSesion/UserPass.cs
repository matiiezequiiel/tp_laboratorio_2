using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQL;
using Clases_Instanciables;
using Clases_Abstractas;
using System.Threading;

namespace InicioSesion
{
    
    public partial class UserPass : Form
    {
        static Comercio datosComercioTabla;
        /// <summary>
        /// IMPLEMENTACION DE HILOS.
        /// </summary>
        Thread cargaDeDatos = new Thread(cargarDatosComercio);


        public UserPass()
        {
            InitializeComponent();
            cargaDeDatos.Start();

        }

        public static void cargarDatosComercio()
        {
            List<Empleado> empleados = EmpleadoDB.TraerEmpleados();
            List<Cliente> clientes = ClienteDB.TraerClientes();
            List<Producto> productos = ProductoDB.TraerProductos();
            List<Venta> ventasRealizadas = Comercio.Leer();

            datosComercioTabla = new Comercio(productos, empleados, clientes, ventasRealizadas);

        }


        private void UserPass_Load(object sender, EventArgs e)
        {

            txtPass.Select();

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {

            if (EmpleadoDB.ValidarContraseña(txtPass.Text, txtLegajo.Text))
            {
                MessageBox.Show("Acceso correcto", "Inicio de sesion de " + txtUsuario.Text, MessageBoxButtons.OK,MessageBoxIcon.Information);
                MenuPrincipal formMenu = new MenuPrincipal(datosComercioTabla,this);
                this.Hide();
                formMenu.Show();
                this.Hide();
            }
            else
            {
                 MessageBox.Show("Acceso fallido", "Inicio de sesion de " + txtUsuario.Text, MessageBoxButtons.OK);
            }       

        }
            
        private void btnAtras_Click(object sender, EventArgs e)
        {
                this.Close();
                FormIngresoSistema formInicio = new FormIngresoSistema();
                formInicio.Show();
        }

        private void UserPass_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(cargaDeDatos.IsAlive)
            {
                cargaDeDatos.Abort();
            }

        }
    }
}

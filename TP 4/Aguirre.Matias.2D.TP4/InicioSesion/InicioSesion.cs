using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InicioSesion
{
    public partial class FormIngresoSistema : Form
    {
       
        public FormIngresoSistema()
        {
            InitializeComponent();
        }

        private void FormIngresoSistema_Load(object sender, EventArgs e)
        {

           // Comercio.CargarHardcodeo();
           // dtgLogin.DataSource = Comercio.RetornarListaEmpleados();

        }

        private void dtgLogin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

/*
            if (e.RowIndex >= 0)
            {
                DataGridViewRow linea = this.dtgLogin.Rows[e.RowIndex];
                nombreUsuario = linea.Cells["nombreEmpleado"].Value.ToString();
                apellidoUsuario = linea.Cells["apellidoEmpleado"].Value.ToString();
                privilegiosUsuario = linea.Cells["puestoEmpleado"].Value.ToString();
            }

            this.Hide();

            UserPass formInicioSesion = new UserPass();
            formInicioSesion.txtUsuario.Text = nombreUsuario + " " + apellidoUsuario;
            formInicioSesion.txtPuesto.Text = privilegiosUsuario;
            formInicioSesion.Show();

            */
        }
    }
}

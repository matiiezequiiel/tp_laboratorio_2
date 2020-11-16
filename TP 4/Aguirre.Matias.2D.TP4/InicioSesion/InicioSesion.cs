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

namespace InicioSesion
{
    public partial class FormIngresoSistema : Form
    {
        public string nombreUsuario;
        public string apellidoUsuario;
        public string legajo;

        public FormIngresoSistema()
        {
            InitializeComponent();
            dtgLogin.DataSource = EmpleadoDB.TraerEmpleados();
                       
        }

        private void dtgLogin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow linea = this.dtgLogin.Rows[e.RowIndex];
                nombreUsuario = linea.Cells["nombreEmpleado"].Value.ToString();
                apellidoUsuario = linea.Cells["apellidoEmpleado"].Value.ToString();
                legajo = linea.Cells["legajoEmpleado"].Value.ToString();
            }

            this.Hide();

            UserPass formInicioSesion = new UserPass();
            formInicioSesion.txtUsuario.Text = nombreUsuario + " " + apellidoUsuario;
            formInicioSesion.txtLegajo.Text = legajo;
            formInicioSesion.Show();

            
        }
    }
}

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
    public partial class UserPass : Form
    {
        public static MenuPrincipal formMenu = new MenuPrincipal();


        public UserPass()
        {
            InitializeComponent();

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string pass = txtPass.Text;
            string privilegios = txtPuesto.Text;

            if (EmpleadoDB.ValidarContraseña(txtPass.Text, txtPuesto.Text))
            {
                MessageBox.Show("Acceso correcto", "KWIK-E MART", MessageBoxButtons.OK);
                this.Hide();

                /* if (privilegios != "Administrador")
                 {

                     formMenu.gestionDelNegocioToolStripMenuItem.Enabled = false;
                     formMenu.txtEmpleadoLogeado.Text = usuario;
                     formMenu.Show();

                 }
                 else
                 {

                     formMenu.txtEmpleadoLogeado.Text = usuario;
                     formMenu.Show();
                 }


             }
             else
             {
                 MessageBox.Show("Acceso fallido", "KWIK-E MART", MessageBoxButtons.OK);
             }

             Comercio.CargarHardcodeo();

                 */
            }

        }
            
            private void button1_Click(object sender, EventArgs e)
            {
                this.Close();
                FormIngresoSistema formInicio = new FormIngresoSistema();
                formInicio.Show();
            }

            private void UserPass_Load(object sender, EventArgs e)
            {
                txtPass.Select();

            }

                   
        
    }
}

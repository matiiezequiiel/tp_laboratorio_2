﻿using System;
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

        public UserPass()
        {
            InitializeComponent();

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
                MenuPrincipal formMenu = new MenuPrincipal(this);
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
    }
}

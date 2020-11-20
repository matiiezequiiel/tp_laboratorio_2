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
using Excepciones;

namespace InicioSesion
{
    delegate void ActualizarCliente();
    public partial class NuevoCliente : Form
    {
        ErrorProvider error = new ErrorProvider();
        MenuPrincipal auxMenu;
        event ActualizarCliente CambioEnListaCliente;

        #region Carga de datos
        /// <summary>
        /// IMPLEMENTACION DE EVENTOS
        /// </summary>
        /// <param name="m"></param>
        public NuevoCliente(MenuPrincipal m)
        {
            InitializeComponent();
            auxMenu = m;
            CambioEnListaCliente += auxMenu.CargarListaCliente;
             
        }

        private void NuevoCliente_Load(object sender, EventArgs e)
        {
            cmbNacio.DataSource = Enum.GetValues(typeof(Persona.ENacionalidad));
            cmbSexo.DataSource = Enum.GetValues(typeof(Persona.ESexo));
        }

        #endregion

        #region Validaciones de campos

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            for (int i = 0; i < txtNombre.TextLength; i++)
            {
                if (char.IsDigit(this.txtNombre.Text[i]))
                {
                    e.Cancel = true;
                    break;

                }

            }

            if (e.Cancel)
            {
                MessageBox.Show("Solo se deben ingresar letras");

            }

        }

        private void txtNombre_Validated(object sender, EventArgs e)
        {
            error.SetError(this.txtNombre, "");
        }

        private void txtApellido_Validating(object sender, CancelEventArgs e)
        {
            for (int i = 0; i < txtApellido.TextLength; i++)
            {
                if (char.IsDigit(this.txtApellido.Text[i]))
                {
                    e.Cancel = true;
                    break;

                }

            }

            if (e.Cancel)
            {
                MessageBox.Show("Solo se deben ingresar letras");

            }

        }

        private void txtApellido_Validated(object sender, EventArgs e)
        {
            error.SetError(this.txtApellido, "");
        }

        private void txtDNI_Validating(object sender, CancelEventArgs e)
        {
            for (int i = 0; i < txtDNI.TextLength; i++)
            {
                if (!char.IsDigit(this.txtDNI.Text[i]))
                {

                    e.Cancel = true;
                    break;

                }

            }

            if (e.Cancel)
            {
                MessageBox.Show("Solo se deben ingresar numeros");

            }

        }

        private void txtDNI_Validated(object sender, EventArgs e)
        {
            error.SetError(this.txtDNI, "");
        }

   
        private void cmbNacio_Validating(object sender, CancelEventArgs e)
        {
            if (this.cmbNacio.SelectedItem is null)
            {
                e.Cancel = true;
            }

            if (e.Cancel)
            {
                MessageBox.Show("Debe elegir una nacionalidad para el cliente.");
                this.cmbNacio.SelectedIndex = 0;
            }

        }

        private void cmbNacio_Validated(object sender, EventArgs e)
        {
            error.SetError(this.cmbNacio, "");
        }
        
        private void cmbSexo_Validating(object sender, CancelEventArgs e)
        {
            if (this.cmbSexo.SelectedItem is null)
            {
                e.Cancel = true;
            }

            if (e.Cancel)
            {
                MessageBox.Show("Debe elegir un sexo para el cliente.");
                this.cmbSexo.SelectedIndex =0;
            }

        }

        private void cmbSexo_Validated(object sender, EventArgs e)
        {
            error.SetError(this.cmbSexo, "");
        }

        #endregion

        #region Agrego Cliente
        /// <summary>
        /// IMPLEMENTACION DE EVENTOS, BD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
         

            if (this.txtNombre.TextLength > 0 && txtApellido.TextLength > 0)
            {
                try
                {
                    Cliente nuevoCliente = new Cliente(this.txtNombre.Text, this.txtApellido.Text, this.txtDNI.Text, (Persona.ESexo)this.cmbSexo.SelectedIndex, (Persona.ENacionalidad)this.cmbNacio.SelectedIndex);
                    ClienteDB.InsertarCliente(nuevoCliente);
                    auxMenu.miComercio.Clientes.Clear();
                    auxMenu.miComercio.Clientes = ClienteDB.TraerClientes();
                    CambioEnListaCliente.Invoke();

                    MessageBox.Show("Cliente agregado correctamente.");
                }
                catch(DniInvalidoException ex)
                {
                    MessageBox.Show(ex.Message, "Error en la carga de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);    
                }
                catch(NacionalidadInvalidaException ex)
                {
                    MessageBox.Show(ex.Message, "Error en la carga de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
            else
            {
                MessageBox.Show("Algun valor es invalido, reeingrese los datos.");
            }

        }

        #endregion

        private void LimpiarCampos()
        {
            this.txtNombre.Text = "";
            this.txtApellido.Text = "";
            this.txtDNI.Text = "";

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            auxMenu.Show();
        }

       
    }
}

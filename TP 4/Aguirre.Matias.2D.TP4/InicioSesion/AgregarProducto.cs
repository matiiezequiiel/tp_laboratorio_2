using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases_Abstractas;
using Clases_Instanciables;
using SQL;
using Metodos_de_extension;

namespace InicioSesion
{
    delegate void ActualizarProducto();
    public partial class AgregarProducto : Form
    {
        ErrorProvider error = new ErrorProvider();
        MenuPrincipal auxMenu;
        enum ETipoProducto { Celular,Computadora,Electrodomestico };
        enum EOpcion { SI,NO };
        event ActualizarCliente CambioEnListaProducto;


        public AgregarProducto(MenuPrincipal m)
        {
            InitializeComponent();
            auxMenu = m;
            CargarMenu(false);
            CambioEnListaProducto += auxMenu.CargarListaProducto;
            CambioEnListaProducto += LimpiarCampos;
            
            
        }
        private void AgregarProducto_Load(object sender, EventArgs e)
        {
            cmbCategoria.DataSource = Enum.GetValues(typeof(Electrodomesticos.ECategoria));
            cmbTipo.DataSource = Enum.GetValues(typeof(ETipoProducto));
            cmbConexion.DataSource = Enum.GetValues(typeof(EOpcion));
            cmbControl.DataSource = Enum.GetValues(typeof(EOpcion));
            cmbGamer.DataSource = Enum.GetValues(typeof(EOpcion));
            cmbPerifericos.DataSource = Enum.GetValues(typeof(EOpcion));
            CargarMenu(false);
            cmbTipo.Text = string.Empty;
            
        }

        public void CargarMenu(bool estado)
        {
          
              lblAlmacenamiento.Enabled = estado;
              lblCategoria.Enabled = estado;
              lblConexion.Enabled = estado;
              lblControl.Enabled = estado;
              lblGamer.Enabled = estado;
              lblMemoria.Enabled = estado;
              lblNombre.Enabled = estado;
              lblPantalla.Enabled = estado;
              lblPerifericos.Enabled = estado;
              lblPotencia.Enabled = estado;
              lblPrecio.Enabled = estado;
              lblStockInicial.Enabled = estado;
              txtAlmacenamiento.Enabled = estado;
              txtMemoria.Enabled = estado;
              txtNombre.Enabled = estado;
              txtPantalla.Enabled = estado;
              txtPotencia.Enabled = estado;
              txtPrecio.Enabled = estado;
              txtStockInicial.Enabled = estado;
              cmbCategoria.Enabled = estado;
              cmbConexion.Enabled = estado;
              cmbControl.Enabled = estado;
              cmbGamer.Enabled = estado;
              cmbPerifericos.Enabled = estado;
            
           
        }

      

        private void btnAgregar_Click(object sender, EventArgs e)
        {
          
            if(this.txtNombre.Text != string.Empty || this.txtPrecio.Text != string.Empty || this.txtStockInicial.Text != string.Empty || this.txtPrecio.Text != string.Empty)
            {
                switch (this.cmbTipo.Text)
                {

                    case "Celular":
                       
                        if(this.txtMemoria.Text != string.Empty && this.txtAlmacenamiento.Text != string.Empty && this.txtPantalla.Text != string.Empty && this.cmbConexion.Text != string.Empty)
                        {
                            Celular nuevoCel = new Celular(this.txtNombre.Text, double.Parse(this.txtPrecio.Text), int.Parse(this.txtStockInicial.Text), int.Parse(this.txtMemoria.Text), int.Parse(this.txtAlmacenamiento.Text), this.cmbConexion.Text.ToBoolean(), float.Parse(this.txtPantalla.Text));
                            ProductoDB.InsertarProductosInformatica(nuevoCel);
                            MessageBox.Show("Producto agregado correctamente.");
                            
                            CambioEnListaProducto.Invoke();

                        }
                        else
                        {
                            MessageBox.Show("Algun dato de el producto celular esta vacio, reeingrese los datos.");
                        }
                        
                        break;

                    case "Electrodomestico":
                        if (this.txtPotencia.Text != string.Empty && this.cmbControl.Text != string.Empty && this.cmbCategoria.Text != string.Empty)
                        {
                            Electrodomesticos nuevoElectro = new Electrodomesticos(this.txtNombre.Text, double.Parse(this.txtPrecio.Text), int.Parse(this.txtStockInicial.Text), int.Parse(this.txtPotencia.Text), this.cmbControl.Text.ToBoolean(), Electrodomesticos.StringTOCategoria(this.cmbCategoria.Text));
                            MessageBox.Show("Producto agregado correctamente.");
                            ProductoDB.InsertarProductosElectro(nuevoElectro);

                            CambioEnListaProducto.Invoke();
                        }
                        else
                        {
                            MessageBox.Show("Algun dato de el producto electrodomestico esta vacio, reeingrese los datos.");
                        }
                          
                       
                        break;
                    case "Computadora":
                        if (this.txtMemoria.Text != string.Empty && this.txtAlmacenamiento.Text != string.Empty && this.cmbPerifericos.Text != string.Empty && this.cmbGamer.Text != string.Empty)
                        {

                            Computadora nuevaComputadora = new Computadora(this.txtNombre.Text, double.Parse(this.txtPrecio.Text), int.Parse(this.txtStockInicial.Text), int.Parse(this.txtMemoria.Text), int.Parse(this.txtAlmacenamiento.Text), this.cmbPerifericos.Text.ToBoolean(), this.cmbGamer.Text.ToBoolean());
                            ProductoDB.InsertarProductosInformatica(nuevaComputadora);
                            MessageBox.Show("Producto agregado correctamente.");

                            CambioEnListaProducto.Invoke();
                        }
                        else
                        {
                            MessageBox.Show("Algun dato de el producto computadora esta vacio, reeingrese los datos.");
                        }
                        
                        break;

                }
           

            }
            else
            {
                MessageBox.Show("Algun valor es invalido, reeingrese los datos.");
            }


        }

        private void LimpiarCampos()
        {
            this.txtNombre.Text = "";
            this.txtPrecio.Text = "";
            this.txtStockInicial.Text = "";
            this.txtAlmacenamiento.Text = "";
            this.txtMemoria.Text = "";
            this.txtPantalla.Text = "";
            this.txtPotencia.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
           // UserPass.formMenu.Show();
            auxMenu.Show();
        }


        #region Validar Campos
        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {

            for (int i = 0; i < txtNombre.TextLength; i++)
            {
                if (string.IsNullOrEmpty(this.txtNombre.Text))
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

        private void txtPrecio_Validating(object sender, CancelEventArgs e)
        {

            for (int i = 0; i < txtPrecio.TextLength; i++)
            {
                if (!char.IsDigit(this.txtPrecio.Text[i]) || string.IsNullOrEmpty(this.txtPrecio.Text))
                {
                    if (this.txtPrecio.Text[i] != '.')
                    {
                        e.Cancel = true;
                        break;
                    }

                }

            }




            if (e.Cancel)
            {
                MessageBox.Show("Solo se deben ingresar numeros, para numeros con decimal debe ingresar '.' para separar el entero del decimal.");

            }

        }

        private void txtPrecio_Validated(object sender, EventArgs e)
        {
            error.SetError(this.txtPrecio, "");
        }
        private void txtStockInicial_Validating(object sender, CancelEventArgs e)
        {

            for (int i = 0; i < txtStockInicial.TextLength; i++)
            {
                if (!char.IsDigit(this.txtStockInicial.Text[i]) || string.IsNullOrEmpty(this.txtStockInicial.Text))
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

        private void txtStockInicial_Validated(object sender, EventArgs e)
        {
            error.SetError(this.txtStockInicial, "");
        }

        private void cmbCategoria_Validating(object sender, CancelEventArgs e)
        {
            if (this.cmbCategoria.SelectedItem is null)
            {
                e.Cancel = true;
            }

            if (e.Cancel)
            {
                MessageBox.Show("Debe elegir una categoria para el electrodomestico.");
                this.cmbCategoria.SelectedIndex = 1;
            }

        }

        private void cmbCategoria_Validated(object sender, EventArgs e)
        {
            error.SetError(this.cmbCategoria, "");
        } 
        
        private void cmbTipo_Validating(object sender, CancelEventArgs e)
        {
            if (this.cmbTipo.SelectedItem is null)
            {
                e.Cancel = true;
            }

            if (e.Cancel)
            {
                MessageBox.Show("Debe elegir un tipo de producto.");
                this.cmbTipo.SelectedIndex = 1;
            }

        }

        private void cmbTipo_Validated(object sender, EventArgs e)
        {
            error.SetError(this.cmbTipo, "");
        }
        
        private void cmbConexion_Validating(object sender, CancelEventArgs e)
        {
            if (this.cmbConexion.SelectedItem is null)
            {
                e.Cancel = true;
            }

            if (e.Cancel)
            {
                MessageBox.Show("Debe elegir si o no para la conexion 5G.");
                this.cmbConexion.SelectedIndex = 1;
            }

        }

        private void cmbConexion_Validated(object sender, EventArgs e)
        {
            error.SetError(this.cmbConexion, "");
        }    
        
        private void cmbGamer_Validating(object sender, CancelEventArgs e)
        {
            if (this.cmbGamer.SelectedItem is null)
            {
                e.Cancel = true;
            }

            if (e.Cancel)
            {
                MessageBox.Show("Debe elegir si o no si la computadora es gamer.");
                this.cmbGamer.SelectedIndex = 1;
            }

        }

        private void cmbGamer_Validated(object sender, EventArgs e)
        {
            error.SetError(this.cmbGamer, "");
        }   
        
        private void cmbPerifericos_Validating(object sender, CancelEventArgs e)
        {
            if (this.cmbPerifericos.SelectedItem is null)
            {
                e.Cancel = true;
            }

            if (e.Cancel)
            {
                MessageBox.Show("Debe elegir si o no si la computadora incluye perifericos.");
                this.cmbPerifericos.SelectedIndex = 1;
            }

        }

        private void cmbPerifericos_Validated(object sender, EventArgs e)
        {
            error.SetError(this.cmbPerifericos, "");
        }
           
        private void cmbControl_Validating(object sender, CancelEventArgs e)
        {
            if (this.cmbControl.SelectedItem is null)
            {
                e.Cancel = true;
            }

            if (e.Cancel)
            {
                MessageBox.Show("Debe elegir si o no si el electrodomestico incluye control remoto.");
                this.cmbControl.SelectedIndex = 1;
            }

        }

        private void cmbControl_Validated(object sender, EventArgs e)
        {
            error.SetError(this.cmbControl, "");
        }

        private void txtMemoria_Validating(object sender, CancelEventArgs e)
        {
            for (int i = 0; i < txtMemoria.TextLength; i++)
            {
                if (!char.IsDigit(this.txtMemoria.Text[i]) || string.IsNullOrEmpty(this.txtMemoria.Text))
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
        private void txtMemoria_Validated(object sender, EventArgs e)
        {
            error.SetError(this.txtMemoria, "");
        }
        
        private void txtAlmacenamiento_Validating(object sender, CancelEventArgs e)
        {
            for (int i = 0; i < txtAlmacenamiento.TextLength; i++)
            {
                if (!char.IsDigit(this.txtAlmacenamiento.Text[i]) || string.IsNullOrEmpty(this.txtAlmacenamiento.Text))
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
        private void txtAlmacenamiento_Validated(object sender, EventArgs e)
        {
            error.SetError(this.txtAlmacenamiento, "");
        }


        private void txtPantalla_Validating(object sender, CancelEventArgs e)
        {

            for (int i = 0; i < txtPantalla.TextLength; i++)
            {
                if (!char.IsDigit(this.txtPantalla.Text[i]) || string.IsNullOrEmpty(this.txtPantalla.Text))
                {
                    if (this.txtPantalla.Text[i] != '.')
                    {
                        e.Cancel = true;
                        break;
                    }

                }

            }


            if (e.Cancel)
            {
                MessageBox.Show("Solo se deben ingresar numeros, para numeros con decimal debe ingresar '.' para separar el entero del decimal.");

            }

        }

        private void txtPantalla_Validated(object sender, EventArgs e)
        {
            error.SetError(this.txtPantalla, "");
        }

        private void txtPotencia_Validating(object sender, CancelEventArgs e)
        {
            for (int i = 0; i < txtPotencia.TextLength; i++)
            {
                if (!char.IsDigit(this.txtPotencia.Text[i]) || string.IsNullOrEmpty(this.txtPotencia.Text))
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
        private void txtPotencia_Validated(object sender, EventArgs e)
        {
            error.SetError(this.txtPotencia, "");
        }


        #endregion

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            switch (cmbTipo.Text)
            {
                case "Celular":
                    CargarMenu(true);
                    this.txtPotencia.Enabled = false;
                    this.cmbGamer.Enabled = false;
                    this.cmbControl.Enabled = false;
                    this.cmbCategoria.Enabled = false;
                    this.cmbPerifericos.Enabled = false;

                    break;
                        
                case "Electrodomestico":
                    CargarMenu(true);
                    this.cmbGamer.Enabled = false;
                    this.cmbPerifericos.Enabled = false;
                    this.cmbConexion.Enabled = false;
                    this.txtAlmacenamiento.Enabled = false;
                    this.txtMemoria.Enabled = false;
                    this.txtPantalla.Enabled = false;
                
                  
                    break;

                case "Computadora":
                    CargarMenu(true);
                    this.txtPotencia.Enabled = false;
                    this.txtPantalla.Enabled = false;
                    this.cmbConexion.Enabled = false;
                    this.cmbControl.Enabled = false;
                    this.cmbCategoria.Enabled = false;
                  
                    break;

            }
           
        }
    }
}
